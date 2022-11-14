using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pets.Domain.Validations.Interfaces;
using Pets.Domain.ValueObjects;

namespace Pets.Domain.Entities.PetContext
{
    public abstract class BaseEntity : IValidations
    {
        protected BaseEntity(Name name)
        {
            Id = Guid.NewGuid();
            Name = name;
            CreatedDate = DateTime.UtcNow;
        }

        //O tipo Guid gera um Hash, um identificador unico
        //Pode substituir o campo do tipo Identity incremental da tabela SQL
        public Guid Id { get; private set; }

        //Propriedade do tipo Name que é um ValueObject 
        //agrupando First e Last Name.
        public Name Name { get; private set; }
        public DateTime CreatedDate { get; private set; }

        //Implementação do Método da Interface Validations
        public abstract bool Validation();
     
    }
}