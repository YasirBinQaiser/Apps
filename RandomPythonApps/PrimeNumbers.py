from math import sqrt, pi
from random import randint
import sys
import readmdb

x1 = []

def IsPrime (num):
    i = 2
    halfNum = num/2
    while i < halfNum:
        if (num % i) == 0:
            return False
        i = i + 1    
    return True
    
def WriteRandomNumbersToFile(num, min, max):
    with open(r"numbers.txt", "w") as file_handler:
        i = 0
        while i < num:
            file_handler.write (str(randint(min, max)))
            file_handler.write ("\n")    
            i = i + 1
    file_handler.close()     
    
    
def ReadNumbersFromFile():
    with open(r"numbers.txt", "r") as file_handler:
        for line in file_handler:
            x1.append(int(line))
    file_handler.close()
    x1.sort()

def MarkPrimeNumbersAndWriteToFile():
    with open(r"numbers.txt", "w") as file_handler:
        i = 0
        while i < len(x1):
            if IsPrime(x1[i]):
                file_handler.write ("[ ] " + str(x1[i]))
            else:
                file_handler.write ("[X] " + str(x1[i]))
            file_handler.write ("\n")    
            i = i + 1
    file_handler.close()    
        
def ReadMarkedNumbersFromFile():    
    with open(r"numbers.txt", "r") as file_handler:
        for line in file_handler:
            print(line[0:len(line) - 1]) # ignore end of line
    file_handler.close()

    
#Main
print (sys.argv)    
if (len(sys.argv) < 4):
    sys.exit("Invalid Arguiments\n  usage:\n  <number of random integers> <min> <max>")

WriteRandomNumbersToFile(int(sys.argv[1]), int(sys.argv[2]), int(sys.argv[3]))    
ReadNumbersFromFile()
MarkPrimeNumbersAndWriteToFile()
ReadMarkedNumbersFromFile()
