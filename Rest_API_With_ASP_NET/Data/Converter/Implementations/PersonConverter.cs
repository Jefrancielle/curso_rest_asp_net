﻿using Rest_API_With_ASP_NET.Data.Converter.Contract;
using Rest_API_With_ASP_NET.Data.VO;
using Rest_API_With_ASP_NET.Model;
using System.Collections.Generic;
using System.Linq;

namespace Rest_API_With_ASP_NET.Data.Converter.Implementations
{
    public class PersonConverter : IParser<PersonVO, Person>, IParser<Person, PersonVO>
    {
        public Person Parse(PersonVO origin)
        {
            if (origin == null) return null;
            return new Person
            {
                Id = origin.Id,
                FirstName = origin.FirstName,
                LastName = origin.LastName,
                Address = origin.Address,
                Gender = origin.Gender
            };

        }

        public PersonVO Parse(Person origin)
        {
            if (origin == null) return null;
            return new PersonVO
            {
                Id = origin.Id,
                FirstName = origin.FirstName,
                LastName = origin.LastName,
                Address = origin.Address,
                Gender = origin.Gender
            };
        }

        public List<Person> Parse(List<PersonVO> origin)
        {
            {
                if (origin == null) return null;
                return origin.Select(item => Parse(item)).ToList();
            }
        }

       public List<PersonVO> Parse(List<Person> origin)
       {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
       }

    }
}