/*
    Filename:   Form1.cs
    Purpose:    1. Set up GUI components for running application
                2. Set up customisation for Data Grid View (table object)
                3. Initialise private data - cellList and studentList
                4. Initialise private data - currentFilePath and sortStatus
    Author:     
    Date:       
    Version:    1.0
    Notes:      Potential Issues:
	

    Development Plan:
                1. Create GUI components
                2. Create Cell class (data for students, desks mapping for class)
                3. Set up Constructor method to include Data Grid View customisations
                4. ReadData() called from FILE > OPEN menu item
                5. DisplayCellData() called from FILE > OPEN menu item
                6. WriteData() called from FILE > SAVE and FILE > SAVE AS
                7. RAF_WriteData() called from RAF Button event handler
                8. LinearSearch() called from Find Button event handler
                9. BinarySearch() called from Find Button event handler
                10. ClearStudentData() called from Clear Button event handler and FILE > OPEN
                11. ExitForm() called from Exit Button event handler

    Testing Plan (functionality - alpha - in house)
                1. Launch app and use FILE > OPEN to read .csv external file
                          Display of data seen in text boxes and data grid view
                2. Use File > Open to read a .jpg image file
                          Display error message in pop-up window
                3. Use File > Save as
                4. Use File > Save
                5. Use File > Exit
                6. Clear text boxes and data grid view
                7. Sort student names alphabetically and display with rows/cols
                8. Search for a student name and display
                9. Save binary file version (RAF or 'Random Access File')


*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classroom
{
    public partial class Classroom_Form : Form
    {
        // constants
        public const int TOTAL_ROWS = 19;
        public const int TOTAL_COLS = 11;

        // private data for the GUI Form
        private List<Cell> cellList;    
        private List<Cell> studentList; // student-only cell list for sorting/search purposes

        private List<Cell> cellCompleteList;

        private string currentFilePath; // external file where data comes from and displayed
        private bool sortStatus;        // true-false to track if student data is sorted
        private bool saveStatus;        // true-false to track whether the data has been saved

        /****************************************************************
        Method:     Classroom_Form() Constructor method
        Purpose:    1. Initialise and set up GUI application
                    2. Customise Data Grid View Table object
                    3. Initialise and set up cellList, studentList and currentFilePath variables
        Input:      void
        *****************************************************************/
        public Classroom_Form()
        {
            InitializeComponent();

            for (int i = 0; i < TOTAL_COLS - 1; i++)
            {
                classroom_DataGridView.Columns.Add(i.ToString(), i.ToString());
            }

            // add further rows to data grid view (total of 19 required)
            for (int i = 0; i < TOTAL_ROWS - 1; i++)
            {
                classroom_DataGridView.Rows.Add();
            }

            // set appropriate row header width (for row header numbers)
            classroom_DataGridView.RowHeadersWidth = 50;

            // set up row header numbers starting with 0
            for (int count = 0; count <= (classroom_DataGridView.Rows.Count - 1); count++)
            {
                classroom_DataGridView.Rows[count].HeaderCell.Value = string.Format((count).ToString(), "0");
            }

            // set up font style and size for the data grid view
            classroom_DataGridView.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);

            // initialise cellList
            cellList = new List<Cell>();
            // initialise studentList (used for sorting and binary search)
            studentList = new List<Cell>();

            cellCompleteList = new List<Cell>();

            studentList.Sort();

            // initialise currentFilePath
            currentFilePath = "";
            // initialise sortStatus to false
            sortStatus = false;
            // intialiase saveStatus to true
            saveStatus = true;
        }
        

        private void ReadData()
        {
            try
            {
                using (StreamReader file = new StreamReader(currentFilePath))
                {
                    int counter = 0;
                    string line = "";

                    while ((line = file.ReadLine()) != null)
                    {
                        string[] lineArray = line.Split(',');

                        if (counter < 4)
                        {
                            switch (counter)
                            {
                                case 0:
                                    teacher_TextBox.Text = lineArray[1];
                                    break;
                                case 1:
                                    class_TextBox.Text = lineArray[1];
                                    break;
                                case 2:
                                    room_TextBox.Text = lineArray[1];
                                    break;
                                case 3:
                                    date_TextBox.Text = lineArray[1];
                                    break;
                            }
                        }
                        else
                        {
                            int columnID = int.Parse(lineArray[0]);
                            int rowID = int.Parse(lineArray[1]);
                            string cellContent = lineArray[2];
                            string cellColor = lineArray[3];

                            Cell readinCell = new Cell(columnID, rowID, cellContent, cellColor);

                            if (counter == 4)
                            {
                                classroom_DataGridView.Rows[rowID].Cells[columnID].Value = cellContent;
                            }
                            else if(!string.IsNullOrEmpty(cellColor) && cellColor.Equals("blue", StringComparison.OrdinalIgnoreCase))
                            {
                                cellList.Add(readinCell);
                            }
                            else
                            {
                                studentList.Add(readinCell);
                            }

                            cellCompleteList.Add(readinCell);
                        }
                        counter++;
                    }

                    file.Close();
                }
            }
            catch (IOException ioe)
            {
                MessageBox.Show("ERROR: Problem in reading the external file: " + currentFilePath, "ERROR!");
                Console.WriteLine(ioe.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: Problem with external file format: " + currentFilePath, "ERROR!");
                Console.WriteLine(ex.Message);
            }
        }


        private void DisplayClassroomData()
        {
            if (cellList.Count > 0)
            {
                // Loop through the cellList to display content and color
                foreach (Cell cell in cellList)
                {
                    int columnID = cell.ColumnID;
                    int rowID = cell.RowID;
                    
                    classroom_DataGridView.Rows[rowID].Cells[columnID].Style.BackColor = Color.SkyBlue;

                }
            }
            if (studentList.Count > 0)
            {
                foreach (Cell student in studentList)
                {
                    int columnID = student.ColumnID;
                    int rowID = student.RowID;
                    string content = student.CellContent;
                    
                    classroom_DataGridView.Rows[rowID].Cells[columnID].Value = content;
                    classroom_DataGridView.Rows[rowID].Cells[columnID].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
        }




        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "D:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*) | *.*";

            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                currentFilePath = openFileDialog.FileName;
                if (cellCompleteList.Count > 0)
                {
                    // clear list
                    cellCompleteList.Clear();
                }
                // read from selected external file
                classroom_DataGridView.CellValueChanged -= classroom_DataGridView_CellValueChanged_1;
                saveStatus = false;
                ReadData();
                saveStatus = true;
                
                DisplayClassroomData();

                classroom_DataGridView.CellValueChanged += classroom_DataGridView_CellValueChanged_1;

                //MessageBox.Show("File > Open menu item selected");
            }
        }
        


        /****************************************************************
        Method:     RAF_WriteData()
        Purpose:    Write to external file a binary version of the cellList data
        Input:      string fileName (file to write to)
        Output:     void
        *****************************************************************/
        private void RAF_WriteData(string fileName)
        {
            // get data to write
            string dataToWrite = "Teacher:," + teacher_TextBox.Text + "\r\n";
            dataToWrite += "Class:," + class_TextBox.Text + "\r\n";
            dataToWrite += "Room:," + room_TextBox.Text + "\r\n";
            dataToWrite += "Date:," + date_TextBox.Text + "\r\n";
            
            if (cellCompleteList.Count > 0)
            {
                for (int i = 0; i < cellCompleteList.Count; i++)
                  {
                     if (i == cellCompleteList.Count - 1)
                       {
                            dataToWrite += cellCompleteList[i].ToString();
                       }
                     else
                       {
                            dataToWrite += cellCompleteList[i].ToString() + "\r\n";
                       }
                  }
               
                 try
                {
                    // FileStream object (sets up file stream with target file name usually in .bin or .dat format)
                    // FileMode.Append means putting the stream in append mode (to write content which is added to any pre-existing content)
                    // FileMode.Create means over-writing the existing content in the binary data file
                    FileStream fstream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                    //create a binary writer object
                    BinaryWriter bwStream = new BinaryWriter(fstream);
                    //set file position where to write data
                    //fstream.Position = pos * size;
                    //write data
                    bwStream.Write(dataToWrite);
                    //close objects
                    bwStream.Close();
                    fstream.Close();
                    MessageBox.Show("Classroom data successfully written to random access file " + fileName, "SUCCESS - Random Access File written!");
                }

                catch (Exception e)
                {
                    MessageBox.Show("ERROR: Classroom data NOT written to random access file " + fileName, "ERROR - Problem in writing to random access file");
                    Console.WriteLine(e.StackTrace);
                }

            }
        } // end RAF_WriteData() method

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            if (studentList.Count > 0)
            {
                foreach (Cell student in studentList)
                {
                    int columnID = student.ColumnID;
                    int rowID = student.RowID;
                    
                    classroom_DataGridView.Rows[rowID].Cells[columnID].Value = "";
                    //classroom_DataGridView.Rows[rowID].Cells[columnID].Style.BackColor = Color.White;
                }
                /*teacher_TextBox.Text = "";
                class_TextBox.Text = "";
                room_TextBox.Text = "";
                date_TextBox.Text = "";*/
            }
        }

        private void saveRAF_Button_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.Title = "Save RAF File";
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                RAF_WriteData(fileName);
            }
        }

        private void sort_Button_Click(object sender, EventArgs e)
        {
            studentList.Sort();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Student\t\tRow\tColumn");
            foreach (var student in studentList)
            {
                sb.AppendLine($"{student.CellContent}\t\t{student.RowID}\t{student.ColumnID}");
            }
            string studentListString = sb.ToString();

            MessageBox.Show(studentListString, "Sorted Student List", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string dataToWrite = "Teacher:," + teacher_TextBox.Text + "\r\n";
                dataToWrite += "Class:," + class_TextBox.Text + "\r\n";
                dataToWrite += "Room:," + room_TextBox.Text + "\r\n";
                dataToWrite += "Date:," + date_TextBox.Text + "\r\n";

                if (cellCompleteList.Count > 0)
                {
                    foreach (Cell cell in cellCompleteList)
                    {
                        dataToWrite += cell.ToString() + "\r\n";
                    }
                    File.WriteAllText(currentFilePath, dataToWrite);
                    MessageBox.Show("Class data saved to " + currentFilePath, "FILE SAVE SUCCESSFUL!");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Could not save data to " + currentFilePath, "FILE SAVE FAILED!");
                Console.WriteLine(exc.StackTrace);
            }
        }

        private void find_Button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(search_TextBox.Text))
            {
                MessageBox.Show("Student name is required in the search field", "ERROR!");
                return;
            }
            else
            {
                string nameToSearch = search_TextBox.Text;
                int foundIndex = BinarySearch(nameToSearch);
                if (foundIndex < 0)
                {
                    MessageBox.Show("No record found for " + nameToSearch, "NOT FOUND!");
                }
                else
                {
                    studentList.Sort();
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("Student\t\tRow\tColumn");

                    for (int i = 0; i < studentList.Count; i++)
                    {
                        var student = studentList[i];
                        string studentInfo = $"{student.CellContent}\t\t{student.RowID}\t{student.ColumnID}";

                        if (i == foundIndex)
                        {
                            studentInfo += " <- FOUND"; 
                        }

                        sb.AppendLine(studentInfo);
                    }

                    string studentListString = sb.ToString();
                    MessageBox.Show(studentListString, "Sorted Student List", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public int BinarySearch(string searchName)
        {
            studentList.Sort();
            /*foreach (var student in studentList)
            {
                Console.WriteLine($"CellContent: {student.CellContent}");
                Console.WriteLine($"RowID: {student.RowID}");
                Console.WriteLine($"ColumnID: {student.ColumnID}");
                Console.WriteLine($"CellColor: {student.CellColor}");
                Console.WriteLine();
            }*/

            int foundIndex = -1;
            int firstIndex = 0;
            int lastIndex = studentList.Count - 1;
            while (firstIndex <= lastIndex)
            {
                int midIndex = (firstIndex + lastIndex) / 2;
                string nameToCompare = studentList[midIndex].CellContent;
                if (nameToCompare.CompareTo(searchName) == 0)
                {
                    foundIndex = midIndex;
                    break;
                }
                else if (nameToCompare.CompareTo(searchName) > 0)
                {
                    lastIndex = midIndex - 1;
                }
                else
                {
                    firstIndex = midIndex + 1;
                }
            }
            return foundIndex;
        }


        private void classroom_DataGridView_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {
            if (saveStatus && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell changedCell = classroom_DataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (changedCell.Value != null)
                {
                    string newCellValue = changedCell.Value.ToString();

                    foreach (var cellComplete in cellCompleteList)
                    {
                        if (e.RowIndex == cellComplete.RowID && e.ColumnIndex == cellComplete.ColumnID)
                        {
                            cellComplete.CellContent = newCellValue;
                            break;
                        }
                    }
                }

                saveStatus = false;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dataToWrite = "Teacher:," + teacher_TextBox.Text + "\r\n";
            dataToWrite += "Class:," + class_TextBox.Text + "\r\n";
            dataToWrite += "Room:," + room_TextBox.Text + "\r\n";
            dataToWrite += "Date:," + date_TextBox.Text + "\r\n";

            if (cellCompleteList.Count > 0)
                {
                    foreach (Cell cell in cellCompleteList)
                    {
                        dataToWrite += cell.ToString() + "\r\n";
                    }
                }
           
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = "D:\\";
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*) | *.*";

            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                currentFilePath = saveFileDialog.FileName;
                try
                {
                    File.WriteAllText(currentFilePath, dataToWrite);
                    MessageBox.Show("Class data saved to " + currentFilePath,
                    "FILE SAVE AS SUCCESSFUL!");
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Could not save data to " + currentFilePath,
                   "FILE SAVE AS FAILED!");
                    Console.WriteLine(exc.StackTrace);
                }
            }
        }

        private void save_Button_Click(object sender, EventArgs e)
        {
            string dataToWrite = "Teacher:," + teacher_TextBox.Text + "\r\n";
            dataToWrite += "Class:," + class_TextBox.Text + "\r\n";
            dataToWrite += "Room:," + room_TextBox.Text + "\r\n";
            dataToWrite += "Date:," + date_TextBox.Text + "\r\n";

            if (cellCompleteList.Count > 0)
            {
                foreach (Cell cell in cellCompleteList)
                {
                    dataToWrite += cell.ToString() + "\r\n";
                }
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = "D:\\";
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*) | *.*";

            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                currentFilePath = saveFileDialog.FileName;
                try
                {
                    File.WriteAllText(currentFilePath, dataToWrite);
                    MessageBox.Show("Class data saved to " + currentFilePath,
                    "FILE SAVE AS SUCCESSFUL!");
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Could not save data to " + currentFilePath,
                   "FILE SAVE AS FAILED!");
                    Console.WriteLine(exc.StackTrace);
                }
            }
        }
    }
}
