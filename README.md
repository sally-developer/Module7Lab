# Module 7 SQL Challenge

This lab uses SQLite and the Northwind sample database to practice basic SQL statements.

## Challenge Files

- `Module7Challenge.sql` — SQL statements for the seven challenge tasks.
- `Module7ChallengeOutput.txt` — Output captured while running the challenge.
- `northwind.db` — SQLite database used for the exercises.

## Key Terms

- **Statement:** One complete instruction written in SQL. It ends with a semicolon.
- **Query:** A `SELECT` statement that asks the database for data.
- **Table:** A set of rows and columns that holds one kind of data, such as customers.
- **Column:** One kind of information in a table, such as a phone number.
- **Row:** One record in a table, such as one customer.
- **Terminal:** A window where you type commands.

## Run the Challenge

```bash
sqlite3 -echo -header -column northwind.db < Module7Challenge.sql 2>&1 | tee Module7ChallengeOutput.txt
```