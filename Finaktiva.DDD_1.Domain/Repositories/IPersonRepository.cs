using Finaktiva.DDD_1.Domain.Entities;
using Finaktiva.DDD_1.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finaktiva.DDD_1.Domain.Repositories
{
    public interface IPersonRepository
    {
        Task<Person> GetPersonById(PersonId Id);
        Task AddPerson(Person person);
    }
}
