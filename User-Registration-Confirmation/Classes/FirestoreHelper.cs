using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Registration_Confirmation.Classes
{
    internal class FirestoreHelper
    {
        static string filepath = "";
        public static FirestoreDb? db { get; private set; }

        public static void SetEnvironmentVariable()
        {
            try
            {
                // Look for credentials file in a secure location outside of the repo
                string credentialsPath = Environment.GetEnvironmentVariable("FIREBASE_CREDENTIALS_PATH");

                if (!string.IsNullOrEmpty(credentialsPath) && File.Exists(credentialsPath))
                {
                    // Use the credentials file specified in environment variable
                    Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", credentialsPath);
                }
                else
                {
                    // Fallback: Check for credentials in AppData or similar secure location
                    string appDataPath = Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                        "RegisterLoginDemo",
                        "firebase-credentials.json");

                    if (File.Exists(appDataPath))
                    {
                        Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", appDataPath);
                    }
                    else
                    {
                        throw new FileNotFoundException("Firebase credentials file not found. Please set FIREBASE_CREDENTIALS_PATH environment variable or place credentials in the AppData folder.");
                    }
                }

                db = FirestoreDb.Create("sign-logindemo");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error setting up Firebase: {ex.Message}");
                throw;
            }
        }
    }
}
