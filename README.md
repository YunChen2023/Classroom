# Classroom
The Classroom application is a C# Windows Forms program designed to manage classroom data, including teacher information, class details, room number, date, and student-specific data within a DataGridView interface. It includes features for reading and writing data from/to external files, sorting student records, searching for specific students, and saving data in different formats.

# Features
* Dynamic DataGridView Setup: The application dynamically sets up the DataGridView with columns and rows based on constants (TOTAL_COLS and TOTAL_ROWS) defined in the code.
* ReadData Function: Reads data from an external file specified by the user and populates the DataGridView and text boxes with the retrieved information.
* DisplayClassroomData Function: Displays classroom data in the DataGridView, including student information and colored cells.
* Open File Dialog: Allows users to select and open a text file containing classroom data.
* Save and Save As Functionality: Enables saving classroom data to a text file either by overwriting an existing file or saving as a new file.
* Binary Search for Students: Implements binary search functionality to quickly find and display student records based on their names.
* Sort Student List: Sorts the list of student records alphabetically and displays them in a message box for easy reference.

# Installation
* Clone or download the repository to your local machine.
* Open the solution file (Classroom.sln) in Visual Studio.
* Build the solution to compile the application.
* Run the application to start managing classroom's information.

# Usage Example
* Place the CSV file titled "Class_5B_Caroline_14June2023" in the designated location on the D drive:

  ![image](https://github.com/YunChen2023/Classroom/assets/143974178/5fe2ebdd-3935-4eb8-9c3e-2262910a1684)

* Launch the application

  ![image](https://github.com/YunChen2023/Classroom/assets/143974178/399e9579-d527-42db-93a4-9d09cd0e43f0)

* Click on the "File" menu and choose the "Open" option. Select the "Class_5B_Caroline_14June2023" CSV file from the file selection dialog, and subsequently click on the "Open" button. As a result, the classroom layout will be displayed on the screen:

  ![image](https://github.com/YunChen2023/Classroom/assets/143974178/3e7f03d2-4a8f-49b7-9ebd-de5218dc27b9)

  ![image](https://github.com/YunChen2023/Classroom/assets/143974178/c15fa154-ef49-4fe4-9884-a00f26f29910)

  ![image](https://github.com/YunChen2023/Classroom/assets/143974178/e084615b-8035-4ac4-933a-280e7bd696af)

* Modify the name of the first student from "Yun" to "Chen" by editing the corresponding field. Proceed by clicking the "Save Changes" button, triggering a file save dialog to appear. Enter the desired file name as "NewFile" and click on the "Save" button. A pop-up notification will then be displayed, indicating that the class data has been successfully saved to the location "D:\NewFile".

  ![image](https://github.com/YunChen2023/Classroom/assets/143974178/71b72868-249a-42b9-8305-b3584cd7695a)

  ![image](https://github.com/YunChen2023/Classroom/assets/143974178/199b6de0-e374-4b02-9bc1-b459196fb81c)

* Navigate to the D drive and locate the file named "NewFile". Open the file to view its contents. Verify that the name of the new student, "Chen", is correctly updated in the file.

  ![image](https://github.com/YunChen2023/Classroom/assets/143974178/efb720ea-201f-423c-a5f0-05aa6a13d5d7)

  





 
