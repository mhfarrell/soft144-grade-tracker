using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Xml.Serialization;


namespace gradechecker
{

    public partial class GradeForm : Form
    {        
        char[] splitter = { ',' };
        string[] moduleData;
        string[] moduleCode;
        string[] moduleName;
        int[] moduleCredit;
        string[] moduleAssess;
        string[] textDoc;
        bool[] exam;
        string[] examName;
        decimal[] examMark;
        decimal[] assessMark;
        string[] assessData;
        decimal[] moduleMark;
        int assessments;
        string temp;
        decimal[] temperory;
        decimal sum;
        int number = 0;
        


        public GradeForm()
        {
            InitializeComponent();
        }//end form

        private void Form1_Load(object sender, EventArgs e)
        {

        }//End load

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GradeForm.ActiveForm.Close();
        }//End close
       

        private void lstModule_SelectedIndexChanged(object sender, EventArgs e)
        {
            //I always clear the list when loading this and other lists as i dont want multiples
            lstAssessment.Items.Clear();
            temp = moduleAssess[lstModule.SelectedIndex].Replace("   ", ",");           
            assessData = temp.Split(splitter);
            assessments = Convert.ToInt32(assessData.Count()) - 1;
            //populating assessment list based on what i click
            for (int i = 0; i < assessments; i = i + 3)
            {
                lstAssessment.Items.Add(assessData[i]);
            }
            if (examName[lstModule.SelectedIndex] == null)
            {

            }
            else
            {                
                    lstAssessment.Items.Add(examName[lstModule.SelectedIndex]);
            }
            int tmp;
            decimal tempNo;
            tmp = lstAssessment.Items.Count;
            temp = lstAssessment.Items[tmp-1].ToString();
            tempNo = tmp;
            //this works out grade scores but i could not get it to work smoothly the math i was using is simple grade timed by weight and add together, in the case of a exam i guessed an exam is worth 50% of a module
            if (temp == "Exam")
            {
                marker(tempNo);
                moduleMark[lstModule.SelectedIndex] = ((examMark[lstModule.SelectedIndex])/2) + (sum /2);
            }
            else
            {
                marker(tempNo);
                moduleMark[lstModule.SelectedIndex] = sum;
            }
            lblModName.Text = moduleName[lstModule.SelectedIndex];
            lblModMark.Text = Convert.ToString(moduleMark[lstModule.SelectedIndex]) + "%";
            lblModCredit.Text = Convert.ToString(moduleCredit[lstModule.SelectedIndex]);

        }

        private void lstAssessment_SelectedIndexChanged(object sender, EventArgs e)
        {

            temp = moduleAssess[lstModule.SelectedIndex].Replace("   ", ",");
            assessData = temp.Split(splitter);
            assessments = Convert.ToInt32(assessData.Count()) - 1;
            lblAssessName.Text = lstAssessment.SelectedItem.ToString();
            if ((lstAssessment.SelectedIndex * 3 + 2) > assessData.Count())
            {
                lblAssessMark.Text = Convert.ToString(examMark[lstModule.SelectedIndex]) + "%";
                lblAssessWeight.Text = "N/A";
            }
            else
            {
                lblAssessMark.Text = assessData[lstAssessment.SelectedIndex * 3 + 1] + "%";
                lblAssessWeight.Text = assessData[lstAssessment.SelectedIndex * 3 + 2];
            }          
        }

