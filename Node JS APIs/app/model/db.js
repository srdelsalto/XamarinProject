const mysql = require("mysql");

// Create a connection to the database
const connection = mysql.createConnection({
    host     : "dbespe.cjvk5snqqjmr.us-east-2.rds.amazonaws.com",
    user     : "rootESPE",
    password : "rootESPE",
    port     : 3306,
    database: "dbsuggestionsportal"
});

// open the MySQL connection
connection.connect(error => {
  if (error) 
    throw error;
  console.log("Successfully connected to the database.");
});

module.exports = connection;