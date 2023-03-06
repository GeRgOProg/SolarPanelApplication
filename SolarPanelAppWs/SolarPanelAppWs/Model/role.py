class role:
    def __init__(self, _roleid, _rolename):
        self.roleId = _roleid
        self.roleName = _rolename
        self.errorCode = 0

    def serialize(self):
        return {"roleId" : self.roleId, "roleName" : self.roleName, "errorCode" : self.errorCode}

