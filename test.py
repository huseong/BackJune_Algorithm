class Test:
    def __init__(self):
        self.a = 1
k = Test()
b = [[1]]
k.a = b[0][0]
print(b[0][0])
b[0][0] = 100
print(k.a)
