class project:
    def __init__(self, projectId, userId, customerId, location, description, currentphase, totalprice, requiredhours):
        self.projectId = projectId
        self.userId = userId
        self.customerId = customerId
        self.location = location
        self.description = description
        self.currentphase = currentphase
        self.totalprice = totalprice
        self.requiredhours = requiredhours

    def serialize(self):
        return {"projectId" : self.projectId, "userId" : self.userId, "customerId" : self.customerId, "location" : self.location, "description" : self.description, "currentPhase" : self.currentphase, "totalPrice" : self.totalprice, "requiredHours" : self.requiredhours}



