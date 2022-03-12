using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaNote.DataLayer.Repository
{
    public interface IPersonRepository
    {
        bool IsExistByEmailAndUserName(string UserName, string EmailOrMobile, string Password);
        Person GetPersonByUserNameAndEmail(string UserName, string EmailOrMobile );
    }
}
