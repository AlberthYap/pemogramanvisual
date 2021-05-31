using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BENGKEL
{
    public partial class fakturJual : Form
    {
        List<JualDetail> _list;
        jual _jual;

        public fakturJual()
        {
            InitializeComponent();
           
        }


        private void fakturJual_Load(object sender, EventArgs e)
        {
            //faktur.SetDataSource(_list);
            //faktur.SetParameterValue("pKd_jual", _jual.OrderID);
            //faktur.SetParameterValue("pDate", _jual.OrderDate.ToString("MM/dd/yyyy"));
            //faktur.SetParameterValue("pContactName", _jual.ContactName);
            //faktur.SetParameterValue("pPostalCode", _jual.PostalCode);
            //faktur.SetParameterValue("pAddress", _jual.Address);
            //faktur.SetParameterValue("pCity", _jual.City);
            //faktur.SetParameterValue("pPhone", _jual.Phone);
            //crystalReportViewer.ReportSource = faktur;
            //crystalReportViewer.Refresh();
        }
    }
}
