using ClassLibrary.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// Библиотека
    /// </summary>
    public class Library
    {
        private static Library _instance;
        /// <summary>
        /// Единственный экземпляр класса Библиотека
        /// </summary>
        public static Library Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Library();
                }
                return _instance;
            }
        }

        /// <summary>
        /// Приватный конструктор
        /// </summary>
        private Library()
        {

        }

        /// <summary>
        /// Словарь читателей
        /// </summary>
        private Dictionary<int, Reader> _readers = new Dictionary<int, Reader>();
        /// <summary>
        /// Словарь книг
        /// </summary>
        private Dictionary<int, Book> _books = new Dictionary<int, Book>();
        /// <summary>
        /// Спосок выданных книг
        /// </summary>
        private List<IssuedBook> _issuedBooks = new List<IssuedBook>();

        /// <summary>
        /// Коллекция ситателей
        /// </summary>
        public IEnumerable<Reader> Readers
        {
            get 
            {
                return _readers.Values.AsEnumerable();
            }
        }
        /// <summary>
        /// Коллекция книг
        /// </summary>
        public IEnumerable<Book> Books
        {
            get
            {
                return _books.Values.AsEnumerable();
            }
        }
        /// <summary>
        /// Коллекция выданных книг
        /// </summary>
        public IEnumerable<IssuedBook> IssuedBooks
        {
            get
            {
                return _issuedBooks;
            }
        }

        public event EventHandler ReaderAdded;
        public event EventHandler BookAdded;
        public event EventHandler IssuedBookAdded;
        public event EventHandler ReaderRemoved;
        public event EventHandler BookRemoved;
        public event EventHandler IssuedBookRemoved;

        /// <summary>
        /// Добавление читателя
        /// </summary>
        /// <param name="reader">Информация о читателе</param>
        public void AddReader(Reader reader)
        {
            if (!reader.IsValid)
            {
                throw new InvalidReaderException("Информация о читателе заполнена некорректно");
            }
            try
            {
                _readers.Add(reader.ReaderId, reader);
                //Герерируем событие о том, что читатель добавлен
                ReaderAdded?.Invoke(reader, EventArgs.Empty);
            }
            catch (System.Exception exception)
            {
                throw new InvalidReaderException("При добавлении читателя произошла ошибка", exception);
            }
        }
        /// <summary>
        /// Добавление книги
        /// </summary>
        /// <param name="book">Информация о книге</param>
        public void AddBook(Book book)
        {
            if (!book.IsValid)
            {
                throw new InvalidBookException("Информация о книге заполнена некорректно");
            }
            try
            {
                _books.Add(book.BookId, book);
                //Герерируем событие о том, что книга добавлена
                BookAdded?.Invoke(book, EventArgs.Empty);
            }
            catch (System.Exception exception)
            {
                throw new InvalidBookException("При добавлении книги произошла ошибка", exception);
            }
        }
        /// <summary>
        /// Информация о выданных книгах
        /// </summary>
        /// <param name="issuedBook"></param>
        public void AddIssuedBook(IssuedBook issuedBook)
        {
            if (!issuedBook.IsValid)
            {
                throw new InvalidIssuedBookException("Информация о выданных книгах заполнена некорректно");
            }
            try
            {
                _issuedBooks.Add(issuedBook);
                //Герерируем событие о том, что информация о выданных книгах добавлена
                IssuedBookAdded?.Invoke(issuedBook, EventArgs.Empty);
            }
            catch (System.Exception exception)
            {
                throw new InvalidIssuedBookException("При добавлении выданных книг произошла ошибка", exception);
            }
        }
        /// <summary>
        /// Удалить читателя по идентификатору
        /// </summary>
        /// <param name="readerKey">Идентификатор читателя</param>
        public void RemoveReader(int readerKey)
        {
            _readers.Remove(readerKey);
            //Генерируем событие о том, что читатель удалён
            ReaderRemoved?.Invoke(readerKey, EventArgs.Empty);
            //Получаем список сведений о выданных книгах читателя
            var issuedBookForReader = IssuedBooks.Where(s => s.Reader.ReaderId == readerKey).ToList();
            for (int i = 0; i < issuedBookForReader.Count; i++)
            {
                //Удаляем сведения о выданных книгах читателя
                RemoveIssuedBook(issuedBookForReader[i]);
            }
        }

        /// <summary>
        /// Удалить книгу по идентификатору
        /// </summary>
        /// <param name="bookKey"></param>
        public void RemoveBook(int bookKey)
        {
            _books.Remove(bookKey);
            //Генерируем событие о том, что книга удалена
            BookRemoved?.Invoke(bookKey, EventArgs.Empty);
            
            var issuedBookForBook = IssuedBooks.Where(s => s.Book.BookId == bookKey).ToList();
            for (int i = 0; i < issuedBookForBook.Count; i++)
            {

                RemoveIssuedBook(issuedBookForBook[i]);
            }
        }
        /// <summary>
        /// Удалить информацию о выданных книгах
        /// </summary>
        /// <param name="settlement">Информация о выданных книгах</param>
        public void RemoveIssuedBook(IssuedBook issuedBook)
        {
            _issuedBooks.Remove(issuedBook);
            //Генерируем событие о том, что информация о выданных книгах удалена
            IssuedBookRemoved?.Invoke(issuedBook, EventArgs.Empty);
        }
    }
}
