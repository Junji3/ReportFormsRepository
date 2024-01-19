using DevExpress.Pdf.Native;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace extra_forms
{
    public partial class CustomersSlipReport : DevExpress.XtraReports.UI.XtraReport
    {
        Dictionary<XRLabel, string> XRLabelDictionary = new Dictionary<XRLabel, string>();

        public CustomersSlipReport()
        {
            InitializeComponent();

            InitXRLabel();
            DisplayXRLabel();
        }

        private void InitXRLabel()
        {
            XRLabelDictionary.Add(CustomerNamePlaceholder, "Lius Paul");
            XRLabelDictionary.Add(CustomerAddressPlaceholder, "Cebu");
            XRLabelDictionary.Add(UnitTypePlaceholder, "TVS Tri Wheeler");
            XRLabelDictionary.Add(ModelPlaceholder, "King Deluxe W/ Door");
            XRLabelDictionary.Add(DownpaymentPlaceHolder, "12,000");
            XRLabelDictionary.Add(AmmortizationPlaceholder, "7,870");
            XRLabelDictionary.Add(TermPlaceholder, "36");
            XRLabelDictionary.Add(ORPlaceholder, "CR-0092");
            XRLabelDictionary.Add(DatePlaceholder, "5-25-22");
            XRLabelDictionary.Add(CashierNamePlaceholder, "Jamizef Pitos");
        }

        private void DisplayXRLabel()
        {
            foreach (KeyValuePair<XRLabel, string> kvp in XRLabelDictionary) 
            {
                kvp.Key.Text = kvp.Value;
            }
        }
    }
}
