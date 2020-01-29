module.exports = app => {
    const student = require("../controller/student.controller.js");

    app.post("/students/", student.create)
    // Retrieve all Publications
    app.get("/students", student.findAll);

    // Retrieve a single Customer with customerId
    app.get("/students/:studentId", student.findOne);

    // Delete a Customer with customerId
    app.delete("/students/:studentId", student.delete);

    // Create a new Customer
    app.delete("/students", student.deleteAll);
};