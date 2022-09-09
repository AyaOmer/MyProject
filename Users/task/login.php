<?php
session_start();
$conn=mysqli_connect("localhost","root","12345","users");
if(!$conn)
echo mysqli_connect_error();
if($_SERVER["REQUEST_METHOD"]=="POST")
     {
    $password=sha1($_POST['password']);
    $email=mysqli_escape_string($conn,$_POST['email']);
    $query="SELECT * FROM Users where email='".$email."' AND  password='".$password."' LIMIT 1";
    $res=mysqli_query($conn,$query);
    if($row=mysqli_fetch_assoc($res))
    {
        $_SESSION["id"]=$row["id"];
        $_SESSION["email"]=$row["email"];
        
        header("location: list.php");
        exit;

    }
    else $eror="Invalid password or email";
    mysqli_free_result($res);
}
mysqli_close($conn);
?>
<!DOCTYPE html>
<html>

    <body>
    <?php if(isset($eror)) echo $eror?>
            <form method="post">
            <label>Email :</label>
            <input type="email" name="email">
            <br><br>
            <label>Password :</label>
            <input type="password" name="password">
            <br><br>
            <input type="submit" name="submit" value="Login">


        </form>
    </body>
</html>

