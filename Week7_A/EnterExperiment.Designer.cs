
namespace Week7_A
{
    partial class EnterExperiment
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.experimentNumberTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.volumeTextBox = new System.Windows.Forms.TextBox();
            this.studentNameDescription = new System.Windows.Forms.Label();
            this.volumeDescription = new System.Windows.Forms.Label();
            this.colorDescription = new System.Windows.Forms.Label();
            this.weightDescription = new System.Windows.Forms.Label();
            this.expDescription = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.setButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.savedDataListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.Location = new System.Drawing.Point(35, 29);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(144, 23);
            this.studentNameTextBox.TabIndex = 0;
            // 
            // experimentNumberTextBox
            // 
            this.experimentNumberTextBox.Location = new System.Drawing.Point(296, 29);
            this.experimentNumberTextBox.Name = "experimentNumberTextBox";
            this.experimentNumberTextBox.Size = new System.Drawing.Size(73, 23);
            this.experimentNumberTextBox.TabIndex = 1;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(35, 58);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(334, 194);
            this.descriptionTextBox.TabIndex = 2;
            this.descriptionTextBox.Text = "Please Enter an Experiment Description";
            this.descriptionTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.descriptionTextBox_MouseClick);
            // 
            // colorTextBox
            // 
            this.colorTextBox.Location = new System.Drawing.Point(153, 285);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(100, 23);
            this.colorTextBox.TabIndex = 3;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(35, 285);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 23);
            this.weightTextBox.TabIndex = 4;
            // 
            // volumeTextBox
            // 
            this.volumeTextBox.Location = new System.Drawing.Point(269, 285);
            this.volumeTextBox.Name = "volumeTextBox";
            this.volumeTextBox.Size = new System.Drawing.Size(100, 23);
            this.volumeTextBox.TabIndex = 5;
            // 
            // studentNameDescription
            // 
            this.studentNameDescription.AutoSize = true;
            this.studentNameDescription.Location = new System.Drawing.Point(35, 9);
            this.studentNameDescription.Name = "studentNameDescription";
            this.studentNameDescription.Size = new System.Drawing.Size(86, 15);
            this.studentNameDescription.TabIndex = 6;
            this.studentNameDescription.Text = "Student Name:";
            // 
            // volumeDescription
            // 
            this.volumeDescription.AutoSize = true;
            this.volumeDescription.Location = new System.Drawing.Point(269, 267);
            this.volumeDescription.Name = "volumeDescription";
            this.volumeDescription.Size = new System.Drawing.Size(80, 15);
            this.volumeDescription.TabIndex = 7;
            this.volumeDescription.Text = "Enter Volume:";
            // 
            // colorDescription
            // 
            this.colorDescription.AutoSize = true;
            this.colorDescription.Location = new System.Drawing.Point(153, 267);
            this.colorDescription.Name = "colorDescription";
            this.colorDescription.Size = new System.Drawing.Size(69, 15);
            this.colorDescription.TabIndex = 8;
            this.colorDescription.Text = "Enter Color:";
            // 
            // weightDescription
            // 
            this.weightDescription.AutoSize = true;
            this.weightDescription.Location = new System.Drawing.Point(35, 267);
            this.weightDescription.Name = "weightDescription";
            this.weightDescription.Size = new System.Drawing.Size(78, 15);
            this.weightDescription.TabIndex = 9;
            this.weightDescription.Text = "Enter Weight:";
            // 
            // expDescription
            // 
            this.expDescription.AutoSize = true;
            this.expDescription.Location = new System.Drawing.Point(296, 11);
            this.expDescription.Name = "expDescription";
            this.expDescription.Size = new System.Drawing.Size(36, 15);
            this.expDescription.TabIndex = 10;
            this.expDescription.Text = "Exp #";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(119, 374);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(200, 374);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // setButton
            // 
            this.setButton.Location = new System.Drawing.Point(164, 332);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(75, 23);
            this.setButton.TabIndex = 14;
            this.setButton.Text = "Set";
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(245, 332);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(83, 332);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 16;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // savedDataListBox
            // 
            this.savedDataListBox.FormattingEnabled = true;
            this.savedDataListBox.ItemHeight = 15;
            this.savedDataListBox.Location = new System.Drawing.Point(403, 53);
            this.savedDataListBox.Name = "savedDataListBox";
            this.savedDataListBox.Size = new System.Drawing.Size(253, 199);
            this.savedDataListBox.TabIndex = 17;
            this.savedDataListBox.SelectedIndexChanged += new System.EventHandler(this.savedDataListBox_SelectedIndexChanged);
            this.savedDataListBox.DoubleClick += new System.EventHandler(this.savedDataListBox_DoubleClick);
            // 
            // EnterExperiment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 435);
            this.Controls.Add(this.savedDataListBox);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.setButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.expDescription);
            this.Controls.Add(this.weightDescription);
            this.Controls.Add(this.colorDescription);
            this.Controls.Add(this.volumeDescription);
            this.Controls.Add(this.studentNameDescription);
            this.Controls.Add(this.volumeTextBox);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.colorTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.experimentNumberTextBox);
            this.Controls.Add(this.studentNameTextBox);
            this.Name = "EnterExperiment";
            this.Text = "Experiment Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.TextBox experimentNumberTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox volumeTextBox;
        private System.Windows.Forms.Label studentNameDescription;
        private System.Windows.Forms.Label volumeDescription;
        private System.Windows.Forms.Label colorDescription;
        private System.Windows.Forms.Label weightDescription;
        private System.Windows.Forms.Label expDescription;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.ListBox savedDataListBox;
    }
}

