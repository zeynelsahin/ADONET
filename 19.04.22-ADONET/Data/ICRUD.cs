using System.Collections.Generic;

namespace _19._04._22_ADONET.Data
{
    public interface ICRUD<T>
    {
        List<T> GetList();
        T Get(int id);
        void Add(T model);
        void Delete(int id);
        void Update(T model);
    }
}