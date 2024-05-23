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
using Google.Cloud.Firestore;
using Flat_Services_Application.Class;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Flat_Services_Application.lessor
{
    public partial class Requests_Lessor : Form
    {
        FirestoreDb db;
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "KR5gPtgHXbYV0t9jMOeKDN3UvRaXulbgAD4aijeN",
            BasePath = "https://account-ac0cc-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        public Requests_Lessor()
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

        private void Chat_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Chat_Lessor chat_Lessor = new Chat_Lessor();
            chat_Lessor.StartPosition = FormStartPosition.CenterScreen;
            chat_Lessor.Show();
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
            services_Lessor.StartPosition = FormStartPosition.CenterScreen;
            services_Lessor.Show();
        }

        private void Requests_Lessor_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if (client == null)
            {
                MessageBox.Show("Connected isn't Successful!");
                return;
            }
               
            // ket noi firestore
            try
            {
                string path = AppDomain.CurrentDomain.BaseDirectory + @"flatservice-a087e-firebase-adminsdk-e8i8j-118340432f.json";
                Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
                db = FirestoreDb.Create("flatservice-a087e");
                Get_Data();
            }
            catch
            {
                MessageBox.Show("Cann't connect to firestore!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        async void Get_Data()
        {
            //them vao listview
              Query doc = db.Collection("ListAwaitBrowse");
              QuerySnapshot snap = await doc.GetSnapshotAsync();

              foreach (DocumentSnapshot sn in snap)
              {
                    listRequest t = sn.ConvertTo<listRequest>();
                    if (sn.Exists)
                    {
                    string id = sn.Id.ToString();
                    ListViewItem data = new ListViewItem(id);
                    data.SubItems.Add(t.Name);
                    data.SubItems.Add(t.Room);
                    lvRequest.Items.Add(data);
                }
              }
        }

        private async void btnBrowse_Click(object sender, EventArgs e)
        {
            while(lvRequest.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvRequest.SelectedItems[0];
                string phone_num = selectedItem.SubItems[0].Text;  
                string room = selectedItem.SubItems[2].Text;

                // cap nhat lai status cua user
                FirebaseResponse responds = await client.GetAsync("Account Tenant/" + phone_num);
                if (responds.Body != "null")
                {
                    Data dt = responds.ResultAs<Data>();
                    var data = new Data()
                    {
                        name = dt.name,
                        email = dt.email,
                        pass = dt.pass,
                        phone = dt.phone,
                        ID = dt.ID,
                        date = dt.date,
                        objects = dt.objects,
                        status = 2,
                        remember = dt.remember,
                        room = dt.room,
                    };

                    FirebaseResponse ud = await client.UpdateAsync("Account Tenant/" + phone_num, data);
                    Data result = ud.ResultAs<Data>();
                }

                // xoa 1 docment trong list
                delete_Document(phone_num);
                //xoa ra khoi listview
                lvRequest.Items.RemoveAt(lvRequest.SelectedItems[0].Index);
            }
        }

        void delete_Document(string s)
        {
            DocumentReference dr = db.Collection("ListAwaitBrowse").Document(s);
            dr.DeleteAsync();
        }
        private void btnNoBrowse_Click(object sender, EventArgs e)
        {

        }
    }
}
