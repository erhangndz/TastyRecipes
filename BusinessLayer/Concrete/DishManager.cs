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
    public class DishManager : IDishService
    {
        private readonly IDishDal _dishDal;

        public DishManager(IDishDal dishDal)
        {
            _dishDal = dishDal;
        }

        public void TDelete(Dish t)
        {
            _dishDal.Delete(t);
        }

        public Dish TGetByID(int id)
        {
           return _dishDal.GetByID(id);
        }

        public List<Dish> TGetList()
        {
            return _dishDal.GetList();
        }

        public void TInsert(Dish t)
        {
           _dishDal.Insert(t);
        }

        public void TUpdate(Dish t)
        {
            _dishDal.Update(t);
        }
    }
}
