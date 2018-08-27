using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebsiteInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //This lines get HTML Code from a website
                string text = txturl.Text;
                string userurl = text;
                using (WebClient client = new WebClient())
                {
                    userurl = client.DownloadString(userurl);
                }
                richTextBox1.Text = userurl;
                //Get the IP from URL
                var url = txturl.Text;
                Uri myUri = new Uri(url);
                var ip = Dns.GetHostAddresses(myUri.Host)[0];
                lblip.Text = ip.ToString();
                //Get the domain from URL
                Uri hostofwebsite = new Uri(txturl.Text);
                string host = hostofwebsite.Host;
                lbldomain.Text = host;
            }
            catch (Exception error)
            {
                MessageBox.Show("Sorry we can't handle this site!. The error is :"+"\n"+error.Message,"OMG guys!, ERRRRRORRRR");
                
            }  
            
        }
    }
}
