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
    public class SocialMediaManager : ISocialMediaService
    {
        ISocialMediaDal _socialmediadal;
        public SocialMediaManager(ISocialMediaDal socialMediaDal)
        {
            _socialmediadal = socialMediaDal;
        }
        public List<SocialMedia> GetList()
        {
            return _socialmediadal.GetList();
        }

        public void TAdd(SocialMedia t)
        {
            _socialmediadal.Insert(t);
        }

        public void TDelete(SocialMedia t)
        {
            _socialmediadal.Delete(t);
        }

        public SocialMedia TGetBytID(int id)
        {
            return _socialmediadal.GetByID(id);
        }

        public void TUpdate(SocialMedia t)
        {
            _socialmediadal.Update(t);
        }
    }
}
