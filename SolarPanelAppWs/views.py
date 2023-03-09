"""
A rendszerfejlesztés korszerű módszerei projekt feladat
10-es csapat:
Keresztúri Gergő
Kozma Henrietta
Balla Patrik
Filotás Patrik

2022/23/2
"""

import mysql.connector
import json
from datetime import datetime
from flask import render_template, jsonify, request
from SolarPanelAppWs import app
from SolarPanelAppWs.Model.databaseloader import databaseloader
from SolarPanelAppWs.Model.user import user
from SolarPanelAppWs.Model.part import part
from SolarPanelAppWs.Model.customer import customer
from SolarPanelAppWs.Model.role import role
from SolarPanelAppWs.Model.project import project
from SolarPanelAppWs.Model.log import log

# Home page
@app.route('/')
@app.route('/home')
def home():
    dbconnection = databaseloader()
    return render_template(
        'index.html',
        roles=dbconnection.getRoles()
    )

# API functions
@app.route("/getUser/<username>/<password>", methods=['GET'])
@app.route("/login/<username>/<password>", methods=['GET'])
def login(username, password):
    try:
        dbconnection = databaseloader()
        dbconnection.connect()
        mydb = dbconnection.db
        cursor = mydb.cursor()
        cursor.execute("SELECT * FROM users WHERE username = '" + username + "' AND password = SHA1('" + password + "')")
        resultuser = cursor.fetchone()
        if(resultuser is None):
           return jsonify({"userId" : 0, "username" : username, "password" : password, "roleId" : 0, "errorCode" : 500}) 
        else:
            userId = resultuser[0]
            userName = resultuser[1]
            password = resultuser[2]
            roleId = resultuser[3]
            cursor.execute("SELECT roleName FROM roles WHERE roleId = " + str(roleId))
            resultRoleName = cursor.fetchone()[0]
            newuser = user(userId, userName, password, roleId, resultRoleName)
            cursor.close()
            dbconnection.disconnect()
            return jsonify(newuser.serialize())
    except mysql.connector.Error as err:
        return jsonify({"userId" : 0, "username" : username, "password" : password, "roleId" : 0, "errorCode" : 500})


@app.route("/getParts", methods=["GET"])
@app.route("/parts", methods=["GET"])
def getParts():
    try:
        partList = []
        dbconnection = databaseloader()
        dbconnection.connect()
        mydb = dbconnection.db
        cursor = mydb.cursor()
        cursor.execute("SELECT * FROM parts")
        myresult = cursor.fetchall()
        for x in myresult:
            partList.append(part(x[0], x[1], x[2], x[3],x[4]).serialize())
        cursor.close()
        dbconnection.disconnect()
        return partList
    except mysql.connector.Error as err:
        return []

@app.route("/updatePrice", methods=["POST"])
def updatePrice():
    try:
        name = request.form.get("name")
        newPrice = request.form.get("newPrice")
        dbconnection = databaseloader()
        dbconnection.connect()
        mydb = dbconnection.db
        cursor = mydb.cursor()
        cursor.execute("UPDATE parts SET unitPrice = " + str(newPrice) + " WHERE PartName = '" + name + "'")
        mydb.commit()
        cursor.close()
        dbconnection.disconnect()
        return {"responseCode" : 0}
    except mysql.connector.Error as err:
        return {"responseCode" : 500}

@app.route("/newPart", methods=["POST"])
@app.route("/registerPart", methods=["POST"])
@app.route("/insertPart", methods=["POST"])
def newPart():
    try:
        name = request.form.get("name")
        unitPrice = request.form.get("unitPrice")
        sum = request.form.get("sum")
        maxPerStorage = request.form.get("maxPerStorage")
        dbconnection = databaseloader()
        dbconnection.connect()
        mydb = dbconnection.db
        cursor = mydb.cursor()
        cursor.execute("INSERT INTO parts (PartName, UnitPrice, Sum, MaxPerStorage) VALUES ('" + str(name) + "', " + str(unitPrice) + ", " + str(sum) + ", " + str(maxPerStorage) + ")")
        mydb.commit()
        cursor.close()
        dbconnection.disconnect()
        return {"responseCode" : 0} 
    except mysql.connector.Error as err:
        return {"responseCode" : 500}

