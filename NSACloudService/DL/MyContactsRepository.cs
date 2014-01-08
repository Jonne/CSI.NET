using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace NSACloudService.DL
{
    public class MyContactsRepository
    {
        private static readonly Random random = new Random();

        public IEnumerable<MyContact> GetAll()
        {
            if (random.Next(0, 10) == 5)
            {
                SomeMethodWithInfiniteLoop();
            }

            return new[]
            {
                new MyContact {Id = 1, Name = "Barack Obama", Image = "obama.jpg"},
                new MyContact {Id = 2, Name = "Yolanthe Cabau van Kasbergen", Image = "yolanthe.jpg"},
                new MyContact {Id = 3, Name = "Dennis Doomen", Image = "Dennis.jpg"},
                new MyContact {Id = 4, Name = "Bill Gates", Image = "Bill.jpg"}
            };
        }

        private static void SomeMethodWithInfiniteLoop()
        {
            var watch = new Stopwatch();
            watch.Start();
            while (true)
            {
                // Make the loop go on for "percentage" milliseconds then sleep the 
                // remaining percentage milliseconds. So 40% utilization means work 40ms and sleep 60ms
                if (watch.ElapsedMilliseconds > 40)
                {
                    Thread.Sleep(100 - 40);
                    watch.Reset();
                    watch.Start();
                }
            }
        }
    }
        
    public class MyContact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
    }
}