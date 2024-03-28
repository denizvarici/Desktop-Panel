using Panel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Panel.Business.Abstract
{
    public interface ICommentService
    {
        void Add(Comment comment);
        void Update(Comment comment);
        void Delete(Comment comment);
        List<Comment> GetAll(Expression<Func<Comment, bool>> filter = null);
        Comment Get(Expression<Func<Comment, bool>> filter);

    }
}
