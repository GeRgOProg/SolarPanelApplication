class customer:
    def __init__(self, _customerid, _name, _address, _taxnumber, _company, _phone, _email):
        self.customerId = _customerid
        self.name = _name
        self.address = _address
        self.taxNumber = _taxnumber
        self.company = _company
        self.phone = _phone
        self.email = _email
        self.errorCode = 0

    def serialize(self):
        return {"customerId" : self.customerId, "name" : self.name, "address" : self.address, "taxNumber" : self.taxNumber, "company" : self.company, "phone" : self.phone, "email" : self.email, "errorCode" : self.errorCode}



