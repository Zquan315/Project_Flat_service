using Newtonsoft.Json;
using qrBank;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flat_Services_Application.tenant
{
    public partial class homecostsing : Form
    {
        public homecostsing()
        {
            InitializeComponent();
        }
        public homecostsing(string s, string p)
        {
            InitializeComponent();
            tbAccount.Text = s;
            tbroom.Text = p;
        }
        private void homecostsing_Load(object sender, EventArgs e)
        {
            this.costsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)41))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.costsBtn.ForeColor = Color.White;



            //using (WebClient client = new WebClient())
            //{
            //    var htmlData = client.DownloadData("https://api.vietqr.io/v2/banks");
            //    var bankRawJson = Encoding.UTF8.GetString(htmlData);
            //    var listBankData = JsonConvert.DeserializeObject<Bank>(bankRawJson);

            //    cb_nganhang.Properties.DataSource = listBankData.data;
            //    cb_nganhang.Properties.DisplayMember = "custom_name";
            //    cb_nganhang.Properties.ValueMember = "bin";
            //    cb_nganhang.EditValue = listBankData.data.FirstOrDefault().bin;
            //    cb_template.SelectedIndex = 0;
            //}
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

        private void chatBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            homechating homechating = new homechating(tbAccount.Text, tbroom.Text);
            homechating.StartPosition = FormStartPosition.CenterScreen;
            homechating.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Setting differencesfee = new Setting(tbAccount.Text, tbroom.Text);
            differencesfee.StartPosition = FormStartPosition.CenterScreen;
            differencesfee.Show();
        }

        private void panel5_Click(object sender, EventArgs e)
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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }





        /*Quan Le*/
        public Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            return image;
        }

        public Image LoadImage(string base64String)
        {
            //data:image/gif;base64,
            //this image is a single pixel (black)
            byte[] bytes = Convert.FromBase64String(base64String);

            Image image;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                image = Image.FromStream(ms);
            }

            return image;
        }

        private void qrCreateBtn_Click(object sender, EventArgs e)
        {
            //var apiRequest = new APIRequest();
            //apiRequest.acqId = Convert.ToInt32(cb_nganhang.EditValue.ToString());
            //apiRequest.accountNo = long.Parse(txtSTK.Text);
            //apiRequest.accountName = txtTenTaiKhoan.Text;
            //apiRequest.amount = Convert.ToInt32(txtSoTien.Text);
            //apiRequest.template = cb_template.Text;
            //var jsonRequest = JsonConvert.SerializeObject(apiRequest);
            //// use restsharp for request api

            //var client = new RestClient("https://api.vietqr.io/v2/generate");
            //var request = new RestRequest();

            //request.Method = Method.Post;
            //request.AddHeader("Accept", "application/json");

            //request.AddParameter("application/json", jsonRequest, ParameterType.RequestBody);
            //Task<RestResponse> response = client.ExecuteAsync(request);
            ///*var response = client.ExecuteAsync(request);*/
            ///*var response = client.Execute(request);*/
            ///*var content = response.Content;
            //var dataResult = JsonConvert.DeserializeObject<APIResponse>(content);*/


            ///*var image = Base64ToImage(dataResult.data.qrDataURL.Replace("data:image/png;base64,", ""));
            //pictureBox1.Image = image;*/
        }
    }
}
