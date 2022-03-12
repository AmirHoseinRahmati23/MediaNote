using MediaNote.DataLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaNote.DataLayer.Service
{
    public class PersonRepository : IPersonRepository
    {
        private MediaNoteEntities _db;
        public PersonRepository(MediaNoteEntities db)
        {
            _db = db;
        }

        public Person GetPersonByUserNameAndEmail(string UserName, string EmailOrMobile)
        {
            return _db.Person.SingleOrDefault
                (p => p.PersonName == UserName && p.EmailOrMobile == EmailOrMobile);
        }

        public bool IsExistByEmailAndUserName(string UserName, string EmailOrMobile,string Password)
        {
            return _db.Person
                .Any(p => p.PersonName == UserName && p.EmailOrMobile == EmailOrMobile
                && p.Password == Password);
        }
    }
}
