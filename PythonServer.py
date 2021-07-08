import socket

with socket.socket(socket.AF_INET, socket.SOCK_STREAM) as s:
    s.bind(("127.0.0.1", 9000))
    s.listen()
    connection, address = s.accept()
    with connection:
        print("Connected by: ", address)
        data = connection.recv(1024)
        connection.sendall(
            "HTTP/1.1 200 OK\r\nServer: My Pythonic Server\r\nAccept-Ranges: bytes\r\nContent-Length: ".encode(
                "utf-8"
            )
            + str(len(data)).encode("utf-8")
            + "\r\nContent-Type: text/html\r\n\r\n".encode("utf-8")
            + data
        )
    print("Connection terminated.")
