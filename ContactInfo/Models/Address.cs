namespace ContactInfo.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel;

    public partial class Address
    {
        public int AddressID { get; set; }

        public int ContactID { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Address Type")]
        public string AddressType { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Address Line 1")]
        public string AddressLine1 { get; set; }

        [StringLength(50)]
        [DisplayName("Address Line 2")]
        public string AddressLine2 { get; set; }

        [Required]
        [StringLength(50)]
        public string City { get; set; }

        [Required]
        [StringLength(2)]
        [DisplayName("State Code")]
        public string StateCode { get; set; }

        public int? Zip { get; set; }

        public virtual Contact Contact { get; set; }
    }
}
