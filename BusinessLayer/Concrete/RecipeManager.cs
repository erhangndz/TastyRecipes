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
    public class RecipeManager : IRecipeService
    {
        private readonly IRecipeDal _recipeDal;

        public RecipeManager(IRecipeDal recipeDal)
        {
            _recipeDal = recipeDal;
        }

        public void TDelete(Recipe t)
        {
            _recipeDal.Delete(t);
        }

        public Recipe TGetByID(int id)
        {
            return _recipeDal.GetByID(id);
        }

        public List<Recipe> TGetList()
        {
            return _recipeDal.GetList();
        }

        public List<Recipe> TGetRecipewithCategory()
        {
            return _recipeDal.GetRecipewithCategory();
        }

        public void TInsert(Recipe t)
        {
            _recipeDal.Insert(t);   
        }

        public void TUpdate(Recipe t)
        {
            _recipeDal.Update(t);
        }
    }
}
