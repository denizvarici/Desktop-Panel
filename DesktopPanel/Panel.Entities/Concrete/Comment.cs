using Panel.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panel.Entities.Concrete
{
    public class Comment:IEntity
    {
        public int Id { get; set; }
        public string Reply { get; set; }
    }
}
