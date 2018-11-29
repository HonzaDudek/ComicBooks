using ComicBookGallery.Models;

namespace ComicBookGallery.Repositories
{
    public class ComicBookRepository
    {
        private static ComicBook[] _comicBooks =
        {
            new ComicBook
            {
                Id = 1,
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHTML = "<p>Final issue!Witness the final hours of Doctor Octopus' life and his one, " +
                                  "last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists = new[]
                {
                    new Artist("Script", "Dan Slott"),
                    new Artist("Pencils", "Humberto Ramos"),
                    new Artist("Inks", "Victor Olazaba"),
                    new Artist("Colors", "Edgar Delgado"),
                    new Artist("Letters", "Chris Eliopoulos")
                }
            },
            new ComicBook
            {
                Id = 2,
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 657,
                DescriptionHTML =
                    "<p><strong>FF: THREE TIE-IN.</strong> Spider-Man visits the FF for a very private wake--just for family.</p>",
                Artists = new[]
                {
                    new Artist("Script", "Dan Slott"),
                    new Artist("Pencils", "Marcos Martin"),
                    new Artist("Inks", "Marcos Martin"),
                    new Artist("Colors", "Muntsa Vicente"),
                    new Artist("Letters", "Joe Caramagna")
                },
                Favorite = false
            },
            new ComicBook
            {
                Id = 3,
                SeriesTitle = "Bone",
                IssueNumber = 50,
                DescriptionHTML =
                    "<p><strong>The Dungeon & The Parapet, Part 1.</strong> Thorn is discovered by Lord Tarsil and " +
                    "the corrupted Stickeaters and thrown into a dungeon with Fone Bone. As she sleeps, a message comes to her about the mysterious " +
                    "\"Crown of Horns\".</p>",
                Artists = new[]
                {
                    new Artist("Script", "Jeff Smith"),
                    new Artist("Pencils", "Jeff Smith"),
                    new Artist("Inks", "Jeff Smith"),
                    new Artist("Letters", "Jeff Smith")
                },
                Favorite = false
            }
        };

        public ComicBook getComicBook(int Id)
        {
            if (Id < _comicBooks.Length)
            {
                return _comicBooks[Id];
            }
            else
            {
                return null;
            }
        }
    }
}