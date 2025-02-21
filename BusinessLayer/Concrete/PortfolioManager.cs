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
    public class PortfolioManager : IPortfolioService
    {
        IPortfolioDal _portfoliodal;
        public PortfolioManager(IPortfolioDal portfoliodal)
        {
            _portfoliodal = portfoliodal;
        }
        public List<Portfolio> GetList()
        {
            return _portfoliodal.GetList();
        }

        public void TAdd(Portfolio t)
        {
            _portfoliodal.Insert(t);
        }

        public void TDelete(Portfolio t)
        {
            _portfoliodal.Delete(t);
        }

        public Portfolio TGetBytID(int id)
        {
            return _portfoliodal.GetByID(id);
        }

        public void TUpdate(Portfolio t)
        {
            _portfoliodal.Update(t);
        }
    }
}
