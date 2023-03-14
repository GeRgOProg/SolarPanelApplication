import mysql.connector, mysql.connector.connection


class databaseloader:
    def __init__(self):
        self.config =  {
                        "host" : "sql.freedb.tech",
                        "user" : "freedb_csiko_dbuser",
                        "password" : "!TbW5TuN3j@tqHy",
                        "database" : "freedb_solarcompany"
                        }
    def connect(self):
         self.db = mysql.connector.connect (
        host = self.config["host"],
        user = self.config["user"],
        password = self.config["password"],
        database = self.config["database"]
        )

    def disconnect(self):
        self.db.close()

    def getRoles(self):
        self.connect()
        mycursor = self.db.cursor()
        mycursor.execute("SELECT RoleName FROM roles WHERE RoleName != 'Adminisztrátor'")
        myresult = mycursor.fetchall()
        mycursor.close()
        self.disconnect()
        roles = []
        for x in myresult:
            roles.append(x[0])
        return roles




