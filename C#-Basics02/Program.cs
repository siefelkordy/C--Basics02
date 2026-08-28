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

    }
}


