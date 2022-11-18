using Finaktiva.DDD_1.Domain.Entities;
using Finaktiva.DDD_1.Domain.Repositories;
using Finaktiva.DDD_1.Domain.ValueObjects;

namespace Finaktiva.DDD_1.API.Queries
{
    public class PersonQueries
    {
        private readonly IPersonRepository personRepository;

        public PersonQueries(IPersonRepository personRepository) 
        { 
            this.personRepository = personRepository;
        }

        public async Task<Person> GetPersonByIdAsync(Guid id)
        {
            var reponse = await personRepository.GetPersonById(PersonId.Create(id));
            return reponse;
        }
    }
}
