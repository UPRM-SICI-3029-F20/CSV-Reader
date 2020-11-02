using System;
using System.IO;
using System.Windows.Forms;

namespace CSV_Reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void BtnProcessGrades_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader myInputFile;
                string rowOfGrades;
                int total = 0 ;
                double avg;
                char delimiter = ',';  // assumes a comma delimted (CSV) file

                // Open File (CSV = Comma Seperated Values)
                myInputFile = File.OpenText("C:\\Users\\Jose\\Desktop\\App_Data\\Grades.csv");
                // Edit the above path according to your environment.
                // Note: Rememeber, if no path is indicated the files are saved in bin/debug/netcoreapp3.1

                // Read file line by line
                while (!myInputFile.EndOfStream)
                {
                    rowOfGrades = myInputFile.ReadLine();
                    // Saves grades into a string array (get tokens)
                    string[] individualGrades = rowOfGrades.Split(delimiter);

                    total = 0;
                    // Accumulate/Totalize the sum of all the grades
                    foreach (string g in individualGrades)
                    {
                        total += Convert.ToInt32(g);
                    }

                    avg = (double)total / individualGrades.Length;

                    // Add info of the row processed to ListBox
                    LBoxAverages.Items.Add($"Grades: {rowOfGrades} ==> Avg. is {avg:n1}");
                    
                }

                // Don't forget to close file when done
                myInputFile.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
