using System;
using System.Collections.Generic;
using System.Text;

namespace HomeLibrary
{
    class LibraryItem 
    {

        public string Title;
        public string Author;
        public int YearOfPublication;
        public string Cathegory;
        public string Serie;
        public string Status;

        public class Book: LibraryItem  
        {
            public string typeOfCover; // hard, soft
            public string ISBN;





            public void SetBook(string SetTitle, string SetAuthor, int SetYearOfPublication, string SetCathegory,
          string SetSerie, string SetStatus, string SettypeOfCover, string SetISBN)
            {
                Title = SetTitle;
                Author = SetAuthor;
                YearOfPublication = SetYearOfPublication;
                Cathegory = SetCathegory;
                Serie = SetSerie;
                Status = SetStatus;
                typeOfCover = SettypeOfCover;
                ISBN = SetISBN;




            }



        public Book GetSample() // Sample values for book.
        {
            Book SampleBook = new Book();
            SampleBook.Title = "Solaris";
            SampleBook.Author = "Lem";
            SampleBook.YearOfPublication = 2010;
            SampleBook.Cathegory = "SF";
            SampleBook.Serie = "SF Library";
            SampleBook.Status = "AtHome";
            SampleBook.typeOfCover = "Hard";
            SampleBook.ISBN = "ISBN 123456789";
            return SampleBook;

        }


        }


        public class Music : LibraryItem
        {
            public string storageType; // CD, vinyl, etc.
           

        }



      





    }
}
