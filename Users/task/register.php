
<?php 
  $conn=mysqli_connect("localhost","root","12345","users");
  if(!$conn)
  {
  echo mysqli_connect_error();

  }
  if($_SERVER["REQUEST_METHOD"]=="POST")
     {
      $name=mysqli_escape_string($conn,$_POST['name']);
      $password=sha1($_POST['password']);
      $email=mysqli_escape_string($conn,$_POST['email']);
      //FILES
      $upload_dir=$_SERVER["DOCUMENT_ROOT"]."/upload";
      $avatar="";
      if($_FILES["avatar"]["error"]==UPLOAD_ERR_OK)
      {
        $tmp=$_FILES["avatar"]["tmp_name"];
        $avatar=basename($_FILES["avatar"]["name"]);
        move_uploaded_file($tmp,"$upload_dir/$name.$avatar");
      }else echo "File can't be uploded";
     
      $query="INSERT  INTO Users  (name,password,email,avatar) VALUES('".$name."','".$password."','".$email."','".$avatar."')";
      if(mysqli_query($conn,$query))
      {
      header("location: list.php");
      exit;
      }
      else echo mysqli_error($conn);
    
     }
 
    
  
  mysqli_close($conn);

?>
<!DOCTYPE>
<html>
    <body>
       <form method="post" enctype="multipart/form-data" >
        <label for="name"> Name  </label>
       
        <input type="text"  name="name" id ="name">
        <br><br>
        <label> Email  </label>
        <input type="email"  name="email" >
        <br><br>
        
        <label> Password   </label>
        <input type="password"  name="password" >
        <br><br>
        
        <label for="avatar">Avatar</label>
        <input type="file"  name="avatar"  >
        <br><br>
        

        <input type="submit" name="submit">








       </form>
    </body>
</html>

