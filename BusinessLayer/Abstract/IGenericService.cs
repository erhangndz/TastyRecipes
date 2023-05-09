using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        public void TUpdate(T t);
        public void TDelete(T t);
        public void TInsert(T t);
        public T TGetByID(int id);
        public List<T> TGetList();
    }
}
