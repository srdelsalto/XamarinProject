const Publication = require("../model/publication.model.js");

exports.create = (req, res) => {
    if (!req.body) {
        res.status(400), send({
            message: "Content cant be empty"
        });
    }
    const publication = new Publication({
        lepub_id: req.body.lepub_id,
        leuser_idespe : req.body.leuser_idespe,
        letop_id : req.body.letop_id,
        lepub_message : req.body.lepub_message,
        lepub_type : req.body.lepub_type,
        lepub_anonymous : req.body.lepub_anonymous,
        lepub_complaint : req.body.lepub_complaint
    });

    Publication.create(publication, (err, data) => {
        if (err)
            res.status(500).send({
                message:
                    err.message || "Some error ocurred while creating the Customer"
            });
        else res.send(data);
    });
};

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