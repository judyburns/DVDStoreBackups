using DVDStore.DataBase.Models;
using System.Linq;

namespace DVDStore.DBAccess.Models
{
    public class DataAccess 
    {
        // get all DVDs 
        public IQueryable GetAllDVDS()
        {
            using (var context = new DVDDB())
            {
                var result = from d in context.DVDs
                             select new { d.Title, d.Genre, d.TimeLength, d.Language, d.Rating, d.Sold, d.Price };

                // for testing purposes only -begin
                var count = result.Count();
                System.Console.WriteLine("     List of All DVDs: Count = " + count);
                System.Console.WriteLine("");
                foreach (var r in result)
                {
                    System.Console.WriteLine("     " + r.Title + " " + r.Genre + " " + r.TimeLength + " " + r.Language + " " + r.Rating + " " + r.Sold + " " + r.Price);
                    System.Console.WriteLine();
                }
                System.Console.ReadLine();
                // for testing purposes only -end

                return result;

            }
        }

        // get all DVDs by genre
        public IQueryable GetAllDVDByGenre(string genre)
        {
            using (var context = new DVDDB())
            {
                var result = from d in context.DVDs
                             where d.Genre == genre
                             select new { d.Title, d.Genre, d.TimeLength, d.Language, d.Rating, d.Sold, d.Price };

                // for testing purposes only -begin
                var count = result.Count();
                System.Console.WriteLine("     List of All DVDs by Genre: Mystery: Count = " + count);
                System.Console.WriteLine("");
                foreach (var r in result)
                {
                    System.Console.WriteLine("     " + r.Title + " " + r.Genre + " " + r.TimeLength + " " + r.Language + " " + r.Rating + " " + r.Sold + " " + r.Price);
                    System.Console.WriteLine();
                }
                System.Console.ReadLine();
                // for testing purposes only -end

                return result;

            }
        }

        // get all DVDs by rating
        public IQueryable GetAllDVDByRating(string rating)
        {
            using (var context = new DVDDB())
            {
                var result = from d in context.DVDs
                             where d.Rating == rating
                             select new { d.Title, d.Genre, d.TimeLength, d.Language, d.Rating, d.Sold, d.Price};

                // for testing purposes only -begin
                var count = result.Count();
                System.Console.WriteLine("     List of All DVDs By Rating: PG-13: Count = " + count);
                System.Console.WriteLine("");
                foreach (var r in result)
                {
                    System.Console.WriteLine("     " + r.Title + " " + r.Genre + " " + r.TimeLength + " " + r.Language + " " + r.Rating + " " + r.Sold + " " + r.Price);
                    System.Console.WriteLine();
                }
                System.Console.ReadLine();
                // for testing purposes only -end

                return result;
            }
        }

        // get all DVDs by title
        public IQueryable GetAllDVDByTitle(string title)
        {
            using (var context = new DVDDB())
            {
                var result = from d in context.DVDs
                             where d.Title == title
                             select new { d.Title, d.Genre, d.TimeLength, d.Language, d.Rating, d.Sold, d.Price};

                // for testing purposes only -begin
                var count = result.Count();
                System.Console.WriteLine("     List of All DVDs By Title: Rush Hour: Count = " + count);
                System.Console.WriteLine("");
                foreach (var r in result)
                {
                    System.Console.WriteLine("     " + r.Title + " " + r.Genre + " " + r.TimeLength + " " + r.Language + " " + r.Rating + " " + r.Sold + " " + r.Price );
                    System.Console.WriteLine();
                }
                System.Console.ReadLine();
                // for testing purposes only -end

                return result;
            }
        }

        // get all Actors 
        public IQueryable GetAllActors()
        {
            using (var context = new DVDDB())
            {
                var result = from a in context.Actors
                             select a;

                // for testing purposes only -begin
                var count = result.Count();
                System.Console.WriteLine("     List of All Actors: Count = " + count);
                System.Console.WriteLine("");
                foreach (var r in result)
                {
                    System.Console.WriteLine("     " + r.FirstName + " " + r.LastName);
                    System.Console.WriteLine();
                }
                System.Console.ReadLine();
                // for testing purposes only -end

                return result;
            }
        }