@app.route("/getCustomerById/<id>", methods=["GET"])
def getCustomerById(id):
    try:
        dbconnection = databaseloader()
        dbconnection.connect()
        mydb = dbconnection.db
        cursor = mydb.cursor()
        cursor.execute("SELECT * FROM customers WHERE CustomerId = " + str(id))
        myresult = cursor.fetchone()
        if(myresult is None):
            return {"customerId" : id, "name" : "", "address" : "", "taxNumber" : "", "company" : "", "phone" : "", "email" : "", "errorCode" : 500}
        else:
            newCustomer = customer(myresult[0], myresult[1], myresult[2], myresult[3], myresult[4], myresult[5], myresult[6])
            cursor.close()
            dbconnection.disconnect()
            return newCustomer.serialize()
    except mysql.connector.Error as err:
        return {"customerId" : id, "name" : "", "address" : "", "taxNumber" : "", "company" : "", "phone" : "", "email" : "", "errorCode" : 500}

@app.route("/getPartById/<id>", methods=["GET"])
def getPartById(id):
    try:
        dbconnection = databaseloader()
        dbconnection.connect()
        mydb = dbconnection.db
        cursor = mydb.cursor()
        cursor.execute("SELECT * FROM parts WHERE PartId = " + str(id))
        myresult = cursor.fetchone()
        if(myresult is None):
            return {"partId" : id, "name" : "", "unitPrice" : 0, "sum" : 0, "maxPerStorage" : 0, "errorCode" : 500}
        else:
            newPart = part(myresult[0], myresult[1], myresult[2], myresult[3], myresult[4])
            cursor.close()
            dbconnection.disconnect()
            return newPart.serialize()
    except mysql.connector.Error as err:
        return {"partId" : id, "name" : "", "unitPrice" : 0, "sum" : 0, "maxPerStorage" : 0, "errorCode" : 500}

@app.route("/getRoleById/<id>", methods=["GET"])
def getRoleById(id):
    try:
        dbconnection = databaseloader()
        dbconnection.connect()
        mydb = dbconnection.db
        cursor = mydb.cursor()
        cursor.execute("SELECT * FROM roles WHERE roleId = " + str(id))
        myresult = cursor.fetchone()
        if(myresult is None):
            return {"roleId" : id, "roleName" : "", "errorCode" : 500}
        else:
            newRole = role(myresult[0], myresult[1])
            cursor.close()
            dbconnection.disconnect()
            return newRole.serialize()
    except mysql.connector.Error as err:
        return {"roleId" : id, "roleName" : "", "errorCode" : 500}


@app.route("/updateMaxPerStorage",  methods=["POST"])
def updateMaxPerStorage():
    try:
        partName = request.form.get("partName")
        newMax = request.form.get("newMax")
        dbconnection = databaseloader()
        dbconnection.connect()
        mydb = dbconnection.db
        cursor = mydb.cursor()
        cursor.execute("UPDATE parts SET MaxPerStorage = " + str(newMax) + " WHERE PartName = '" + partName + "'")
        mydb.commit()
        cursor.close()
        dbconnection.disconnect()
        return {"responseCode" : 0}
    except mysql.connector.Error as err:
        return {"responseCode" : 500}

