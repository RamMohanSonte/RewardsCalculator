Execute the script in your SQL Server DB (Available with the name script.txt in side the DBScript folder)
Update the connection string in the file TestContext.cs to connect to your 
SQL Server.
Run the application.

This API supports Swagger. There 2 different customers with id 1 and 2.
Call method calculaterwards API by passing customer ID 1 or 2.

There are two tables. 
1)Customer (Master Data)
2)Transactions (Child table)

Every transaction , we record transaction details in the Transactions table by associating 
customer id .

API could calculate last 30 days rewards points as per business logic.

