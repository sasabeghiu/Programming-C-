using System;
using System.Collections.Generic;
using DAL;
using Model;

namespace ReservationSystemLogic
{
    public class BookService
    {
        BookDAO bookDAO;
        public BookService()
        {
            bookDAO = new BookDAO();
        }

        public List<Book> GetAll()
        {
            List<Book> books = bookDAO.GetAll();
            return books;
        }

        public Book GetById(int bookId)
        {
            Book book = bookDAO.GetById(bookId);
            return book;
        }

        public List<Book> GetByAuthor(string authorName)
        {
            List<Book> books = bookDAO.GetbyAuthor(authorName);
            return books;
        }
    }
}
