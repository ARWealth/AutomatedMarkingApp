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
using System.Drawing.Imaging;

namespace automatedMarkingApp
{
    using AForge;
    using AForge.Imaging;
    using AForge.Imaging.Filters;
    using AForge.Imaging.ComplexFilters;
    using AForge.Math;
    using AForge.Math.Geometry;

    public partial class frmMark : Form
    {
        public frmMark()
        {
            InitializeComponent();
        }
        // Declare the openfiledialog
        OpenFileDialog ofd = new OpenFileDialog();
        // Declare savefiledialog
        SaveFileDialog sfd = new SaveFileDialog();
        // Declare listbox to hold the total number of items in the template
        ListBox lb = new ListBox();
        // Declare listbox to hold the score of the student
        ListBox lbscore = new ListBox();

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialise labelboxes
            lblXY.Text = "";
            lblARGB.Text = "";
            lblWH.Text = "";
            lblScore.Text = "";
            lblinfo.Text = "";
         
            // Hide labelboxes on startup
            lblScore.Visible = false;
            lblinfo.Visible = false;
            // Hide textbox on startup
            txtScore.Visible = false;

            // Disable pictureboxes on startup
            templatePb.Enabled = false;
            formPb.Enabled = false;

            // Colour the form
            this.BackColor = Color.Silver;
            this.ForeColor = Color.Navy;
            

        }

