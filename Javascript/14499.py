import copy
ipt = list(map(lambda x: int(x), input().split(' ')))
sizeY = ipt[0]
sizeX = ipt[1]
diceY = ipt[2]
diceX = ipt[3]
orderCount = ipt[4]
field = []
for i in range(sizeY):
    field.append(list(map(lambda x: int(x), input().split(' '))))
orders = list(map(lambda x: int(x), input().split(' ')))

class DiceBlock:
    def __init__(self):
        self.num = 0

class Dice:
    def __init__(self, top, bottom, front, back, left, right):
        self.top = top
        self.bottom = bottom
        self.front = front
        self.back = back
        self.left = left
        self.right = right

    def roll(self, direction):
        before = copy.deepcopy(self)
        if direction == 1:
            self.bottom = before.right
            self.left = before.bottom
            self.top = before.left
            self.right = before.top
        elif direction == 2:
            self.bottom = before.left
            self.left = before.top
            self.top = before.right
            self.right = before.bottom
        elif direction == 3:
            self.bottom = before.front
            self.front = before.top
            self.top = before.back
            self.back = before.bottom
        elif direction == 4:
            self.bottom = before.back
            self.front = before.bottom
            self.top = before.front
            self.back = before.top

dice = Dice(DiceBlock(), DiceBlock(), DiceBlock(), DiceBlock(), DiceBlock(), DiceBlock())
isFirst = True
for order in orders:
    if order == 1:
        if diceX == sizeX - 1:
            continue
        diceX += 1
    elif order == 2:
        if diceX == 0:
            continue
        diceX -= 1
    elif order == 3:
        if diceY == 0:
            continue
        diceY -= 1
    elif order == 4:
        if diceY == sizeY - 1:
            continue
        diceY += 1
    dice.roll(order)
    if field[diceY][diceX] == 0:
        field[diceY][diceX] = dice.bottom.num
    else:
        dice.bottom.num = field[diceY][diceX]
        field[diceY][diceX] = 0
    if isFirst:
        isFirst = False
    elif not isFirst:
        print()
    print(dice.top.num, end = '')
    
    