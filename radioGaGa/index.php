<?php include("inc/header.php");?>

    <div class="homeContainer">
        <div class="subTitle">
            <h1>Lil-Pobi FM</h1>
            <h2>Hét beste radiostation van <span class="nederland">Nederland</span> en <span class="limburg">Limburg.</span> </h2>
        </div>
        <div id="bg" style="background-image:url('https:/picsum.photos/2560/1600');" class="bg"></div>
    </div>

    <div id="cookie-consent">
    This website uses cookies. By continuing to use this website, you consent to our use of these cookies.
    <button id="accept-cookies" onclick="acceptCookies()">Accept</button>
    </div>

    <style>
        body{
            overflow: hidden;
        }
        header p:nth-child(2) a,
        .barMenu div:nth-child(1) a{
            background-color: rgba(26, 26, 26, 0.525);
            box-shadow: inset 0.2vh 0.2vh 0.5vh 0.2vh black;
            border:0.2vh solid rgb(24, 24, 24);
            color: white;
            text-shadow: 0px 0px 20px rgba(220, 220, 220, 0.6);
        }
    </style>

<?php include("inc/footer.php");?>