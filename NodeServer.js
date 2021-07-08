const server = require("net").createServer().listen(7000, "127.0.0.1")
server.on("connection", (socket) => {
    console.log("Connected by: " + socket.remoteAddress)
    socket.on("data", (data) => {
        socket.write("HTTP/1.1 200 OK\r\nServer: My Pythonic Server\r\nAccept-Ranges: bytes\r\nContent-Length: " + data.length + "\r\nContent-Type: text/html\r\n\r\n" + data)
        console.log("Connection terminated.")
        socket.destroy()
        server.close()
    })
})