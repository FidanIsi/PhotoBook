namespace ConsoleApp1
{
    public class PhotoBook
    {
        private int numPages;

        public PhotoBook ()
        {
            numPages = 16;
            return;
        }

        public PhotoBook (int pages)
        {
            numPages = pages;
        }

        public int GetNumberPages()
        {
            return numPages;
        }
        
    }

    public class BigPhotoBook : PhotoBook
    { 
        public BigPhotoBook(int numPages)  
        {
            numPages = 64;
            return;
        }
    }
       


    internal class Program
    {
        static void Main(string[] args)
        {
            PhotoBook photoBook1 = new PhotoBook();
            Console.WriteLine("First photo book has " + photoBook1.GetNumberPages() + " pages.");

            PhotoBook photoBook2 = new PhotoBook(24);
            Console.WriteLine("Second photo book has " + photoBook2.GetNumberPages() + " pages.");

            BigPhotoBook largePhotoBook = new BigPhotoBook(64);
            Console.WriteLine("This big photo book has " + largePhotoBook.GetNumberPages() + " pages.");
        }
    }
}