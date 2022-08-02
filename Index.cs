using cmrds_manager.Config;
using Excel = Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace cmrds_manager
{
    public partial class Index : Form
    {
        // Private list.
        private List<Group> _groups;
        private List<Person> _persons;

        // Private file infos.
        private string _filepath;
        private string _dirpath;
        private string _filename;

        // Work rules.
        private int _maxgroupsize;

        // Usefull data.
        private int _personsnumber;
        private int _groupsnumber;

        public Index()
        {
            InitializeComponent();

            // Initialisation.
            _groups = new List<Group>();
            _persons = new List<Person>();
        }

        private void Btn_Select_File_Click(object sender, EventArgs e)
        {
            // Get excel file info's.
            Get_Excel_File_Infos();
        }

        private void Btn_Launch_Treatment_Click(object sender, EventArgs e)
        {
            // Explicit.
            Set_Groups_Size();

            // Launch the treatment.
            Excel_Treatment();
        }

        /***********/
        /* Methods */
        /***********/

        // Get excel file info's.
        public void Get_Excel_File_Infos()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "*.xls|";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _filepath = openFileDialog.FileName;
                _dirpath = System.IO.Path.GetDirectoryName(_filepath);
                _filename = System.IO.Path.GetFileNameWithoutExtension(_filepath);
            }
        }

        // Set max size of groups.
        public void Set_Groups_Size()
        {
            _maxgroupsize = (int)numUD_Group_Size.Value;
        }


        // Explicit.
        public void Excel_Treatment()
        {
            // Get and transform excel data into Person object store in _persons list. 
            Get_Excel_Data();

            // Constitution of groups.
            Groups_Constitution();

            // Export data's into file.
            Export_Data();
        }
        
        // Scrap data into excel file.
        public void Get_Excel_Data()
        {
            // Initialisation of excel file into app.
            Excel.Application excel = new Excel.Application();
            Excel.Workbook excelWb = excel.Workbooks.Open(_filepath);
            Excel.Worksheet excelWs = (Excel.Worksheet) excelWb.Worksheets[1];

            // Data scraper.
            bool stillData = true;
            int excelRowNumber = 1;

            while (stillData)
            {
                // Get person data's

                    // Name
                Excel.Range nameRange = excelWs.Cells[excelRowNumber, 1] ;
                string name = nameRange.Value;

                    // Firstname
                Excel.Range firstnameRange = excelWs.Cells[excelRowNumber, 2];
                string firstname = firstnameRange.Value;

                    // Division
                Excel.Range divisionRange = excelWs.Cells[excelRowNumber, 3];
                string division = divisionRange.Value.ToLower();

                    // Seniority
                Excel.Range seniorityRange = excelWs.Cells[excelRowNumber, 4];
                int seniority = (int)seniorityRange.Value;

                    // Staff
                Excel.Range staffRange = excelWs.Cells[excelRowNumber, 5];
                bool staff;

                if (staffRange.Value == 0)
                {
                    staff = false;
                }
                else
                {
                    staff = true;
                }

                // Create and add person into persons list.
                Person person = new Person(name, firstname, division, seniority, staff);
                _persons.Add(person);

                // Go to next row
                excelRowNumber++;

                // Check if next row still have data (only first collumn)
                Excel.Range nextRow = excelWs.Cells[excelRowNumber, 1];
                if (nextRow.Value == null)
                {
                    stillData = false;
                }
            }

            _personsnumber = _persons.Count;
        }

        // Constitution of groups of people according to the indicated parameters.
        public void Groups_Constitution()
        {
            // Creation of groups.
            Groups_Creation();

            // Distribution of leader.
            Leader_Distribution();

            // Distribution of people.
            People_Distribution();
        }

        // Creation of group entities and store into groups list. 
        public void Groups_Creation()
        {
            // Retrieve the number of groups and create them.
            for (int i = 1; i <= Calculation_Group_Number(); i++)
            {
                Group group = new Group();
                _groups.Add(group);
            }
        }

        // Calculation of the number of groups.
        public int Calculation_Group_Number()
        {
            _groupsnumber = (int)Math.Ceiling((float)_personsnumber / _maxgroupsize);
            return _groupsnumber;
        }

        // Get the oldest people and put them in chief.
        public void Leader_Distribution()
        {
            // Sort by the most seniority in order to have in leader the most experienced.
            _persons = _persons.OrderByDescending(x => x.Seniority).ToList();

            // Adding a leader to groups.
            foreach (Group group in _groups)
            {
                group.List.Add(_persons[0]);
                _persons.RemoveAt(0);
            }
        }

        // Shuffle people and add in groups.
        public void People_Distribution()
        {
            bool looping = true;

            // Shuffle people.
            _persons.Shuffle();

            // Add people in groups.
            while (looping)
            {
                foreach (Group group in _groups)
                {
                    if (_persons.Count != 0)
                    {
                        group.List.Add(_persons[0]);
                        _persons.RemoveAt(0);
                    }
                    else
                    {
                        looping = false;
                    }
                }
            }
        }

        // Export data's into new excel file.
        public void Export_Data()
        {
            Excel.Application export = new Excel.Application();
            Excel.Workbook exportWb = export.Workbooks.Add();
            Excel.Worksheet exportWs = (Excel.Worksheet) exportWb.Sheets.Add();

            int currentLine = 1;

            /*
             * Excel.Range seniorityRange = excelWs.Cells[excelRowNumber, 4];
             * 
                int seniority = (int)seniorityRange.Value;
            */

            foreach (Group group in _groups)
            {
                exportWs.Cells[currentLine, 1] = "Nom de groupe : ";
                currentLine++;
                foreach(Person person in group.List)
                {
                    exportWs.Cells[currentLine, 1] = person.Name;
                    exportWs.Cells[currentLine, 2] = person.Firstname;
                    exportWs.Cells[currentLine, 3] = person.Division;
                    exportWs.Cells[currentLine, 4] = person.Seniority;
                    exportWs.Cells[currentLine, 5] = person.Staff;

                    currentLine++;
                }
                currentLine++;
            }

            export.ActiveWorkbook.SaveAs(@"" + _dirpath + "\\" + _filename + " - Traité", Excel.XlFileFormat.xlWorkbookNormal);

            MessageBox.Show("Votre fichier a bien été traité !");

            exportWb.Close();
            export.Quit();

        }
    }

    static class ExtensionsClass
    {
        private static Random rng = new Random();

        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
