const express = require('express');
const app = express();
const port = 3000;

app.get('/', (req, res) => {
  res.send('Hello World!');
});

app.get('/api', (req, res) => {
  const obj = { personName: "John Doe", address: "Home St. 1234" }
  res.json(obj);
});

app.listen(port, () => {
  console.log(`Example app listening on http://localhost:${port}/`);
});
