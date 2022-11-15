using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Pets.Domain.Notifications;

namespace Pets.Domain.Validations
{
    //Classe extendida de ContractValidations com as validações da 
    //Propriedade Email
    public partial class ContractValidations<T>
    {
        public ContractValidations<T> EmailIsValid(string email, string message, string propertyName)
        {
             string emailPattern = string.Format("{0}{1}",
                @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))",
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$");
            
            if(string.IsNullOrEmpty(email) || !Regex.IsMatch(email,emailPattern))
                AddNotification(new Notification(message, propertyName));

            return this;
        }
    }
}