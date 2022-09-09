<?php
$conn=mysqli_connect("localhost","root","12345","users");
if(!$conn)
echo mysqli_connect_error();
$id=filter_input(INPUT_GET,"id",FILTER_SANITIZE_NUMBER_INT);
$del="DELETE FROM Users WHERE id='".$id."' ";
if(mysqli_query($conn,$del))
{
    header("location:list.php");
    exit;
}
else mysqli_error($conn);
mysqli_close($conn);
?>