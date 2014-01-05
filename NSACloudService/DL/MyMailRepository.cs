using System.Collections.Generic;
using System.Threading;

namespace NSACloudService.DL
{
    public class MyMailRepository
    {
        private static readonly object lockable = new object();

        public IEnumerable<MyMail> GetAll()
        {
            lock (lockable)
            {
                Thread.Sleep(2000);

                return new[]
                {
                    new MyMail {Id = 1, Subject = "Welkom bij Outlook"},
                    new MyMail {Id = 2, Subject = "U wachtwoord"}
                };
            }
        }
    }

    public class MyMail
    {
        public int Id { get; set; }
        public string Subject { get; set; }
    }
}