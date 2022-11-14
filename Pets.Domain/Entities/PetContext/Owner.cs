using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pets.Domain.ValueObjects;

namespace Pets.Domain.Entities.PetContext
{
    public class Owner : BaseEntity
    {
        public Owner(Name name, string email, Document document)
            : base(name)
        {
            Email = email;
            Document = document;
        }

        public string Email { get; private set; }
        
        //Propriedade do tipo Document que é um ValueObject 
        //agrupando Number e Type do Document.
        public Document Document { get; private set; }
        public void SetEmail(string email)
        {
            Email = email;
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