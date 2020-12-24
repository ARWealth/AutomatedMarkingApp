/* Developer: Uchenna Chukwuma Adubasim
 * SID Number: 5317110
 * Company: Coventry University
 * Module: M08AEE - Individual Project
 * Supervisor: Richard Rider
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace automatedMarkingApp
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            // Set the cursor property
            this.Cursor = Cursors.AppStarting;

            // Configuring the progressbar
            
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;

            // Configuring the timer
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Start();

            // Clear label3
            label3.Text = "";

            // Colour the form
            this.BackColor = Color.Silver;
            this.ForeColor = Color.Navy;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                // Conditions for loading the application
                progressBar1.Increment(30);
                if (progressBar1.Value <= 50)
                {
                    label3.Text = "...Application is loading";
                }
                else if (progressBar1.Value > 50 & progressBar1.Value <= 80)
                {
                    label3.Text = "...Application is almost ready";
                }
                else if (progressBar1.Value > 80 & progressBar1.Value < 100)
                {
                    label3.Text = "...Setting up a few more things";
                }
                if (progressBar1.Value == 100)
                {
                    // Enable timer
                    timer1.Enabled = false;
                    // Hide this form
                    this.Hide();
                    // Display Form 2
                    frmLogin myform = new frmLogin();
                    myform.Show();
                    // Set cursor property to default
                    this.Cursor = Cursors.Default;         }   }
        }}
