using System.Collections.Generic;

namespace NSACloudService.DL
{
    public class MyMailRepository
    {
        public IEnumerable<MyMail> GetAll()
        {
            return new[]
            {
                new MyMail {Id = 1, Subject = "Welkom bij Outlook"},
                new MyMail {Id = 2, Subject = "Uw wachtwoord"}
            };
        }
    }

    public class MyMail
    {
        public int Id { get; set; }
        public string Subject { get; set; }
    }
}