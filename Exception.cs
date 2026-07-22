

class BookNotFoundException: Exception{
    public BookNotFoundException():
    base("Book not found")
    {
    }
}

class NoCopiesAvailableException: Exception {
    public NoCopiesAvailableException(): base("No copies found")
    {
    }
}

class BookNotBorrowedException: Exception{
    public BookNotBorrowedException(): base("Book is not borrowed")
    {
    }
}

class MaxBorrowedLimitException: Exception{
    public MaxBorrowedLimitException(): base ("Max limit of borrowing reached")
    {}
}

class InvalidInputException: Exception{
    public InvalidInputException(): base ("Non-integer value is entered")
    {}
}

class MemberNotFoundException: Exception{
    public MemberNotFoundException(): base("Member is not found"){}
}