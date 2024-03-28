using Panel.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panel.Entities.Concrete
{
    public class App:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string FileExtension { get; set; }
        public int CategoryId { get; set; }

        //public Category Category { get; set; }

    }
}
