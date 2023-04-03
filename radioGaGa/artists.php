<?php include("inc/header.php"); ?>

  <h1 class="artistH1">Artists</h1>
  <?php
  $sql = "SELECT * FROM artist";

  $result = $conn->query($sql);

  if ($result->num_rows > 0){

    // output data of each row
    echo '<div class="playlistContainer">';
    $rows = 0;
    while($row = $result->fetch_assoc()) {
      $rows++;     
      ?>
    <div class="artist artist<?php echo $rows;?>">
      <h2 class="title"><?php echo $row["artistName"]; ?></h2> 
      
          <a class="artistSelector" href="player.php?<?php echo "artistId=" , $row['artistId']; echo "&albumId=" , $row['artistId']; ?>">
            <div class="bgpl bgpl<?php echo $rows ?>" onmouseover="playSnippet(<?php echo $rows; ?>)" onmouseout="pauseSnippet(<?php echo $rows; ?>)">
              <video  id="vid<?php echo $rows ?>" onmouseover="unmute(<?php echo $rows; ?>)" onmouseout="mute(<?php echo $rows; ?>)" loop muted>
                <source src="media\mp4\<?php echo $rows; ?>.mp4"  type="video/mp4">
              </video>
              <p class="artistDescription"><?php echo $row['artistDescription'] ?></p>
              <ul class="artistTop3">
                <h3>Top 3 songs:</h3>
                <li><?php echo $row['artistTop1']?></li>
                <li><?php echo $row['artistTop2']?></li>
                <li><?php echo $row['artistTop3']?></li>
              </ul>
            </div>
          </a> 
    </div>
  <?php
    }
    echo "</div>";
  }
  ?>

  </div>


  <div style="background-image:url('https:/picsum.photos/2560/1600');" class="bg"></div>

  <style>
    header p:nth-child(3) a,
    .barMenu div:nth-child(2) a{
      background-color: rgba(26, 26, 26, 0.525);
      box-shadow: inset 0.2vh 0.2vh 0.5vh 0.2vh black;
      border:0.2vh solid rgb(24, 24, 24);
      color: white;
      text-shadow: 0px 0px 20px rgba(220, 220, 220, 0.6)/*, 0px 0px 40px rgba(220, 220, 220, 0.3)*/;
    }

    body{
      overflow-x: visible;
    }

    .bg{
      position: fixed;

    }

  </style>

<?php include("inc/footer.php"); ?>