        // get all Actors by DVD genre 
        public IQueryable GetAllActorsByDVDGenre(string genre)
        {
            using (var context = new DVDDB())
            {
                var result = (from a in context.Actors
                              from d in a.DVD_Title
                              where d.Genre == genre
                              select new { d.Title, d.Genre, d.TimeLength, d.Language, d.Rating, d.Sold, d.Price, a.FirstName, a.LastName });

                // for testing purposes only -begin
                var count = result.Count();
                System.Console.WriteLine("     List of All Actors By DVD Genre: Action: Count = " + count);
                System.Console.WriteLine("");
                foreach (var r in result)
                {
                    System.Console.WriteLine("     " + r.Title + " " + r.Genre + " " + r.TimeLength + " " + r.Language + " " + r.Rating + " " + r.Sold + " " + r.Price + " " + r.FirstName + " " + r.LastName);
                    System.Console.WriteLine();
                }
                System.Console.ReadLine();
                // for testing purposes only -end

                return result;
            }
        }

        // get all Actors by DVD rating 
        public IQueryable GetAllActorsByDVDRating(string rating)
        {
            using (var context = new DVDDB())
            {
                var result = (from a in context.Actors
                              from d in a.DVD_Title
                              where d.Rating == rating
                              select new { d.Title, d.Genre, d.TimeLength, d.Language, d.Rating, d.Sold, d.Price, a.FirstName, a.LastName });

                // for testing purposes only -begin
                var count = result.Count();
                System.Console.WriteLine("     List of All Actors By DVD Rating: R: Count = " + count);
                System.Console.WriteLine("");
                foreach (var r in result)
                {
                    System.Console.WriteLine("     " + r.Title + " " + r.Genre + " " + r.TimeLength + " " + r.Language + " " + r.Rating + " " + r.Sold + " " + r.Price + " " + r.FirstName + " " + r.LastName);
                    System.Console.WriteLine();
                }
                System.Console.ReadLine();
                // for testing purposes only -end

                return result;
            }
        }

        // get all Actors by DVD title 
        public IQueryable GetAllActorsByDVDTitle(string title)
        {
            using (var context = new DVDDB())
            {
                var result = (from a in context.Actors
                              from d in a.DVD_Title
                              where d.Title == title
                              select new { d.Title, d.Genre, d.TimeLength, d.Language, d.Rating, d.Sold, d.Price, a.FirstName, a.LastName });

                // for testing purposes only -begin
                var count = result.Count();
                System.Console.WriteLine("     List of All Actors By DVD Title: Braveheart: Count = " + count);
                System.Console.WriteLine("");
                foreach (var r in result)
                {
                    System.Console.WriteLine("     " + r.Title + " " + r.Genre + " " + r.TimeLength + " " + r.Language + " " + r.Rating + " " + r.Sold + " " + r.Price + " " + r.FirstName + " " + r.LastName);
                    System.Console.WriteLine();
                }
                System.Console.ReadLine();
                // for testing purposes only -end

                return result;
            }
        }

        // find DVD by id 
        public IQueryable FindDVDByID(int id)
        {
            using (var context = new DVDDB())
            {
                var result = (from d in context.DVDs
                              where d.ID == id
                              select new { d.Title, d.Genre, d.TimeLength, d.Language, d.Rating, d.Sold, d.Price});

                // for testing purposes only -begin
                var count = result.Count();
                System.Console.WriteLine("     DVD By Id: 4: Count = " + count);
                System.Console.WriteLine("");
                foreach (var r in result)
                {
                    System.Console.WriteLine("     " + r.Title + " " + r.Genre + " " + r.TimeLength + " " + r.Language + " " + r.Rating + " " + r.Sold + " " + r.Price);
                    System.Console.WriteLine();
                }
                System.Console.ReadLine();
                // for testing purposes only -end

                return result;
            }
        }

        // find Actor by id 
        public IQueryable FindActorByID(int id)
        {
            using (var context = new DVDDB())
            {
                var result = (from a in context.Actors
                              where a.ID == id
                              select new { a.FirstName, a.LastName });

                // for testing purposes only -begin
                var count = result.Count();
                System.Console.WriteLine("     Actor By Id: 8: Count = " + count);
                System.Console.WriteLine("");
                foreach (var r in result)
                {
                    System.Console.WriteLine("     " + r.FirstName + " " + r.LastName);
                }
                System.Console.ReadLine();
                // for testing purposes only -end

                return result;
            }
        }
    }
}
