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
    public class BlogCategoryManager : IBlogCategoryService
    {
        private readonly IBlogCategoryDal _blogcategoryDal;

        public BlogCategoryManager(IBlogCategoryDal blogcategoryDal)
        {
            _blogcategoryDal = blogcategoryDal;
        }

        public void TDelete(BlogCategory t)
        {
            _blogcategoryDal.Delete(t);
        }

        public BlogCategory TGetByID(int id)
        {
           return _blogcategoryDal.GetByID(id);
        }

        public List<BlogCategory> TGetList()
        {
            return _blogcategoryDal.GetList();
        }

        public void TInsert(BlogCategory t)
        {
            _blogcategoryDal.Insert(t);
        }

        public void TUpdate(BlogCategory t)
        {
            _blogcategoryDal.Update(t);
        }
    }
}
