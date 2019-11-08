namespace StudentSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.commBtn = new System.Windows.Forms.RadioButton();
            this.dormBtn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stuListBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mahaBtn = new System.Windows.Forms.RadioButton();
            this.appaBtn = new System.Windows.Forms.RadioButton();
            this.wapelloBtn = new System.Windows.Forms.RadioButton();
            this.trusteeBtn = new System.Windows.Forms.RadioButton();
            this.oakBtn = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.highBtn = new System.Windows.Forms.RadioButton();
            this.mediumBtn = new System.Windows.Forms.RadioButton();
            this.basicBtn = new System.Windows.Forms.RadioButton();
            this.addBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.errorBox = new System.Windows.Forms.TextBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.assignBtn = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // idBox
            // 
            resources.ApplyResources(this.idBox, "idBox");
            this.idBox.Name = "idBox";
            this.idBox.TextChanged += new System.EventHandler(this.idBox_TextChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // nameBox
            // 
            resources.ApplyResources(this.nameBox, "nameBox");
            this.nameBox.Name = "nameBox";
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // commBtn
            // 
            resources.ApplyResources(this.commBtn, "commBtn");
            this.commBtn.Name = "commBtn";
            this.commBtn.UseVisualStyleBackColor = true;
            this.commBtn.CheckedChanged += new System.EventHandler(this.commBtn_CheckedChanged);
            // 
            // dormBtn
            // 
            resources.ApplyResources(this.dormBtn, "dormBtn");
            this.dormBtn.Checked = true;
            this.dormBtn.Name = "dormBtn";
            this.dormBtn.TabStop = true;
            this.dormBtn.UseVisualStyleBackColor = true;
            this.dormBtn.CheckedChanged += new System.EventHandler(this.dormBtn_CheckedChanged);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // stuListBox
            // 
            this.stuListBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.stuListBox.HideSelection = false;
            resources.ApplyResources(this.stuListBox, "stuListBox");
            this.stuListBox.Name = "stuListBox";
            this.stuListBox.ReadOnly = true;
            this.stuListBox.ShortcutsEnabled = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.nameBox);
            this.groupBox2.Controls.Add(this.idBox);
            this.groupBox2.Controls.Add(this.dormBtn);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.commBtn);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mahaBtn);
            this.groupBox3.Controls.Add(this.appaBtn);
            this.groupBox3.Controls.Add(this.wapelloBtn);
            this.groupBox3.Controls.Add(this.trusteeBtn);
            this.groupBox3.Controls.Add(this.oakBtn);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // mahaBtn
            // 
            resources.ApplyResources(this.mahaBtn, "mahaBtn");
            this.mahaBtn.Name = "mahaBtn";
            this.mahaBtn.TabStop = true;
            this.mahaBtn.UseVisualStyleBackColor = true;
            this.mahaBtn.CheckedChanged += new System.EventHandler(this.mahaBtn_CheckedChanged);
            // 
            // appaBtn
            // 
            resources.ApplyResources(this.appaBtn, "appaBtn");
            this.appaBtn.Name = "appaBtn";
            this.appaBtn.TabStop = true;
            this.appaBtn.UseVisualStyleBackColor = true;
            this.appaBtn.CheckedChanged += new System.EventHandler(this.appaBtn_CheckedChanged);
            // 
            // wapelloBtn
            // 
            resources.ApplyResources(this.wapelloBtn, "wapelloBtn");
            this.wapelloBtn.Name = "wapelloBtn";
            this.wapelloBtn.TabStop = true;
            this.wapelloBtn.UseVisualStyleBackColor = true;
            this.wapelloBtn.CheckedChanged += new System.EventHandler(this.wapelloBtn_CheckedChanged);
            // 
            // trusteeBtn
            // 
            resources.ApplyResources(this.trusteeBtn, "trusteeBtn");
            this.trusteeBtn.Name = "trusteeBtn";
            this.trusteeBtn.TabStop = true;
            this.trusteeBtn.UseVisualStyleBackColor = true;
            this.trusteeBtn.CheckedChanged += new System.EventHandler(this.trusteeBtn_CheckedChanged);
            // 
            // oakBtn
            // 
            resources.ApplyResources(this.oakBtn, "oakBtn");
            this.oakBtn.Name = "oakBtn";
            this.oakBtn.TabStop = true;
            this.oakBtn.UseVisualStyleBackColor = true;
            this.oakBtn.CheckedChanged += new System.EventHandler(this.oakBtn_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.highBtn);
            this.groupBox4.Controls.Add(this.mediumBtn);
            this.groupBox4.Controls.Add(this.basicBtn);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // highBtn
            // 
            resources.ApplyResources(this.highBtn, "highBtn");
            this.highBtn.Name = "highBtn";
            this.highBtn.TabStop = true;
            this.highBtn.UseVisualStyleBackColor = true;
            this.highBtn.CheckedChanged += new System.EventHandler(this.highBtn_CheckedChanged);
            // 
            // mediumBtn
            // 
            resources.ApplyResources(this.mediumBtn, "mediumBtn");
            this.mediumBtn.Name = "mediumBtn";
            this.mediumBtn.TabStop = true;
            this.mediumBtn.UseVisualStyleBackColor = true;
            this.mediumBtn.CheckedChanged += new System.EventHandler(this.mediumBtn_CheckedChanged);
            // 
            // basicBtn
            // 
            resources.ApplyResources(this.basicBtn, "basicBtn");
            this.basicBtn.Name = "basicBtn";
            this.basicBtn.TabStop = true;
            this.basicBtn.UseVisualStyleBackColor = true;
            this.basicBtn.CheckedChanged += new System.EventHandler(this.basicBtn_CheckedChanged);
            // 
            // addBtn
            // 
            resources.ApplyResources(this.addBtn, "addBtn");
            this.addBtn.Name = "addBtn";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // updateBtn
            // 
            resources.ApplyResources(this.updateBtn, "updateBtn");
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            resources.ApplyResources(this.deleteBtn, "deleteBtn");
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // errorBox
            // 
            this.errorBox.BackColor = System.Drawing.SystemColors.Menu;
            this.errorBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.errorBox, "errorBox");
            this.errorBox.ForeColor = System.Drawing.Color.Red;
            this.errorBox.Name = "errorBox";
            // 
            // exitBtn
            // 
            resources.ApplyResources(this.exitBtn, "exitBtn");
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Name = "label6";
            // 
            // assignBtn
            // 
            resources.ApplyResources(this.assignBtn, "assignBtn");
            this.assignBtn.Name = "assignBtn";
            this.assignBtn.UseVisualStyleBackColor = true;
            this.assignBtn.Click += new System.EventHandler(this.assignBtn_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.assignBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.errorBox);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.stuListBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.RadioButton commBtn;
        private System.Windows.Forms.RadioButton dormBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox stuListBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton mahaBtn;
        private System.Windows.Forms.RadioButton appaBtn;
        private System.Windows.Forms.RadioButton wapelloBtn;
        private System.Windows.Forms.RadioButton trusteeBtn;
        private System.Windows.Forms.RadioButton oakBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton highBtn;
        private System.Windows.Forms.RadioButton mediumBtn;
        private System.Windows.Forms.RadioButton basicBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox errorBox;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button assignBtn;
    }
}

