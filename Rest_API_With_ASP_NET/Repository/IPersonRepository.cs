using Rest_API_With_ASP_NET.Model;
using System.Collections.Generic;


namespace Rest_API_With_ASP_NET.Repository
{
    public interface IPersonRepository : IRepository<Person>
    {
        Person Disable(long id);

        List<Person> FindByName(string firstName, string secondName);

    }
}
