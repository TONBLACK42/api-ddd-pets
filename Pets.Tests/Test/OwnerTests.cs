using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pets.Domain.Entities.PetContext;
using Pets.Domain.ValueObjects;
using Pets.Domain.Enums;

namespace Pets.Tests.Test
{
    [TestClass]
    public class OwnerTests
    {
        [TestMethod]
        //Verifica se os contratos estão funcionando.
        public void Dado_Um_Nome_Invalido_Deve_Passar()
        {
            //Usando parametros nomeados passar os parametros da classe.
            var owner = new Owner(name: new Name("Ceci","Alves"), email: "cecilia@alves.com", 
            document: new Document("26131144877",EDocumentType.CPF));

            //Aqui chamamos o Método Validadion da classe Owner que verifica 
            //todos os contratos.
            //passamos true pois esse método compara os 2 parametros, então 
            //se for valido irá retornar true também e o teste passará.
            Assert.AreEqual(false,owner.Validation());
        }
        
        [TestMethod]
        public void Dado_Um_Email_Invalido_Deve_Passar()
        {
            var owner = new Owner(name: new Name("Cecilia","Alves"), email: "cecilia@alves.com", 
            document: new Document("26131144877",EDocumentType.CPF));

            Assert.AreEqual(true,owner.Validation());
        }

        [TestMethod]
        public void Dado_Um_Documento_Invalido_Deve_Passar()
        {
            var owner = new Owner(name: new Name("Cecilia","Alves"), email: "cecilia@alves.com", 
            document: new Document("26131144877",EDocumentType.CPF));

            Assert.AreEqual(true,owner.Validation());
        }
        
    }
}