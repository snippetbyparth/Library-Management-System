public class Menu
{
    public int menu()
    {
        Console.WriteLine("\n===================LIBRARY MANAGEMENT SYSTEM===================");
        Console.WriteLine("1. Add New Book");
        Console.WriteLine("2. Add New Member");
        Console.WriteLine("3. Borrow Book");
        Console.WriteLine("4. Return Book");
        Console.WriteLine("5. Search Book by Title");
        Console.WriteLine("6. Display All Books");
        Console.WriteLine("7. Display All Members");
        Console.WriteLine("8. Exit");
        Console.Write("Enter your choice: ");
        int choice = 0;
        try { choice = Convert.ToInt32(Console.ReadLine()); }
        catch (InvalidInputException) { }
        return choice;
    }
}