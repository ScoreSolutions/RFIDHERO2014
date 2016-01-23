<html>

<head>
    <title>Luxand FaceCrop PHP Sample</title>

<?php

if ($_SERVER['REQUEST_METHOD'] == "POST"){    
    $uploaddir = "./";
    
    $now = time(); 
    while(file_exists($newfile = $uploaddir.$now.'-'.$_FILES['imgfile']['name'])){ 
        $now++; 
    }
    $cropfile = $newfile.'-crop.jpg'; 
    
    if (is_uploaded_file($_FILES['imgfile']['tmp_name'])){
       if (!copy($_FILES['imgfile']['tmp_name'],"$newfile")){
          print "Error Uploading File.";
          exit();
       }
    }

    unlink($_FILES['imgfile']['tmp_name']);
   
    echo "Please request the evaluation license key from Luxand, Inc., comment this line and pass the key to fcActivate. Please visit http://www.luxand.com/facecrop/ to request the key.<br>";
    $activation_key = "INSERT_LICENSE_KEY_HERE";
 
    if(0 == fcActivate($activation_key)){

        $context_id = fcCreateContextID();

        if (0 == fcFaceCrop(getcwd().'/'.$newfile, getcwd().$cropfile, 128, 196, $context_id)){
            print("<img src=\"$newfile\">");
            print("<img src=\"$cropfile\">");
        } else {
            print("Error cropping face");
        }

        fcFreeContextID($context_id);
    } else {
        print("Error: can't activate FaceCrop library");
    }

}
?>
</head>

<body bgcolor="#FFFFFF">

    <h2>Upload photo and crop face</h2>

    <form action="<?php echo $_SERVER['PHP_SELF']; ?>" method="POST" enctype="multipart/form-data">
    <input type="hidden" name="MAX_FILE_SIZE" value="1000000">
    <input type="file" name="imgfile"><br>
    <font size="1">Click browse to upload a photo</font><br>
    <br>
    <input type="submit" value="Upload">
    </form>

</body>
</html>
