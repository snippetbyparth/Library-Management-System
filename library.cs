class Library {
    private List<Book>Books {get;set;}
    private List<Member> Members{get; set;}

    public Library(){                                 //<-------constructor
        Books = new List<Book>();                     //creates new list of book object type and assign it to books
        Members = new List<Member>();                     //creates new list of member object type and assign it to members
    }
    public void AddBook(Book book){                 //method to add new book type object to books list
        Books.Add(book);
    }
    public void AddMember(Member member){           //method to add member type object to members list
        Members.Add(member);
    }
    public void BorrowBook(int memberId, int bookId){
        Book? foundbook = null;                           //referencing to null
        Member? foundmember = null;                           //referencing to null
        foreach(var i in Books){                           //searching whole books list
            if(i.BookId==bookId){
                foundbook = i;
                break;
            }
        }
        foreach(var i in Members){                           //searching whole members list
            if(i.MemberId==memberId){
                foundmember=i;
                break;
            }
        }
        if(foundbook==null){
            throw new BookNotFoundException();
        }
        if(foundmember==null){
            throw new MemberNotFoundException();
        }
        if(foundbook.AvailableCopies<1){
            throw new NoCopiesAvailableException();
        }
        if(foundmember.BorrowedBooks.Contains(bookId)){
            throw new Exception("Book already borrowed.");
        }
        if(foundmember.BorrowedBooks.Count>=3){
            throw new MaxBorrowedLimitException();
        }
        foundbook.AvailableCopies--;
        foundmember.BorrowedBooks.Add(bookId);
    }
    public void ReturnBook(int memberId, int bookId){
        Book? foundbook = null;
        Member? foundmember = null;
        foreach(var i in Books){
            if(i.BookId==bookId){
                foundbook = i;
                break;
            }
        }
        foreach(var i in Members){
            if(i.MemberId==memberId){
                foundmember=i;
                break;
            }
        }
        if(foundbook==null){
            throw new BookNotFoundException();
        }
        if(foundmember==null){
            throw new MemberNotFoundException();
        }
        if(!foundmember.BorrowedBooks.Contains(bookId)){
            throw new BookNotBorrowedException();
        }
        foundbook.AvailableCopies++;
        foundmember.BorrowedBooks.Remove(bookId);
    }

    public void SearchBookByTitle(string title){
        Book? foundbook=null;
        foreach(var i in Books){
            if(i.Title.Equals(title)){
                foundbook =i;
                break;
            }
        }
        if(foundbook==null){
            throw new BookNotFoundException();
        }
        else{foundbook.DisplayInfo();}
    }

    public void DisplayAllBooks(){
        if (Books.Count==0){
            Console.WriteLine("No data available");
        }
        foreach(var i in Books){
            i.DisplayInfo();
        }
    }

    public void DisplayAllMembers(){
        if(Members.Count==0){
            Console.WriteLine("No data available");
        }
        foreach(var i in Members){
            i.DisplayInfo();
        }
    }

}