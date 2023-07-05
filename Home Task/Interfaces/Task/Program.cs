using Task.PhotoBook;

var photo = new PhotoBook();
System.Console.WriteLine(photo.GetNumPages());

 photo = new PhotoBookTest(24);
System.Console.WriteLine(photo.GetNumPages());

 photo = new BigPhotoBook(64);
System.Console.WriteLine(photo.GetNumPages());

