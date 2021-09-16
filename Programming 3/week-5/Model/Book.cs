using System;

namespace Model
{
    public class Book
    {
        private int id;
        public int Id { get { return id; } set { id = value; } }
        public string Author { get; set; }
        public string Title { get; set; }

        public Book(int id, string title, string author)
        {
            this.Id = id;
            this.Title = title;
            this.Author = author;
        }

        public override string ToString()
        {
            return $"'{Title}' by {Author}";
        }
    }
}
