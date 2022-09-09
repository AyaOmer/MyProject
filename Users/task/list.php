<?php
  session_start();
 
  if(isset($_SESSION["id"]))
    {
        echo "<p> Welcome:  ".$_SESSION["email"].'  <a href="logout.php">   Log Out</a></p>';
    }
    else
    {
        header("location: login.php");
        exit;
    } 

    $conn=mysqli_connect("localhost","root","12345","users");
    if(!$conn)
    echo mysqli_connect_error();
?>
<html>
    <body>
        <form method="get">
            <input type="text"  name ="search" placeholder="Enter a Name Or Email ">
            <input type="submit" value="search">
            
        </form>

    <table>
        <thead>
            <tr>
                <th>ID</th>
                <th>Name</th>
                <th>Password</th>
                <th>Email</th>
                <th>Avatar</th>

            </tr>
        </thead>
        <tbody>
         <?php
         $query="select * from Users";
         if(isset($_GET["search"]))
         {
            $search=mysqli_escape_string($conn,$_GET["search"]);
         $query.=" WHERE name LIKE '%".$search."%'  OR email  LIKE '%".$search."%'";
         }
         $res=mysqli_query($conn,$query);
         while($row=mysqli_fetch_assoc($res))
         {
            ?>
          
            <tr>
                <td><?=$row["id"]?> </td>
                <td><?=$row["name"]?> </td>
                <td><?=$row["password"]?> </td>
                <td><?=$row["email"]?> </td>
                <td><?=$row["avatar"]?> </td>

                
                <td><a href="edit.php?id=<?=$row["id"]?>" >Edit</a></td>
                
                <td><a href ="delete.php?id=<?=$row["id"]?>" >Delete</a></td>




            </tr> 
           
            <?php  } ?>
         
         
        </tbody>
        <tfoot>
            <tr>
                <td colspan="2" > <?= mysqli_num_rows($res) ?> Users </td> 
                <td colspan="2" ><a  href="register.php" >ADD USERS</a></td>
            </tr>
        </tfoot>



    </table>
  
    </body>
</html>
<?php
    mysqli_free_result($res);
    mysqli_close($conn);
    ?>