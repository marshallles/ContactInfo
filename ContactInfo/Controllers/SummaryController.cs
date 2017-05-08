using System.Data;
using System.Linq;
using System.Web.Mvc;
using ContactInfo.Models;
using System.Collections.Generic;

namespace ContactInfo.Controllers
{
    public class SummaryController : Controller
    {

        private ContactModel db = new ContactModel();

        // GET: Summary
        public ActionResult Index()
        {
            var summary = new Summary();
            summary.NumberOfContacts = db.Contacts.ToList().Count;
            summary.NumberOfComputers = db.Contacts.Sum(x => x.NumberOfComputers).GetValueOrDefault();
            summary.ContactsPerAddressTypeList = GetContactsPerAddressType();
            return View(summary);
        }

        private List<Summary.ContactsPerAddressType> GetContactsPerAddressType()
        {
            return (from a in db.Addresses
                    group a by a.AddressType into g
                    select new Summary.ContactsPerAddressType
                    {
                        AddressType = g.Key,
                        count = g.Count()
                    }).ToList();
        }
    }
}