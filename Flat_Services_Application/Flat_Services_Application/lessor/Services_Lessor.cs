﻿using Flat_Services_Application.tenant;
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
    public partial class Services_Lessor : Form
    {
        public Services_Lessor()
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

        private void Flat_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Flat_Management_2 flat_Management_2 = new Flat_Management_2();
            flat_Management_2.StartPosition = FormStartPosition.CenterScreen;
            flat_Management_2.Show();
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

        private void Add_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Service_Lessor add_Service_Lessor = new Add_Service_Lessor();
            add_Service_Lessor.StartPosition = FormStartPosition.CenterScreen;
            add_Service_Lessor.Show();
        }

        private void Setting_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings_Lessor settings_Lessor = new Settings_Lessor();
            settings_Lessor.StartPosition=FormStartPosition.CenterScreen;
            settings_Lessor.Show();
        }
    }
}
