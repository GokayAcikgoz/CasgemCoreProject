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
    public class SocialMediaManager : ISocialMediService
    {
        private readonly ISocialMediaDal _socialMedia;

        public SocialMediaManager(ISocialMediaDal socialMedia)
        {
            _socialMedia = socialMedia;
        }

        public void TDelete(SocialMedia t)
        {
            _socialMedia.Delete(t);
        }

        public SocialMedia TGetById(int id)
        {
            return _socialMedia.GetById(id);
        }

        public List<SocialMedia> TGetList()
        {
            return _socialMedia.GetList();
        }

        public void TInsret(SocialMedia t)
        {
            _socialMedia.Insret(t);
        }

        public void TUpdate(SocialMedia t)
        {
            _socialMedia.Update(t);
        }
    }
}