        private void formPb_MouseMove(object sender, MouseEventArgs e)
        {
                // Catch exceptions
                try
            {
                // Declare variables
                Bitmap bmp2 = new Bitmap(formPb.Image);
                Color mycolor2 = bmp2.GetPixel(e.X, e.Y);          
                // Display image properties on the labelboxes
                lblXY.Text = Convert.ToString("X=" + " " + e.X + "," + " " + "Y=" + e.Y);
                lblARGB.Text = Convert.ToString("A=" + " " + mycolor2.A + "," + " " + "R=" + " " + 
                    mycolor2.R + "," + " " + "G=" + " " + mycolor2.G + "," + " " + "B=" + " " + mycolor2.B);
                lblWH.Text = Convert.ToString("Width=" + " " + bmp2.Width + "," + " " + "Height=" + " " + bmp2.Height);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void templatePb_MouseMove(object sender, MouseEventArgs e)
        {
                // Catch exceptions
                try
            {
                // Declare variables
                Bitmap bmp = new Bitmap(templatePb.Image);
                Color mycolor = bmp.GetPixel(e.X, e.Y);
           
                // Display image properties on the labelboxes
                lblXY.Text = Convert.ToString("X=" + " " + e.X + "," + " " + "Y=" + e.Y);
                lblARGB.Text = Convert.ToString("A=" + " " + mycolor.A + "," + " " + "R=" + " " + 
                    mycolor.R + "," + " " + "G=" + " " + mycolor.G + "," + " " + "B=" + " " + mycolor.B);
                lblWH.Text = Convert.ToString("Width=" + " " + bmp.Width + "," + " " + "Height=" + " " + bmp.Height);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void invertTemplate()
        { // Declare variables
            Bitmap bmp = new Bitmap(templatePb.Image);
            int a, r, g, b;
            // Catch exceptions
            try
            {
                // Iterate through image
                for (int x = 0; x < bmp.Width; x++)
                {
                    for (int y = 0; y < bmp.Height; y++)
                    {
                        // Get the pixels
                        a = bmp.GetPixel(x, y).A;
                        r = bmp.GetPixel(x, y).R;
                        g = bmp.GetPixel(x, y).G;
                        b = bmp.GetPixel(x, y).B;
                        // Invert the pixels
                        bmp.SetPixel(x, y, Color.FromArgb(a, 255 - r, 255 - g, 255 - b));
                    } }

                // Refresh and display on picturebox
                templatePb.Refresh();
                templatePb.Image = bmp;       }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }     }


        private void invertForm()
        {
            // Declare variables
            Bitmap bmp2 = new Bitmap(formPb.Image);
            int a, r, g, b;

            try
            {
                // Iterate through image
                for (int x = 0; x < bmp2.Width; x++)
                {
                    for (int y = 0; y < bmp2.Height; y++)
                    {
                        // Get the pixels
                        a = bmp2.GetPixel(x, y).A;
                        r = bmp2.GetPixel(x, y).R;
                        g = bmp2.GetPixel(x, y).G;
                        b = bmp2.GetPixel(x, y).B;
                        // Invert the pixels
                        bmp2.SetPixel(x, y, Color.FromArgb(a, 255 - r, 255 - g, 255 - b));
                    }     }
                // Refresh and display on picturebox
                formPb.Refresh();
                formPb.Image = bmp2;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }      }


        private void filterBlueInk()
        {
            // Declare image variables
            Bitmap bmp = new Bitmap(templatePb.Image);
            Bitmap bmp2 = new Bitmap(formPb.Image);
            // create filter
            EuclideanColorFiltering filter = new EuclideanColorFiltering();
            // set center color and radius
            filter.CenterColor = new RGB(255, 143, 63);
            filter.Radius = 100;
            // apply the filter to the images
            filter.ApplyInPlace(bmp);
            filter.ApplyInPlace(bmp2);
            // Display result on pictureboxes
            templatePb.Image = bmp;
            formPb.Image = bmp2;
        }

        private void filterGreenInk()
        {
            // Declare image variables
            Bitmap bmp = new Bitmap(templatePb.Image);
            Bitmap bmp2 = new Bitmap(formPb.Image);
            // create filter
            EuclideanColorFiltering filter = new EuclideanColorFiltering();
            // set center color and radius
            filter.CenterColor = new RGB(255, 79, 175);
            filter.Radius = 100;
            // apply the filter to the images
            filter.ApplyInPlace(bmp);
            filter.ApplyInPlace(bmp2);
            // Display result on pictureboxes
            templatePb.Image = bmp;
            formPb.Image = bmp2;
        }

        private void filterRedInk()
        {
            // Declare image variables
            Bitmap bmp = new Bitmap(templatePb.Image);
            Bitmap bmp2 = new Bitmap(formPb.Image);
            // create filter
            EuclideanColorFiltering filter = new EuclideanColorFiltering();
            // set center color and radius
            filter.CenterColor = new RGB(0, 255, 255);
            filter.Radius = 100;
            // apply the filter to the images
            filter.ApplyInPlace(bmp);
            filter.ApplyInPlace(bmp2);
            // Display result on pictureboxes
            templatePb.Image = bmp;
            formPb.Image = bmp2;
        }

        private void invertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                // Change cursor to wait cursor
                this.Cursor = Cursors.WaitCursor;
                //Invert filter
                invertTemplate();
                invertForm();
                // Change cursor to default
                this.Cursor = Cursors.Default;
            }
        }

        private void markForm()
        {
            // Catch exceptions
            try
            {

                // Declare images
                Bitmap bmp = new Bitmap(templatePb.Image);
                Bitmap bmp2 = new Bitmap(formPb.Image);

                // Blob counter algorithm for the template and form
                BlobCounter blobCounter = new BlobCounter();
                BlobCounter blobCounter2 = new BlobCounter();

                // Filter blobs
                blobCounter.FilterBlobs = true;
                blobCounter2.FilterBlobs = true;

                // Minimum width and minimum height to consider
                blobCounter.MinWidth = 10;
                blobCounter.MinHeight = 10;
                blobCounter2.MinWidth = 10;
                blobCounter2.MinHeight = 10;               

                // Process image
                blobCounter.ProcessImage(bmp);
                blobCounter2.ProcessImage(bmp2);

                // Array of rectangles
                Rectangle[] rects = blobCounter.GetObjectsRectangles();
                Rectangle[] rects2 = blobCounter2.GetObjectsRectangles();

                // Rectangular objects in the image
                foreach (Rectangle objectRect in rects)
                {
                    if (rects.Length > 0)
                    {
                        // Add all the items in the template to the listbox
                        lb.Items.Add(objectRect);
                        // Draw a rectangular border on each rectangular objects in image1   
                        Graphics g = Graphics.FromImage(bmp);

                        using (Pen pen = new Pen(Color.FromArgb(160, 255, 160), 5))
                        {
                            g.DrawRectangle(pen, objectRect);
                        }
                        // Dispose Graphics1
                        g.Dispose();
                        // Display result on picturebox1
                        templatePb.Image = bmp;

                        // Rectangular objects in the image2
                        foreach (Rectangle objectRect2 in rects2)
                        {
                            if (rects2.Length > 0)
                            {
                                // Draw a rectangular border on each rectangular objects in image2
                                Graphics g2 = Graphics.FromImage(bmp2);

                                using (Pen pen2 = new Pen(Color.FromArgb(160, 255, 160), 5))
                                {
                                    g2.DrawRectangle(pen2, objectRect2);
                                }
                                // Dispose Graphics2
                                g2.Dispose();
                                // Display result on picturebox2
                                formPb.Image = bmp2;

                                // Boolean variable comparing both objects
                                bool blobFE = true;                               
                                blobFE = objectRect2.X.Equals(objectRect.X) && objectRect2.Y.Equals(objectRect.Y);

                                // If blob location is equal in both images
                                if (blobFE)
                                {
                                    // Add 1 mark to the score
                                    lbscore.Items.Add(1);
                                    // Exit loop
                                    break;
                                }

                                // If blob is not found or blob location in both images are not equal, do nothing
                                else
                                { }

                                // Close loops
                            }
                        }
                    }
                }
                       
                // Declare the variable to sum up items on the listbox
                int sum = 0;
                // Display labelbox
                lblScore.Visible = true;
                // Set the text property of the Labelbox
                lblScore.Text = Convert.ToString("Total score =");
                // Display textbox
                txtScore.Visible = true;
                // Score represents each item in the list box
                foreach (object score in lbscore.Items)
                {
                // Add up only the correct answers
                    if (score.Equals(1))
                    {
                        // If the students' number of fills is less than or equal to the number of required answers
                        if (blobCounter2.ObjectsCount <= blobCounter.ObjectsCount)
                        {
                            // Add up all the items in the listbox
                            sum = sum + 1;
                            
                            // Display the result on the textbox
                            txtScore.Text = Convert.ToString(sum + " " + "/" + " " + lb.Items.Count);
                        }
                        // If the students' number of fills exceed the number of required answers
                        else if (blobCounter2.ObjectsCount > blobCounter.ObjectsCount)
                        {
                            // Get the number of extra fills
                            int d = blobCounter2.ObjectsCount - blobCounter.ObjectsCount;
                            // Multiply the number of extra fills by 2
                            int f = (d * 2);
                            // Add up all the items in the listbox
                            sum = sum + 1;
                            // Substract the doubled extra fills from the total score
                            int g = sum - f;
                            // Display the result on the textbox
                            txtScore.Text = ("Total mark=" + " " + g + "/" + blobCounter.ObjectsCount);
                        }
                    }
                }
                // Display result on messagebox
                MessageBox.Show("This student scored:"+ " " + txtScore.Text, "Total score");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }


        private void openTemplate()
        {
            // Enable the picturebox
            templatePb.Enabled = true;
            // Set the filters for the image file formats
            ofd.Filter = "BMP files|*.bmp|JPEG files|*.jpg|PNG files|*.png|GIF files|*.gif|TIFF files|*.tiff";
            // Conditions to select an image
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Catch exception
                try
                {
                        templatePb.Image = System.Drawing.Image.FromFile(ofd.FileName);
                        // Declare image variable
                        Bitmap bmp = new Bitmap(templatePb.Image);
                        // Declare new size of both image
                        Size newSize = new Size(650, 600);
                        // Apply new size to image
                        bmp = new Bitmap(templatePb.Image, newSize);
                        // Make image fit to picturebox
                        templatePb.SizeMode = PictureBoxSizeMode.AutoSize;
                        // Display result on picturebox
                        templatePb.Image = bmp;
                        // Hide labelbox
                        lblinfo.Visible = false;
                }
                catch (Exception exc)
                { MessageBox.Show("Error:" + " " + exc.Message + "," + " " + "Please try again"); }
            } }
        

        private void openForm()
        {  // Enable the picturebox
            formPb.Enabled = true;
            // Set the filters for the image file formats
            ofd.Filter = "BMP files|*.bmp|JPEG files|*.jpg|PNG files|*.png|GIF files|*.gif|TIFF files|*.tiff";
            // Conditions to select an image
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Catch exception
                try
                {
                        formPb.Image = System.Drawing.Image.FromFile(ofd.FileName);
                        // Declare image variable
                        Bitmap bmp2 = new Bitmap(formPb.Image);
                        // Declare new size of both image
                        Size newSize = new Size(650, 600);
                        // Apply new size to image
                        bmp2 = new Bitmap(formPb.Image, newSize);
                        // Make image fit to picturebox
                        formPb.SizeMode = PictureBoxSizeMode.AutoSize;
                        // Display result on picturebox
                        formPb.Image = bmp2;
                }
                catch (Exception exc)
                { MessageBox.Show("Error:" + " " + exc.Message + "," + " " + "Please try again"); }
            }
        }

