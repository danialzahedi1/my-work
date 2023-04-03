<?php

    session_start();
    $catId = array( "", "Action", "Adventure", "FPS", "Sandbox", "Open world");

    function dbconnect(){
        $servername = "localhost";
        $username = "root";
        $password = "";
        $dbname = "gameworld";
    
        // Create connection
        $mysqli = new mysqli($servername, $username, $password, $dbname);
        // Check connection
        if ($mysqli->connect_error) {
            die("Connection failed: " . $mysqli->connect_error);
        }
        return $mysqli;
    }

    function getNav(){
        $conn = dbconnect();
        $sql = "SELECT * FROM nav";
        $result = $conn->query($sql) or die($conn->error);

        $nav = $result->fetch_all(MYSQLI_ASSOC);

        return $nav;
    }

    function displayNav(){        
        $nav = getNav(); 
        foreach ($nav as $item) {
            echo "<a href='" . $item['navLink'] . "'>" . $item['navName'] . "</a>";
        }
    }

    function getGames(){
        $conn = dbconnect();

        $sql = "SELECT * FROM games ORDER BY gameName";

        $result = $conn->query($sql) or die($conn->error);

        $games = $result->fetch_all(MYSQLI_ASSOC);

        return $games;  
    }

    function displayGames(){
        
        if(isset($_GET['q'])){
            $games = getGameSearch();
        }else{
            $games = getGames(); 
        }
        foreach ($games as $item) {
            $isnum = is_numeric($item['gameSale']);
            if($isnum){
                $item['gameSale'] = $item['gamePrice'] - $item['gameSale'];
            }
            echo 
            "
            <a href='?gameId=" . $item['gameId'] . "'>
                <div onclick='openModal()' class='itemContainer'>
                    <img loading='lazy' src='" . $item['gameImg'] . "'>
                    <h1>" . $item['gameName'] . "</h1>
                    <h2 class='platform'>" . $item['gamePlatform'] . "</h2>
                    <h2 class='category'>" . $item['gameCategory'] . "<h2>
                    <span>
                        <h2 class='price "; if($isnum){echo "line-through"; } echo "'>" . $item['gamePrice'] . "</h2>
                        ";
                        if($isnum){
                            echo "<h2 class='discount'>" . $item['gameSale'] . "</h2>";
                        }
                    echo "
                    </span>                
                </div>  
            </a>
            ";
        }
    }

    function getGamesCat(){
        $conn = dbconnect();
        $categoryId = $_GET['categoryId'];

        $sql = "SELECT * FROM games WHERE categoryId LIKE '%$categoryId%' ORDER BY gameName";

        $result = $conn->query($sql) or die($conn->error);

        $games = $result->fetch_all(MYSQLI_ASSOC);

        return $games;  
    }

    function displayGamesCat(){

        if(isset($_GET['categoryId'])){
            $games = getGamesCat(); 
            $categoryId = $_GET['categoryId'];

            foreach ($games as $item) {
                $isnum = is_numeric($item['gameSale']);
                if($isnum){
                    $item['gameSale'] = $item['gamePrice'] - $item['gameSale'];
                }
                echo 
                "
                <a href='?categoryId=" . $categoryId . "&gameId=" . $item['gameId'] . "'>
                    <div onclick='openModal()' class='itemContainer'>
                        <img loading='lazy' src='" . $item['gameImg'] . "'>
                        <h1>" . $item['gameName'] . "</h1>
                        <h2 class='platform'>" . $item['gamePlatform'] . "</h2>
                        <h2 class='category'>" . $item['gameCategory'] . "<h2>
                        <span>
                            <h2 class='price "; if($isnum){echo "line-through"; } echo "'>" . $item['gamePrice'] . "</h2>
                            ";
                            if($isnum){
                                echo "<h2 class='discount'>" . $item['gameSale'] . "</h2>";
                            }
                        echo "
                        </span>                
                    </div>  
                </a>
                ";
            }
        }else{
            displayGames();
        }
        
    }

    function getGame(){
        if (!isset($_GET['gameId'])) {
            return false; // Return false if gameId parameter is not set
        }
        
        $conn = dbconnect();
        $gameId = mysqli_real_escape_string($conn, $_GET['gameId']);
    
        $sql = "SELECT * FROM games WHERE gameId = $gameId";
        $result = $conn->query($sql) or die($conn->error);
    
        $games = $result->fetch_all(MYSQLI_ASSOC);
    
        return $games;
    }

    function displayGame(){
        if(isset($_GET['gameId'])) {
            $games = getGame();
            
            foreach ($games as $item) {
                $isnum = is_numeric($item['gameSale']);
                if($isnum){
                    $item['gameSale'] = $item['gamePrice'] - $item['gameSale'];
                }
                echo 
                "
                <img loading='lazy' src='" . $item['gameImg'] . "'>
                <div class='infoContainer'>
                    <h1>" . $item['gameName'] . "</h1>
                    <h2 class='platform'>" . $item['gamePlatform'] . "</h2>
                    <h2 class='category'>" . $item['gameCategory'] . "</h2>
                    <h3 class ='desc'>" . $item['gameDesc'] . "</h3>
                    <span>
                        <h2 class='price "; if($isnum){echo "line-through"; } echo "'>" . $item['gamePrice'] . "</h2>
                        ";
                        if($isnum){
                            echo "<h2 class='discount'>" . $item['gameSale'] . "</h2>";
                        }
                    echo "
                    </span>
                </div>
                <style>
                    .modal{
                        display: block
                    }
                </style>
                ";
            }
        }else{
            $br = "<br>";
            echo str_repeat($br, 10);
            echo "loading...";
        }
    }

    function getGamesSale(){
        $conn = dbconnect();
        $sql = "SELECT * FROM games WHERE gameSale REGEXP '^[0-9]+(\.[0-9]+)?$' ORDER BY gameName";
        $result = $conn->query($sql) or die($conn->error);

        $games = $result->fetch_all(MYSQLI_ASSOC);

        return $games;
    }

    function displayGamesSale(){
        $games = getGamesSale(); 
        foreach ($games as $item) {
            $isnum = is_numeric($item['gameSale']);
            if($isnum){
                $item['gameSale'] = $item['gamePrice'] - $item['gameSale'];
            }
            echo 
            "
            <a href='?gameId=" . $item['gameId'] . "'>
                <div onclick='openModal()' class='itemContainer'>
                    <img loading='lazy' src='" . $item['gameImg'] . "'>
                    <h1>" . $item['gameName'] . "</h1>
                    <h2 class='platform'>" . $item['gamePlatform'] . "</h2>
                    <h2 class='category'>" . $item['gameCategory'] . "<h2>
                    <span>
                        <h2 class='price "; if($isnum){echo "line-through"; } echo "'>" . $item['gamePrice'] . "</h2>
                        ";
                        if($isnum){
                            echo "<h2 class='discount'>" . $item['gameSale'] . "</h2>";
                        }
                    echo "
                    </span>                
                </div>  
            </a>
            ";
        }
    }

    function getGamesPlatform(){
        $conn = dbconnect();
        $platform = mysqli_real_escape_string($conn, $_GET['platform']);
        $sql = "SELECT * FROM games WHERE gamePlatform LIKE '%$platform%'  ORDER BY gameName";

        $result = $conn->query($sql) or die($conn->error);
        $games = $result->fetch_all(MYSQLI_ASSOC);
        return $games;
    }

    function displayGamesPlatform(){
        if(isset($_GET['platform'])) {
            $games = getGamesPlatform();
            $platform = $_GET['platform'];

            foreach ($games as $item) {
            echo 
            "
            <a href='?platform=" . $platform . "&gameId=" . $item['gameId'] . "'>
                <div onclick='openModal()' class='itemContainer'>
                    <img loading='lazy' src='" . $item['gameImg'] . "'>
                    <h1>" . $item['gameName'] . "</h1>
                    <h2 class='platform'>" . $item['gamePlatform'] . "</h2>
                    <h2 class='category'>" . $item['gameCategory'] . "<h2>
                    <h2 class='price'>" . $item['gamePrice'] . "</h2>
                </div>
            </a>
            ";
        }
        }else{
            displayGames();
        }
    }

    function getGameSearch(){
        $conn = dbconnect();
        $q = $_GET['q'];
        $sql = "SELECT * FROM games WHERE gameName LIKE '%$q%'  ORDER BY gameName";

        $result = $conn->query($sql) or die($conn->error);
        $games = $result->fetch_all(MYSQLI_ASSOC);
        return $games;
    }

    function getGamesPop(){
        $conn = dbconnect();
        $sql = "SELECT * FROM games WHERE gamePop > 0  ORDER BY gamePop";

        $result = $conn->query($sql) or die($conn->error);
        $games = $result->fetch_all(MYSQLI_ASSOC);
        return $games;
    }

    function displayGamesPop(){
        $games = getGamesPop();
        foreach ($games as $item) {
            $isnum = is_numeric($item['gameSale']);
            if($isnum){
                $item['gameSale'] = $item['gamePrice'] - $item['gameSale'];
            }
            echo 
            "
            <a href='?gameId=" . $item['gameId'] . "'>
                <div onclick='openModal()' class='itemContainer'>
                    <img loading='lazy' src='" . $item['gameImg'] . "'>
                    <h1>" . $item['gameName'] . "</h1>
                    <h2 class='platform'>" . $item['gamePlatform'] . "</h2>
                    <h2 class='category'>" . $item['gameCategory'] . "<h2>
                    <span>
                        <h2 class='price "; if($isnum){echo "line-through"; } echo "'>" . $item['gamePrice'] . "</h2>
                        ";
                        if($isnum){
                            echo "<h2 class='discount'>" . $item['gameSale'] . "</h2>";
                        }
                    echo "
                    </span>                
                </div>  
            </a>
            ";
        }
    }

    function getImg(){
        $conn = dbconnect();
        $sql = "SELECT gameImg FROM games ORDER BY gameCategory";

        $result = $conn->query($sql) or die($conn->error);
        $img = $result->fetch_all(MYSQLI_ASSOC);
        return $img;
    }

    function displayImg(){
        $img = getImg();
        foreach($img as $item){
            echo '
            <img src="' . $item['gameImg'] . '" onmouseover="myMarquee.stop()" onmouseout="myMarquee.start()">
            ';
        }
    }

    // $productId = $_POST['productId'];
    // $quantity = $_POST['quantity'];

    // $item = array(
    // 'productId' => $productId,
    // 'quantity' => $quantity
    // );

    // if (!isset($_SESSION['cart'])) {
    // $_SESSION['cart'] = array();
    // }

    // array_push($_SESSION['cart'], $item);

    // if (isset($_SESSION['cart'])) {
    //     foreach ($_SESSION['cart'] as &$item) {
    //       if ($item['productId'] == $productId){
    //             $item['quantity'] = $quantity;
    //         }
    //     }
    // }
    // if(isset($_GET['productId'])){
    //     $product_id = $_GET['productId'];
    // }

    // if (isset($_SESSION['cart'])) {
    //     foreach ($_SESSION['cart'] as $key => $item) {
    //         if ($item['productId'] == $productId) {
    //             unset($_SESSION['cart'][$key]);
    //         }
    //     }
    // }
?>