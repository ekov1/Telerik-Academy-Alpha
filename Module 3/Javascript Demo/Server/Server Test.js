const server = require(`http`);

server.createServer(function (req, res) {
    res.end("Hello World!")
}).listen(8080);