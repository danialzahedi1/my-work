<?php include("inc/head.php") ?>
<body class="platformsPage">

    <?php include("inc/header.php"); ?>


    <div class="platformsContainer">
        <div class="pfPc"><a href="?platform=PC">PC</a></div>
        <div class="pfPlaystation"><a href="?platform=Playstation">PLAYSTATION</a></div>
        <div class="pfXbox"><a href="?platform=Xbox">XBOX</a></div>
        <div class="pfSwitch">
            <a href="?platform=Switch"> SWITCH</a>
            <div class="blue"></div>
            <div class="black"></div>
            <div class="red"></div>
        </div>  
    </div>

    <h1 class="gamesTitle"><?php if(isset($_GET['q'])){ echo "Search results for: '" . $_GET['q'] . "'"; }else if(isset($_GET['platform'])){echo $_GET['platform'];}else{echo "All Platforms";} ?></h1>

    <div class="gamesContainer">

    <?php displayGamesPlatform(); ?>
    </div>

    <dialog class="modal">
        <div class="productDetails">
            <?php displayGame(); ?> 
            <button onclick="closeModal()" class='btnCloseModal'>x</button>
            <button class="btnAddToBag">
                <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-bag-plus" viewBox="0 0 16 16">
                    <path class="svgPlus" fill-rule="evenodd" d="M8 7.5a.5.5 0 0 1 .5.5v1.5H10a.5.5 0 0 1 0 1H8.5V12a.5.5 0 0 1-1 0v-1.5H6a.5.5 0 0 1 0-1h1.5V8a.5.5 0 0 1 .5-.5z"/>
                    <path d="M8 1a2.5 2.5 0 0 1 2.5 2.5V4h-5v-.5A2.5 2.5 0 0 1 8 1zm3.5 3v-.5a3.5 3.5 0 1 0-7 0V4H1v10a2 2 0 0 0 2 2h10a2 2 0 0 0 2-2V4h-3.5zM2 5h12v9a1 1 0 0 1-1 1H3a1 1 0 0 1-1-1V5z"/>
                </svg>
                <svg class="svgBagCheck" xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-bag-check" viewBox="0 0 16 16">
                    <path fill-rule="evenodd" d="M10.854 8.146a.5.5 0 0 1 0 .708l-3 3a.5.5 0 0 1-.708 0l-1.5-1.5a.5.5 0 0 1 .708-.708L7.5 10.793l2.646-2.647a.5.5 0 0 1 .708 0z"/>
                    <path d="M8 1a2.5 2.5 0 0 1 2.5 2.5V4h-5v-.5A2.5 2.5 0 0 1 8 1zm3.5 3v-.5a3.5 3.5 0 1 0-7 0V4H1v10a2 2 0 0 0 2 2h10a2 2 0 0 0 2-2V4h-3.5zM2 5h12v9a1 1 0 0 1-1 1H3a1 1 0 0 1-1-1V5z"/>
                </svg>
            </button>
        </div>

    </dialog>
</body>

<?php include("inc/footer.php") ?>