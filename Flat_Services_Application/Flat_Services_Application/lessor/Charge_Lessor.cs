using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flat_Services_Application.lessor
{
    public partial class Charge_Lessor : Form
    {
        public Charge_Lessor()
        {
            InitializeComponent();
        }
        string sdt;
        public Charge_Lessor(string sdt)
        {
            InitializeComponent();
            this.sdt = sdt;
        }
        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Charge_Lessor_Load(object sender, EventArgs e)
        {

        }
    }
}
