using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace ClassLibrary.Serialization
{
    [Serializable]
    public class LibrarySerializable
    {
        public List<Reader> Readers { get; set; } = new List<Reader>();
        public List<Book> Books { get; set; } = new List<Book>();
        public List<IssuedBookSerializable> IssuedBooks { get; set; } = new List<IssuedBookSerializable>();

        public static void Save(string fileName, SerializeType type)
        {
            var librarySerializable = new LibrarySerializable();
            var library = Library.Instance;
            foreach (var reader in library.Readers)
            {
                librarySerializable.Readers.Add(reader);
            }
            foreach (var book in library.Books)
            {
                librarySerializable.Books.Add(book);
            }
            foreach (var settlement in library.IssuedBooks)
            {
                librarySerializable.IssuedBooks.Add(new IssuedBookSerializable
                {
                    ReaderId = settlement.Reader.ReaderId,
                    BookId = settlement.Book.BookId,
                    IssueDate = settlement.IssueDate,
                    ReturnDate = settlement.ReturnDate
                });
            }
            switch (type)
            {
                case SerializeType.XML:
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(LibrarySerializable));
                    using (StreamWriter xmlStreamWriter = new StreamWriter(fileName))
                    {
                        xmlSerializer.Serialize(xmlStreamWriter, librarySerializable);
                    }
                    break;
                case SerializeType.JSON:
                    using (StreamWriter jsonStreamWriter = File.CreateText(fileName))
                    {
                        JsonSerializer jsonSerializer = new JsonSerializer { Formatting = Formatting.Indented };
                        jsonSerializer.Serialize(jsonStreamWriter, librarySerializable);
                    }
                    break;
                case SerializeType.Binary:
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (FileStream binaryFileStream = new FileStream(fileName, FileMode.OpenOrCreate))
                    {
                        formatter.Serialize(binaryFileStream, librarySerializable);
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }

        public static void Load(string fileName, SerializeType type)
        {
            LibrarySerializable librarySerializable;
            switch (type)
            {
                case SerializeType.XML:
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(LibrarySerializable));
                    StreamReader streamReader = new StreamReader(fileName);
                    librarySerializable = (LibrarySerializable)xmlSerializer.Deserialize(streamReader);
                    break;
                case SerializeType.JSON:
                    StreamReader jsonStreamReader = File.OpenText(fileName);
                    JsonSerializer jsonSerializer = new JsonSerializer();
                    librarySerializable = (LibrarySerializable)jsonSerializer.Deserialize(jsonStreamReader, typeof(LibrarySerializable));
                    break;
                case SerializeType.Binary:
                    BinaryFormatter formatter = new BinaryFormatter();
                    FileStream binaryFileStream = new FileStream(fileName, FileMode.Open);
                    librarySerializable = (LibrarySerializable)formatter.Deserialize(binaryFileStream);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
            var library = Library.Instance;
            var libraryReaders = library.Readers.ToList();
            var libraryBooks = library.Books.ToList();
            var libraryIssuedBooks = library.IssuedBooks.ToList();
            foreach (var libraryReader in libraryReaders)
            {
                library.RemoveReader(libraryReader.ReaderId);
            }
            foreach (var libraryBook in libraryBooks)
            {
                library.RemoveBook(libraryBook.BookId);
            }
            foreach (var libraryIssuedBook in libraryIssuedBooks)
            {
                library.RemoveIssuedBook(libraryIssuedBook);
            }
            var readers = new Dictionary<int, Reader>();
            var books = new Dictionary<int, Book>();
            int maxReaderId = 0;
            int maxBookId = 0;
            foreach (var reader in librarySerializable.Readers)
            {
                if (reader.ReaderId > maxReaderId) maxReaderId = reader.ReaderId;
                readers.Add(reader.ReaderId, reader);
                library.AddReader(reader);
            }
            foreach (var book in librarySerializable.Books)
            {
                if (book.BookId > maxBookId) maxBookId = book.BookId;
                books.Add(book.BookId, book);
                library.AddBook(book);
            }
            foreach (var issuedBook in librarySerializable.IssuedBooks)
            {
                library.AddIssuedBook(new IssuedBook
                {
                    Reader = readers[issuedBook.ReaderId],
                    Book = books[issuedBook.BookId],
                    IssueDate = issuedBook.IssueDate,
                    ReturnDate = issuedBook.ReturnDate
                });
            }
            Reader.NewReaderId = maxReaderId;
            Book.NewBookId = maxBookId;
        }
    }
}