

using ConsoleApp5.Models;
using System.Xml.Linq;

Console.WriteLine();



Book[] Books = new Book[10];
for(int i = 0; i < Books.Length; i++)
{

    Console.WriteLine("Enter the Name:");
    string Name = Console.ReadLine();
    Console.WriteLine("Enter the PageCount:");
    int page = int.Parse(Console.ReadLine());

    while (!CheckName(Name))
    {
        Console.WriteLine("Enter correct name");
        Name= Console.ReadLine();
    }
    while (!CheckName(page))
    {
        Console.WriteLine("Enter correct pagecount");
        int Page = int.Parse(Console.ReadLine());
    }
    while (Search(Name, PageCount))
    {
        Console.WriteLine("This book is already exsists  ");
        Console.WriteLine("Enter the correct name");
        Name = Console.ReadLine();
        Console.WriteLine("Enter the correct page count");
        PageCount = int.Parse(Console.ReadLine());
    }

    Book book = new Book(Name,page);
    Books[i] = book;


    bool CheckName(string name)
    {
        if (!string.IsNullOrWhiteSpace(name) && name.Length > 10) ;
        return true;

        return false;
    }



    bool CheckName(int pageCount)
    {
        if(pageCount > 10)
            return true;

        return false;
    }
}

bool CheckName(int page)
{
    throw new NotImplementedException();
}

bool Search(object bookName)
{
    throw new NotImplementedException();
}

foreach (Book book in Books)
{
 Console.WriteLine($"Name : {book.Name}  pageCount :{book.PageCount}");
}