<?php include("inc/head.php") ?>
<body class="gamePage">
    <?php include("inc/header.php"); ?>

    <h1 class="gamesTitle"><?php if(isset($_GET['q'])){ echo "Search results for: '" . $_GET['q'] . "'"; }else if(isset($_GET['categoryId'])){echo $catId[$_GET['categoryId']];}else{echo "All Games";} ?></h1>

    <div class="gamePageContainer">
        <div class="categorySelector">
            <form action="POST">
            <label for="">All games</label>
                <input type="radio" name="category" id="all" onclick="location.href = 'Games.php'"<?php if(!isset($_GET['categoryId'])){echo 'checked';}?>>
                <label for="">Action</label>
                <input type="radio" name="category" id="action" onclick="location.href = '?categoryId=1'"<?php if(isset($_GET['categoryId']) && $_GET['categoryId'] == 1){echo 'checked';}?>>
                <label for="">Adventure</label>
                <input type="radio" name="category" id="adventure" data-catId="2" onclick="location.href = '?categoryId=2'"<?php if(isset($_GET['categoryId']) && $_GET['categoryId'] == 2){echo 'checked';}?>>
                <label for="">FPS</label>
                <input type="radio" name="category" id="fps" data-catId="3" onclick="location.href = '?categoryId=3'"<?php if(isset($_GET['categoryId']) && $_GET['categoryId'] == 3){echo 'checked';}?>>
                <label for="">Sandbox</label>
                <input type="radio" name="category" id="sandbox" data-catId="4" onclick="location.href = '?categoryId=4'"<?php if(isset($_GET['categoryId']) && $_GET['categoryId'] == 4){echo 'checked';}?>>
                <label for="">Open world</label>
                <input type="radio" name="category" id="openWorld" data-catId="5" onclick="location.href = '?categoryId=5'"<?php if(isset($_GET['categoryId']) && $_GET['categoryId'] == 5){echo 'checked';}?>>
            </form>
        </div>
        <div class="gamesContainer">
            
            <!-- <a href="">
                <div class="itemContainer">
                    <img src="media\img\mcJava.jpg" alt="">
                    <h1>Minecraft</h1>
                    <h2 class="platform">PC, Playstation, Xbox, Mobile, Switch</h2>
                    <h2 class="category">Sandbox</h2>
                    <h2 class="price">29,99</h2>
                </div>
            </a> -->

            <?php displayGamesCat(); ?>

        </div>
    </div>

    

    <dialog class="modal">
        <div class="productDetails">
            <?php displayGame(); ?> 
            <button onclick="closeModal()" class='btnCloseModal'>x</button>
            <form method="post" action="Shopping-Bag.php">
                <button class="btnAddToBag" submit>
                    <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-bag-plus" viewBox="0 0 16 16">
                        <path class="svgPlus" fill-rule="evenodd" d="M8 7.5a.5.5 0 0 1 .5.5v1.5H10a.5.5 0 0 1 0 1H8.5V12a.5.5 0 0 1-1 0v-1.5H6a.5.5 0 0 1 0-1h1.5V8a.5.5 0 0 1 .5-.5z"/>
                        <path d="M8 1a2.5 2.5 0 0 1 2.5 2.5V4h-5v-.5A2.5 2.5 0 0 1 8 1zm3.5 3v-.5a3.5 3.5 0 1 0-7 0V4H1v10a2 2 0 0 0 2 2h10a2 2 0 0 0 2-2V4h-3.5zM2 5h12v9a1 1 0 0 1-1 1H3a1 1 0 0 1-1-1V5z"/>
                    </svg>
                    <svg class="svgBagCheck" xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-bag-check" viewBox="0 0 16 16">
                        <path fill-rule="evenodd" d="M10.854 8.146a.5.5 0 0 1 0 .708l-3 3a.5.5 0 0 1-.708 0l-1.5-1.5a.5.5 0 0 1 .708-.708L7.5 10.793l2.646-2.647a.5.5 0 0 1 .708 0z"/>
                        <path d="M8 1a2.5 2.5 0 0 1 2.5 2.5V4h-5v-.5A2.5 2.5 0 0 1 8 1zm3.5 3v-.5a3.5 3.5 0 1 0-7 0V4H1v10a2 2 0 0 0 2 2h10a2 2 0 0 0 2-2V4h-3.5zM2 5h12v9a1 1 0 0 1-1 1H3a1 1 0 0 1-1-1V5z"/>
                    </svg>
                </button>
            </form>
        </div>

    </dialog>

</body>
<?php include("inc/footer.php") ?>