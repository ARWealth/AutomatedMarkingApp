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
using System.Data .OleDb ;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace automatedMarkingApp
{
    public partial class frmDatabase : Form
    {
        public frmDatabase()
        {
            InitializeComponent();
        }
        // Declare oledb variables
        OleDbConnection conn = new OleDbConnection();
        OleDbCommand cmd;
        
        private void frmDatabase_Load(object sender, EventArgs e)
        {
            // Create connection string
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\IUCEE\\OneDrive\\Documents"
                +"\\MSC PROJECT\\"+
                "Final MSC Project\\automatedMarkingApp\\finalProDB.accdb;Persist Security info=false";
           
            // Disable textbox
            tbSID.Enabled = false;
         
            // Colour the form
            this.BackColor = Color.Silver;
            this.ForeColor = Color.Navy;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Update records
                update();
                // Load table
                loadTable();
            }
                // Catch Exceptions
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            
        }


        private void update()
        {
            // If textboxes are not empty
            if (tbSID.Text != "" && tbFName.Text != "" && tbMName.Text != "" && tbLName.Text != "")
            {
                // Open connection
                conn.Open();
                // Create an instance of oledb command
                cmd = new OleDbCommand();
                cmd.Connection = conn;
                string query = "update studentsTb set FirstName= '" + tbFName.Text + "' ,MiddleName= '" + tbMName.Text + "'" +
                ",LastName= '" + tbLName.Text + "' ,Score= '" + tbScore.Text + "' ,Feedback= '" + tbFeedback.Text + "'" +
                "where StudentID='" + tbSID.Text + "'";
                // Show query on messagebox
                MessageBox.Show(query);
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Records updated");
                //Refresh Datagridview
                dataGridView1.Refresh();
                // Close connection
                conn.Close();
                // Clear textboxes
                clear();
            }
            else
            {
                MessageBox.Show("No database connection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
             
                     
        private void insert()
        {
            // Open database conection and write on the console if database is open
            conn.Open();

            // Declare variables
            string SID =  tbSID.Text;
            string FName = tbFName.Text;
            string MName = tbMName.Text;
            string LName = tbLName.Text;
            string Score = tbScore.Text;
            string Feedback = tbFeedback.Text;
                       
            // Declare oledbcommand (Insert)
            cmd = new OleDbCommand ("INSERT into studentsTb([StudentID], [FirstName], [MiddleName], [LastName], [Score], [Feedback])" 
                + "values(@SID,@FName,@MName,@LName,@Score,@Feedback)", conn);
            // If database connection is open
            if (conn .State == ConnectionState .Open)
            {
                // Insert details to the database
                cmd.Parameters.Add("@SID", OleDbType.Char, 20).Value = SID;
                cmd .Parameters .Add ("@FName", OleDbType.Char , 50).Value = FName ;
                cmd.Parameters.Add("@MName", OleDbType.Char, 50).Value = MName;
                cmd .Parameters .Add ("@LName", OleDbType.Char, 50).Value = LName ;
                cmd.Parameters.Add("@Score", OleDbType.Char, 10).Value = Score;
                cmd.Parameters.Add("@Feedback", OleDbType.Char, 200).Value = Feedback;
                
                // Execute command
                cmd.ExecuteNonQuery();
                // Display message if command execution is successful
                MessageBox.Show("Registration succeeded");
                
                // Close connection
                conn .Close ();
                // Clear textboxes
                clear();           
                }
                else
            {
                // If connection is not open, display the message
                MessageBox .Show ("Connection failed");
            }        
        }



        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Register new student
                insert();
                // Load table
                loadTable();
            }
            // Catch Exceptions
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {}

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Load table to datagridview
                loadTable();
            }
                // Catch Exceptions
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            
        }

        private void loadTable()
        {
            // sql statement
            string strSql = "Select * from studentsTb";
            cmd = new OleDbCommand(strSql, conn);
            // Open database connection
            conn.Open();
            cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable studentsTb = new DataTable();
            da.Fill(studentsTb);
            dataGridView1.DataSource = studentsTb;
            // Close connection
            conn.Close();
            // Clear textboxes
            clear();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                // Display datagridview selections on textboxes
                DataGridViewCell cell = null;
                foreach (DataGridViewCell selectedcell in dataGridView1.SelectedCells)
                {
                    cell = selectedcell;
                    break;
                }
                if (cell != null)
                {
                    DataGridViewRow row = cell.OwningRow;
                    tbSID.Text = row.Cells[0].Value.ToString();
                    tbFName.Text = row.Cells[1].Value.ToString();
                    tbMName.Text = row.Cells[2].Value.ToString();
                    tbLName.Text = row.Cells[3].Value.ToString();
                    tbScore.Text = row.Cells[5].Value.ToString();
                    tbFeedback.Text = row.Cells[6].Value.ToString();
                }
            }
            // Catch Exceptions
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Quit the application
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Generate student's ID
            Random rand = new Random();
            int num = rand.Next(5000000, 5999999);
            tbSID.Text = num.ToString ();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // Call delete sub
            delete();
            // Load table
            loadTable();
        }

        private void delete()
        {
            try
            {
                // Create delete statement
                string sql = "delete from studentsTb where StudentID='" + tbSID.Text + "'";
                // Open connection
                conn.Open();
                // Oledb command
                cmd = new OleDbCommand(sql, conn);
                // Execute command
                cmd.ExecuteNonQuery();
                // Display confirmation on message box
                MessageBox.Show("Record deleted");
                // Close database connection
                conn.Close();
                // Clear textboxes
                clear();
            }
                // Catch Exceptions
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        
        }

        private void clear()
        {
            // Clear textboxes
            tbSID.Text = "";
            tbFName.Text = "";
            tbMName.Text = "";
            tbLName.Text = "";
            tbScore.Text = "";
            tbFeedback.Text = "";
        }





    }
}
