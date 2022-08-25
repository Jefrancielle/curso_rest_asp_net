using Rest_API_With_ASP_NET.Data.VO;
using System.Collections.Generic;

namespace Rest_API_With_ASP_NET.Business
{
    public interface IPersonBusiness
    {
        PersonVO Create(PersonVO person);
        PersonVO FindByID(long id);
        List<PersonVO> FindAll();
        PersonVO Update(PersonVO person);
        void Delete(long id);
    }
}
