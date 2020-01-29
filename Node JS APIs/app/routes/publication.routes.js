module.exports = app => {
    const publication = require("../controller/publication.controller.js");

    app.post("/publications/", publication.create)
    // Retrieve all Publications
    app.get("/publications", publication.findAll);
  
    // Retrieve a single Customer with customerId
    app.get("/publications/:publicationId", publication.findOne);
  
    // Delete a Customer with customerId
    app.delete("/publications/:publicationId", publication.delete);
  
    // Create a new Customer
    app.delete("/publications", publication.deleteAll);
  };