using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_CodeAlongApp
{
    class Program
    {
        static List<Book> getBookList()
        {
            List<Book> books = new List<Book>();
            books.Add(new Book() { Author = "Ed McBain", Title = "Da Capo", ReleaseYear = 1981 });
            books.Add(new Book() { Author = "Ed McBain", Title = "Sångfågel", ReleaseYear = 1982 });
            books.Add(new Book() { Author = "Patricia Cornwell", Title = "Depraved Heart: A Scarpetta Novel", ReleaseYear = 1991 });
            books.Add(new Book() { Author = "Patricia Cornwell", Title = "Grön död", ReleaseYear = 1985 });
            books.Add(new Book() { Author = "Astrid Lindgren", Title = "Bröderna Lejonhjärta", ReleaseYear = 1965 });
            books.Add(new Book() { Author = "Astrid Lindgren", Title = "Pippi Långstrump på de sju haven", ReleaseYear = 1971 });
            books.Add(new Book() { Author = "J. R. R. Tolkien", Title = "The Fellowship of the Ring", ReleaseYear = 1954 });
            books.Add(new Book() { Author = "J. R. R. Tolkien", Title = "The Two Towers", ReleaseYear = 1955 });
            books.Add(new Book() { Author = "J. R. R. Tolkien", Title = "The Return of the King", ReleaseYear = 1955 });
            return books;
        }
        
        static void Main(string[] args)
        {
            List<Book> books = getBookList();


        }
    }
}
