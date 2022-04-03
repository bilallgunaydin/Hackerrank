using System;

namespace Abstract_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            String title=Console.ReadLine();
            String author=Console.ReadLine();
            int price=Int32.Parse(Console.ReadLine());
            Book new_novel=new MyBook(title,author,price);
            new_novel.display();
        }
    }

    abstract class Book
    {
            
            protected String title;
            protected  String author;
            
            public Book(String t,String a){
                title=t;
                author=a;
            }
            public abstract void display();
    }

class MyBook:Book
{
    public MyBook(string title, string author, int price): base(title,author)
    {
       
        this.price=price;
        
    }
    private int price=0;
    public override void display()
    {
        Console.WriteLine("Title: "+title);
        Console.WriteLine("Author: "+author);
        Console.WriteLine("Price: "+price);
    }
}

    
}
