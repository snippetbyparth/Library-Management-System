public class Member{
    public int MemberId{get;set;}
    public String Name{get; set;}
    public List<int> BorrowedBooks{get; set;}
    public Member(int memberid, String name){
        MemberId = memberid;
        Name= name;
        BorrowedBooks = new List<int>();
    }
    public void DisplayInfo(){
        Console.WriteLine($"{MemberId}, {Name}");
        foreach(var booknum in BorrowedBooks){
            Console.WriteLine(booknum);
        }
    }
}