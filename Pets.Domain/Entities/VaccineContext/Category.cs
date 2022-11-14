using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pets.Domain.Entities.VaccineContext
{
    public class Category : BaseEntity
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
    }
}