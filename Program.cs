
public class Program
{
    static void Main()
    {
        Menu menu = new Menu();
        Library library = new Library();
        int nextMemberId = 1;
        while (true)
        {
            int choice = menu.menu();
            switch (choice)
            {
                case 1:
                    {
                        try
                        {
                            Console.Write("Enter book id: ");
                            int bid = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter the title: ");
                            string title = Console.ReadLine() ?? "";
                            Console.Write("Enter the name of the author: ");
                            string auth = Console.ReadLine() ?? "";
                            Console.Write("Enter the Total number of copies: ");
                            int tc = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter the number of available copies: ");
                            int ac = Convert.ToInt32(Console.ReadLine());
                            Book book = new Book(bid, title, auth, tc, ac);
                            library.AddBook(book);
                            Console.WriteLine("Added");

                        }
                        catch (Exception ex) { Console.WriteLine(ex.Message); }
                        finally
                        {
                            Console.WriteLine("Transaction attempt completed\n");
                        }
                        break;
                    }
                case 2:
                    {
                        try
                        {
                            Console.Write("Enter the name: ");
                            string name = Console.ReadLine() ?? "";
                            Member member = new Member(nextMemberId, name);
                            library.AddMember(member);
                            nextMemberId++;
                            Console.WriteLine("Member added");
                        }
                        catch (Exception ex) { Console.WriteLine(ex.Message); }
                        finally
                        {
                            Console.WriteLine("Transaction attempt completed\n");
                        }
                        break;
                    }
                case 3:
                    {
                        try
                        {
                            Console.Write("Enter the member's ID: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter the Book's ID: ");
                            int bid = Convert.ToInt32(Console.ReadLine());
                            library.BorrowBook(id, bid);
                            Console.WriteLine("Book borrowed");

                        }
                        catch (BookNotFoundException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        catch (MemberNotFoundException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        catch (NoCopiesAvailableException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        catch (MaxBorrowedLimitException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        finally
                        {
                            Console.WriteLine("Transaction attempt completed\n");
                        }
                        break;
                    }
                case 4:
                    {
                        try
                        {
                            Console.Write("Enter the member's ID: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter the Book's ID: ");
                            int bid = Convert.ToInt32(Console.ReadLine());
                            library.ReturnBook(id, bid);
                            Console.WriteLine("Book returned.");

                        }
                        catch (BookNotFoundException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        catch (BookNotBorrowedException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        catch (MemberNotFoundException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        finally
                        {
                            Console.WriteLine("Transaction attempt completed\n");
                        }
                        break;
                    }
                case 5:
                    {
                        try
                        {
                            Console.Write("Enter the title of the book: ");
                            string title = Console.ReadLine() ?? "";
                            library.SearchBookByTitle(title);
                        }
                        catch (BookNotFoundException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        catch (Exception ex) { Console.WriteLine(ex.Message); }
                        finally
                        {
                            Console.WriteLine("Transaction attempt completed\n");
                        }
                        break;
                    }
                case 6:
                    {
                        try
                        {
                            library.DisplayAllBooks();

                        }
                        catch (Exception ex) { Console.WriteLine(ex.Message); }
                        finally
                        {
                            Console.WriteLine("Transaction attempt completed\n");
                        }
                        break;
                    }
                case 7:
                    {
                        try
                        {
                            library.DisplayAllMembers();

                        }
                        catch (Exception ex) { Console.WriteLine(ex.Message); }
                        finally
                        {
                            Console.WriteLine("Transaction attempt completed\n");
                        }
                        break;
                    }
                case 8:
                    {
                        try
                        {
                            Console.WriteLine("Exiting....");

                        }
                        catch (Exception ex) { Console.WriteLine(ex.Message); }
                        finally
                        {
                            Console.WriteLine("Transaction attempt completed\n");
                        }
                        return;
                    }
            }
        }
    }
}