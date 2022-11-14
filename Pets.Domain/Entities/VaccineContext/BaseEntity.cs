using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pets.Domain.Entities.VaccineContext
{
    public abstract class BaseEntity
    {
        protected BaseEntity(string description)
        {
            Id = Guid.NewGuid();
            CreatedDate = DateTime.UtcNow;

        }

        public Guid Id { get; private set; }
        public DateTime CreatedDate { get; private set; }

        //Durante a criação percebi que essa propriedade é comum para 
        //mais de uma Entidade.
        public string Description { get; private set; }


        //Como a Descrição é diferente para cada Contexto onde ela será
        //usada, usei de polimorfismo para que cada contexto tenha sua 
        //implementação.
        public virtual void SetDescription(String description)
        {
            Description = description;
        }
    }
}