using Panel.Business.Abstract;
using Panel.DataAccess.Abstract;
using Panel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Panel.Business.Concrete
{
    public class AppManager : IAppService
    {
        private IAppDal _appDal;

        public AppManager(IAppDal appDal)
        {
            _appDal = appDal;
        }
        public void Add(App app)
        {
            _appDal.Add(app);
        }

        public void Update(App app)
        {
            _appDal.Update(app);
        }

        public void Delete(App app)
        {
            _appDal.Delete(app);
        }

        public List<App> GetAll(Expression<Func<App, bool>> filter = null)
        {
            return _appDal.GetAll(filter);
        }

        public App Get(Expression<Func<App, bool>> filter)
        {
            return _appDal.Get(filter);
        }
    }
}
