const express = require("express");
const router = express.Router();

// User profile with ID
router.get("/:id([0-9]{4})", (req, res) => {
  res.send(`User Profile for ID: ${req.params.id}`);
});

// Route with multiple parameters and regular expression
router.get("/:year([0-9]{4})/:month([0-9]{2})", (req, res) => {
  const { year, month } = req.params;
  res.send(`Posts from Year: ${year}, Month: ${month}`);
});

router.post("/:id([0-9]{4})", (req, res) => {
  const postData = req.body; //check authentication and connect to MongoDB
  res.send({ name: postData.firstname + postData.lastname });
});

module.exports = router;
