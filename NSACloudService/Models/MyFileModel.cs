using System;

namespace NSACloudService.Models
{
    public class MyFileModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }

        public bool Authenticated { get; private set; }

        public void OnFileAuthenticated(object sender, EventArgs e)
        {
            Authenticated = true;
        }
    }
}