@app.route("/newProject",  methods=["POST"])
@app.route("/insertProject",  methods=["POST"])
def insertProject():
    try:
        location = request.form.get("location")
        description = request.form.get("description")
        currentphase = "New"
        totalprice = request.form.get("totalprice") #not final totalprice, but initial price of work.
        requiredhours = request.form.get("requiredhours")
        #Customer identity:
        taxnumber = request.form.get("taxNumber")
        #User identity:
        userId = request.form.get("userId")
        dbconnection = databaseloader()
        dbconnection.connect()
        mydb = dbconnection.db
        cursor = mydb.cursor()
        cursor.execute("SELECT CustomerId FROM customers WHERE TaxNumber = '" + taxnumber + "'")
        myresult = cursor.fetchone()
        if(myresult is None):
           return {"responseCode" : 500}
        else:
            customerid = myresult[0]
            cursor.execute("INSERT INTO projects (UserId, CustomerId, Location, Description, CurrentPhase, TotalPrice, RequiredHours) VALUES ( " + str(userId) + ", " + str(customerid) + ", '" + location + "', '" + description + "', '" + currentphase + "', " + str(totalprice) + ", " + str(requiredhours) + " )")
            mydb.commit()
            cursor.execute("SELECT ProjectId FROM projects WHERE UserId = " + str(userId) + " AND CustomerId = " + str(customerid) + " AND Location = '" + location + "' AND Description = '" + description + "' AND CurrentPhase = '" + currentphase + "' AND TotalPrice = " + str(totalprice) + " AND RequiredHours = " + str(requiredhours))
            myresult = cursor.fetchone()
            projectId = myresult[0]
            cursor.execute("INSERT INTO log (ProjectId, Phase, Timestamp) VALUES (" + str(projectId) + ", '" + currentphase + "', CURRENT_TIMESTAMP())")
            mydb.commit()
            cursor.close()
            dbconnection.disconnect()
            return {"responseCode" : 0}
    except mysql.connector.Error as err:
       return {"responseCode" : 500, "Msg" : err.msg}

@app.route("/newCustomer",  methods=["POST"])
@app.route("/insertCustomer",  methods=["POST"])
def insertCustomer():
    try:
        name = request.form.get("name")
        address = request.form.get("address")
        taxnumber = request.form.get("taxNumber")
        company = request.form.get("company")
        phone = request.form.get("phone")
        email = request.form.get("email")
        dbconnection = databaseloader()
        dbconnection.connect()
        mydb = dbconnection.db
        cursor = mydb.cursor()
        cursor.execute("INSERT INTO customers (CustomerName, Address, TaxNumber, Company, Phone, Email) VALUES ( '" + name + "', '" + address + "', '" + taxnumber + "', '" + company + "', '" + phone + "', '" + email + "' )")
        mydb.commit()
        cursor.close()
        dbconnection.disconnect()
        return {"responseCode" : 0}
    except mysql.connector.Error as err:
       return {"responseCode" : 500}

@app.route("/getPartLocation/<partId>", methods=["GET"])
def getPartLocation(partId):
    locationList = []
    try:
        dbconnection = databaseloader()
        dbconnection.connect()
        mydb = dbconnection.db
        cursor = mydb.cursor()
        cursor.execute("SELECT parts.PartName, parts.UnitPrice, CONCAT(line.LineId, '-', storage.ColumnId, '-', storage_parts.StorageId) AS 'Location', OnStock-Reserved AS 'OnStockActual'  FROM storage_parts JOIN parts ON storage_parts.PartId = parts.PartId  JOIN storage ON storage.StorageId = storage_parts.StorageId JOIN columns ON storage.ColumnId = columns.ColumnId JOIN line ON line.LineId = columns.ColumnId WHERE storage_parts.PartId = " + partId)
        myresult = cursor.fetchall()
        if(myresult is None):
            return {"locationList" : [] , "errorCode" : 500}
        else:
            for x in myresult:
                locationList.append({"partName" : x[0], "unitPrice" : x[1], "location" : x[2], "actualOnStock" : x[3]})
        cursor.close()
        dbconnection.disconnect()    
        return {"locationList" : locationList, "errorCode" : 0}
    except mysql.connector.Error as err:
         return {"locationList" : [] , "errorCode" : 500}

@app.route("/getAllPartLocation", methods=["GET"])
def getAllPartLocation():
    locationList = []
    try:
        dbconnection = databaseloader()
        dbconnection.connect()
        mydb = dbconnection.db
        cursor = mydb.cursor()
        cursor.execute("SELECT parts.PartName, parts.UnitPrice, CONCAT(line.LineId, '-', storage.ColumnId, '-', storage_parts.StorageId) AS 'Location', OnStock-Reserved AS 'OnStockActual'  FROM storage_parts JOIN parts ON storage_parts.PartId = parts.PartId  JOIN storage ON storage.StorageId = storage_parts.StorageId JOIN columns ON storage.ColumnId = columns.ColumnId JOIN line ON line.LineId = columns.ColumnId ORDER BY storage_parts.PartId")
        myresult = cursor.fetchall()
        if(myresult is None):
            return {"locationList" : [] , "errorCode" : 500}
        else:
            for x in myresult:
                locationList.append({"partName" : x[0], "unitPrice" : x[1], "location" : x[2], "actualOnStock" : x[3]})
        cursor.close()
        dbconnection.disconnect()    
        return {"locationList" : locationList, "errorCode" : 0}
    except mysql.connector.Error as err:
         return {"locationList" : [] , "errorCode" : 500}

