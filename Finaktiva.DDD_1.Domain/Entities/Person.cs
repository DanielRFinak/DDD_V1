using Finaktiva.DDD_1.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finaktiva.DDD_1.Domain.Entities
{
    public class Person
    {
        /// <summary>
        /// Set no es publico, solo permite tomar valor cada vez que se crea la persona
        /// </summary>
        public Guid Id { get; init; }
        public PersonName Name { get; private set; }
        public Person(Guid id) 
        { 
            this.Id = id;
        }
        public void SetName (PersonName name) 
        { 
            this.Name = name;
        }
    }
}
