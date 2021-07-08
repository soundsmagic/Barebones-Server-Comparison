# Barebones-Server-Comparison
Educational comparison of the most barebones web server possible in different languages

During my education to become a system developer, I first got in contact with web server functionality during a Javascript course, where we got to build a "Hello World!" server in Node using both the HTTP module and Express. But in order to grasp the underlying concepts and understand the workings at a lower level, I tasked myself with building the most barebones web server I could with Node. Later on in a C# course, I had some time over and revisited the "barebones server" with the aim of building the same functionality in C#, to see how it differed. Later still, I had some time over during my first internship and decided to learn Python on my own. Of course I revisited the server once again, to add Python to the comparison.

The goal is to get as "low level" in these "high level" languages as possible, to learn more about the intersection where the language "ends" and the lower parts of the computer takes over. A fun thing was to see how many lines each language took to perform the same task, although I didn't want to compress the code as far as it possibly could, as that would make it harder to read - thus working against the educational purpose.

When writing this I am still in school, continuing to learn about all these awesome things! So please don't hesitate to point out if I missed something, for example if there is actually a "lower level" to perform some parts of the code in the different languages, or something else!

The functionality I was aiming for was to be able to connect locally to the server, have the server output in its end a message that a client connected and from what address, echo back the incoming HTTP request and then close the connection and terminate the server.
