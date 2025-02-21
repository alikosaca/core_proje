using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDal _contactdal;
        public ContactManager(IContactDal contact)
        {
            _contactdal = contact;
        }
        public List<Contact> GetList()
        {
            return _contactdal.GetList();
        }

        public void TAdd(Contact t)
        {
            _contactdal.Insert(t);
        }

        public void TDelete(Contact t)
        {
            _contactdal.Delete(t);
        }

        public Contact TGetBytID(int id)
        {
            return _contactdal.GetByID(id);
        }

        public void TUpdate(Contact t)
        {
            _contactdal.Update(t);
        }
    }
}
