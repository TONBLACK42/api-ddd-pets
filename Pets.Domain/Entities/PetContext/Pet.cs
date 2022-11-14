using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pets.Domain.ValueObjects;

namespace Pets.Domain.Entities.PetContext
{
    public class Pet : BaseEntity
    {
        public Pet(Name name, int identifier)
            : base(name)
        {
            Identifier = identifier;
        }

        public int Identifier { get; private set; }

        public void SetIdentifier(int identifier)
        {
            Identifier = identifier;
        }

        //Implementação Concreta do Método Validation que vem da BaseEntity
        //Que por sua vez Implementa a Interface de Validação onde há o
        //Contrato para o Método.
        public override bool Validation()
        {
            if(string.IsNullOrEmpty(this.Name.FirstName))
                return false;

             if(string.IsNullOrEmpty(this.Name.LastName))
                return false;

            return true;
        }
        
    }
}