using Realms;
using System.Collections.Generic;
using System.Linq;

namespace RealMDemo.Models
{
    public class RealmConnection
    {
        public Realm realm;
        public RealmConnection()
        {
            realm = Realm.GetInstance();
        }

        public bool InsertDog(Dog data)
        {
            bool isSuccess = false;
            realm.Write(() =>
            {
                realm.Add(data);
            });
            return isSuccess;
        }

        public IQueryable<Dog> SelectDog()
        {
            var data = realm.All<Dog>();
            return data;
        }
    }
}
