using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pets.Domain.Notifications;
using Pets.Domain.ValueObjects;

namespace Pets.Domain.Validations
{
    //Classe extendida de ContractValidations com as validações da 
    //Propriedade Nome
    public partial class ContractValidations<T>
    {
        public ContractValidations<T> FirstNameIsValid(Name name, short maxLength, short mimLength, string message, string propertyName)
        {
            if(string.IsNullOrEmpty(name.FirstName) || (name.FirstName.Length < mimLength) || (name.FirstName.Length > maxLength))
                AddNotification(new Notification(message, propertyName));

            return this;
        }

         public ContractValidations<T> LastNameIsValid(Name name, short maxLength, short mimLength, string message, string propertyName)
        {
            if(string.IsNullOrEmpty(name.LastName) || (name.LastName.Length < mimLength) || (name.LastName.Length > maxLength))
                AddNotification(new Notification(message, propertyName));

            return this;
        }
    }
}