using Panel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Panel.Business.Abstract
{
    public interface IAppService
    {
        void Add(App app);
        void Update(App app);
        void Delete(App app);
        List<App> GetAll(Expression<Func<App, bool>> filter = null);
        App Get(Expression<Func<App, bool>> filter);


    }
}
