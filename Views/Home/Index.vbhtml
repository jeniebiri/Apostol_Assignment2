@Code
    ViewData("Title") = "Home Page"
End Code


<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>My Portfolio</title>
    <style>
        body {
            text-align: center;
            background-color: #FFOOFF;
        }

        section {
            margin: 5px auto;
            max-width: 800px;
            background-color: white;
            padding: 20px;
            border-radius: 10px;
        }

        img {
            max-width: 50%;
            height: auto;
            margin: 10px; 
        }

        footer {
            background-color: #F6CEFC;
            ;
            padding: 20px;
            text-align: center;
            color: black;
        }
    </style>
</head>
<body>

    <section id="home">
        <h1>Welcome to my website</h1>
       </p>
        <p>
    </section>

    <section id="gallery">
        <h2>Gallery</h2>
        <img src="~/Content/Images/pic2.jpg">
        <img src="~/Content/Images/pic3.jpg">
        <img src="~/Content/Images/pic4.jpg">
    </section>


</body>
</html>