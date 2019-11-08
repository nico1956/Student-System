namespace StudentSystem
{
    partial class AssignmentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignmentsForm));
            this.assignGrid = new System.Windows.Forms.DataGridView();
            this.AssignmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.returnBtn = new System.Windows.Forms.Button();
            this.stuListbox = new System.Windows.Forms.ListBox();
            this.errorBox = new System.Windows.Forms.TextBox();
            this.mainFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.assignGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // assignGrid
            // 
            this.assignGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assignGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AssignmentName,
            this.Points,
            this.MaxPoints});
            this.assignGrid.Location = new System.Drawing.Point(98, 319);
            this.assignGrid.Name = "assignGrid";
            this.assignGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.assignGrid.Size = new System.Drawing.Size(543, 185);
            this.assignGrid.TabIndex = 0;
            // 
            // AssignmentName
            // 
            this.AssignmentName.HeaderText = "Assignment Name";
            this.AssignmentName.Name = "AssignmentName";
            this.AssignmentName.ToolTipText = "Assignement Name";
            this.AssignmentName.Width = 300;
            // 
            // Points
            // 
            this.Points.HeaderText = "Points";
            this.Points.MaxInputLength = 3;
            this.Points.Name = "Points";
            this.Points.ToolTipText = "Points earned";
            // 
            // MaxPoints
            // 
            this.MaxPoints.HeaderText = "Max Points";
            this.MaxPoints.MaxInputLength = 3;
            this.MaxPoints.Name = "MaxPoints";
            this.MaxPoints.ToolTipText = "Maxium points possible";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(266, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Meal Plan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(209, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Dorm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(95, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Student Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(61, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "ID";
            // 
            // saveBtn
            // 
            this.saveBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.saveBtn.Location = new System.Drawing.Point(508, 112);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(121, 34);
            this.saveBtn.TabIndex = 25;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // returnBtn
            // 
            this.returnBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.returnBtn.Location = new System.Drawing.Point(508, 174);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(121, 34);
            this.returnBtn.TabIndex = 26;
            this.returnBtn.Text = "Return";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // stuListbox
            // 
            this.stuListbox.FormattingEnabled = true;
            this.stuListbox.Location = new System.Drawing.Point(56, 84);
            this.stuListbox.Name = "stuListbox";
            this.stuListbox.ScrollAlwaysVisible = true;
            this.stuListbox.Size = new System.Drawing.Size(384, 173);
            this.stuListbox.TabIndex = 27;
            this.stuListbox.SelectedIndexChanged += new System.EventHandler(this.stuListbox_SelectedIndexChanged);
            // 
            // errorBox
            // 
            this.errorBox.BackColor = System.Drawing.SystemColors.Menu;
            this.errorBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.errorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.errorBox.ForeColor = System.Drawing.Color.Red;
            this.errorBox.Location = new System.Drawing.Point(123, 282);
            this.errorBox.Name = "errorBox";
            this.errorBox.Size = new System.Drawing.Size(494, 13);
            this.errorBox.TabIndex = 28;
            this.errorBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mainFormBindingSource
            // 
            this.mainFormBindingSource.DataSource = typeof(StudentSystem.MainForm);
            // 
            // AssignmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 549);
            this.Controls.Add(this.errorBox);
            this.Controls.Add(this.stuListbox);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.assignGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AssignmentsForm";
            this.Text = "Assignments";
            this.Load += new System.EventHandler(this.AssignmentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.assignGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource mainFormBindingSource;
        private System.Windows.Forms.DataGridView assignGrid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.ListBox stuListbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Points;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxPoints;
        private System.Windows.Forms.TextBox errorBox;
    }
}