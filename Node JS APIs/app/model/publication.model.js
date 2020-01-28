var sql = require("./db.js");

// constructor
const Publication = function(publication) {
    this.lepub_id = publication.lepub_id;
    this.leuser_idespe = publication.leuser_idespe;
    this.letop_id = publication.letop_id;
    this.lepub_message = publication.lepub_message;
    this.lepub_type = publication.lepub_type;
    this.lepub_anonymous = publication.lepub_anonymous;
    this.lepub_complaint = publication.lepub_complaint;
};

Publication.createPublication - function (newPublication, result) {
    sql.query("INSERT INTO lepub_publication set ?", newPublication, function (err, res) {
        if (err) {
            console.log("error: ", err);
        } else {
            console.log(res.insertId);
            result(null, res.insertId);
        }
    });
};

Publication.getAllPublication = function (result) {
    sql.query("SELECT * FROM lepub_publication", function (err, res) {
      if (err) {
        console.log("error: ", err);
        result(null, err);
        return;
      }
  
      console.log('Publications: ', res);
      result(null, res);
    });
  };

Publication.findById = (publicationId, result) => {
  sql.query(`SELECT * FROM lepub_publication WHERE lepub_id = ${publicationId}`, (err, res) => {
    if (err) {
      console.log("error: ", err);
      result(err, null);
      return;
    }

    if (res.length) {
      console.log("found Publication: ", res[0]);
      result(null, res[0]);
      return;
    }

    // not found Publication with the id
    result({ kind: "not_found" }, null);
  });
};

Publication.remove = (id, result) => {
  sql.query("DELETE FROM lepub_publication WHERE id = ?", id, (err, res) => {
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

    console.log("deleted Publication with id: ", id);
    result(null, res);
  });
};

Publication.removeAll = result => {
  sql.query("DELETE FROM lepub_publication", (err, res) => {
    if (err) {
      console.log("error: ", err);
      result(null, err);
      return;
    }

    console.log(`deleted ${res.affectedRows} Publications`);
    result(null, res);
  });
};

module.exports = Publication;