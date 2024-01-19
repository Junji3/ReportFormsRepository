using DevExpress.XtraEditors;
using extra_forms.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace extra_forms
{
    public partial class DisplayReportTestForm : DevExpress.XtraEditors.XtraForm
    {
        public DisplayReportTestForm()
        {
            InitializeComponent();

            DisclosureStatement_OfLoanCreditTransaction report1 = new DisclosureStatement_OfLoanCreditTransaction();
            documentViewer1.DocumentSource = report1; 
        }
    }
}