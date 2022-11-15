using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pets.Domain.Notifications;

namespace Pets.Domain.Validations
{
    //Classe extendida de ContractValidations com as validações do 
    //nosso identificador Guid.
    public partial class ContractValidations<T>
    {
        public ContractValidations<T> IsGuid(object guid, string message, string propertyName)
        {
            if(guid! is Guid)
                AddNotification(new Notification(message, propertyName));

            return this;
        }
        
    }
}