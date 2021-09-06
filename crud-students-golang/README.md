# CRUD - Golang MySQL

Using Git Bash first install driver for Go's MySQL database package. Run below command and install MySQL driver's
```go
go get -u github.com/go-sql-driver/mysql
```

## Now create go_employee Database
1. Open PHPMyAdmin/HeidiSQL or what ever MySQL database management tool that you are using.
2. Create a new database "go_employee"

## Step 2: Creating the Employee Table

Execute the following SQL query to create a table named Employee inside your MySQL database. We will use this table for all of our future operations.

```sql
DROP TABLE IF EXISTS `go_employee`;
CREATE TABLE `employee` (
  `id` int(6) unsigned NOT NULL AUTO_INCREMENT,
  `name` varchar(30) NOT NULL,
  `city` varchar(30) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;
```


Run the following command
```go
go run main.go
```

Load the following URL
```go
http://localhost:8080/
```