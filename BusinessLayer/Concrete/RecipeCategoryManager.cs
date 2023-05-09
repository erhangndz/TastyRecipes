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
    public class RecipeCategoryManager : IRecipeCategoryService
    {
        private readonly IRecipeCategoryDal _recipeCategoryDal;

        public RecipeCategoryManager(IRecipeCategoryDal recipeCategoryDal)
        {
            _recipeCategoryDal = recipeCategoryDal;
        }

        public void TDelete(RecipeCategory t)
        {
           _recipeCategoryDal.Delete(t);
        }

        public RecipeCategory TGetByID(int id)
        {
            return _recipeCategoryDal.GetByID(id);
        }

        public List<RecipeCategory> TGetList()
        {
           return _recipeCategoryDal.GetList();
        }

        public void TInsert(RecipeCategory t)
        {
            _recipeCategoryDal.Insert(t);
        }

        public void TUpdate(RecipeCategory t)
        {
           _recipeCategoryDal.Update(t);
        }
    }
}