@app.route("/getProjects/<userId>", methods=["GET"])
def getProjects(userId):
    try:
        projects = []
        dbconnection = databaseloader()
        dbconnection.connect()
        mydb = dbconnection.db
        cursor = mydb.cursor()
        cursor.execute("SELECT * FROM projects WHERE userId = " + userId)
        myresult = cursor.fetchall()
        if(myresult is None):
            return []
        else:
            for x in myresult:
                projects.append(project(x[0], x[1], x[2], x[3], x[4], x[5], x[6], x[7]).serialize())
            return projects
    except mysql.connector.Error as err:
        return []

@app.route("/getLog/<projectId>", methods=["GET"])
def getLog(projectId):
    try:
        logs = []
        dbconnection = databaseloader()
        dbconnection.connect()
        mydb = dbconnection.db
        cursor = mydb.cursor()
        cursor.execute("SELECT * FROM log WHERE projectId = " + projectId)
        myresult = cursor.fetchall()
        if(myresult is None):
            return []
        else:
            for x in myresult:
                logs.append(log(x[0], x[1], x[2], x[3]).serialize())
            return logs
    except mysql.connector.Error as err:
        return []


@app.route("/insertShipment", methods=["POST"])
@app.route("/newShipment", methods=["POST"])
def insertShipment():
    try:
        identity = request.form.get("identity")
        shippingdate = request.form.get("shippingDate")
        driver = request.form.get("driver")
        company = request.form.get("company")
        totalweight = request.form.get("totalWeight")
        partData = json.loads(request.form.get("partData")) #partId, quantity
        dbconnection = databaseloader()
        dbconnection.connect()
        mydb = dbconnection.db
        cursor = mydb.cursor()
        cursor.execute("INSERT INTO shipments (Identity, ShippingDate, Driver, Company, TotalWeight) VALUES ('" + str(identity) + "', '" + str(shippingdate) + "', '" + driver + "', '" + company + "', " + str(totalweight) + " )")
        mydb.commit()
        cursor.execute("SELECT ShipmentId FROM shipments WHERE Identity = '" + str(identity) + "'")
        myresult = cursor.fetchone()
        shipmentId = myresult[0]
        for data in partData:
            cursor.execute("INSERT INTO shipments_parts (ShipmentId, PartId, Quantity) VALUES ( " + str(shipmentId) + ", " + str(data["partId"]) + ", " + str(data["quantity"]) + " )")
            cursor.execute("UPDATE parts SET sum = sum + " + str(data["quantity"]) + " WHERE partId = " + str(data["partId"]))
        mydb.commit()
        return {"responseCode" : 0}
    except mysql.connector.Error as err:
       return {"responseCode" : 500}

@app.route("/updateStorageCapacity", methods=["POST"])
@app.route("/updateStorageWeightCapacity", methods=["POST"])
def updateStorageCapacity():
    try:
        line = request.form.get("line")
        column = request.form.get("column")
        storage = request.form.get("storage")
        maxweightcapacity = request.form.get("maxWeightCapacity")
        dbconnection = databaseloader()
        dbconnection.connect()
        mydb = dbconnection.db
        cursor = mydb.cursor()
        cursor.execute("SELECT line.LineId, columns.ColumnId, storage.StorageId FROM storage JOIN columns ON storage.ColumnId = columns.ColumnId JOIN line ON line.LineId = columns.ColumnId WHERE line.LineId = " + str(line) + " AND columns.ColumnId = " + str(column) + " AND storage.StorageId = " + str(storage))
        myresult = cursor.fetchone()
        if(myresult is None):
            return {"responseCode" : 500}
        else:
            cursor.execute("UPDATE storage JOIN columns ON storage.ColumnId = columns.ColumnId JOIN line ON line.LineId = columns.ColumnId SET MaxWeightCapacity = " + str(maxweightcapacity) + " WHERE line.LineId = " + str(line) + " AND columns.ColumnId = " + str(column) + " AND storage.StorageId = " + str(storage))
            mydb.commit()
            return {"responseCode" : 0}
    except mysql.connector.Error as err:
       return {"responseCode" : 500}

