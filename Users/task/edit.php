

<?php 
     $conn=mysqli_connect("localhost","root","12345","users");
     if(!$conn)
     echo mysqli_connect_error();
     // show the information about users
     $id=filter_input(INPUT_GET,"id",FILTER_SANITIZE_NUMBER_INT);
     $match="SELECT * FROM  Users WHERE id=".$id." LIMIT 1";
     $res=mysqli_query($conn,$match);
     if($res)
     echo "thanks";
     else mysqli_error($conn);

     $row=mysqli_fetch_assoc($res);

     
     
     //update to data base
     $error_field= array();
     if($_SERVER["REQUEST_METHOD"]=="POST")
     {
        if((!isset($_POST["name"])&& !empty($_POST["name"])))
        $error_field[]="name";
        if((!isset($_POST["email"])&& filter_input(INPUT_POST,"email",FILTER_VALIDATE_EMAIL)))
        $error_field[]="email";

        
        if(empty($error_field))
        {
            $id=filter_input(INPUT_POST,"id",FILTER_SANITIZE_NUMBER_INT);
            $name=mysqli_escape_string($conn,$_POST['name']);
         $password=sha1($_POST['password']);
         $email=mysqli_escape_string($conn,$_POST['email']);
            $edit="UPDATE Users SET  name='".$name."' ,  password='".$password."' ,email='".$email."'  WHERE id='".$id."'"; 
       
           if( mysqli_query($conn,$edit))
           {
            header("location: list.php");
            exit;
           }
           else echo mysqli_error($conn);
       
        }
     }
     mysqli_free_result($res);
     mysqli_close($conn);

?>


<html>
    
    <body>
        <form  method ="post">
            <label>Name:  </label>
            <input type="hidden" name="id" value="<?=(isset($row["id"]))?$row["id"]:""?>"/>

            <input type="text" name="name" value="<?=(isset($row["name"]))?$row["name"]:""?>"/>
            <br><br>
            <label>Password:  </label>
            <input type="password" name="password"  value="<?=(isset($row["paeeword"]))?$row["password"]:""?>">
            <br><br>
            <label>Email:  </label>
            <input type="email" name="email"  value="<?=(isset($row["email"]))?$row["email"]:""?>">
            <br><br>
            <input type="submit" name="submit">
        </form>
    </body>
</html>
