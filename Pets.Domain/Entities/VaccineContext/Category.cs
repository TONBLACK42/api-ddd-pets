using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pets.Domain.Validations;
using Pets.Domain.Validations.Interfaces;

namespace Pets.Domain.Entities.VaccineContext
{
    public class Category : BaseEntity, IContract
    {
        public Category(string description) : base(description)
        {
        }

        //Método especifico da Entidade Vacina com suas regras de negocio
        //especificas. Sobrescrevendo o Método virtual criado na BaseEntity.
        public override void SetDescription(string description)
        {
            base.SetDescription(description);
        }

        public override bool Validation()
        {
            var contracts = new ContractValidations<Category>()
            .DescriptionIsValid(this.Description, 64, 12, "A descrição deve conter entre 12 e 64 caracteres", "Description");
        
            return contracts.IsValid();
        }
    }
}