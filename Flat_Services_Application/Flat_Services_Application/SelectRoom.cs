using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using Flat_Services_Application.Class;
using Google.Cloud.Firestore;
using static System.Net.Mime.MediaTypeNames;

namespace Flat_Services_Application
{
    public partial class SelectRoom : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "KR5gPtgHXbYV0t9jMOeKDN3UvRaXulbgAD4aijeN",
            BasePath = "https://account-ac0cc-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        FirestoreDb db;
        public SelectRoom()
        {
            InitializeComponent();
        }

        private void SelectRoom_Load(object sender, EventArgs e)
        {
            int[] room = { 101, 102, 103, 104, 105, 201, 202, 203, 204, 205, 301, 302, 303, 304, 305 };
            RadioButton[] IDroom = { rdb101, rdb102, rdb103, rdb104, rdb105, rdb201, rdb202, rdb203, rdb204, rdb205, rdb301, rdb302, rdb303, rdb304, rdb305};
            client = new FireSharp.FirebaseClient(config);

            if (client == null)
            {
                MessageBox.Show("Connected isn't Successful!");
                return;
            }

            try
            {
                string path = AppDomain.CurrentDomain.BaseDirectory + @"flatservice-a087e-firebase-adminsdk-e8i8j-118340432f.json";
                Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
                db = FirestoreDb.Create("flatservice-a087e");
                Get_a_Data(room, IDroom);
            }
            catch
            {
                MessageBox.Show("Cann't connect to firestore!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return; 
            }

        }

        async void Get_a_Data(int[] room, RadioButton[] IDroom)
        {
           
            for (int i = 0; i < room.Length; i++)
            {
                DocumentReference doc = db.Collection("SelectRoom").Document(room[i].ToString());
                DocumentSnapshot snap = await doc.GetSnapshotAsync();
                if (snap.Exists)
                { 
                    room1 t = snap.ConvertTo<room1>();
                   if(t.Status == 1)
                   {
                        IDroom[i].Enabled = false;
                        IDroom[i].Text = IDroom[i].Text + " - hired";
                   }
                   else
                        IDroom[i].Enabled = true;

                }
            }
        }
    }
}
