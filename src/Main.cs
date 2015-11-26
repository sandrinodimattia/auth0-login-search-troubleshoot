using System;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Auth0.LoginTester
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            ServicePointManager.ServerCertificateValidationCallback = (object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) =>
            {
                return true;
            };
        }

        private void OnSignIn(object sender, EventArgs e)
        {
            Log("Signing in with {0}...", textLoginUsername.Text);
            Log(" > Connection: {0}", textLoginConnection.Text);
            Log(" > Client Id: {0}", textLoginClientId.Text);
            Log(" > Domain: {0}", textLoginDomain.Text);

            try
            {
                var client = new Auth0.Client(textLoginClientId.Text, textLoginDomain.Text);
                var tokens = client.LoginUser(textLoginUsername.Text, textLoginPassword.Text, textLoginConnection.Text, "openid profile");

                Log("Login success!");
                Log(" > Id Token: {0}", tokens.IdToken);
                Log(" > Access Token: {0}", tokens.AccessToken);

                var jwt = JWT.JsonWebToken.Decode(tokens.IdToken, "", false);
                var jwtObj = Newtonsoft.Json.JsonConvert.DeserializeObject(jwt);
                Log(" > JWT:\r\n\r\n{0}\r\n", Newtonsoft.Json.JsonConvert.SerializeObject(jwtObj, Newtonsoft.Json.Formatting.Indented));
            }
            catch (Exception ex)
            {
                Log("Login failed!");
                Log(" > Error: {0}", ex.Message);
            }
        }

        private void OnSearch(object sender, EventArgs e)
        {
            Log("Searching for {0}...", textSearchUserId.Text);
            Log(" > Client Id: {0}", textSearchClientId.Text);
            Log(" > Domain: {0}", textSearchDomain.Text);

            try
            {
                var client = new Auth0.Client(textSearchClientId.Text, textSearchClientSecret.Text, textSearchDomain.Text);
                var user = client.GetUser(textSearchUserId.Text);
                if (user != null)
                {
                    Log("User found!");
                    Log(" > Data:\r\n\r\n{0}\r\n", Newtonsoft.Json.JsonConvert.SerializeObject(user, Newtonsoft.Json.Formatting.Indented));
                }
                else
                {
                    Log("User not found!");
                }
            }
            catch (Exception ex)
            {
                Log("User not found!");
                Log(" > Error: {0}", ex.Message);
            }

        }

        private void Log(string message, params object[] args)
        {
            textLogs.AppendText(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss - ") + String.Format(message, args) + "\r\n");
        }
    }
}
