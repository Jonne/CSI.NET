using System.Collections.Generic;

namespace NSACloudService.DL
{
    public class MyFileRepository
    {
        public IEnumerable<MyFile> GetAll()
        {
            return new[]
            {
                new MyFile {Id = 1, Name = "Document1.doc"},
                new MyFile {Id = 2, Name = "Document2.doc"},
                new MyFile {Id = 3, Name = "Document3.doc"},
                new MyFile {Id = 4, Name = "Document4.doc"}
            };
        }
    }

    public class MyFile
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}