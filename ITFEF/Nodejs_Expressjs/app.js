const express = require("express");
const bodyParser = require("body-parser");
const indexRoutes = require("./routes/index");
const userRoutes = require("./routes/user");

const app = express();
const port = 3000;

app.use(bodyParser.json());

app.use("/", indexRoutes);

app.all("/user/*", (req, res, next) => {
  console.log(`HTTP Method: ${req.method}`); //Handles all requests irrespective of header
  next();
});

app.use("/user", userRoutes);

app.use((err, req, res, next) => {
  console.error(err.stack);
  res.status(500).send("Something went wrong!");
});

app.listen(port, () => {
  console.log(`Server running on http://localhost:${port}`);
});
