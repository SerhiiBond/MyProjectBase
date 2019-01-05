using System;
using System.Collections.Generic;
using System.Text;

namespace L01_ex02_Book
{
    class Book
    {
        readonly Author author;
        readonly Content content;
        readonly Title title;
        public Book(string author, string content, string title)
        {
            this.author = new Author(author);
            this.title = new Title(title);
            this.content = new Content (content);
        }
        public void Show()
        {
            author.Show();
            title.Show();
            content.Show();
        }

    }
}
