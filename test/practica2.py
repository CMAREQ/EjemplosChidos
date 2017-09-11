import sys

def printFile(path):
    f = open(path)
    return f.read()

def writeFile(path, str):
    f = open(path,'w')
    f.write(str)


if __name__ == '__main__':
    writeFile("inicial.txt","charmander")
    print(printFile("inicial.txt"))
