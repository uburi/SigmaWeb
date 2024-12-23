#!/bin/bash
wait_time=15s
password=Password123

# wait for SQL Server to come up
echo importing data will start in $wait_time...
sleep $wait_time
echo executing script...

# run the init script to create the DB and the tables in /table
/opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P $password -i /scripts/init.sql