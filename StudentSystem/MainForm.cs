using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace StudentSystem
{
    public partial class MainForm : Form
    {
        //create a connection object tied to an external database (Book.accdb resides in the Bin/Debug folder)
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=StudentDatabase.accdb");
        
        AssignmentsForm assignments = new AssignmentsForm();
        public static List<Student> studentList = new List<Student>();    //Student List
        string dorm = "";                                                 //String to hold dorm name value
        string meal = "";                                                 //String to hold meal plan value
        int finalIndex = -1;                                              //Index value used to find object of interest in list and update it
        bool nameValid;                                                   //Bool for name validation
        bool idValid;                                                     //Bool for id validation

        public MainForm()
        {
            InitializeComponent();
        }

        //Form load
        private void MainForm_Load(object sender, EventArgs e)
        {   
            //Set form location on screen
            this.Location = new Point(600, 300);
            conn.Close();

            //check if .ser file exists. If so, deserialize, otherwise print message in main menu
            try
            {
                if (File.Exists("students.ser"))
                {
                    errorBox.Text = "";

                    using (Stream stream = File.Open("students.ser", FileMode.Open))
                    {
                        if (stream.Length != 0)
                        {
                            BinaryFormatter bin = new BinaryFormatter();
                            studentList = (List<Student>)bin.Deserialize(stream);
                            assignBtn.Enabled = true;
                        }
                    }
                }
                else
                {
                    errorBox.Text = "Student file doesn't exist.";
                    assignBtn.Enabled = false;
                }
            }
            catch (IOException)
            {
                errorBox.Text = "Student file doesn't exist.";
            }

            //Disable add button by default if no Id and name are prompted
            addBtn.Enabled = false;

            //Populate ListBox looping thru student list
            foreach (var item in studentList)
            {
                stuListBox.Text += item + Environment.NewLine;
            }
        }

        //Text changed in Id Box
        private void idBox_TextChanged(object sender, EventArgs e)
        {   
            //Check for invalid chars. If any, assign total count of such chars to int var.
            int invalidChar = Regex.Matches(idBox.Text, @"[a-zA-Z°!|#$%&/()?¡¿´¨+*{}[-_;,:.~^`]").Count;

            //Check for min Id length and invalid char presence
            if (idBox.Text.Length < 5 || invalidChar > 0)
            {
                errorBox.Text = "Student ID must be 5 digits and contain only numbers!";
                idValid = false;
            }    
            else if (idBox.Text.Length == 0)
            {
                //Reset error box text if there is no data in Id box
                errorBox.Text = "";
                idValid = false;
            }           
            else
            {
                //Reset error box if input is valid and set bool to true
                errorBox.Text = "";
                idValid = true;
            }

            //If both name and Id are valid, enable add button
            if (idValid && nameValid)
            {
                addBtn.Enabled = true;
            }
            else
            {
                addBtn.Enabled = false;
            }

            //Linq to search the list based on input from Id box. If entered Id matches, auto-compile name box with associated name
            //(Part of Update Student)
            try
            {
                var query = from items in studentList
                            where items.Id == Int32.Parse(idBox.Text)
                            select (items.Name);

                foreach (var q in query)
                {
                    nameBox.Text = q;
                }
            }
            catch (FormatException)
            {
                nameBox.Text = "";
                return;
            }

            //Find index of student list that matches Id entered in Id textbox and assign it to global int var
            //(Part of Update Student)
            int Index = studentList.FindIndex(s => s.Id == Int32.Parse(idBox.Text));
            if (Index >= 0)
            {
                finalIndex = Index;
            }
            else
            {
                return;
            }
        }

        //Text changed in Name Box
        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            //Check for invalid chars. If any, assign total count of such chars to int var.
            int invalidChar = Regex.Matches(nameBox.Text, @"[0-9°!|#$%&/()?¡¿´¨+*{}[-_;,:~^`]").Count;

            //Check for max name length and invalid char presence
            if (invalidChar > 0 || nameBox.Text.Length > 30)
            {
                errorBox.Text = "Student name can't be longer than 30 characters and must contain only letters!";
                nameValid = false;
            }
            else if (nameBox.Text.Length == 0)
            {
                //Reset error box text if there is no data in name box
                errorBox.Text = "";
                nameValid = false;
            }
            else
            {
                //Reset error box if input is valid and set bool to true
                errorBox.Text = "";
                nameValid = true;
            }

            //If both name and Id are valid, enable add button
            if (idValid && nameValid)
            {
                addBtn.Enabled = true;
            }
            else
            {
                addBtn.Enabled = false;
            }

            //Linq to search the list based on input from name box. If entered name matches, auto-compile Id box with associated Id
            //(Part of Update Student)
            try
            {
                var query = from items in studentList
                            where items.Name == nameBox.Text
                            select (items.Id);

                foreach (var q in query)
                {
                    idBox.Text = q.ToString();
                }
            }
            catch (FormatException)
            {
                idBox.Text = "";
                return;
            }
        }

        //Reset error box message, meal and dorm vars. Disable dorm and meal plan radio buttons if Commuter is selected
        private void commBtn_CheckedChanged(object sender, EventArgs e)
        {
            errorBox.Text = "";
            meal = "";
            dorm = "";
            foreach (RadioButton btn in new RadioButton[] { oakBtn, trusteeBtn, wapelloBtn, appaBtn, mahaBtn, basicBtn, mediumBtn, highBtn })
            {
                btn.Enabled = false;
            }
        }

        //Enable and clean radio buttons if Dorm student is selected
        private void dormBtn_CheckedChanged(object sender, EventArgs e)
        {
            foreach (RadioButton btn in new RadioButton[] { oakBtn, trusteeBtn, wapelloBtn, appaBtn, mahaBtn, basicBtn, mediumBtn, highBtn })
            {
                btn.Enabled = true;
                btn.Checked = false;
            }
        }

        //Assign name of dorm and meal plan based on selections
        private void oakBtn_CheckedChanged(object sender, EventArgs e)
        {
            dorm = "Oak";
        }
        private void trusteeBtn_CheckedChanged(object sender, EventArgs e)
        {
            dorm = "Trustee";
        }
        private void wapelloBtn_CheckedChanged(object sender, EventArgs e)
        {
            dorm = "Wapello";
        }
        private void appaBtn_CheckedChanged(object sender, EventArgs e)
        {
            dorm = "Appanoose";
        }
        private void mahaBtn_CheckedChanged(object sender, EventArgs e)
        {
            dorm = "Mahaska";
        }
        private void basicBtn_CheckedChanged(object sender, EventArgs e)
        {
            meal = "Basic";
        }
        private void mediumBtn_CheckedChanged(object sender, EventArgs e)
        {
            meal = "Medium";
        }
        private void highBtn_CheckedChanged(object sender, EventArgs e)
        {
            meal = "High";
        }

        //Add student button
        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {   
                //Check if Id is already in use
                foreach(var item in studentList)
                {
                    if(item.Id == Int32.Parse(idBox.Text)){
                        errorBox.Text = "Student Id already in use!";
                        return;
                    }
                }
            }
            catch (InvalidOperationException)
            {
                errorBox.Text = "Entry Submitted!";
            }

            //If commuter radio btn is checked, create new student from parent class, add it to the list, sort it and re-print on ListBox
            if (commBtn.Checked)
            {
                try
                {   
                    Student commStudent = (new Student(Int32.Parse(idBox.Text), nameBox.Text));
                    //studentList.Add(commStudent);
                    //studentList.Sort();
                    //stuListBox.Clear();

                    //open the database
                    conn.Open();

                    //create an adapter
                    OleDbDataAdapter da = new OleDbDataAdapter();

                    string insertCmd = "INSERT INTO STUDENTS VALUES('" + commStudent.Id + "', '" + commStudent.Name + "', '" + "No" + "')";

                    da.InsertCommand = new OleDbCommand(insertCmd, conn);
                    da.InsertCommand.ExecuteNonQuery();
                    errorBox.Text = "Row(s) Inserted !! ";
                }
                catch (Exception exc)
                {
                    errorBox.Text = exc.ToString();
                }

                conn.Close();

                //foreach (var item in studentList)
                //{
                //    stuListBox.Text += item.ToString() + Environment.NewLine;
                //}
            }

            //If dorm radio btn is checked, check that dorm and meal are selected before submission,
            //create new student from child class, add it to the list, sort it and re-print on ListBox
            if (dormBtn.Checked)
            {
                if (dorm == "" || meal == "")
                {
                    errorBox.Text = "You must select the dorm and meal plan for this student!";
                    return;
                }
                else
                {
                    errorBox.Text = "";
                   
                    try
                    {
                        Student dormStudent = (new DormStudent(Int32.Parse(idBox.Text), nameBox.Text, dorm, meal));

                        //open the database
                        conn.Open();

                        //create an adapter
                        OleDbDataAdapter da = new OleDbDataAdapter();

                        string insertCmd = "INSERT INTO STUDENTS VALUES('" + dormStudent.Id + "', '" + dormStudent.Name + "', '" + dorm + "', ´" + meal + "')";

                        da.InsertCommand = new OleDbCommand(insertCmd, conn);
                        da.InsertCommand.ExecuteNonQuery();
                        errorBox.Text = "Row(s) Inserted !! ";
                    }
                    catch(Exception exc)
                    {
                        errorBox.Text = exc.ToString();
                    }
                    conn.Close();

                    //studentList.Add(dormStudent);
                    //studentList.Sort();
                    //stuListBox.Clear();
                    //foreach (var item in studentList)
                    //{
                    //    stuListBox.Text += item.ToString() + Environment.NewLine;
                    //}

                    //Reset dorm and mealplan
                    dorm = "";
                    meal = "";
                    //Clean radio buttons
                    foreach (RadioButton btn in new RadioButton[] { oakBtn, trusteeBtn, wapelloBtn, appaBtn, mahaBtn, basicBtn, mediumBtn, highBtn })
                    {
                        btn.Checked = false;
                    }
                }
            }

            //Reset id and name box after submission
            idBox.Text = "";
            nameBox.Text = "";
        }

        //Update button
        private void updateBtn_Click(object sender, EventArgs e)
        {

            try
            {   
                //If commuter button is checked, check that the name to update is not missing
                if (commBtn.Checked)
                {
                    if (nameBox.Text == "")
                    {
                        errorBox.Text = "Name is missing!";
                        return;
                    }

                    //Replace index found thru the Id or name value with the new updated object and re-print updated listbox
                    studentList[finalIndex] = new Student(id: Int32.Parse(idBox.Text), name: nameBox.Text);
                    stuListBox.Clear();
                    studentList.Sort();
                    foreach (var item in studentList)
                    {
                        stuListBox.Text += item.ToString() + Environment.NewLine;
                    }
                }

                //If dorm button is checked, check that the name to update is not missing
                if (dormBtn.Checked)
                {
                    if (nameBox.Text == "")
                    {
                        errorBox.Text = "Name is missing!";
                        return;
                    }

                    //Check that dorm and meal plan are selected before sending update
                    if (dorm == "" || meal == "")
                    {
                        errorBox.Text = "You must select the dorm and meal plan for this student!";
                        return;
                    }
                    else
                    {
                        //Replace index found thru the Id or name value with the new updated child object and re-print updated listbox
                        studentList[finalIndex] = new DormStudent(id: Int32.Parse(idBox.Text), name: nameBox.Text, dorm: dorm, mealplan: meal);
                        stuListBox.Clear();
                        studentList.Sort();
                        foreach (var item in studentList)
                        {
                            stuListBox.Text += item.ToString() + Environment.NewLine;
                        }
                    }
                }
            }
            catch (Exception ex)  
            {
                if (ex is ArgumentOutOfRangeException || ex is FormatException)
                {
                    errorBox.Text = "Student not found!";
                    return;
                }
            }

            errorBox.Text = "Student Updated!";

            //Reset index, textboxes and vars
            finalIndex = -1;
            idBox.Text = "";
            nameBox.Text = "";
            meal = "";
            dorm = "";

            //Clean radio buttons after update
            foreach (RadioButton btn in new RadioButton[] { oakBtn, trusteeBtn, wapelloBtn, appaBtn, mahaBtn, basicBtn, mediumBtn, highBtn })
            {
                btn.Checked = false;
            }
        }

        //Delete button
        private void deleteBtn_Click(object sender, EventArgs e)
        {   
            //Id search
            try
            {   
                //If Id box not empty, find object that matches entered id and remove it from list
                if (idBox.Text != "")
                {
                    var foundId = studentList.First(s => s.Id == Int32.Parse(idBox.Text));
                    studentList.Remove(foundId);
                    stuListBox.Clear();
                    //Re-print updated listbox
                    for (int i = 0; i < studentList.Count; i++)
                    {
                        stuListBox.Text += studentList[i].ToString() + Environment.NewLine;
                    }
                    idBox.Text = "";
                    nameBox.Text = "";
                }
            }
            catch (Exception ex)
            {
                if (ex is FormatException || ex is InvalidOperationException)
                {
                    errorBox.Text = "Student not found!";
                    return;
                }
            }

            //Name search
            try
            {
                //If name box not empty, find object that matches entered name and remove it from list
                if (nameBox.Text != "")
                {
                    var foundName = studentList.First(s => s.Name == nameBox.Text);
                    studentList.Remove(foundName);
                    stuListBox.Clear();
                    //Re-print updated listbox
                    for (int i = 0; i < studentList.Count; i++)
                    {
                        stuListBox.Text += studentList[i].ToString() + Environment.NewLine;
                    }
                    //Reset text boxes after deleting object
                    idBox.Text = "";
                    nameBox.Text = "";
                }
            }
            catch (InvalidOperationException)
            {
                errorBox.Text = "Name not Found";
                return;
            }
        }

        //Assignment Button
        private void assignBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            assignments.Show();
        }

        //Serialize list to student file if form is closed using X in top right corner (Not working)
        private void MainFormClosing(Object sender, FormClosingEventArgs e)
        {
            try
            {
                using (Stream stream = File.Open("students.ser", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, studentList);
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Error writing file");
            }

            this.Close();
            Application.Exit();
        }

        //Serialize list to student file if form is closed using the exit button
        private void exitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (Stream stream = File.Open("students.ser", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, studentList);
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