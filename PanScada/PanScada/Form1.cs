using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Net;

namespace PanScada
{
    public partial class Form1 : Form
    {
        private string IP;
        Website MainWebsite;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            usersCheckBox.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filename = ofd.FileName;
                //MessageBox.Show(filename);
                string filetext = File.ReadAllText(filename);
                ConfigFile configfile = JsonConvert.DeserializeObject<ConfigFile>(filetext);
                this.IP = configfile.IP;
            }
            ofd.Dispose();
        }

        private void startAppointmentButton_Click(object sender, EventArgs e)
        {
            MainWebsite = new Website(new[] { this.IP }, OnRequest);
            MainWebsite.Start();
        }

        private string OnRequest(HttpListenerContext context)
        {
            if (context.Request.HttpMethod == "GET" && 
                (context.Request.RawUrl).Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries)[0] == "login")
            {
                string newuser = (context.Request.RawUrl).Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries)[1];
                usersCheckBox.Items.Add(newuser);
                return @"<!doctype html><html><head></head><body>U was successfully logged in</body></html>";
            }
            return @"<!doctype html><html><head></head><body>Monopoly</body></html>";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainWebsite.Stop();
        }
    }
}
