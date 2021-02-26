<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
        require './models/Book.php';
        require './models/SchoolBook.php';
        require './models/ReferenceBook.php';
        
        $book1 = new SchoolBook("11a",100,2,"hieu sach viet","old");
        $book2 = new ReferenceBook("11a",100,2,"hieu sach viet",0.2);
        echo "total = ".$book1->getTotalPrice();
    ?>
</body>
</html>

