using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pets.Domain.Notifications;
using Pets.Domain.Validations.Interfaces;
using Pets.Domain.ValueObjects;

namespace Pets.Domain.Entities.PetContext
{
    public abstract class BaseEntity : IValidations
    {
        //Deve receber as notificações de validação para o dominio.
        private List<Notification> _notifications;
        protected BaseEntity(Name name)
        {
            Id = Guid.NewGuid();
            Name = name;
            CreatedDate = DateTime.UtcNow;
        }

        //O tipo Guid gera um Hash, um identificador unico
        //Pode substituir o campo do tipo Identity incremental da tabela SQL
        public Guid Id { get; private set; }

        //Propriedade do tipo Name que é um ValueObject 
        //agrupando First e Last Name.
        public Name Name { get; private set; }
        public DateTime CreatedDate { get; private set; }

        //Propriedade Somente Leitura para carregar Notificações.
        public IReadOnlyCollection<Notification> Notifications => _notifications;

        //Método para passar as notificações para nossa lista interna.
        protected void SetNotificationsList(List<Notification> notifications)
        {
            _notifications = notifications;
        }

        //Implementação do Método da Interface Validations
        public abstract bool Validation();
     
    }
}