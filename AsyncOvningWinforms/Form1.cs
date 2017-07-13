using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncOvningWinforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void oneWebsiteButton_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();

            var timer = new Stopwatch();
            timer.Start();

            var task1 = client.GetStringAsync(Url);
            var task2 = client.GetStringAsync(Url);
            var task3 = client.GetStringAsync(Url);

            string[] results = await Task.WhenAll(task1, task2, task3);

            timer.Stop();

            MessageBox.Show($"Det tog totalt {timer.Elapsed.Milliseconds} millisekunder att genomföra");
        }
        const string Url = "http://www.facebook.com";


        
        

    }
}
