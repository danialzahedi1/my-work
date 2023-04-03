<?php include("inc/header.php"); ?>

  <h1 class="contactH1">Contact</h1>
  <div class="contact-form">
    <form method="post" target="_self">
      <h1>Contact Form</h1>

      <input class="required" id="js-name" type="text" placeholder="Name" name="name" required>
      <input class="required" id="js-lastName" type="text" placeholder="Last name" name="lastName" required>

      <input class="required" type="email" placeholder="Email" name="email" required>

      <textarea class="required" id="js-message" placeholder="Message" name="message" required></textarea>
      <br><br>
      <div class="captcha">
        <input type="text" value="" name="question" id="js-captcha" required readonly>
        <input type="text" placeholder="Answer" name="captcha" id="captchaAnswer" required>
        <a onclick="captcha()">Check captcha</a>
      </div>
      <br>
  
      <input onclick="formSubmit()" type="button" value="Send" id="js-submit" style="color:gray; background-color: #191919;" disabled>
      <p id="thankYouMessage" style="display:none;">Thank you <span id="userName"></span> for contacting us Lil-Pobi FM!</p>
    </form>
  </div>


  <div style="background-image:url('https:/picsum.photos/2560/1600');" class="bg"></div>

  <style>
    body{
      display: flex;
      align-items: center;
    }

    header p:nth-child(4) a,
    .barMenu div:nth-child(3) a{
      background-color: rgba(26, 26, 26, 0.525);
      box-shadow: inset 0.2vh 0.2vh 0.5vh 0.2vh black;
      border:0.2vh solid rgb(24, 24, 24);
      color: white;
      text-shadow: 0px 0px 20px rgba(220, 220, 220, 0.6);
    }
  </style>

<?php include("inc/footer.php"); ?>
