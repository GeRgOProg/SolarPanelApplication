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
from datetime import datetime
from flask import render_template, jsonify, request
from SolarPanelAppWs import app
from SolarPanelAppWs.Model.databaseloader import databaseloader
from SolarPanelAppWs.Model.user import user
from SolarPanelAppWs.Model.part import part
from SolarPanelAppWs.Model.customer import customer
from SolarPanelAppWs.Model.role import role

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

@app.route("/getCustomerById/<id>")
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
            return newCustomer.serialize()
    except mysql.connector.Error as err:
        return {"customerId" : id, "name" : "", "address" : "", "taxNumber" : "", "company" : "", "phone" : "", "email" : "", "errorCode" : 500}

@app.route("/getPartById/<id>")
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
            return newPart.serialize()
    except mysql.connector.Error as err:
        return {"partId" : id, "name" : "", "unitPrice" : 0, "sum" : 0, "maxPerStorage" : 0, "errorCode" : 500}

@app.route("/getRoleById/<id>")
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
            return newRole.serialize()
    except mysql.connector.Error as err:
        return {"roleId" : id, "roleName" : "", "errorCode" : 500}