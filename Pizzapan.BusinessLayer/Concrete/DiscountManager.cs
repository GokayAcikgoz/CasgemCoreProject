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
    public class DiscountManager : IDiscountService
    {
        private readonly IDiscountDal _discountDal;

        public DiscountManager(IDiscountDal discountDal)
        {
            _discountDal = discountDal;
        }

        public void TDelete(Discount t)
        {
            throw new NotImplementedException();
        }

        public Discount TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Discount> TGetList()
        {
            return _discountDal.GetList();  
        }

        public void TInsret(Discount t)
        {
            _discountDal.Insret(t);
        }

        public void TUpdate(Discount t)
        {
            throw new NotImplementedException();
        }
    }
}
