using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public interface InterfaceDAO<T>
    {
        public int Insert(T t);
        public int Update(T t);
        public int Delete(T t);
        //public List<T> GetAll();
    }
}
