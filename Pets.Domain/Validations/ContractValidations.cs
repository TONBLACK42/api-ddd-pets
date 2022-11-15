using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pets.Domain.Notifications;
using Pets.Domain.Validations.Interfaces;

namespace Pets.Domain.Validations
{
    //Só extende a Interface se o tipo for compativel com o tipo validado 
    //na claussula where ou seja igual a IContract
    public partial class ContractValidations <T> where T: IContract
    {
        //Cria uma lista de notificaões interna.
        private List<Notification> _notifications;

        //Construtor onde nossa lista de notificações interna é populada.
        public ContractValidations()
        {
            _notifications = new List<Notification>();
        }

        //Cria uma lista de notificações externa somente leitura 
        //para que ninguem alem dos contratos possam alterar.
        public IReadOnlyCollection<Notification> Notifications => _notifications;
  
        //Método para adicionar uma notificação. Recebemos uma notificação
        //e passamos para a lista interna.
        public void AddNotification(Notification notification)
        {
            _notifications.Add(notification);
        }

        //Metodo que verifica se houve alguma notificação.
        //Se houve alguma quebra de contrato.
        public bool IsValid()
        {
            return (_notifications.Count ==0 ? true : false);
        }
    }
}