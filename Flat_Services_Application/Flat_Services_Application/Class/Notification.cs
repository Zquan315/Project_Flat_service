using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flat_Services_Application.Class
{
    
    [FirestoreData]
    public class Notification
    {
        [FirestoreProperty]
        public int Noti { get; set; }


    }
}
