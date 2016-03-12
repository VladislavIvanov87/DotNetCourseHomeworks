﻿namespace LibrarySystem
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class FileOperations
    {
        public const string FilePath = @"C:\Users\Vlado\Desktop\SIPartTwo\LibraryDataBase";

        public static List<Book> ReadBooksFromDataBase()
        {
            var listOfBooks = new List<Book>();
            using (var reader = new StreamReader(FileOperations.FilePath))
            {
                var currentBookLine = reader.ReadLine();

                while (currentBookLine != null)
                {
                    var currentBook = currentBookLine.Split('|');
                    var book = new Book(
                        currentBook[0].Trim(),
                        currentBook[1].Trim(),
                        double.Parse(currentBook[2].Trim()));
                    listOfBooks.Add(book);
                    currentBookLine = reader.ReadLine();
                }
            }
            return listOfBooks;
        }

        public static bool AddBookToDataBase(Book bookToAdd)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(FileOperations.FilePath, true))
                {
                    writer.WriteLine(bookToAdd);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}