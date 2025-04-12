using System;
using System.IO;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using MimeKit;

namespace User_Registration_Confirmation.EmailService
{
    public class SendMailSMTP
    {
        public static async Task SendMail(string toMail, string subject, string body)
        {
            try
            {
                // Try to get credentials path from environment variable
                string credentialPath = Environment.GetEnvironmentVariable("GOOGLE_OAUTH_CREDENTIALS_PATH");

                // If not set in environment, check AppData folder
                if (string.IsNullOrEmpty(credentialPath) || !File.Exists(credentialPath))
                {
                    credentialPath = Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                        "RegisterLoginDemo",
                        "google-oauth-credentials.json");

                    // Ensure directory exists
                    Directory.CreateDirectory(Path.GetDirectoryName(credentialPath));
                }

                if (!File.Exists(credentialPath))
                {
                    throw new FileNotFoundException("Google OAuth credentials not found. Please set GOOGLE_OAUTH_CREDENTIALS_PATH environment variable or place credentials in the AppData folder.");
                }

                var credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.FromFile(credentialPath).Secrets,
                    new[] { GmailService.Scope.MailGoogleCom },
                    "user",
                    CancellationToken.None);

                var service = new GmailService(new BaseClientService.Initializer
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "User Registration Confirmation"
                });

                var email = new MimeMessage();
                email.From.Add(new MailboxAddress("BubblyChat", "silverhd280105@gmail.com"));
                email.To.Add(new MailboxAddress("", toMail));
                email.Subject = subject;
                email.Body = new TextPart("plain")
                {
                    Text = body
                };

                //Mã hóa
                using (var stream = new MemoryStream())
                {
                    email.WriteTo(stream);
                    var rawMessage = Convert.ToBase64String(stream.ToArray())
                                            .Replace("+","-")
                                            .Replace("/","_")
                                            .Replace("=","");
                    var message = new Google.Apis.Gmail.v1.Data.Message { Raw = rawMessage };
                    await service.Users.Messages.Send(message, "me").ExecuteAsync();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error sending email: {ex.Message}");
                throw;
            }
        }
    }
}
