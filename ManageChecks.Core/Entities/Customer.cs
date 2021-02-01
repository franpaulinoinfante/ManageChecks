using System;
using System.Collections.Generic;
using System.Text;

namespace ManageChecks.Core.Entities
{
    public class Customer : BaseEntity<int>
    {
        public Customer(int id, int customerId, int documentTypeId, string documentCode, string firstName, string lastName, string gender, DateTime dateBorn, string cID, string country, string city, string sector, string address) : base(id)
        {
            CustomerId = customerId;
            DocumentTypeId = documentTypeId;
            DocumentCode = documentCode;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            DateBorn = dateBorn;
            CID = cID;
            Country = country;
            City = city;
            Sector = sector;
            Address = address;
        }

        public int CustomerId { get; private set; }
        public int DocumentTypeId { get; private set; }
        public string DocumentCode { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Gender { get; private set; }
        public DateTime DateBorn { get; private set; }
        public string CID { get; private set; }
        public string Country { get; private set; }
        public string City { get; private set; }
        public string Sector { get; private set; }
        public string Address { get; private set; }

        public DocumentType DocumentType { get; private set; }

        public void SetDocumentType(DocumentType documentType)
        {
            if (documentType == null)
            {
                string error = "error";
                return;
            }
            DocumentType = documentType;
        }

    }
}
