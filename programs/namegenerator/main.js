const fetch = require('node-fetch');

const url = 'https://raw.githubusercontent.com/Domenik1408/50k-random-names/main/names.txt';

fetch(url)
  .then(response => response.text())
  .then(text => {
    const lines = text.split('\n');
    const randomLine = lines[Math.floor(Math.random() * lines.length)];
    console.log(randomLine);
  });
