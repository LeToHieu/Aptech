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
        require './models/BookState.php';
        require './models/Book.php';
        require './models/SchoolBook.php';
        require './models/ReferenceBook.php';
        
        $book1 = new SchoolBook("11a",100,2,"hieu sach viet",BookState::OLD);
        $book2 = new SchoolBook("22a",200,3,"hieu sach abc",BookState::NEW);

        $book3 = new ReferenceBook("33a",200,2,"hieu sach viet",0.2);
        $book4 = new ReferenceBook("44a",300,2,"hieu sach abc",0.3);
        $book5 = new ReferenceBook("55a",500,2,"hieu sach viet",0.5);
        $books = array($book1, $book2,$book3, $book4,$book5);
        $totalReferenceBookPrice = 0.0;
        $totalSchoolBookPrice = 0.0;

        $numberOfReferenceBooks = 0;

        foreach($books as $book) {
            if($book instanceof SchoolBook) {
                $totalSchoolBookPrice += $book->getTotalPrice();
            }else if($book instanceof ReferenceBook) {
                $totalReferenceBookPrice += $book->getTotalPrice();
                $numberOfReferenceBooks++;
            }
            if($book->getProducer() == "hieu sach abc") {
                print_r($book);
            }
        }
        echo "totalSchoolBookPrice = ".$totalSchoolBookPrice."<br>";
        echo "totalReferenceBookPrice = ".$totalReferenceBookPrice."<br>";
        echo "mean = ".$totalReferenceBookPrice / $numberOfReferenceBooks."<br>";

    ?>
</body>
</html>

