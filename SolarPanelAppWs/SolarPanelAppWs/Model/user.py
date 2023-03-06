class user:
    def __init__(self, _userid, _username, _password, _roleid, _roleName):
        self.userId = _userid
        self.userName = _username
        self.password = _password
        self.roleId = _roleid
        self.roleName = _roleName
        self.errorCode = 0

    def serialize(self):
        return {"userId" : self.userId, "username" : self.userName, "password" : self.password, "roleId" : self.roleId, "roleName" : self.roleName,  "errorCode" : self.errorCode}


