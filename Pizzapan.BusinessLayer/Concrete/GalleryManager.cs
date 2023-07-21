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
    public class GalleryManager : IGalleryService
    {

        private readonly IGalleryDal _galleryDal;

        public GalleryManager(IGalleryDal galleryDal)
        {
            _galleryDal = galleryDal;
        }

        public void TDelete(Gallery t)
        {
            _galleryDal.Delete(t);
        }

        public Gallery TGetById(int id)
        {
            return _galleryDal.GetById(id);
        }

        public List<Gallery> TGetList()
        {
            return _galleryDal.GetList();
        }

        public void TInsret(Gallery t)
        {
            _galleryDal.Insret(t);
        }

        public void TUpdate(Gallery t)
        {
            _galleryDal.Update(t);
        }
    }
}
