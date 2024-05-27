using Flat_Services_Application.Class;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Google.Rpc.Context.AttributeContext.Types;

namespace Flat_Services_Application.tenant
{
    public partial class homeservices : Form
    {
        FirestoreDb db;
        public homeservices()
        {
            InitializeComponent();
        }
        public homeservices(string s, string p)
        {
            InitializeComponent();
            tbAccount.Text = s;
            tbroom.Text = p;
        }
        private void homeservices_Load(object sender, EventArgs e)
        {
            this.servicesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)41))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.servicesBtn.ForeColor = Color.White;

            

            //ket noi firestore
            try
            {
                string path = AppDomain.CurrentDomain.BaseDirectory + @"flatservice-a087e-firebase-adminsdk-e8i8j-118340432f.json";
                Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
                db = FirestoreDb.Create("flatservice-a087e");
            }
            catch
            {
                MessageBox.Show("Cann't connect to firestore!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //
            load_data();
        }


        async void load_data()
        {
            Query doc = db.Collection("ListServiceForRent");
            QuerySnapshot snap = await doc.GetSnapshotAsync();

            foreach (DocumentSnapshot sn in snap)
            {
                ListServiceForRent t = sn.ConvertTo<ListServiceForRent>();
                if (sn.Exists)
                {
                    string id = sn.Id.ToString();                   
                    ListViewItem data = new ListViewItem(id);
                    data.SubItems.Add(t.Name);
                    data.SubItems.Add(t.Price.ToString());
                    data.SubItems.Add(t.Note);
                    listView2.Items.Add(data);
                    

                }
            }
        }
        private void homeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            homenavigation homenavigation = new homenavigation(tbAccount.Text, tbroom.Text);
            homenavigation.StartPosition = FormStartPosition.CenterScreen;
            homenavigation.Show();
        }

        private void costsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            homecostsing homecostsing = new homecostsing(tbAccount.Text, tbroom.Text);
            homecostsing.StartPosition = FormStartPosition.CenterScreen;
            homecostsing.Show();
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            homeinformation homeinformation = new homeinformation(tbAccount.Text, tbroom.Text);
            homeinformation.StartPosition = FormStartPosition.CenterScreen;
            homeinformation.Show();
        }

        private void servicesBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            homeservices homeservices = new homeservices(tbAccount.Text, tbroom.Text);
            homeservices.StartPosition = FormStartPosition.CenterScreen;
            homeservices.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Setting differencesfee = new Setting(tbAccount.Text, tbroom.Text);
            differencesfee.StartPosition = FormStartPosition.CenterScreen;
            differencesfee.Show();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Click(object sender, EventArgs e)
        {
            
        }

        private void chatBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            homechating homechating = new homechating(tbAccount.Text, tbroom.Text);
            homechating.StartPosition = FormStartPosition.CenterScreen;
            homechating.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void logoutBtn_Click(object sender, EventArgs e)
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
