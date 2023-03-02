class part:
    def __init__(self, _partid, _name, _unitprice, _sum, _maxperstorage):
        self.partId = _partid
        self.name = _name
        self.unitPrice = _unitprice
        self.sum = _sum
        self.maxPerStorage = _maxperstorage
        self.errorCode = 0

    def serialize(self):
        return {"partId" : self.partId, "name" : self.name, "unitPrice" : self.unitPrice, "sum" : self.sum, "maxPerStorage" : self.maxPerStorage, "errorCode" : self.errorCode}





