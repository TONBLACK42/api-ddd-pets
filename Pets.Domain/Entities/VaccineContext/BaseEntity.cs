using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pets.Domain.Notifications;
using Pets.Domain.Validations.Interfaces;

namespace Pets.Domain.Entities.VaccineContext
{
    public abstract class BaseEntity : IValidations
    {
        //Deve receber as notificações de validação para o dominio.
        private List<Notification> _notifications;
        
        protected BaseEntity(string description)
        {
            Id = Guid.NewGuid();
            CreatedDate = DateTime.UtcNow;

        }

        public Guid Id { get; private set; }
        public DateTime CreatedDate { get; private set; }

        //Durante a criação percebi que essa propriedade é comum para 
        //mais de uma Entidade.
        public string Description { get; private set; }


        //Como a Descrição é diferente para cada Contexto onde ela será
        //usada, usei de polimorfismo para que cada contexto tenha sua 
        //implementação.
        public virtual void SetDescription(String description)
        {
            Description = description;
        }

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