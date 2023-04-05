using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientsSite.Data.Repository
{
    public interface IRepository<T> where T : class
    {
        public T Add(T item);
        public List<T> GetAll();
        public T GetById(int id);
        public void Update(T item);
        public void Delete(T item);

    }
}
