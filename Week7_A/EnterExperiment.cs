using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Week7_A
{
    public partial class EnterExperiment : Form
    {
        enum Colors
        {
            Crimson, Azure, Taupe, Mauve, Vermillion, Chartreuse
        }

        //List to hold the experiment objects
        private List<Experiment> experimentDataList = new List<Experiment>();
        public EnterExperiment()
        {
            InitializeComponent();
        }

        //The get experiment data method accepts an experiment object as and argument and assigns the user entered data to the 
        //experiment properties
        private void GetExperimentData(Experiment experiment)
        {
            //temporary variables to hold numerical data
            double weight;
            double volume;
            int experimentNumber;

            //get the student name
            experiment.StudentName = studentNameTextBox.Text;

            //get the description
            experiment.ExperimentDescription = descriptionTextBox.Text;

            //get the color
            Colors color; //temporary variable to hold the color

            if (colorTextBox.Text == Colors.Azure.ToString() || colorTextBox.Text == Colors.Crimson.ToString() || colorTextBox.Text == Colors.Chartreuse.ToString() || colorTextBox.Text == Colors.Mauve.ToString() || colorTextBox.Text == Colors.Taupe.ToString() || colorTextBox.Text == Colors.Vermillion.ToString())
            {
                experiment.Color = colorTextBox.Text;
            }
            else
            {
                MessageBox.Show("please enter a valid color");
            }

            //get the experiment number
            if (int.TryParse(experimentNumberTextBox.Text, out experimentNumber))
            {
                if (experimentNumber > 0 && experimentNumber <= 50)
                {
                    experiment.ExperimentNumber = experimentNumber;
                }
                else
                {
                    MessageBox.Show("enter a number between 1 and 50");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number between 1 and 50");
            }

            //get the volume
            if (double.TryParse(volumeTextBox.Text, out volume))
            {
                experiment.Volume = volume;
            }
            else
            {
                MessageBox.Show("Please enter a valid number");
            }

            //get the weight
            if (double.TryParse(weightTextBox.Text, out weight))
            {
                experiment.Weight = weight;
            }
            else
            {
                MessageBox.Show("Please enter a valid number");
            }
        }



        private void descriptionTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            descriptionTextBox.Text = "";
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            //create an experiment object
            Experiment myExperiment = new Experiment();

            //get the experiment data
            GetExperimentData(myExperiment);
            if (experimentDataList.Count <= 50)
            {

                savedDataListBox.Items.Add(myExperiment.ExperimentNumber + "\t" + myExperiment.ExperimentDescription);

                //add the experiment object to the data list
                experimentDataList.Add(myExperiment);

            }
            else
            {
                MessageBox.Show("Cannot hold anymore experiment information");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            descriptionTextBox.Text = "";
            studentNameTextBox.Text = "";
            weightTextBox.Text = "";
            volumeTextBox.Text = "";
            experimentNumberTextBox.Text = "";
            colorTextBox.Text = "";

            //gives focus to the experiment number
            experimentNumberTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //declares a streamwriter output file variable
            StreamWriter outputFile;

            //create an experiment object
            Experiment myExperiment = new Experiment();

            //get the experiment data
            GetExperimentData(myExperiment);

            //Saves the data to a file of the users choice
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                outputFile = File.AppendText(saveFile.FileName);
                //write the contents of the list to the saved file
                for (int i = 0; i < experimentDataList.Count; i++ )
                {
                    outputFile.Write(experimentDataList);

                    //outputFile.WriteLine(myExperiment.ExperimentDescription);
                    //outputFile.WriteLine(myExperiment.Color);
                    //outputFile.WriteLine(myExperiment.ExperimentNumber);
                    //outputFile.WriteLine(myExperiment.StudentName);
                    //outputFile.WriteLine(myExperiment.Volume);
                    //outputFile.WriteLine(myExperiment.Weight);
                }
                //close streamwriter
                outputFile.Close();
                MessageBox.Show("File Save Successful");

            }
            else
            {
                MessageBox.Show("Operation Cancelled");
            }
        }

        private void savedDataListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get the index of the selected item.
            int index = savedDataListBox.SelectedIndex;

            //Display the experiment's data
            experimentNumberTextBox.Text = experimentDataList[index].ExperimentNumber.ToString();
            studentNameTextBox.Text = experimentDataList[index].StudentName.ToString();
            descriptionTextBox.Text = experimentDataList[index].ExperimentDescription.ToString();
            volumeTextBox.Text = experimentDataList[index].Volume.ToString();
            weightTextBox.Text = experimentDataList[index].Weight.ToString();
            colorTextBox.Text = experimentDataList[index].Color.ToString();

        }

        private void setButton_Click(object sender, EventArgs e)
        {
            //get index of selected item
            int index = savedDataListBox.SelectedIndex;

            //create an experiment object
            Experiment myExperiment = new Experiment();

                //get the experiment data
                GetExperimentData(myExperiment);
                if (experimentDataList.Count <= 50)
                {

                    //add the experiment object to the data list
                    experimentDataList.Insert(index, myExperiment);

                    MessageBox.Show("data change saved");
                }
                else
                {
                    MessageBox.Show("Cannot hold anymore experiment information");

                }
            

        }

        private void savedDataListBox_DoubleClick(object sender, EventArgs e)
        {
            ExperimentReview reviewForm = new ExperimentReview();

            //get the index of the selected item.
            int index = savedDataListBox.SelectedIndex;

            //Display the experiment's data
            reviewForm.experimentNumberLabel.Text = experimentDataList[index].ExperimentNumber.ToString();
            reviewForm.studentNameLabel.Text = experimentDataList[index].StudentName.ToString();
            reviewForm.experimentDescriptionLabel.Text = experimentDataList[index].ExperimentDescription.ToString();
            reviewForm.volumeLabel.Text = experimentDataList[index].Volume.ToString();
            reviewForm.weightLabel.Text = experimentDataList[index].Weight.ToString();
            reviewForm.colorLabel.Text = experimentDataList[index].Color.ToString();

            reviewForm.ShowDialog();


        }
    }
}
