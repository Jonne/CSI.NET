using System;

namespace NSACloudService.BL
{
    public sealed class DomainEvents
    {
        private static readonly DomainEvents instance = new DomainEvents();

        private DomainEvents() { }

        public static DomainEvents Instance
        {
            get { return instance; }
        }

        public EventHandler<EventArgs> FileAuthenticated;
    }
}