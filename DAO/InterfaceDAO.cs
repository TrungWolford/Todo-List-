using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public interface InterfaceDAO<T>
    {
        public void Insert(T t);
        public void Update(T t);
        public void Delete(T t);
    }
}
