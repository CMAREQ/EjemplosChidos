import sys

def birthdayCakeCandles(n, al):
    l = 0
    alMax = max(al)

    for x in al:
        if x == alMax:
            l += 1
    return l

n = int(input().strip())
al = list(map(int, input().strip().split(' ')))

result = birthdayCakeCandles(n, al)
print (result)
