using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pets.Domain.Validations;
using Pets.Domain.Validations.Interfaces;

namespace Pets.Domain.Entities.VaccineContext
{
    public class Vaccine : BaseEntity, IContract
    {
        public Vaccine(string description, Guid categoryId, Guid petId)
            : base(description)
        {
            CategoryId = categoryId;
            PetId = petId;
        }

        //Guarda o ID da Categoria em que essa vacina esta inclusa.
        //Essa informação é obrigatória, por isso deve ser passada como 
        //parametro.
        public Guid CategoryId { get; private set; }

        //Guarda o ID do Pet em que a vacina esta sendo aplicada.
        //Essa informação é obrigatória, por isso deve ser passada como 
        //parametro.
        public Guid PetId { get; private set; }

        //Método especifico da Entidade Vacina com suas regras de negocio
        //especificas. Sobrescrevendo o Método virtual criado na BaseEntity.
         public override void SetDescription(string description)
        {
            base.SetDescription(description);
        }

        //Valida as propriedades de Vaccine.
        public override bool Validation()
        {
            var contracts = new ContractValidations<Vaccine>()
            .DescriptionIsValid(this.Description, 32, 10, "A descrição deve conter entre 10 e 32 caracteres", "Description")
            .IsGuid(this.CategoryId,"O Id da Categoria deve ser um guid válido.", "CategoryId")
            .IsGuid(this.PetId,"O Id do Pet deve ser um guid válido.", "PetId");
        
            return contracts.IsValid();



        }
    }
}