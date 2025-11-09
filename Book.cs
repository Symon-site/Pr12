using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR12
{
    internal class Book
    {
        private readonly int ISBN;

        public string Author { get; set; }
        public string Title { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine($"Книга: {Title}, Автор: {Author}, ISBN: {ISBN} ");
        }

        public Book(int iSBN, string author, string title)
        {
            this.ISBN = iSBN;
            Author = author;
            Title = title;
        }

        
    }
}
