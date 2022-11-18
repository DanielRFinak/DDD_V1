using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finaktiva.DDD_1.Domain.ValueObjects
{
    /// <summary>
    /// record pues los valueObject son inmutables
    /// </summary>
    public record PersonName
    {
        public string Value { get; init; }

        internal PersonName(string value) 
        { 
            this.Value = value;
        }

        public static PersonName Create(string value)
        {
            Validate(value);
            return new PersonName(value); 
        }

        public static void Validate(string value) 
        { 
            if (value == null) 
            { 
                throw new ArgumentNullException("El valor no puede ser nulo");
            }
        }
    }
}
