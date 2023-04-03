<?php include("inc/head.php") ?>
<body class="shopBagPage">

    <?php include("inc/header.php"); ?>

    <?php
    // if (isset($_SESSION['cart'])) {
    //     foreach ($_SESSION['cart'] as $item) {
    //         $product_id = $item['product_id'];
    //         $quantity = $item['quantity'];
    //     }   
    // }
    ?>

    <!-- <div class="checkoutContainer">
        <form method="post" action="checkout.php">
            <label for="name">Name:</label>
            <input type="text" name="name" id="name">
            <label for="email">Email:</label>
            <input type="email" name="email" id="email">
            <label for="address">Shipping Address:</label>
            <textarea name="address" id="address"></textarea>
            <button type="submit">Checkout</button>
        </form>
    </div> -->
</body>
<?php include("inc/footer.php") ?>