using System.Collections.Generic;
using System.Threading;

namespace NSACloudService.DL
{
    public class MyPicturesRepository
    {
        private static readonly object lockable = new object();

        public IEnumerable<MyPicture> GetAll()
        {
            lock (lockable)
            {
                return GetDataFromDatabase();
            }
        }

        private static IEnumerable<MyPicture> GetDataFromDatabase()
        {
            Thread.Sleep(2000);

            return new[]
            {
                new MyPicture {Id = 1, Name = "Yes we scan", Url = "/Images/NSA/Scan.jpg"},
                new MyPicture {Id = 2, Name = "Listens", Url = "/Images/NSA/Listens.jpg"},
                new MyPicture {Id = 3, Name = "Joke", Url = "/Images/NSA/Joke.png"},
                new MyPicture {Id = 4, Name = "Privacy", Url = "/Images/NSA/Privacy.jpg"},
                new MyPicture {Id = 5, Name = "Your move", Url = "/Images/NSA/move.jpg"},
            };
        }
    }

    public class MyPicture
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }
}