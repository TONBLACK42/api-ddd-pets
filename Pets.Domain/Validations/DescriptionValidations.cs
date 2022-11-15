using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pets.Domain.Notifications;

namespace Pets.Domain.Validations
{
    //Classe extendida de ContractValidations com as validações da 
    //Propriedade Descrição.
    public partial class ContractValidations<T>
    {
        public ContractValidations<T> DescriptionIsValid(string description, short maxLength, short mimLength, string message, string propertyName)
        {
            if(string.IsNullOrEmpty(description) || (description.Length < mimLength) || (description.Length > maxLength))
                AddNotification(new Notification(message, propertyName));

            return this;
        }
        
    }
}