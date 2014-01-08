using System;

namespace NSACloudService.BL
{
    public class FileAuthenticationService
    {
        public void Authenticate()
        {
            if (DomainEvents.Instance.FileAuthenticated != null)
            {
                DomainEvents.Instance.FileAuthenticated(this, new EventArgs());
            }
        }
    }
}