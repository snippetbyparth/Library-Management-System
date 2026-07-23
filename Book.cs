public class Book{
    public int BookId{get; set;}     
    public string Title{get; set;}
    public string Author{get; set;}
    public int TotalCopies{get; set;}
    public int AvailableCopies{get; set;}
    public Book(int bookid, string title, string author, int totalcopies, int availablecopies){
        if (availablecopies> totalcopies){
            throw new ArgumentException("Available copies cannot be more than the total copies.");
        }
        BookId = bookid;
        Title = title;
        Author = author;
        TotalCopies= totalcopies;
        AvailableCopies= availablecopies;
    }
    public void DisplayInfo(){
        Console.WriteLine($"Book_ID: {BookId}, Title: {Title}, Author: {Author}, Total copies: {TotalCopies}, Available copies: {AvailableCopies}");
    }
}

