Database Systems - Overview
Homework
1.	What database models do you know?
-	Hierarchical (tree) – the data is organized in a tree-like structure. The data is stored as records connected through links. Every record has a collection of fields. Every field contains only one value. A record corresponds to a row in a relational DB. Each parent record can have one or more child records, each child on the other hand can have only one parent.
-	Network (graph) – a flexible way of representing objects and their relationships. The schema is a graph where object types are nodes and relationships are arcs. It is not restricted like the hierarchical DB model.
-	Relational (table) – All data is grouped in tuples, grouped into relations. Most relational DB use SQL and query language. A table in SQL DB schema corresponds to a predicate variable, the contents of a table to a relation.
-	Object-oriented – the information is represented in a form of objects. OO DB are a hybrid between OO and table approach.
2.	Which are the main functions performed by a Relational Database Management System (RDBMS)?
-	Creating, altering, deleting tables and relationships between them (DB schema).
-	Adding, changing, deleting, searching and retrieving of data stored in tables.
-	RDBMS supports SQL language.
3.	Define what is "table" in database terms.
A table consists of data, arranged in rows and columns. The rows have the same structure and the columns have name and type.
4.	Explain the difference between a primary and a foreign key.
A Primary Key is a column of the table that uniquely identifies its rows and it’s usually a number. It can also be composed by several columns – composite primary key. Relationships between the tables are done via interconnections primary key and a foreign key. The Foreign Key is a record identifier in another table.

5.	Explain the different kinds of relationships between tables in relational databases.
-	One-to-many (many-to-one) – a single record in the first table has many corresponding records in the second table. Example: Country -> Cities.
-	Many-to-many – records in the first table have many corresponding records in the second table. It is implemented with an additional table.
-	One-to-one – A single record in the first table corresponds to a single record in the second table. It is used to model inheritance between tables.
6.	When is a certain database schema normalized?
A DB is considered normalized when repeated data is removed.
7.	What are the advantages of normalized databases?
An advantage of normalized DB is avoiding data repetition. This reduces the size of the DB. The data is organized more logically.
8.	What are database integrity constraints and when are they used?
Integrity constraints enforce rules which cannot be violated. This ensures data integrity in DB. There are different types of constraints:
-	Primary Key constraint – ensures that the primary key of a table has unique value for each table row.
-	Unique Key constraint – ensures that all values in a certain column or group of columns are unique.
-	Foreign Key constraint – Ensures that the value in a given column is from another table.
-	Check constraint – Ensures that values from a certain column meet some predefined condition.
9.	Point out the pros and cons of using indexes in a database.
Pros:
-	Speed up search in a certain column or group of columns.
-	Can be clustered (built-in table) or non-clustered (stored externally).
Cons:
-	Adding and deleting records in indexed tables is slower.
-	Should be used for big tables only (50 000 rows).

10.	 What's the main purpose of the SQL language?
Structured Query language is used for manipulation of relational DB. SQL supports creating, altering, deleting tables and other objects in the DB, searching, retrieving, inserting, modifying and deleting data table rows. 
11.	 What are transactions used for? Give an example.
Transactions are a sequence of DB operations executed as a single unit, either all of them are executed successfully or none of them. They guarantee the integrity of the DB. All changes in a transaction are temporary. Changes are final when COMMIT is successfully executed. At anytime all changes could be cancelled by executing ROLLBACK. Example: A bank transfer from one account to another which includes withdraw from one account and deposit to the other fails if one of the operations is cancelled.
12.	 What is a NoSQL database?
Use document-based (non-relational) model. NoSQL uses schema-free document storage which still supports CRUD (Create, Read, Update, Delete), indexing and querying, concurrency and transactions. NoSQL is highly optimized for append/retrieve and has great performance and scalability.
Could be a set of documents (JSON), key-value pairs, hierarchical key-value pairs, key-value model with schema (Cassandra), set of OOP-style objects.

13.	 Explain the classical non-relational data models.
Data is stored as documents. Single entity document is a single record. Documents do not have a fixed structure. 
14.	 Give few examples of NoSQL databases and their pros and cons.
-	MongoDB - Mature and powerful JSON-document database. 
Cons: data size is typically higher due to each document has field names stored in it; less flexible with querying – no JOINs; no support for transactions; 
-	Redis - Mature and powerful JSON-document database.
Cons: no JOINs or query language; 
-	CouchDB - Mature and powerful JSON-document database.
Cons: arbitrary queries are expensive. To do a query that you haven't created a view for, you need to create a temporary view;
-	Cassandra - Mature and powerful JSON-document database.
Cons: no aggregations, no Ad-Hoc Queries, unpredictable Performance; 

