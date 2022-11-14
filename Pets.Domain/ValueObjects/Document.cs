using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pets.Domain.Enums;

namespace Pets.Domain.ValueObjects
{
    public struct Document
    {
        public Document(string documentNumber, EDocumentType documentType)
        {
            DocumentNumber = documentNumber;
            DocumentType = documentType;
        }

        public string DocumentNumber { get; private set; }

        //Usa o tipo EDocumentType que é o Enum criado para tipo de documento.
        public EDocumentType DocumentType { get; private set; }
        
    }
}