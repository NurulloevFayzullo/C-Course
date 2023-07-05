namespace Task.PhotoBook;

public class PhotoBook
{
    int numPages;
    public PhotoBook()
    {
        numPages = 16;
    }
    public PhotoBook(int numPages)
    {
        this.numPages = numPages;
    }
    public int GetNumPages()
    {
        return numPages;
    }
}
