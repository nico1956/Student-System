using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace StudentSystem
{
    public partial class AssignmentsForm : Form
    {

        public AssignmentsForm()
        {
            InitializeComponent();
        }

        private void AssignmentsForm_Load(object sender, EventArgs e)
        {
            this.Location = new Point(600, 300);

            //Populate Listbox looping thru student list.
            foreach (var item in MainForm.studentList)
            {
                stuListbox.Items.Add(item.ToString());
            }
        }

        private void stuListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 0;
            assignGrid.Rows.Clear();
            try
            {   
                //Loop thru the assigment list that match the index of the selected student in the listbox. Add data to data grid.
                foreach (var item in MainForm.studentList[stuListbox.SelectedIndex].AssignmentsList)
                {
                    assignGrid.Rows.Add();
                    assignGrid.Rows[i].Cells[0].Value = item.AssignName;
                    assignGrid.Rows[i].Cells[1].Value = item.Points;
                    assignGrid.Rows[i].Cells[2].Value = item.MaxPoints;
                    i++;
                }
            }
            catch (NullReferenceException)
            {
                return;
            }
        }

        //Save button
        private void saveBtn_Click(object sender, EventArgs e)
        {
            //Allocate a new assignment list for the selected student when save button is clicked.
            MainForm.studentList[stuListbox.SelectedIndex].AssignmentsList = new List<Assignments>();  

            //Loop thru the rows in datagrid and pull out data from them
            foreach (DataGridViewRow dgvr in assignGrid.Rows)
            {   
                //Check that the first row is not empty, otherwise student doesn't have any assignment data stored.
                if (dgvr.Cells[0].Value != null)
                {   
                    //Assign name to local var
                    string assignName = dgvr.Cells[0].Value.ToString();
                        
                    //Try catch for invalid points input.
                    try
                    {   
                        //Assign points and max points to local var pulling data from datagrid.
                        double points = Convert.ToDouble(dgvr.Cells[1].Value);
                        double maxp = Convert.ToDouble(dgvr.Cells[2].Value);
                        //Check that points isn't greated than max points. Otherwise print message and don't save
                        if(points > maxp)
                        {
                            errorBox.Text = "Points can't be greater than Maximum points possible!";
                        }
                        else
                        {   
                            //Create new assignment object and pass parameters from the datagrid.
                            Assignments a = new Assignments(assignName, points, maxp);
                            //Add new assignment object to the assignment list of the selected student.
                            MainForm.studentList[stuListbox.SelectedIndex].AssignmentsList.Add(a);
                            errorBox.Text = "";
                        }
                    }
                    catch (FormatException)
                    {
                        errorBox.Text = "Points must be a numeric value!";
                    }
                   
                    //Serialize at each saving to keep data stored.
                    try
                    {
                        using (Stream stream = File.Open("students.ser", FileMode.Create))
                        {
                            BinaryFormatter bin = new BinaryFormatter();
                            bin.Serialize(stream, MainForm.studentList);
                        }
                    }
                    catch (IOException)
                    {
                        return;
                    }
                }
            }
        }

        //Return button
        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm main = new MainForm();
            main.Show();
        }

        //Serialize student list to student file if form is closed using X in top right corner (Not working)
        private void MainFormClosing(Object sender, FormClosingEventArgs e)
        {
            try
            {
                using (Stream stream = File.Open("students.ser", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, MainForm.studentList);
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Error writing file");
            }

            this.Close();
            Application.Exit();
        }
    }
}