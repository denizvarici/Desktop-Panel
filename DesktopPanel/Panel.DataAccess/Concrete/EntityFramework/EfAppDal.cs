using Panel.DataAccess.Abstract;
using Panel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panel.DataAccess.Concrete.EntityFramework
{
    public class EfAppDal:EfEntityRepositoryBase<App,PanelContext>,IAppDal
    {
    }
}
