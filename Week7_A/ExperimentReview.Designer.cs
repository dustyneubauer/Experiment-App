
namespace Week7_A
{
    partial class ExperimentReview
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
            this.closeButton = new System.Windows.Forms.Button();
            this.studentNameLabel = new System.Windows.Forms.Label();
            this.studentNameDescription = new System.Windows.Forms.Label();
            this.colorDescription = new System.Windows.Forms.Label();
            this.descriptionDescription = new System.Windows.Forms.Label();
            this.experimentNumberDescription = new System.Windows.Forms.Label();
            this.volumeDescription = new System.Windows.Forms.Label();
            this.weightDescription = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.volumeLabel = new System.Windows.Forms.Label();
            this.colorLabel = new System.Windows.Forms.Label();
            this.experimentDescriptionLabel = new System.Windows.Forms.Label();
            this.experimentNumberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(249, 286);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // studentNameLabel
            // 
            this.studentNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentNameLabel.Location = new System.Drawing.Point(186, 9);
            this.studentNameLabel.Name = "studentNameLabel";
            this.studentNameLabel.Size = new System.Drawing.Size(100, 23);
            this.studentNameLabel.TabIndex = 1;
            // 
            // studentNameDescription
            // 
            this.studentNameDescription.AutoSize = true;
            this.studentNameDescription.Location = new System.Drawing.Point(83, 9);
            this.studentNameDescription.Name = "studentNameDescription";
            this.studentNameDescription.Size = new System.Drawing.Size(92, 15);
            this.studentNameDescription.TabIndex = 2;
            this.studentNameDescription.Text = "Student Name : ";
            // 
            // colorDescription
            // 
            this.colorDescription.AutoSize = true;
            this.colorDescription.Location = new System.Drawing.Point(133, 180);
            this.colorDescription.Name = "colorDescription";
            this.colorDescription.Size = new System.Drawing.Size(42, 15);
            this.colorDescription.TabIndex = 3;
            this.colorDescription.Text = "Color :";
            // 
            // descriptionDescription
            // 
            this.descriptionDescription.AutoSize = true;
            this.descriptionDescription.Location = new System.Drawing.Point(39, 85);
            this.descriptionDescription.Name = "descriptionDescription";
            this.descriptionDescription.Size = new System.Drawing.Size(136, 15);
            this.descriptionDescription.TabIndex = 4;
            this.descriptionDescription.Text = "Experiment Description :";
            // 
            // experimentNumberDescription
            // 
            this.experimentNumberDescription.AutoSize = true;
            this.experimentNumberDescription.Location = new System.Drawing.Point(55, 46);
            this.experimentNumberDescription.Name = "experimentNumberDescription";
            this.experimentNumberDescription.Size = new System.Drawing.Size(120, 15);
            this.experimentNumberDescription.TabIndex = 5;
            this.experimentNumberDescription.Text = "Experiment Number :";
            // 
            // volumeDescription
            // 
            this.volumeDescription.AutoSize = true;
            this.volumeDescription.Location = new System.Drawing.Point(119, 210);
            this.volumeDescription.Name = "volumeDescription";
            this.volumeDescription.Size = new System.Drawing.Size(56, 15);
            this.volumeDescription.TabIndex = 6;
            this.volumeDescription.Text = "Volume : ";
            // 
            // weightDescription
            // 
            this.weightDescription.AutoSize = true;
            this.weightDescription.Location = new System.Drawing.Point(124, 242);
            this.weightDescription.Name = "weightDescription";
            this.weightDescription.Size = new System.Drawing.Size(51, 15);
            this.weightDescription.TabIndex = 7;
            this.weightDescription.Text = "Weight :";
            // 
            // weightLabel
            // 
            this.weightLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weightLabel.Location = new System.Drawing.Point(186, 242);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(100, 23);
            this.weightLabel.TabIndex = 8;
            // 
            // volumeLabel
            // 
            this.volumeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.volumeLabel.Location = new System.Drawing.Point(186, 210);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(100, 23);
            this.volumeLabel.TabIndex = 9;
            // 
            // colorLabel
            // 
            this.colorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorLabel.Location = new System.Drawing.Point(186, 180);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(100, 23);
            this.colorLabel.TabIndex = 10;
            // 
            // experimentDescriptionLabel
            // 
            this.experimentDescriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.experimentDescriptionLabel.Location = new System.Drawing.Point(186, 85);
            this.experimentDescriptionLabel.Name = "experimentDescriptionLabel";
            this.experimentDescriptionLabel.Size = new System.Drawing.Size(293, 82);
            this.experimentDescriptionLabel.TabIndex = 11;
            // 
            // experimentNumberLabel
            // 
            this.experimentNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.experimentNumberLabel.Location = new System.Drawing.Point(186, 46);
            this.experimentNumberLabel.Name = "experimentNumberLabel";
            this.experimentNumberLabel.Size = new System.Drawing.Size(100, 23);
            this.experimentNumberLabel.TabIndex = 12;
            // 
            // ExperimentReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 321);
            this.Controls.Add(this.experimentNumberLabel);
            this.Controls.Add(this.experimentDescriptionLabel);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.volumeLabel);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.weightDescription);
            this.Controls.Add(this.volumeDescription);
            this.Controls.Add(this.experimentNumberDescription);
            this.Controls.Add(this.descriptionDescription);
            this.Controls.Add(this.colorDescription);
            this.Controls.Add(this.studentNameDescription);
            this.Controls.Add(this.studentNameLabel);
            this.Controls.Add(this.closeButton);
            this.Name = "ExperimentReview";
            this.Text = "ExperimentReview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label studentNameDescription;
        private System.Windows.Forms.Label colorDescription;
        private System.Windows.Forms.Label descriptionDescription;
        private System.Windows.Forms.Label experimentNumberDescription;
        private System.Windows.Forms.Label volumeDescription;
        private System.Windows.Forms.Label weightDescription;
        public System.Windows.Forms.Label experimentNumberLabel;
        public System.Windows.Forms.Label studentNameLabel;
        public System.Windows.Forms.Label weightLabel;
        public System.Windows.Forms.Label volumeLabel;
        public System.Windows.Forms.Label colorLabel;
        public System.Windows.Forms.Label experimentDescriptionLabel;
    }
}