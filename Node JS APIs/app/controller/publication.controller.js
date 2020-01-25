const Publication = require("../model/publication.model.js");

// Retrieve all Customers from the database.
exports.findAll = (req, res) => {
    Publication.getAllPublication((err, data) => {
      if (err)
        res.status(500).send({
          message:
            err.message || "Some error occurred while retrieving customers."
        });
      else res.send(data);
    });
  };
// Find a single Customer with a customerId
exports.findOne = (req, res) => {
    Publication.findById(req.params.publicationId, (err, data) => {
      if (err) {
        if (err.kind === "not_found") {
          res.status(404).send({
            message: `Not found Publication with id ${req.params.publicationId}.`
          });
        } else {
          res.status(500).send({
            message: "Error retrieving Publication with id " + req.params.publicationId
          });
        }
      } else res.send(data);
    });
  };

// Delete a Customer with the specified customerId in the request
exports.delete = (req, res) => {
    Publication.remove(req.params.publicationId, (err, data) => {
      if (err) {
        if (err.kind === "not_found") {
          res.status(404).send({
            message: `Not found Publication with id ${req.params.publicationId}.`
          });
        } else {
          res.status(500).send({
            message: "Could not delete Publication with id " + req.params.publicationId
          });
        }
      } else res.send({ message: `Publication was deleted successfully!` });
    });
  };

// Delete all Customers from the database.
exports.deleteAll = (req, res) => {
    Publication.removeAll((err, data) => {
      if (err)
        res.status(500).send({
          message:
            err.message || "Some error occurred while removing all publications."
        });
      else res.send({ message: `All Publications were deleted successfully!` });
    });
  };