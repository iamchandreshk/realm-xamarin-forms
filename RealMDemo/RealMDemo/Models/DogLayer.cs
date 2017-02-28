using Realms;
using System;

namespace RealMDemo.Models
{
    public class Dog : RealmObject
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person Owner { get; set; }
    }

    public class Person : RealmObject
    {
        public string Name { get; set; }
        public DateTimeOffset Created { get; set; }
    }
}