@app.route("/assignParts", methods=["POST"])
def assignPart():
       try:
           projectId = request.form.get("projectId")
           partData = json.loads(request.form.get("partData")) #partId, quantity
           dbconnection = databaseloader()
           dbconnection.connect()
           mydb = dbconnection.db
           cursor = mydb.cursor()
           #Getting sum of each part, calculate new sum (sum - required, or get all of sum and reserve rest)
           for x in partData:
             cursor.execute("SELECT Sum, UnitPrice FROM parts WHERE partId = " + str(x["partId"]))
             myresult = cursor.fetchone()
             sum = myresult[0]
             unitPrice = myresult[1]
             cursor.execute("SELECT * FROM projects_parts WHERE projectId = " + str(projectId) + " AND partId = " + str(x["partId"]))
             myresult = cursor.fetchone()
             if(myresult is None):
                if(sum < x["quantity"]):
                    reserved =x["quantity"] - sum
                    cursor.execute("INSERT INTO projects_parts (ProjectId, PartId, Reserved, Required) VALUES ( " + str(projectId) + ", " + str(x["partId"]) + ", " + str(reserved) + ", " + str(sum) + " )")
                    cursor.execute("UPDATE parts SET sum = 0 WHERE PartId = " + str(x["partId"]))
                    cursor.execute("UPDATE storage_parts SET Reserved = Reserved + " + str(reserved) + " WHERE PartId = " + str(x["partId"]))
                    cursor.execute("UPDATE projects SET TotalPrice = TotalPrice + " + str(x["quantity"] * unitPrice) + " WHERE projectId = " + str(projectId))
                else:
                    cursor.execute("INSERT INTO projects_parts (ProjectId, PartId, Reserved, Required) VALUES ( " + str(projectId) + ", " + str(x["partId"]) + ", 0, " + str(x["quantity"]) + " )")
                    cursor.execute("UPDATE parts SET sum = sum - " + str(x["quantity"]) + " WHERE PartId = " + str(x["partId"]))
                    cursor.execute("UPDATE projects SET TotalPrice = TotalPrice + " + str(x["quantity"] * unitPrice) + " WHERE projectId = " + str(projectId))
             else:
                 if(sum < x["quantity"]):
                     reserved =x["quantity"] - sum
                     cursor.execute("UPDATE projects_parts SET Reserved = Reserved + " + str(reserved) + ", Required = Required + " + str(sum) + " WHERE ProjectId = " + str(projectId) + " AND partId = " + str(x["partId"]))
                     cursor.execute("UPDATE parts SET sum = 0 WHERE PartId = " + str(x["partId"]))
                     cursor.execute("UPDATE storage_parts SET Reserved = Reserved + " + str(reserved) + " WHERE PartId = " + str(x["partId"]))
                     cursor.execute("UPDATE projects SET TotalPrice = TotalPrice + " + str(x["quantity"] * unitPrice) + " WHERE projectId = " + str(projectId))
                 else:
                     cursor.execute("UPDATE projects_parts SET Required = Required + " + str(x["quantity"]) + " WHERE projectId = " + str(projectId) + " AND partId = " + str(x["partId"]))
                     cursor.execute("UPDATE parts SET sum = sum - " + str(x["quantity"]) + " WHERE PartId = " + str(x["partId"]))
                     cursor.execute("UPDATE projects SET TotalPrice = TotalPrice + " + str(x["quantity"] * unitPrice) + " WHERE projectId = " + str(projectId))
             mydb.commit()
           return {"errorCode" : 0}
       except mysql.connector.Error as err:
           return {"responseCode" : 500}
  