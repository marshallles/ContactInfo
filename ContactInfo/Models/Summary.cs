using System.Collections.Generic;
using System.ComponentModel;

namespace ContactInfo.Models
{
    public class Summary
    {
        public class ContactsPerAddressType
        {
            [DisplayName("Address Type")]
            public string AddressType { get; set; }

            [DisplayName("Count")]
            public int count { get; set; }
        }
        [DisplayName("Total Number Of Contacts")]
        public int NumberOfContacts { get; set; }

        [DisplayName("Total Number Of Computers")]
        public int NumberOfComputers { get; set; }

        public ICollection<ContactsPerAddressType> ContactsPerAddressTypeList { get; set; }

    }
}