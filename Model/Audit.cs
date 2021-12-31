using System;

namespace Model
{
    public class Audit
    {
        public User User;

        public DateTime Date;

        public EventType Event;
    }

    public enum EventType
    {
        CREATE,
        UPDATE,
        DELETE
    }
}
