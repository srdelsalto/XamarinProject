const Student = require("../model/student.model.js");

exports.create = (req, res) => {
    if (!req.body) {
        res.status(400), send({
            message: "Content cant be empty"
        });
    }
    const student = new Student({
        id_espe: req.body.id_espe,
        name: req.body.name,
        last_name : req.body.last_name,
        ci : req.body.ci,
        user_name : req.body.user_name,
        user_pass : req.body.user_pass
    });

    Student.create(student, (err, data) => {
        if (err)
            res.status(500).send({
                message:
                    err.message || "Some error ocurred while creating the Student"
            });
        else res.send(data);
    });
};

// Retrieve all Customers from the database.
exports.findAll = (req, res) => {
    Student.getAllStudent((err, data) => {
        if (err)
            res.status(500).send({
                message:
                    err.message || "Some error occurred while retrieving students."
            });
        else res.send(data);
    });
};
// Find a single Customer with a customerId
exports.findOne = (req, res) => {
    Student.findById(req.params.studentId, (err, data) => {
        if (err) {
            if (err.kind === "not_found") {
                res.status(404).send({
                    message: `Not found Student with id ${req.params.studentId}.`
                });
            } else {
                res.status(500).send({
                    message: "Error retrieving Student with id " + req.params.studentId
                });
            }
        } else res.send(data);
    });
};

// Delete a Customer with the specified customerId in the request
exports.delete = (req, res) => {
    Student.remove(req.params.studentId, (err, data) => {
        if (err) {
            if (err.kind === "not_found") {
                res.status(404).send({
                    message: `Not found Student with id ${req.params.studentId}.`
                });
            } else {
                res.status(500).send({
                    message: "Could not delete Student with id " + req.params.studentId
                });
            }
        } else res.send({ message: `Student was deleted successfully!` });
    });
};

// Delete all Customers from the database.
exports.deleteAll = (req, res) => {
    Student.removeAll((err, data) => {
        if (err)
            res.status(500).send({
                message:
                    err.message || "Some error occurred while removing all students."
            });
        else res.send({ message: `All Students were deleted successfully!` });
    });
};