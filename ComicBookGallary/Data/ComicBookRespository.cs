using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ComicBookGallary.Models;

namespace ComicBookGallary.Data
{
    public class ComicBookRespository
    {
        private static ComicBook[] _comicBooks = new ComicBook[]
        {
            new ComicBook()
            {
                Id = 1,
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists = new Artists[]
                  {
                         new Artists() {Name = "Dan Slott", Role = "Script" },
                         new Artists() {Name = "Pencils", Role = "Humberto Ramos" },
                         new Artists() {Name = "Inks", Role = "Victor Olazaba" },
                         new Artists() {Name = "Colors", Role = "Edgar Delgado" },
                         new Artists() {Name = "Letters", Role = "Chris Eliopoulos" },
                    },

            },
            new ComicBook()
                    {
                    Id = 2,
                    SeriesTitle = "The Amazing Spider-Man",
                    IssueNumber = 657,
                    DescriptionHtml = "<p><strong>FF: THREE TIE-IN.</strong> Spider-Man visits the FF for a very private wake--just for family.</p>",
                    Artists = new Artists[]
                             {
                            new Artists() { Name = "Dan Slott", Role = "Script" },
                            new Artists() { Name = "Marcos Martin", Role = "Pencils" },
                            new Artists() { Name = "Marcos Martin", Role = "Inks" },
                            new Artists() { Name = "Muntsa Vicente", Role = "Colors" },
                            new Artists() { Name = "Joe Caramagna", Role = "Letters" }
                            },
                     Favorite = false
             },
         new ComicBook()
             {
                    Id = 3,
                    SeriesTitle = "Bone",
                    IssueNumber = 50,
                    DescriptionHtml = "<p><strong>The Dungeon & The Parapet, Part 1.</strong> Thorn is discovered by Lord Tarsil and the corrupted Stickeaters and thrown into a dungeon with Fone Bone. As she sleeps, a message comes to her about the mysterious \"Crown of Horns\".</p>",
                    Artists = new Artists[]
                        {
                            new Artists() { Name = "Jeff Smith", Role = "Script" },
                            new Artists() { Name = "Jeff Smith", Role = "Pencils" },
                            new Artists() { Name = "Jeff Smith", Role = "Inks" },
                            new Artists() { Name = "Jeff Smith", Role = "Letters" }
                        },
                        Favorite = false
               }
            };
       
        //Set up a data source for the comic book list page
        //acess the Comic Book arrey ComicBook[]
        public ComicBook[] GetComicBooks()
        {
            //return the above _comic book field
            return _comicBooks;
        }


        public ComicBook GetComicBook(int id)
        {
            ComicBook comicBookToReturn = null;

            foreach (var comicBook in _comicBooks)
            {
                if(comicBook.Id == id)
                {
                    comicBookToReturn = comicBook;
                    break;
                }

            }
            return comicBookToReturn;
        }
    }
}