using System;
using System.Windows.Forms;
using System.Security.Principal;
using System.IO;

namespace hosts_changer
{
    public partial class changeHosts : Form
    {

        public static bool IsAdministrator()
        {
            using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
            {
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
        }

        public changeHosts()
        {
            InitializeComponent();
        }

        private void enigmaBtn_Click(object sender, EventArgs e)
        {

            string filePath = Path.Combine(Environment.SystemDirectory, "defrag.exe").ToLower();
            filePath = filePath.Replace("defrag.exe", "");
            string hostsLocation = filePath + "drivers\\etc\\hosts";
            string text = File.ReadAllText(hostsLocation);
            if (text.Contains("growtopia1.com") && !text.Contains("51.91.8.30"))
            {
                string answer = MessageBox.Show("Found IP of another Growtopia server from your hosts file. Might be unsafe to add Enigma's ip address at the same time if another one is present.\nAre you still sure you want to add it?", "Another IP found", MessageBoxButtons.YesNo).ToString().ToLower();
                if (answer == "no")
                {
                    System.Windows.Forms.MessageBox.Show("Nothing was modified.");
                    return;
                }
            }
            if (text.Contains("growtopia1.com") && text.Contains("51.91.8.30") || text.Contains("growtopia2.com") && text.Contains("51.91.8.30"))
            {
                string answer = MessageBox.Show("There is already an IP of Enigma found in your hosts file. If it's there, it might not be necessary to re-add it.\nAre you still sure you want to add it?", "Already exists", MessageBoxButtons.YesNo).ToString().ToLower();
                if (answer == "no") {
                    System.Windows.Forms.MessageBox.Show("Nothing was modified.");
                    return;
                }
            }
            File.WriteAllText(hostsLocation, text + "\n51.91.8.30 growtopia1.com\n51.91.8.30 growtopia2.com\n51.91.8.30 www.growtopia1.com\n51.91.8.30 www.growtopia2.com");
            System.Windows.Forms.MessageBox.Show("IP added to your hosts file. You should be able to login to Enigma now.");
            return;
        }

        private void rgtBtn_Click(object sender, EventArgs e)
        {

            string filePath = Path.Combine(Environment.SystemDirectory, "defrag.exe").ToLower();
            filePath = filePath.Replace("defrag.exe", "");
            string hostsLocation = filePath + "drivers\\etc\\hosts";
            string text = File.ReadAllText(hostsLocation);
            if (text.Contains("growtopia1.com") && text.Contains("51.91.8.30") || text.Contains("growtopia2.com") && text.Contains("51.91.8.30"))
            {
                text = text.Replace("51.91.8.30 growtopia1.com", "");
                text = text.Replace("51.91.8.30 www.growtopia1.com", "");
                text = text.Replace("51.91.8.30 growtopia2.com", "");
                text = text.Replace("51.91.8.30 www.growtopia2.com", "");
                File.WriteAllText(hostsLocation, text);
                System.Windows.Forms.MessageBox.Show("Removed the IPs of Enigma from your hosts file.");
                return;
            } else
            {
                System.Windows.Forms.MessageBox.Show("No IP of Enigma was found from your hosts file.");
                return;
            };
        }

        private void changeHosts_Load(object sender, EventArgs e)
        {
            if (!IsAdministrator())
            {
                System.Windows.Forms.MessageBox.Show("You didn't open the app as an admin. I am not able to modify hosts file without them.\nRight click on this app, and choose \"run as an administrator\" option and then try again.");
                this.Close();
                return;
            };

            string answer = MessageBox.Show("This application WILL perform actions on your behalf, do you wish to continue? By accepting, the owner (JamSandwich, JammuMies327#5283) will not be responsible if any issue occurs.", "SAFETY NOTICE", MessageBoxButtons.YesNo).ToString().ToLower();
            if (answer == "no")
            {
                this.Close();
                return;
            }
        }
    }
}
