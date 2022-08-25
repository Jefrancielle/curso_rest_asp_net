using Rest_API_With_ASP_NET.Model;
using Rest_API_With_ASP_NET.Model.Base;
using System.Collections.Generic;

namespace Rest_API_With_ASP_NET.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create(T item);
        T FindByID(long id);
        List<T> FindAll();
        T Update(T item);
        void Delete(long id);
        bool Exists(long id);
    }
}
