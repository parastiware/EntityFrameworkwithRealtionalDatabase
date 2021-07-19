using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Employee employee = new Employee();
        employee_college_details empdetail = new employee_college_details();
        DbEmployeeEntities db = new DbEmployeeEntities();
        public string gender = "M";
        bool updateRecord = false;

        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            populateDataGridViewEmployee();
            clear();

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            employee.FName = textBoxFName.Text.Trim();
            employee.LName = textBoxLName.Text.Trim();
            employee.MName = textBoxMName.Text.Trim();
            employee.Address = textBoxAddress.Text.Trim();
            employee.Department = textBoxDepartment.Text.Trim();
            employee.Gender = gender;

            if (updateRecord)

            {
                // uodate EMployee Data
                var id = Convert.ToInt32(dataGridViewEmployee.CurrentRow.Cells["Employee_Id"].Value);
                Employee olddata = db.Employees.Find(id);
                olddata.FName = textBoxFName.Text;
                olddata.MName = textBoxMName.Text;
                olddata.Address = textBoxAddress.Text;
                olddata.Department = textBoxDepartment.Text;
                olddata.Gender = gender;
                empdetail = olddata.employee_college_details.FirstOrDefault();
                empdetail.college_name = textBoxCollegeName.Text;
                empdetail.college_address = textBoxCollegeAddress.Text;
                db.Entry(olddata).State = EntityState.Modified;
                db.Entry(empdetail).State = EntityState.Modified;

                db.SaveChanges();

                updateRecord = false;



            }
            else
            {
                //Save EMployeeData 
                employee.FName = textBoxFName.Text;
                employee.MName = textBoxMName.Text;
                employee.Address = textBoxAddress.Text;
                employee.Department = textBoxDepartment.Text;
                employee.Gender = gender;

                //Save EMployee college Data

                empdetail.college_name = textBoxCollegeName.Text;
                empdetail.college_address = textBoxCollegeAddress.Text;
                employee.employee_college_details.Add(empdetail);
                db.Employees.Add(employee);
                db.SaveChanges();
                MessageBox.Show("Record saved successfully");

            }

            clear();
            populateDataGridViewEmployee();
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            clear();
        }
        void clear()
        {
            textBoxFName.Text = textBoxAddress.Text = textBoxMName.Text = textBoxLName.Text = textBoxDepartment.Text = textBoxCollegeName.Text = textBoxCollegeAddress.Text = "";
            radioButtonMale.Checked = true;
            buttonDelete.Enabled = false;
            buttonDelete.BackColor = Color.Transparent;
            buttonSave.Text = "Save";

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("You surely want to delete this record", "Alert!!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                employee.Id = Convert.ToInt32(dataGridViewEmployee.CurrentRow.Cells["Employee_Id"].Value);

                employee = db.Employees.Find(employee.Id);
                empdetail = employee.employee_college_details.FirstOrDefault();
                db.employee_college_details.Attach(empdetail);
                db.employee_college_details.Remove(empdetail);
                db.Employees.Attach(employee);
                db.Employees.Remove(employee);

                db.SaveChanges();
                clear();
                populateDataGridViewEmployee();

            }
            else if (dialogResult == DialogResult.No)
            {
            }


        }
        void populateDataGridViewEmployee()
        {
            dataGridViewEmployee.Rows.Clear();
            var employeeData = db.Employees.ToList();
            int i = 0;
            try
            {
                foreach (var employee in employeeData)
                {
                    dataGridViewEmployee.Rows.Add();
                    dataGridViewEmployee.Rows[i].Cells[0].Value = employee.Id;
                    dataGridViewEmployee.Rows[i].Cells[1].Value = employee.FName;
                    dataGridViewEmployee.Rows[i].Cells[2].Value = employee.MName;
                    dataGridViewEmployee.Rows[i].Cells[3].Value = employee.LName;
                    dataGridViewEmployee.Rows[i].Cells[4].Value = employee.Address;
                    dataGridViewEmployee.Rows[i].Cells[5].Value = employee.Gender;
                    dataGridViewEmployee.Rows[i].Cells[6].Value = employee.employee_college_details.FirstOrDefault()?.college_name;
                    dataGridViewEmployee.Rows[i].Cells[7].Value = employee.employee_college_details.FirstOrDefault()?.college_address;
                    dataGridViewEmployee.Rows[i].Cells[8].Value = employee.Department;
                    i++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Array out of bound", ex);
            }


        }





        private void radioButtonMale_Checked(object sender, EventArgs e)
        {
            gender = "M";
        }



        private void radioFemale_Checked(object sender, EventArgs e)
        {
            gender = "F";
        }

        private void radioOthers_Checked(object sender, EventArgs e)
        {
            gender = "O";
        }



        private void EmployeeCellDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dataGridViewEmployee.CurrentRow.Index != -1)
                {
                    employee.Id = Convert.ToInt32(dataGridViewEmployee.CurrentRow.Cells["Employee_Id"].Value);


                    employee = db.Employees.Find(employee.Id);
                    try
                    {
                        textBoxFName.Text = employee.FName;
                        textBoxMName.Text = employee.MName;
                        textBoxLName.Text = employee.LName;
                        switch (employee.Gender)
                        {
                            case "M":
                                radioButtonMale.Checked = true;
                                break;
                            case "F":
                                radioButtonFemale.Checked = true;
                                break;
                            case "O":
                                radioButtonOthers.Checked = true;
                                break;
                        }

                        textBoxAddress.Text = employee.Address;
                        empdetail = employee.employee_college_details.FirstOrDefault();
                        textBoxDepartment.Text = employee.Department;
                        textBoxCollegeName.Text = empdetail.college_name;
                        textBoxCollegeAddress.Text = empdetail.college_address;

                    }
                    catch (NullReferenceException ex)
                    {
                        Console.WriteLine("Exception occured", ex);


                    }
                    updateRecord = true;
                    buttonDelete.Enabled = true;
                    buttonDelete.BackColor = Color.Red;
                    buttonSave.Text = "Update";

                }
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("select valid row", ex);
            }

        }
    }
}
