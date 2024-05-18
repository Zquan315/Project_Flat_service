using Flat_Services_Application.tenant;
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
    public partial class Flat_Management_2 : Form
    {
        public Flat_Management_2()
        {
            InitializeComponent();
        }

        private void Home_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Lessor home_Lessor = new Home_Lessor();
            home_Lessor.StartPosition = FormStartPosition.CenterScreen;
            home_Lessor.Show();
        }

        private void Pay_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment_Lessor payment_Lessor = new Payment_Lessor();
            payment_Lessor.StartPosition = FormStartPosition.CenterScreen;
            payment_Lessor.Show();
        }

        private void Requests_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Requests_Lessor request_Lessor = new Requests_Lessor();
            request_Lessor.StartPosition = FormStartPosition.CenterScreen;
            request_Lessor.Show();
        }

        private void Chat_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Chat_Lessor chat_Lessor = new Chat_Lessor();
            chat_Lessor.StartPosition = FormStartPosition.CenterScreen;
            chat_Lessor.Show();
        }

        private void LogOut_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to log out?", "Log out", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Login l = new Login();
                l.Show();
            }
            else
            {
                this.Show();
            }
        }

        private void Setting_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings_Lessor settings_Lessor = new Settings_Lessor();
            settings_Lessor.StartPosition=FormStartPosition.CenterScreen;
            settings_Lessor.Show();
        }

        private void Services_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Services_Lessor services_Lessor = new Services_Lessor();
            services_Lessor.StartPosition=FormStartPosition.CenterScreen;
            services_Lessor.Show();
        }

        private void btn101_Click(object sender, EventArgs e)
        {
            this.Hide();
            Flat_Info_Lessor flat_Info_Lessor = new Flat_Info_Lessor();
            flat_Info_Lessor.StartPosition=FormStartPosition.CenterScreen;
            flat_Info_Lessor.Show();
        }

        private void btn102_Click(object sender, EventArgs e)
        {
            this.Hide();
            Flat_Info_Lessor flat_Info_Lessor = new Flat_Info_Lessor();
            flat_Info_Lessor.StartPosition = FormStartPosition.CenterScreen;
            flat_Info_Lessor.Show();
        }

        private void btn103_Click(object sender, EventArgs e)
        {
            this.Hide();
            Flat_Info_Lessor flat_Info_Lessor = new Flat_Info_Lessor();
            flat_Info_Lessor.StartPosition = FormStartPosition.CenterScreen;
            flat_Info_Lessor.Show();
        }

        private void btn104_Click(object sender, EventArgs e)
        {
            this.Hide();
            Flat_Info_Lessor flat_Info_Lessor = new Flat_Info_Lessor();
            flat_Info_Lessor.StartPosition = FormStartPosition.CenterScreen;
            flat_Info_Lessor.Show();
        }

        private void btn105_Click(object sender, EventArgs e)
        {
            this.Hide();
            Flat_Info_Lessor flat_Info_Lessor = new Flat_Info_Lessor();
            flat_Info_Lessor.StartPosition = FormStartPosition.CenterScreen;
            flat_Info_Lessor.Show();
        }

        private void btn201_Click(object sender, EventArgs e)
        {
            this.Hide();
            Flat_Info_Lessor flat_Info_Lessor = new Flat_Info_Lessor();
            flat_Info_Lessor.StartPosition = FormStartPosition.CenterScreen;
            flat_Info_Lessor.Show();
        }

        private void btn202_Click(object sender, EventArgs e)
        {
            this.Hide();
            Flat_Info_Lessor flat_Info_Lessor = new Flat_Info_Lessor();
            flat_Info_Lessor.StartPosition = FormStartPosition.CenterScreen;
            flat_Info_Lessor.Show();
        }

        private void btn203_Click(object sender, EventArgs e)
        {
            this.Hide();
            Flat_Info_Lessor flat_Info_Lessor = new Flat_Info_Lessor();
            flat_Info_Lessor.StartPosition = FormStartPosition.CenterScreen;
            flat_Info_Lessor.Show();
        }

        private void btn204_Click(object sender, EventArgs e)
        {
            this.Hide();
            Flat_Info_Lessor flat_Info_Lessor = new Flat_Info_Lessor();
            flat_Info_Lessor.StartPosition = FormStartPosition.CenterScreen;
            flat_Info_Lessor.Show();
        }

        private void btn205_Click(object sender, EventArgs e)
        {
            this.Hide();
            Flat_Info_Lessor flat_Info_Lessor = new Flat_Info_Lessor();
            flat_Info_Lessor.StartPosition = FormStartPosition.CenterScreen;
            flat_Info_Lessor.Show();
        }

        private void btn301_Click(object sender, EventArgs e)
        {
            this.Hide();
            Flat_Info_Lessor flat_Info_Lessor = new Flat_Info_Lessor();
            flat_Info_Lessor.StartPosition = FormStartPosition.CenterScreen;
            flat_Info_Lessor.Show();
        }

        private void btn302_Click(object sender, EventArgs e)
        {
            this.Hide();
            Flat_Info_Lessor flat_Info_Lessor = new Flat_Info_Lessor();
            flat_Info_Lessor.StartPosition = FormStartPosition.CenterScreen;
            flat_Info_Lessor.Show();
        }

        private void btn303_Click(object sender, EventArgs e)
        {
            this.Hide();
            Flat_Info_Lessor flat_Info_Lessor = new Flat_Info_Lessor();
            flat_Info_Lessor.StartPosition = FormStartPosition.CenterScreen;
            flat_Info_Lessor.Show();
        }

        private void btn304_Click(object sender, EventArgs e)
        {
            this.Hide();
            Flat_Info_Lessor flat_Info_Lessor = new Flat_Info_Lessor();
            flat_Info_Lessor.StartPosition = FormStartPosition.CenterScreen;
            flat_Info_Lessor.Show();
        }

        private void btn305_Click(object sender, EventArgs e)
        {
            this.Hide();
            Flat_Info_Lessor flat_Info_Lessor = new Flat_Info_Lessor();
            flat_Info_Lessor.StartPosition = FormStartPosition.CenterScreen;
            flat_Info_Lessor.Show();
        }
    }
}
