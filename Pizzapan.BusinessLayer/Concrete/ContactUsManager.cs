using Pizzapan.BusinessLayer.Abstract;
using Pizzapan.DataAccessLayer.Abstract;
using Pizzapan.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzapan.BusinessLayer.Concrete
{
    public class ContactUsManager : IContactUsService
    {
        private readonly IContactUsDal _contactUsDal;

        public ContactUsManager(IContactUsDal contactUsDal)
        {
            _contactUsDal = contactUsDal;
        }

        public void TDelete(ContactUs t)
        {
            _contactUsDal.Delete(t);
        }

        public ContactUs TGetById(int id)
        {
            return _contactUsDal.GetById(id);
        }

        public List<ContactUs> TGetList()
        {
            return _contactUsDal.GetList();
        }

        public void TInsret(ContactUs t)
        {
            _contactUsDal.Insret(t);
        }

        public void TUpdate(ContactUs t)
        {
            _contactUsDal.Update(t);
        }
    }
}
