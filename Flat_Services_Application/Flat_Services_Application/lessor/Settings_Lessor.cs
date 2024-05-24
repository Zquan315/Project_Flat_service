﻿using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
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
    public partial class Settings_Lessor : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "KR5gPtgHXbYV0t9jMOeKDN3UvRaXulbgAD4aijeN",
            BasePath = "https://account-ac0cc-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        public Settings_Lessor()
        {
            InitializeComponent();
        }
        string sdt;
        public Settings_Lessor(string sdt)
        {
            InitializeComponent();
            this.sdt = sdt;
        }

        private void Home_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Lessor home = new Home_Lessor(sdt);
            home.StartPosition = FormStartPosition.CenterScreen;
            home.Show();
        }

        private void tbChangePass_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePass c = new ChangePass();
            c.Show();
        }

        private void Flat_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Flat_Management_2 flat_Management_2 = new Flat_Management_2(sdt);
            flat_Management_2.StartPosition = FormStartPosition.CenterScreen;
            flat_Management_2.Show();
        }

        private void Pay_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment_Lessor pay = new Payment_Lessor(sdt);
            pay.StartPosition = FormStartPosition.CenterScreen;
            pay.Show();
        }

        private void Requests_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Requests_Lessor requests_Lessor = new Requests_Lessor(sdt);
            requests_Lessor.StartPosition = FormStartPosition.CenterScreen;
            requests_Lessor.Show();
        }

        private void Chat_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Chat_Lessor chat = new Chat_Lessor(sdt);
            chat.StartPosition = FormStartPosition.CenterScreen;
            chat.Show();
        }

        private void LogOut_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to log out?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Login l = new Login();
                l.Show();
            }
            else
            {
                DialogResult = DialogResult.No;
            }
        }

        private void Services_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Services_Lessor services_Lessor = new Services_Lessor(sdt);
            services_Lessor.StartPosition = FormStartPosition.CenterScreen;
            services_Lessor.Show();
        }

        private void bunifuPanel3_Click(object sender, EventArgs e)
        {

        }

        private async void Settings_Lessor_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            if (client == null)
            {
                MessageBox.Show("Connected isn't Successful!");
                return;
            }
            Phone_tb.Text = sdt;

            FirebaseResponse Response = await client.GetAsync("Account Lessor/" + Phone_tb.Text);
            if (Response.Body != "null")
            {
                Data dt = Response.ResultAs<Data>();
                Name_tb.Text = dt.name;
                Email_tb.Text = dt.email;
                ID_tb.Text = dt.ID;
            }
        }

        private void Setting_btn_Click(object sender, EventArgs e)
        {

        }

        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePass c = new ChangePass(sdt);
            c.Show();
        }

        private void Name_tb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
