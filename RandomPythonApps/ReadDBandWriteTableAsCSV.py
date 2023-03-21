import csv, pyodbc
import sys

def ReadMDBAndWriteToCSV(databasepath, tablename):
    # set up some constants
    driver = "{Microsoft Access Driver (*.mdb, *.accdb)}"
    connString = r"Driver={};DBQ={};".format(driver, databasepath)
    print(r"Opening DB: {}...".format(connString))
    # connect to db
    connection = pyodbc.connect(connString)
    cursor = connection.cursor()

    # run a query and get the results 
    SQL = r"SELECT * FROM {};".format(tablename) # your query goes here

    rows = cursor.execute(SQL).fetchall()

    names = list(map(lambda x: x[0], cursor.description))
    # you could change the mode from 'w' to 'a' (append) for any subsequent queries
    
    
    with open(tablename + ".csv", 'w') as fou:
        i = 0
        while i < len(names):
            fou.write(names[i] + ",")
            i = i + 1
        fou.write("\n")    
        csv_writer = csv.writer(fou) # default field-delimiter is ","
        csv_writer.writerows(rows)    
        
    cursor.close()
    connection.close()
    
#Main
print (sys.argv)    
if (len(sys.argv) < 3):
    sys.exit("Invalid Arguiments\n  usage:\n  <database path> <table name>")
    
ReadMDBAndWriteToCSV(str(sys.argv[1]), str(sys.argv[2]))