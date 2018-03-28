using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVDStore.DBAccess.Models;

namespace DVDStore.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // get and find methods
            GetAllDVDS();
            GetAllActors();
            GetDVDGenre("Mystery");
            GetDVDRating("PG-13");
            GetDVDTitle("Rush Hour");
            GetAllActorsByDVDGenre("action");
            GetAllActorsByDVDRating("R");
            GetAllActorsByDVDTitle("Braveheart");
            FindDVDByID(4);
            FindActorByID(8);
        }

        public static void GetAllDVDS()
        {
            DataAccess db = new DataAccess();
            var result = db.GetAllDVDS();
        }

        public static void GetAllActors()
        {
            DataAccess db = new DataAccess();
            var result = db.GetAllActors();
        }

        public static void GetDVDGenre(string input)
        {
            DataAccess db = new DataAccess();
            var result = db.GetAllDVDByGenre(input);
        }

        public static void GetDVDRating(string input)
        {
            DataAccess db = new DataAccess();
            var result = db.GetAllDVDByRating(input);
        }

        public static void GetDVDTitle(string input)
        {
            DataAccess db = new DataAccess();
            var result = db.GetAllDVDByTitle(input);
        }

        public static void GetAllActorsByDVDGenre(string input)
        {
            DataAccess db = new DataAccess();
            var result = db.GetAllActorsByDVDGenre(input);
        }

        public static void GetAllActorsByDVDRating(string input)
        {
            DataAccess db = new DataAccess();
            var result = db.GetAllActorsByDVDRating(input);
        }

        public static void GetAllActorsByDVDTitle(string input)
        {
            DataAccess db = new DataAccess();
            var result = db.GetAllActorsByDVDTitle(input);
        }

        public static void FindDVDByID(int input)
        {
            DataAccess db = new DataAccess();
            var result = db.FindDVDByID(input);
        }

        public static void FindActorByID(int input)
        {
            DataAccess db = new DataAccess();
            var result = db.FindActorByID(input);
        }
    }
}
