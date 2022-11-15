using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pets.Domain.Validations;
using Pets.Domain.Validations.Interfaces;
using Pets.Domain.ValueObjects;

namespace Pets.Domain.Entities.PetContext
{
    public class Pet : BaseEntity, IContract
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
            //Verifica se o tipo informado é do tipo IContract para poder 
            //instanciar as validações.
            //Como retornamos a prórpia extensão é possivel chamarmos métodos 
            //em cima de métodos.
            var contracts = 
            new ContractValidations<Pet>()
            .FirstNameIsValid(this.Name,20,5,"O primeiro nome deve ter entre 4 e 20 caracteres","FirstName")
            .LastNameIsValid(this.Name,20,5,"O último nome deve ter entre 4 e 20 caracteres","LastName");
            
            //Faz um count na lista de notificação e se estiver zerada,
            //retorna true (é valida)
            return contracts.IsValid();
        }
        
    }
}