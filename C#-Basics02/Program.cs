class Book
{ 
    public string title;
    public int pages;
}

class Program
{
    static void Main()
    {
        //Answer to question 1
        Book book1 = new Book();
        object obj = book1;
        ((Book)obj).title = "C# Basics";
        ((Book)obj).pages = 200;
        Console.WriteLine($"Title: {((Book)obj).title}, Pages: {((Book)obj).pages}");
        //Answer to question 2
        Console.WriteLine(book1.ToString());
        Console.WriteLine(book1.Equals(obj));
        Console.WriteLine(book1.GetHashCode());
        Console.WriteLine(book1.GetType());
        //Answer to question 3
        //int pages= "300"; compiler-runtime error
        //solution is to change the type of pages to int and assign a valid integer value
        int pages = 300;
        //Answer to question 4
        try
        {
            int num1 = 0;
            int num2 = 10;
            int result = num2 / num1; // This will throw a DivideByZeroException

        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");

        }
        finally
        {
            Console.WriteLine("Done");
        }
    }
    }


