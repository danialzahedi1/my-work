<!DOCTYPE html>
<html lang="en">
<?php include("inc/functions.php") ?>
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="author" content="Danial Zahedi">
    <link rel="stylesheet" href="style/style.css">
    <title>Lil-Pobi Radio</title>
</head>
<body class="noscroll">
    <header class="pcHeader">
        <p id="play">lil-Pobi FM</p>
        <?php
        $sql = "SELECT * FROM nav";
        $result = $conn->query($sql);
 
        while($row = mysqli_fetch_array($result)) {
        echo "<p><a href='" . $row['navLink'] . "'>" . $row['navName'] . "</a></p>";
        }
        ?>
    </header>
    <header class="phoneHeader">
        <p class="play">lil-Pobi FM</p>
        <i class="fa-solid fa-bars bars"></i>
        <div class="barMenu">
            <?php
            $sql = "SELECT * FROM nav";
            $result = $conn->query($sql);

            while($row = mysqli_fetch_array($result)) {
            echo "<div><a href='" . $row['navLink'] . "'>" . $row['navName'] . "</a></div>";
            }
            ?>

        </div>
    </header>