        public void marker(decimal tempNo)
        {
            //this does all the calculating for the marks
            temperory = new decimal[Convert.ToInt32(tempNo)];
            temp = moduleAssess[lstModule.SelectedIndex].Replace("   ", ",");
            assessData = temp.Split(splitter);
            assessments = Convert.ToInt32(assessData.Count()) - 1;
            for (int num = 0; num < (tempNo - 1); num++)
            {
                temperory[number] = ((Convert.ToDecimal(assessData[number * 3 + 1])) * (Convert.ToDecimal(assessData[number * 3 + 2])));
                    number++;
            }
            
            sum = temperory.Sum();
            number = 0;
            //return sum;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //The format of the text file is similar to the statement of results, i did this for both ease of use and it made sense to use it as a model.
            //I have ommitted a lot of loose data that wasnt needed this also made my job of reading in data easier.
            openFileDialog1.InitialDirectory = "D:\\Dropbox\\University\\SOFT144\\Assignment Grade Tracker\\gradechecker\\gradechecker";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            int lineCount = System.IO.File.ReadAllLines(openFileDialog1.FileName).Count();
                            textDoc = new string[lineCount + 1];
                            int n = 0;
                            string[] lines = System.IO.File.ReadAllLines(openFileDialog1.FileName);
                            foreach (string line in lines)
                            {
                                textDoc[n] = line;
                                n++;
                            }
                            lstModule.Items.Clear();
                            header();
                            dataSort(lineCount);
                            
                            
                        }//end mystream
                    }//end if
                }//end try
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);

                }//End catch
            }//End if
        } //End Open

        public void header()
        {
            //Header Info
            lblStuName.Text = textDoc[0];
            lblStuID.Text = textDoc[1];
            lblDOB.Text = textDoc[2];
            lblCourseName.Text = textDoc[3];
            lblNumModules.Text = textDoc[4].Replace("Number of modules: ", "");
        }

        public void dataSort(int count)
        {
            int n = 0;
            int modules = Convert.ToInt32(lblNumModules.Text);
            moduleCode = new string[modules];
            moduleName = new string[modules];
            moduleCredit = new int[modules];
            exam = new bool[modules];
            examName = new string[modules];
            examMark = new decimal[modules];
            moduleMark = new decimal[modules];
            moduleAssess = new string[modules];
            assessMark = new decimal[4];
            assessData = new string[modules];
            

            for (int i = 0; i > modules; i++)
            {
                exam[i] = false;
            }


                //i start at 5 as we know lines 0-4 are header info and line 5 is empty
                for (int i = 5; i < count; i++)
                {
                    if (textDoc[i] == "Coursework")
                    {

                        //This was a method i mainly used for testing but ended up keeping it rather then re-write another
                        bool tester = false;
                        while (tester == false)
                        {
                            if (i == (count))
                            {
                                break;
                            }
                            else if (textDoc[i] == "Examination" || textDoc[i] == "")
                            {
                                tester = true;
                                
                            }
                            else
                            {
                                i++;
                                if (textDoc[i] == "" || textDoc[i] == null)
                                {
                                    continue;
                                }
                                else
                                {
                                    if (moduleAssess[n] == null)
                                    {
                                        moduleAssess[n] = textDoc[i];
                                    }
                                    else
                                    {
                                        moduleAssess[n] = moduleAssess[n] + "   " + textDoc[i];
                                    }
                                }                              
                            }

                        }
                        moduleAssess[n] = moduleAssess[n].Replace("Examination", "");
                        temp = moduleAssess[n].Replace("   ", ",");                        
                        assessData = temp.Split(splitter);
                        n++;
                        i--;
                    }
                        // i use a lot of if statements to help keep the data i get out in right format although if its too different when i use it i will catch an error
                    else if (textDoc[i] == "Examination")
                    {
                        i++;                        
                        exam[n - 1] = true;
                        textDoc[i] = textDoc[i].Replace("   ", ",");
                        moduleData = textDoc[i].Split(splitter);
                        examName[n - 1] = moduleData[0];
                        examMark[n - 1] = Convert.ToDecimal(moduleData[1]);                        
                        continue;
                    }
                    else if (textDoc[i] == "")
                    {
                        continue;
                    }
                    else
                    {
                        textDoc[i] = textDoc[i].Replace("   ", ",");
                        moduleData = textDoc[i].Split(splitter);
                        moduleCode[n] = moduleData[0];
                        moduleName[n] = moduleData[1];
                        moduleCredit[n] = Convert.ToInt32(moduleData[2]);
                        lstModule.Items.Add(moduleCode[n]);
                    }                    
                }
                //i did consider using a database to hold the values but decided against this.
        }
    }//End class
}//End namespace
            
            