        private void saveTemplate()
        {
            // Catch exception
            try
            {
                // Supported file formats for the savefile dialog
                sfd.Filter = "BMP files|*.bmp|JPEG files|*.jpg|PNG files|*.png|GIF files|*.gif|TIFF files|*.tiff";
                // Conditions to save file
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    // Save image
                    templatePb.Image.Save(sfd.FileName);
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void saveForm()
        {
          // Catch exception
            try
            {
                    // Supported file formats for the savefile dialog
                    sfd.Filter = "BMP files|*.bmp|JPEG files|*.jpg|PNG files|*.png|GIF files|*.gif|TIFF files|*.tiff";
                    // Conditions to save file
                    if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        // Save image
                        formPb.Image.Save(sfd.FileName);
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
   
        private void openTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {         
            // Declare variables for messagebox
            string m = "The template you will select is visible by default, Do you want to hide it?";
            string caption = "Template visibility";
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            // Display message
            var mbox = MessageBox.Show(m, caption, buttons);
            // Choose either to hide the template or display it
            if (mbox == DialogResult.Yes)
            {
                // if yes is chosen, hide template
                templatePb.Visible = false;
                // Open template
                openTemplate();

                // Display label box
                lblinfo.Visible = true;  
                // Display message
                lblinfo.Text = "Template load successful";
            }

            else if (mbox == DialogResult.No)
            {
                // If no is chosen, display template
                templatePb.Visible = true;
                // Open template
                openTemplate();
            }

            else if (mbox == DialogResult.Cancel)
            {
                // If you want to cancel the dialogresult, refresh the form
                this.Refresh();
            }

           
        }

        private void openFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Initialise textbox
            txtScore.Text = "";
            // Initialise listboxes
            lb.Items.Clear();
            lbscore.Items.Clear();
            // Open Form
            openForm();
        }

        private void filterIfBlueInkWasUsedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Filter if blue ink was used
            filterBlueInk();
        }

        private void filterIfGreenInkWasUsedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Filter if green ink was used
            filterGreenInk();
        }

        private void filterIfRedInkWasUsedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Filter if red ink was used
            filterRedInk();
        }

