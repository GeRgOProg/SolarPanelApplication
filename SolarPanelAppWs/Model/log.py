class log:
    def __init__(self, logId, projectId, phase, timestamp):
        self.logId = logId
        self.projectId = projectId
        self.phase = phase
        self.timestamp = timestamp

    def serialize(self):
        return {"logId" : self.logId, "projectId" : self.projectId, "phase" : self.phase, "timestamp" : self.timestamp}


