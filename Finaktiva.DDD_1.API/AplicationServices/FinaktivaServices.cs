using Finaktiva.DDD_1.API.Commands;
using Finaktiva.DDD_1.API.Queries;
using Finaktiva.DDD_1.Domain.Entities;
using Finaktiva.DDD_1.Domain.Repositories;
using Finaktiva.DDD_1.Domain.ValueObjects;

namespace Finaktiva.DDD_1.API.AplicationServices
{
    public class FinaktivaServices
    {
        private readonly IPersonRepository repository;
        private readonly PersonQueries personQueries;

        public FinaktivaServices(IPersonRepository repository, PersonQueries personQueries) 
        { 
            this.repository = repository;
            this.personQueries = personQueries;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="createPerson"></param>
        /// <returns></returns>
        public async Task HandleCommand(CreatePersonCommand createPerson)
        {
            var person = new Person(PersonId.Create(createPerson.personId));
            person.SetName(PersonName.Create(createPerson.Name));
            await repository.AddPerson(person);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Person> GetPerson(Guid id)
        {
            return await personQueries.GetPersonByIdAsync(id);
        }
    }
}