        private void markFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Mark the form
            markForm();
        }

        private void saveTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Save template
            saveTemplate();
        }

        private void saveFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Save Form
            saveForm();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Restart the application
            Application.Restart();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Quit the application
            Application.Exit();
        }

        private void resizeImage640x594pixels()
        {
            try
            {
                // Clear label box
                lblWH.Text = "";
                // Declare image variables
                Bitmap bmp = new Bitmap(templatePb.Image);
                Bitmap bmp2 = new Bitmap(formPb.Image);
                // Declare new size of both images
                Size newSize = new Size(640, 594);
                // Apply new size to both images
                bmp = new Bitmap(templatePb.Image, newSize);
                bmp2 = new Bitmap(formPb.Image, newSize);
                // Display result on pictureboxes
                templatePb.Image = bmp;
                formPb.Image = bmp2;
                // Make image to fit pictureboxes
                templatePb.SizeMode = PictureBoxSizeMode.AutoSize;
                formPb.SizeMode = PictureBoxSizeMode.AutoSize;
                // Display width and height on label boxes
                lblWH.Text = Convert.ToString("Width=" + " " + bmp.Width + "," + " " + "Height=" + " " + bmp.Height);
                lblWH.Text = Convert.ToString("Width=" + " " + bmp2.Width + "," + " " + "Height=" + " " + bmp2.Height);
            }
            // Catch exceptions
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            
        }

        private void resizeImage640x590PixelsToolStripMenuItem_Click(object sender, EventArgs e)
        {}

        private void openAndSaveResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            // Display next form
            frmDatabase myform = new frmDatabase();
            myform.Show();
            // Resize current form
            this.Width = myform.Width;
            this.Height = myform.Height;
            // Set form location
            myform.Location = new System.Drawing.Point(500, 30);
            
        }

        private void saveTemplateAsBMPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Save template in recommended BMP file format
            try
            {
                // Supported file formats for the savefile dialog
                sfd.Filter = "BMP files|*.bmp";
                // Conditions to save file
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    // Save image
                    templatePb.Image.Save(sfd.FileName);
                }

            }
            // Catch exception
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void saveFormAsBMPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Save form in recommended BMP file format
            try
            {
                // Supported file formats for the savefile dialog
                sfd.Filter = "BMP files|*.bmp";
                // Conditions to save file
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    // Save image
                    formPb.Image.Save(sfd.FileName);
                }
            }
            // Catch exception
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void markFormAndRetainTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Mark form and keep the current template
            markFormAndRetainTemplate();
        }

        private void invertTemplateOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Change cursor to wait cursor
            this.Cursor = Cursors.WaitCursor;
            // Invert Template only
            invertTemplate();
            // Change cursor to default
            this.Cursor = Cursors.Default;
        }

        private void invertFormOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Change cursor to wait cursor
            this.Cursor = Cursors.WaitCursor;
            // Invert Form only
            invertForm();
            // Change cursor to default
            this.Cursor = Cursors.Default;
        }

        private void blueInkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Filter blue ink template only
                filterBlueTemplateOnly();
            }
                // Catch Exceptions
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void filterBlueTemplateOnly()
        {
            // Declare image variable
            Bitmap bmp = new Bitmap(templatePb.Image);
            // create filter
            EuclideanColorFiltering filter = new EuclideanColorFiltering();
            // set center color and radius
            filter.CenterColor = new RGB(255, 143, 63);
            filter.Radius = 100;
            // apply the filter to the image
            filter.ApplyInPlace(bmp);
            // Display result on picturebox
            templatePb.Image = bmp;
        }

        private void filterGreenTemplateOnly()
        {
            // Declare image variable
            Bitmap bmp = new Bitmap(templatePb.Image);
            // create filter
            EuclideanColorFiltering filter = new EuclideanColorFiltering();
            // set center color and radius
            filter.CenterColor = new RGB(255, 79, 175);
            filter.Radius = 100;
            // apply the filter to the image
            filter.ApplyInPlace(bmp);
            // Display result on picturebox
            templatePb.Image = bmp;

        }

        private void filterRedTemplateOnly()
        {
            // Declare image variable
            Bitmap bmp = new Bitmap(templatePb.Image);
            // create filter
            EuclideanColorFiltering filter = new EuclideanColorFiltering();
            // set center color and radius
            filter.CenterColor = new RGB(0, 255, 255);
            filter.Radius = 100;
            // apply the filter to the image
            filter.ApplyInPlace(bmp);
            // Display result on picturebox
            templatePb.Image = bmp;
           
        }

        private void greenInkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Filter green ink template only
                filterGreenTemplateOnly();
            }
            // Catch Exceptions
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void redInkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Filter red ink template only
                filterRedTemplateOnly();
            }
            // Catch Exceptions
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void blueInkToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                // Filter blue ink form only
                filterBlueFormOnly();
            }
            // Catch Exceptions
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void filterBlueFormOnly()
        {
            // Declare image variable
            Bitmap bmp2 = new Bitmap(formPb.Image);
            // create filter
            EuclideanColorFiltering filter = new EuclideanColorFiltering();
            // set center color and radius
            filter.CenterColor = new RGB(255, 143, 63);
            filter.Radius = 100;
            // apply the filter to the image
            filter.ApplyInPlace(bmp2);
            // Display result on picturebox
            formPb.Image = bmp2;
        }

        private void filterGreenformOnly()
        {
            // Declare image variable
            Bitmap bmp2 = new Bitmap(formPb.Image);
            // create filter
            EuclideanColorFiltering filter = new EuclideanColorFiltering();
            // set center color and radius
            filter.CenterColor = new RGB(255, 79, 175);
            filter.Radius = 100;
            // apply the filter to the image
            filter.ApplyInPlace(bmp2);
            // Display result on picturebox
            formPb.Image = bmp2;

        }

        private void filterRedformOnly()
        {
            // Declare image variable
            Bitmap bmp2 = new Bitmap(formPb.Image);
            // create filter
            EuclideanColorFiltering filter = new EuclideanColorFiltering();
            // set center color and radius
            filter.CenterColor = new RGB(0, 255, 255);
            filter.Radius = 100;
            // apply the filter to the image
            filter.ApplyInPlace(bmp2);
            // Display result on picturebox
            formPb.Image = bmp2;

        }

        private void greenInkToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                // Filter green ink form only
                filterGreenformOnly();
            }
            // Catch Exceptions
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void redInkToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                // Filter red ink form only
                filterRedformOnly();
            }
            // Catch Exceptions
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void markFormAndRetainTemplate()
        {
            // Catch exceptions
            try
            {

                // Declare images
                Bitmap bmp = new Bitmap(templatePb.Image);
                Bitmap bmp2 = new Bitmap(formPb.Image);

                // Blob counter algorithm for the template and form
                BlobCounter blobCounter = new BlobCounter();
                BlobCounter blobCounter2 = new BlobCounter();

                // Filter blobs
                blobCounter.FilterBlobs = true;
                blobCounter2.FilterBlobs = true;

                // Minimum width and minimum height to consider
                blobCounter.MinWidth = 10;
                blobCounter.MinHeight = 10;
                blobCounter2.MinWidth = 10;
                blobCounter2.MinHeight = 10;

                // Process image
                blobCounter.ProcessImage(bmp);
                blobCounter2.ProcessImage(bmp2);

                // Array of rectangles
                Rectangle[] rects = blobCounter.GetObjectsRectangles();
                Rectangle[] rects2 = blobCounter2.GetObjectsRectangles();

                // Rectangular objects in the image
                foreach (Rectangle objectRect in rects)
                {
                    if (rects.Length > 0)
                    {
                        // Add all the items in the template to the listbox
                        lb.Items.Add(objectRect);

                        // Rectangular objects in the image2
                        foreach (Rectangle objectRect2 in rects2)
                        {
                            if (rects2.Length > 0)
                            {

                                // Boolean variable comparing both objects
                                bool blobFE = true;
                                blobFE = objectRect2.X.Equals(objectRect.X) && objectRect2.Y.Equals(objectRect.Y);

                                // If blob location is equal in both images
                                if (blobFE)
                                {
                                    // Add 1 mark to the score
                                    lbscore.Items.Add(1);
                                    // Exit loop
                                    break;
                                }

                                // If blob is not found or blob location in both images are not equal, do nothing
                                else
                                { }

                                // Close loops
                            }
                        }
                    }
                }

                // Declare the variable to sum up items on the listbox
                int sum = 0;
                // Display labelbox
                lblScore.Visible = true;
                // Set the text property of the Labelbox
                lblScore.Text = Convert.ToString("Total score =");
                // Display textbox
                txtScore.Visible = true;
                // Score represents each item in the list box
                foreach (object score in lbscore.Items)
                {
                    // Add up only the correct answers
                    if (score.Equals(1))
                    {
                        // If the students' number of fills is less than or equal to the number of required answers
                        if (blobCounter2.ObjectsCount <= blobCounter.ObjectsCount)
                        {
                            // Add up all the items in the listbox
                            sum = sum + 1;

                            // Display the result on the textbox
                            txtScore.Text = Convert.ToString(sum + " " + "/" + " " + lb.Items.Count);
                        }
                        // If the students' number of fills exceed the number of required answers
                        else if (blobCounter2.ObjectsCount > blobCounter.ObjectsCount)
                        {
                            // Get the number of extra fills
                            int d = blobCounter2.ObjectsCount - blobCounter.ObjectsCount;
                            // Multiply the number of extra fills by 2
                            int f = (d * 2);
                            // Add up all the items in the listbox
                            sum = sum + 1;
                            // Substract the doubled extra fills from the total score
                            int g = sum - f;
                            // Display the result on the textbox
                            txtScore.Text = ("Total mark=" + " " + g + "/" + blobCounter.ObjectsCount);
                        }
                    }
                }
                // Display result on messagebox
                MessageBox.Show("This student scored:" + " " + txtScore.Text, "Total score");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }


        private void templateAndFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Resize image
            resizeImage640x594pixels();
        }

        private void templateOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear label box
                lblWH.Text = "";
                // Declare image variable
                Bitmap bmp = new Bitmap(templatePb.Image);
                // Declare new size of both image
                Size newSize = new Size(640, 594);
                // Apply new size to image
                bmp = new Bitmap(templatePb.Image, newSize);
                // Display result on picturebox
                templatePb.Image = bmp;
                // Make image to fit picturebox
                templatePb.SizeMode = PictureBoxSizeMode.AutoSize;
                // Display width and height on label box
                lblWH.Text = Convert.ToString("Width=" + " " + bmp.Width + "," + " " + "Height=" + " " + bmp.Height);
            }
            // Catch exceptions
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            
        }

        private void formOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear label box
                lblWH.Text = "";
                // Declare image variable
                Bitmap bmp2 = new Bitmap(formPb.Image);
                // Declare new size of both image
                Size newSize = new Size(640, 594);
                // Apply new size to image
                bmp2 = new Bitmap(formPb.Image, newSize);
                // Display result on picturebox
                formPb.Image = bmp2;
                // Make image to fit picturebox
                formPb.SizeMode = PictureBoxSizeMode.AutoSize;
                // Display width and height on label box
                lblWH.Text = Convert.ToString("Width=" + " " + bmp2.Width + "," + " " + "Height=" + " " + bmp2.Height);
            }
            // Catch exceptions
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            
        }

        private void templatePb_Click(object sender, EventArgs e)
        { }

        private void formPb_Click(object sender, EventArgs e)
        { }

        private void correctContrast()
        {
            Bitmap bmp = new Bitmap(templatePb.Image);
            Bitmap bmp2 = new Bitmap(formPb.Image);
            // create filter
            ContrastCorrection filter = new ContrastCorrection(15);
            // apply the filter
            filter.ApplyInPlace(bmp);
            filter.ApplyInPlace(bmp2);
            templatePb.Image = bmp;
            formPb.Image = bmp2;
        }

        private void pointedmeanfloodFill()
        {
            Bitmap bmp = new Bitmap(templatePb.Image);
            Bitmap bmp2 = new Bitmap(formPb.Image);
            var clonedbmp = AForge.Imaging.Image.Clone(bmp, PixelFormat.Format24bppRgb);
            var clonedbmp2 = AForge.Imaging.Image.Clone(bmp2, PixelFormat.Format24bppRgb);
            // create filter
            PointedMeanFloodFill filter = new PointedMeanFloodFill();
            // configure the filter
            filter.Tolerance = Color.FromArgb(150, 92, 92);
            filter.StartingPoint = new IntPoint(150, 100);
            // apply the filter
            filter.ApplyInPlace(clonedbmp);
            filter.ApplyInPlace(clonedbmp2);
            templatePb.Image = clonedbmp;
            formPb.Image = clonedbmp2;
        }

        private void grayscale()
        {
            Bitmap bmp = new Bitmap(templatePb.Image);
            Bitmap bmp2 = new Bitmap(formPb.Image);
            // create grayscale filter (BT709)
            Grayscale filter = new Grayscale(0.2125, 0.7154, 0.0721);
            // apply the filter
            Bitmap grayImage = filter.Apply(bmp);
            Bitmap grayImage2 = filter.Apply(bmp2);
            templatePb.Image = grayImage;
            formPb.Image = grayImage2;
        }

        private void medianFiltering()
        {
            // Median filtering
            Bitmap bmp = new Bitmap(templatePb.Image);
            Bitmap bmp2 = new Bitmap(formPb.Image);
            // create filter
            Median filter = new Median();
            // apply the filter
            filter.ApplyInPlace(bmp);
            filter.ApplyInPlace(bmp2);
            templatePb.Image = bmp;
            formPb.Image = bmp2;
        }

        private void bilateralFiltering()
        {
              //Bilateral smoothing filters
            Bitmap bmp = new Bitmap(templatePb.Image);
            Bitmap bmp2 = new Bitmap(formPb.Image);
            // create filter
            BilateralSmoothing filter = new BilateralSmoothing();
            filter.KernelSize = 7;
            filter.SpatialFactor = 10;
            filter.ColorFactor = 60;
            filter.ColorPower = 0.5;
            // apply the filter
            filter.ApplyInPlace(bmp);
            filter.ApplyInPlace(bmp2);
            templatePb.Image = bmp;
            formPb.Image = bmp2;
        }

        private void removeExcessNoiseToolStripMenuItem_Click(object sender, EventArgs e)
        { }

        private void templateAndFormToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Apply several filters
            correctContrast();
            pointedmeanfloodFill();
            grayscale();
            medianFiltering();
            bilateralFiltering();
        }

        private void correctContrastTemplateonly()
        {
            Bitmap bmp = new Bitmap(templatePb.Image);
            // create filter
            ContrastCorrection filter = new ContrastCorrection(15);
            // apply the filter
            filter.ApplyInPlace(bmp);
            templatePb.Image = bmp;
        }

        private void pointedmeanfloodFillTemplateonly()
        {
            Bitmap bmp = new Bitmap(templatePb.Image);
            var clonedbmp = AForge.Imaging.Image.Clone(bmp, PixelFormat.Format24bppRgb);
            // create filter
            PointedMeanFloodFill filter = new PointedMeanFloodFill();
            // configure the filter
            filter.Tolerance = Color.FromArgb(150, 92, 92);
            filter.StartingPoint = new IntPoint(150, 100);
            // apply the filter
            filter.ApplyInPlace(clonedbmp);
            templatePb.Image = clonedbmp;
        }

        private void grayscaleTemplateonly()
        {
            Bitmap bmp = new Bitmap(templatePb.Image);
            // create grayscale filter (BT709)
            Grayscale filter = new Grayscale(0.2125, 0.7154, 0.0721);
            // apply the filter
            Bitmap grayImage = filter.Apply(bmp);
            templatePb.Image = grayImage;
        }

        private void medianFilteringTemplateonly()
        {
            // Median filtering
            Bitmap bmp = new Bitmap(templatePb.Image);
            // create filter
            Median filter = new Median();
            // apply the filter
            filter.ApplyInPlace(bmp);
            templatePb.Image = bmp;
        }

        private void bilateralFilteringTemplateonly()
        {
            //Bilateral smoothing filters
            Bitmap bmp = new Bitmap(templatePb.Image);
            // create filter
            BilateralSmoothing filter = new BilateralSmoothing();
            filter.KernelSize = 7;
            filter.SpatialFactor = 10;
            filter.ColorFactor = 60;
            filter.ColorPower = 0.5;
            // apply the filter
            filter.ApplyInPlace(bmp);
            templatePb.Image = bmp;
        }

        private void correctContrastFormonly()
        {
            Bitmap bmp2 = new Bitmap(formPb.Image);
            // create filter
            ContrastCorrection filter = new ContrastCorrection(15);
            // apply the filter
            filter.ApplyInPlace(bmp2);
            formPb.Image = bmp2;
        }

        private void pointedmeanfloodFillFormonly()
        {
            Bitmap bmp2 = new Bitmap(formPb.Image);
            var clonedbmp2 = AForge.Imaging.Image.Clone(bmp2, PixelFormat.Format24bppRgb);
            // create filter
            PointedMeanFloodFill filter = new PointedMeanFloodFill();
            // configure the filter
            filter.Tolerance = Color.FromArgb(150, 92, 92);
            filter.StartingPoint = new IntPoint(150, 100);
            // apply the filter
            filter.ApplyInPlace(clonedbmp2);
            formPb.Image = clonedbmp2;
        }

        private void grayscaleFormonly()
        {
            Bitmap bmp2 = new Bitmap(formPb.Image);
            // create grayscale filter (BT709)
            Grayscale filter = new Grayscale(0.2125, 0.7154, 0.0721);
            // apply the filter
            Bitmap grayImage2 = filter.Apply(bmp2);
            formPb.Image = grayImage2;
        }

        private void medianFilteringFormonly()
        {
            // Median filtering
            Bitmap bmp2 = new Bitmap(formPb.Image);
            // create filter
            Median filter = new Median();
            // apply the filter
            filter.ApplyInPlace(bmp2);
            formPb.Image = bmp2;
        }

        private void bilateralFilteringFormonly()
        {
            //Bilateral smoothing filters
            Bitmap bmp2 = new Bitmap(formPb.Image);
            // create filter
            BilateralSmoothing filter = new BilateralSmoothing();
            filter.KernelSize = 7;
            filter.SpatialFactor = 10;
            filter.ColorFactor = 60;
            filter.ColorPower = 0.5;
            // apply the filter
            filter.ApplyInPlace(bmp2);
            formPb.Image = bmp2;
        }

        private void templateOnlyToolStripMenuItem1_Click(object sender, EventArgs e)
        {     
            //Apply several filters
            correctContrastTemplateonly();
            pointedmeanfloodFillTemplateonly();
            grayscaleTemplateonly();
            medianFilteringTemplateonly();
            bilateralFilteringTemplateonly();
        }

        private void formOnlyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //// Apply several filters
            correctContrastFormonly();
            pointedmeanfloodFillFormonly();
            grayscaleFormonly();
            medianFilteringFormonly();
            bilateralFilteringFormonly();
        }
     }
    }
