using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using accounts_payable.Models;
using accounts_payable.Models.DBGenerated;

namespace accounts_payable.Models.ViewModels
{
    public class VendorInvoiceList
    {


        public Vendor Vendor { get; set; }

        public string InvoiceNumber { get; set; }
        public string VendorAddress1 { get; set; }

        public string Term { get; set; }

        public int SelectedInvoiceID { get; set; }

        public NameGroupFilter NameGroupFilter { get; set; }

        public List<Invoice> Invoices { get; set; }

        public Invoice SelectedInvoice { get; set; }

        public List<InvoiceLineItem> InvoiceLineItems { get; set; }

        public string GetActiveInvoice(int invoiceId)
        {
            return SelectedInvoiceID == invoiceId ? "active" : string.Empty;
        }




    }
}
