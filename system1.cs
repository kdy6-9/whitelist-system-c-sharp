// Importing all the things we need
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

// The code
namespace Whitelist_system // If you copy the whole thing, change the name over here to what you named your solution, the "_" defines a space
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Defining the code that will grab the IP Address
        static string grabIP()
        {
            //using webclient
        using (WebClient webclient = new WebClient())
            {
                // Code that will Grab the users' IP Address, and Return it
                return webclient.DownloadString("https://wtfismyip.com/text"); // This part of the code is not mine, It is someone elses, I will leave the channel and video link in the description
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Over here, when the application loads, we are gonna place a message box saying That their IP is going to be used to whitelist them, and then list their IP Address
            MessageBox.Show($"Hello user, thank you for using the application. The thing is, we are using your IP address to whitelist you into the application. We do not want certain people to access this application. This is your IP Address: {grabIP()}", "Please read");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // On the click of the button, it will check the IP address, and define if it will be whitelisted, or kicked

            // Again, define the webclient
            WebClient wc = new WebClient();
            if (grabIP().Contains("IP")) // If the string we download from the website contains the IP that you put in the "", Then it will do this
            {
                Form2 f2 = new Form2(); // Define the second form that we created
                f2.Show(); // Show the form by using the variable we defined form2 as
                this.Hide(); // Hide this form from the user.
                MessageBox.Show("Welcome Back User, Your have been successfully whitelisted", "Whitelist success"); // Display a message to the user saying Welcome
            }
            else // If the IP Address is not the same, then do this
            {
                MessageBox.Show("Sorry, but you are not allowed in this application. If you keep logging in using this IP Address, then I will keep popping up.", "Not whitelisted"); // Show a message box telling them that they are not welcome.
                Application.Exit(); // After they click OK on the Message Box, It will close the application
            } // This code took me a while to made (well this part at least.) I couldn't find it on the internet something that would do the same function as this, so This is my code, I could be wrong, But for now I say it is mine
        }
    }
}
// To add more IPs, you simply do this:
// if if (grabIP().Contains("Ip here") || grabIP().Contains("Other Ip Here")) 
// The || are saying "or." So if this ip clicks, it works, if the other Ip clicks, it works, if a IP not listed her clicks, it don't work 
