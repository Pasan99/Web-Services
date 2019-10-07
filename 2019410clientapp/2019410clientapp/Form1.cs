using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using _2019410clientapp.ServiceReference1;// add the namespace

namespace _2019410clientapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // method for display data on dataGridView
        bool displayTable()
        {
            try{
                WebService1SoapClient y = new WebService1SoapClient();
                List<Student> students = y.GetStudent().ToList();
                dgvstudent.DataSource = students;
                return true;
            }
            catch(Exception i){
                return false;
            }
        }

        // when the form loads to screen
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!(displayTable()))
            {
                ErrorMessage.Text = "Sever Not Found";
            }
        }


        // Data Grid VIew Item Click Listner
        private void dgvstudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // get the row index from sender
            int row = e.RowIndex;
            // fill data from table
            if (row != -1)
            {
                lblid.Text = dgvstudent.Rows[row].Cells[0].Value.ToString();
                nametxt.Text = dgvstudent.Rows[row].Cells[1].Value.ToString();
                addresstxt.Text = dgvstudent.Rows[row].Cells[2].Value.ToString();
                agetxt.Text = dgvstudent.Rows[row].Cells[3].Value.ToString();
            }
        }


        // Add Student
        private void AddButtonClick(object sender, EventArgs e)
        {
            // avoid adding student when updating
            if (this.isUpadating())
            {
                ErrorMessage.ForeColor = Color.Red;
                ErrorMessage.Text = "Please Clear Textboxes Before adding new record";
                return;
            }
            // avoid null entries
            if (this.isNullTextBoxes())
            {
                return;
            }

            // get data from text boxes
            Student s = new Student();
            s.Address = addresstxt.Text;
            s.Student_Name = nametxt.Text;
            s.Age = Convert.ToInt32(agetxt.Text);

            try
            {
                // use the stub 
                WebService1SoapClient y = new WebService1SoapClient();
                // call method using stub
                if (y == null || !(y.AddStudent(s)))
                {
                    ErrorMessage.Text = "Operation Not Successfull";
                }
            }catch(Exception i)
            {
                ErrorMessage.Text = "Sever Not Available (" + i.Message + ")";
            }

            // display the result
            this.displayTable();
            this.ClearTextBoxes();

            ErrorMessage.ForeColor = Color.Green;
            ErrorMessage.Text = "Record Added Succesfully";
        }


        // Update Student
        private void UpdateButtonClick(object sender, EventArgs e)
        {
            // avoid null entries
            if (this.isNullTextBoxes()) {return;}

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to Update student with ID Number "
                + lblid.Text + " (" + nametxt.Text + ") ?",
                "Delete", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                // get data from text boxes
                Student s = new Student();
                s.Student_ID = Convert.ToInt32(lblid.Text);
                s.Address = addresstxt.Text;
                s.Student_Name = nametxt.Text;
                s.Age = Convert.ToInt32(agetxt.Text);

                try
                {
                    // use the stub 
                    WebService1SoapClient y = new WebService1SoapClient();
                    // call method using stub
                    if ( y == null || !(y.UpdateStudent(s)))
                    {
                        ErrorMessage.Text = "Operation Not Successfull";
                    }
                }
                catch (Exception i)
                {
                    ErrorMessage.Text = "Sever Not Available (" + i.Message + ")";
                }

                // display the result
                this.displayTable();
                this.ClearTextBoxes();
            }

        }

        // Delete Student
        private void DeleteButtonClick(object sender, EventArgs e)
        {
            // avoid null entries
            if (this.isNullTextBoxes()) { return; }

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete student with ID Number "
                + lblid.Text + " ("+ nametxt.Text + ")?", 
                "Delete", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                int studentID = Convert.ToInt32(lblid.Text);

                try
                {
                    // use the stub 
                    WebService1SoapClient y = new WebService1SoapClient();
                    // call method using stub
                    if ( y.t == null || !(y.DeleteStudent(studentID)))
                    {
                        ErrorMessage.Text = "Operation Not Successfull";
                    }
                }
                catch (Exception i)
                {
                    ErrorMessage.Text = "Sever Not Available (" + i.Message + ")";
                }

                // display the result
                this.displayTable();
                this.ClearTextBoxes();
            }
        }

        // Clear Text Boxes 
        void ClearTextBoxes()
        {
            lblid.Text = "";
            nametxt.Text = "";
            addresstxt.Text = "";
            agetxt.Text = "";
            ErrorMessage.Text = "";
        }

        private void ClearButtonClick(object sender, EventArgs e)
        {
            this.ClearTextBoxes();
        }


        private bool isUpadating()
        {
            if (lblid.Text == null || lblid.Text.Equals(null) || lblid.Text.Equals(""))
            {
                return false;
            }
            return true;
        }

        // find whether text fields are null or not
        private bool isNullTextBoxes()
        {
            if ( nametxt.Text == null || nametxt.Text.Equals(""))
            {
                ErrorMessage.ForeColor = Color.Red;
                ErrorMessage.Text = "Please Enter the Name";
                return true;
            }
            else if ( addresstxt.Text == null || addresstxt.Text.Equals(""))
            {
                ErrorMessage.ForeColor = Color.Red;
                ErrorMessage.Text = "Please Enter the Address";
                return true;
            }
            else if ( agetxt.Text == null || agetxt.Text.Equals("") )
            {
                ErrorMessage.ForeColor = Color.Red;
                ErrorMessage.Text = "Please Enter the Age";
                return true;
            }
            return false;
        }

    }
}
