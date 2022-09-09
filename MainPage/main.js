
function myfun()
{
   var dots= document.getElementById("dot");
   var More= document.getElementById("more");
   var  btnText= document.getElementById("btnM");
    if( dots.style.display==="none")
    {
 dots.style.display="inline";
 btnText.innerHTML="Read More";
 More.style.display = "none";

    }
    else{
        dots.style.display="none";
        btnText.innerHTML="Read Less";
        More.style.display = "inline";
    }
}
