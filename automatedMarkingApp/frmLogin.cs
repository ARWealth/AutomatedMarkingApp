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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // Colour the form
            this.BackColor = Color.Silver;
            this.ForeColor = Color.Navy;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Quit the application
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // If username and password is correct
            if (textBox1.Text == "uadubasim" & textBox2.Text == "ucee")
            {

                // Hide this form
                this.Hide();
                // Display next form
                frmMark myform = new frmMark();
                myform.Show();
            }
            // If username and/or password is not correct
            else
            {
                // Display error message
                MessageBox.Show("Invalid Login details, Please try again", "Login Error", MessageBoxButtons .OK , 
                     MessageBoxIcon.Error);
            }
        }
    
    
    }}
