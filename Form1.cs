using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Exercise_with_List_2
{
    public partial class Form1 : Form
    {
        List<StudentResult> StudentResultsList = new List<StudentResult>();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnReadStudents_Click(object sender, EventArgs e)
        {
            using (StreamReader ReadObject = new StreamReader("StudentResults.txt"))
            {
                string r = "";
                string[]data;
                StudentResult sr = null;
                while(!ReadObject.EndOfStream)
                {

                    r = ReadObject.ReadLine();
                    data = r.Split(';');
                    sr = new StudentResult(data[0], Convert.ToDouble(data[1])); ;
                    StudentResultsList.Add(sr);

                }




            }

            lbResult.DataSource = StudentResultsList;

        }
    }
}
