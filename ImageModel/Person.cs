using System;
using System.Collections;
using System.Collections.Generic;

namespace Model
{
    public class Person
    {

        public long IdPerson;

        public string Name;

        public DateTime BirthDate;

        public IEnumerable<Contact> Contacts;
    }
}
