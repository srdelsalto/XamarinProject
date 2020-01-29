var sql = require("./db.js");

// constructor
const Student = function (student) {
    this.id_espe = student.id_espe;
    this.name = student.name;
    this.last_name = student.last_name;
    this.ci = student.ci;
    this.user_name = student.user_name;
    this.user_pass = student.user_pass;
};

Student.createStudent - function (newStudent, result) {
    sql.query("INSERT INTO sp_user set ?", newStudent, function (err, res) {
        if (err) {
            console.log("error: ", err);
        } else {
            console.log(res.insertId);
            result(null, res.insertId);
        }
    });
};

Student.getAllStudent = function (result) {
    sql.query("SELECT * FROM sp_user", function (err, res) {
        if (err) {
            console.log("error: ", err);
            result(null, err);
            return;
        }

        console.log('Students: ', res);
        result(null, res);
    });
};

Student.findById = (studentId, result) => {
    sql.query(`SELECT * FROM sp_user WHERE id_espe = ${studentId}`, (err, res) => {
        if (err) {
            console.log("error: ", err);
            result(err, null);
            return;
        }

        if (res.length) {
            console.log("found Student: ", res[0]);
            result(null, res[0]);
            return;
        }

        // not found Publication with the id
        result({ kind: "not_found" }, null);
    });
};

Student.remove = (id, result) => {
    sql.query("DELETE FROM sp_user WHERE id_espe = ?", id, (err, res) => {
        if (err) {
            console.log("error: ", err);
            result(null, err);
            return;
        }

        if (res.affectedRows == 0) {
            // not found Publication with the id
            result({ kind: "not_found" }, null);
            return;
        }

        console.log("deleted Student with id: ", id);
        result(null, res);
    });
};

Student.removeAll = result => {
    sql.query("DELETE FROM sp_user", (err, res) => {
        if (err) {
            console.log("error: ", err);
            result(null, err);
            return;
        }

        console.log(`deleted ${res.affectedRows} Students`);
        result(null, res);
    });
};

module.exports = Student;