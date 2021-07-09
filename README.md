# Barebones-Server-Comparison
Educational comparison of the most barebones web server possible in different languages

During my education to become a system developer, I first got in contact with web server functionality during a Javascript course, where we got to build a "Hello World!" server in Node using both the HTTP module and Express. But as with all programming I've been learning, I wanted to understand the workings at a lower level and grasp the underlying concepts. When I found very little on the internet regarding building web servers with the least amount of code, libraries and built-in functions, I tasked myself with building the most barebones web server I could with Node. Later on in a C# course, I had some time over and revisited the "barebones server" with the aim of building the same functionality in C#, to see how it differed. Later still, I had some spare time during my first internship and decided to learn Python on my own. Of course I revisited the server once again, to add Python to the comparison.

The goal is to get as "low level" in these "high level" languages as possible, to learn more about the intersection where the language "ends" and the lower parts of the computer takes over. Avoiding ready made libraries and built-in functions aids in this as well. A fun thing was to see how many lines each language took to perform the same task when coding in this manner, although I didn't want to compress the code as far as I possibly could, as that would make it harder to read - thus working against the educational purpose (well, I did compress the Node code a bit). I found it interesting that C# forced me to use a lot of special types like "IPEndPoint", and also that JavaScript/Node in some places forced me to use ready made classes and functions, abstracting away some low level stuff that I couldn't even get to - now that I "strangely enough" wanted to!

When writing this I am still in school, continuing to learn about all these awesome things! So please don't hesitate to point out if I missed something, for example if there is actually a "lower level" to perform some parts of the code in the different languages, or if the code in any of the languages could be improved with the goal of this little project in mind!

The functionality I was aiming for was to be able to connect locally to the server, have the server output on its end a message that a client connected and from what address, echo back the incoming HTTP request and then close the connection and terminate the server.
