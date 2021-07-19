
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxMName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCollege = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxDepartment = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonOthers = new System.Windows.Forms.RadioButton();
            this.textBoxCollegeName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCollegeAddress = new System.Windows.Forms.TextBox();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.employeeDbDemoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeDbDemoDataSet = new WindowsFormsApp1.EmployeeDbDemoDataSet();
            this.label11 = new System.Windows.Forms.Label();
            this.employeecollegedetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employee_college_detailsTableAdapter = new WindowsFormsApp1.EmployeeDbDemoDataSetTableAdapters.employee_college_detailsTableAdapter();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new WindowsFormsApp1.EmployeeDbDemoDataSetTableAdapters.EmployeeTableAdapter();
            this.employeecollegedetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Employee_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CollegeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CollegeAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartMent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeecollegedetailsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.employeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDbDemoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDbDemoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeecollegedetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeecollegedetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeecollegedetailsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSave.Location = new System.Drawing.Point(22, 303);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(102, 29);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Red;
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonDelete.Location = new System.Drawing.Point(129, 303);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(102, 29);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonCancel.Location = new System.Drawing.Point(238, 303);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(102, 29);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxFName
            // 
            this.textBoxFName.Location = new System.Drawing.Point(12, 109);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(165, 20);
            this.textBoxFName.TabIndex = 2;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(200, 156);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(172, 20);
            this.textBoxAddress.TabIndex = 2;
            // 
            // textBoxMName
            // 
            this.textBoxMName.Location = new System.Drawing.Point(200, 109);
            this.textBoxMName.Name = "textBoxMName";
            this.textBoxMName.Size = new System.Drawing.Size(172, 20);
            this.textBoxMName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(208, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(208, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Middle Name:";
            // 
            // labelCollege
            // 
            this.labelCollege.AutoSize = true;
            this.labelCollege.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCollege.Location = new System.Drawing.Point(13, 233);
            this.labelCollege.Name = "labelCollege";
            this.labelCollege.Size = new System.Drawing.Size(102, 15);
            this.labelCollege.TabIndex = 3;
            this.labelCollege.Text = "College Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Employee Details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(529, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Employee Table";
            // 
            // textBoxLName
            // 
            this.textBoxLName.Location = new System.Drawing.Point(12, 156);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(165, 20);
            this.textBoxLName.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "First Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "Department:";
            // 
            // textBoxDepartment
            // 
            this.textBoxDepartment.Location = new System.Drawing.Point(12, 197);
            this.textBoxDepartment.Name = "textBoxDepartment";
            this.textBoxDepartment.Size = new System.Drawing.Size(165, 20);
            this.textBoxDepartment.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(208, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 15);
            this.label10.TabIndex = 3;
            this.label10.Text = "Gender:";
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(199, 200);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(48, 17);
            this.radioButtonMale.TabIndex = 5;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            this.radioButtonMale.Click += new System.EventHandler(this.radioButtonMale_Checked);
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(250, 200);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(59, 17);
            this.radioButtonFemale.TabIndex = 5;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            this.radioButtonFemale.Click += new System.EventHandler(this.radioFemale_Checked);
            // 
            // radioButtonOthers
            // 
            this.radioButtonOthers.AutoSize = true;
            this.radioButtonOthers.Location = new System.Drawing.Point(312, 200);
            this.radioButtonOthers.Name = "radioButtonOthers";
            this.radioButtonOthers.Size = new System.Drawing.Size(56, 17);
            this.radioButtonOthers.TabIndex = 5;
            this.radioButtonOthers.TabStop = true;
            this.radioButtonOthers.Text = "Others";
            this.radioButtonOthers.UseVisualStyleBackColor = true;
            this.radioButtonOthers.MouseCaptureChanged += new System.EventHandler(this.radioOthers_Checked);
            // 
            // textBoxCollegeName
            // 
            this.textBoxCollegeName.Location = new System.Drawing.Point(12, 251);
            this.textBoxCollegeName.Name = "textBoxCollegeName";
            this.textBoxCollegeName.Size = new System.Drawing.Size(165, 20);
            this.textBoxCollegeName.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(208, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "College Address:";
            // 
            // textBoxCollegeAddress
            // 
            this.textBoxCollegeAddress.Location = new System.Drawing.Point(200, 251);
            this.textBoxCollegeAddress.Name = "textBoxCollegeAddress";
            this.textBoxCollegeAddress.Size = new System.Drawing.Size(172, 20);
            this.textBoxCollegeAddress.TabIndex = 2;
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.AllowUserToDeleteRows = false;
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Employee_Id,
            this.FirstName,
            this.MiddleName,
            this.LastName,
            this.Address,
            this.EmpGender,
            this.CollegeName,
            this.CollegeAddress,
            this.DepartMent});
            this.dataGridViewEmployee.Location = new System.Drawing.Point(388, 65);
            this.dataGridViewEmployee.MultiSelect = false;
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.ReadOnly = true;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(409, 279);
            this.dataGridViewEmployee.TabIndex = 6;
            this.dataGridViewEmployee.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.EmployeeCellDoubleClick);
            // 
            // employeeDbDemoDataSetBindingSource
            // 
            this.employeeDbDemoDataSetBindingSource.DataSource = this.employeeDbDemoDataSet;
            this.employeeDbDemoDataSetBindingSource.Position = 0;
            // 
            // employeeDbDemoDataSet
            // 
            this.employeeDbDemoDataSet.DataSetName = "EmployeeDbDemoDataSet";
            this.employeeDbDemoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(521, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "(Double click row  to Edit data)";
            // 
            // employeecollegedetailsBindingSource
            // 
            this.employeecollegedetailsBindingSource.DataMember = "employee_college_details";
            this.employeecollegedetailsBindingSource.DataSource = this.employeeDbDemoDataSetBindingSource;
            // 
            // employee_college_detailsTableAdapter
            // 
            this.employee_college_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.employeeDbDemoDataSetBindingSource;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // employeecollegedetailsBindingSource1
            // 
            this.employeecollegedetailsBindingSource1.DataMember = "employee_college_details";
            this.employeecollegedetailsBindingSource1.DataSource = this.employeeDbDemoDataSetBindingSource;
            // 
            // Employee_Id
            // 
            this.Employee_Id.DataPropertyName = "Id";
            this.Employee_Id.HeaderText = "Id";
            this.Employee_Id.Name = "Employee_Id";
            this.Employee_Id.ReadOnly = true;
            this.Employee_Id.Visible = false;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // MiddleName
            // 
            this.MiddleName.DataPropertyName = "MName";
            this.MiddleName.HeaderText = "Middle Name";
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LName";
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // EmpGender
            // 
            this.EmpGender.DataPropertyName = "Gender";
            this.EmpGender.HeaderText = "Gender";
            this.EmpGender.Name = "EmpGender";
            this.EmpGender.ReadOnly = true;
            // 
            // CollegeName
            // 
            this.CollegeName.DataPropertyName = "college_name";
            this.CollegeName.HeaderText = "College Name";
            this.CollegeName.Name = "CollegeName";
            this.CollegeName.ReadOnly = true;
            // 
            // CollegeAddress
            // 
            this.CollegeAddress.DataPropertyName = "college_address";
            this.CollegeAddress.HeaderText = "College Address";
            this.CollegeAddress.Name = "CollegeAddress";
            this.CollegeAddress.ReadOnly = true;
            // 
            // DepartMent
            // 
            this.DepartMent.DataPropertyName = "Department";
            this.DepartMent.HeaderText = "Department";
            this.DepartMent.Name = "DepartMent";
            this.DepartMent.ReadOnly = true;
            // 
            // employeecollegedetailsBindingSource2
            // 
            this.employeecollegedetailsBindingSource2.DataMember = "employee_college_details";
            this.employeecollegedetailsBindingSource2.DataSource = this.employeeDbDemoDataSetBindingSource;
            // 
            // employeeBindingSource1
            // 
            this.employeeBindingSource1.DataMember = "Employee";
            this.employeeBindingSource1.DataSource = this.employeeDbDemoDataSetBindingSource;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridViewEmployee);
            this.Controls.Add(this.radioButtonOthers);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.radioButtonMale);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelCollege);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMName);
            this.Controls.Add(this.textBoxCollegeAddress);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxCollegeName);
            this.Controls.Add(this.textBoxDepartment);
            this.Controls.Add(this.textBoxLName);
            this.Controls.Add(this.textBoxFName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDbDemoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDbDemoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeecollegedetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeecollegedetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeecollegedetailsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

      
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxMName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCollege;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource customerDemoDbDataSetBindingSource;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAdderssDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxDepartment;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonOthers;
        private System.Windows.Forms.TextBox textBoxCollegeName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCollegeAddress;
        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource employeeDbDemoDataSetBindingSource;
        private EmployeeDbDemoDataSet employeeDbDemoDataSet;
        private System.Windows.Forms.BindingSource employeecollegedetailsBindingSource;
        private EmployeeDbDemoDataSetTableAdapters.employee_college_detailsTableAdapter employee_college_detailsTableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private EmployeeDbDemoDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn CollegeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CollegeAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartMent;
        private System.Windows.Forms.BindingSource employeecollegedetailsBindingSource1;
        private System.Windows.Forms.BindingSource employeeBindingSource1;
        private System.Windows.Forms.BindingSource employeecollegedetailsBindingSource2;
    }
}

