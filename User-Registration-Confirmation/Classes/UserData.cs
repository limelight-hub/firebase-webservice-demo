    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;


namespace User_Registration_Confirmation.Classes
{
    [FirestoreData]
    internal class UserData
    {
        [FirestoreProperty]
        public string Username { get; set; }
        [FirestoreProperty]
        public string Email { get; set; }

        [FirestoreProperty]
        public string Password { get; set; }
        [FirestoreProperty]
        public string Gender { get; set; }
        [FirestoreProperty]
        public int Zipcode { get; set; }
    }
}
