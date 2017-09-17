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
using System.Security;
using System.Security.Cryptography;
using System.Runtime.InteropServices;

/*

 ____________________________________
/ Salary Calculator 3000 by Sagindyk \
\                         Urazayev   /
  —----------------------------------
        \   ^__^
         \  (oo)\_______
            (__)\       )\/\
                ||----w |
                ||     ||
/// This Application calculates employees salary.
/// Additional features:
/// 1. Login with different accounts: admin, accountant and supervisor, therefore with different access levels to
/// prevent integrity, privacy, security, relaiblity and policy issues.
/// 2. Availability to upload images and see them on further starts of the Salary Calculator 3000.
/// 3. Edit, update records.
/// 4. Delete records.
/// 5. Along with the salary, calculate premium for each record, based on performance level and number of
/// skipped days.
/// 6. Automatically save all the data from the application into the plain text file.
/// 7. Automatically upload all the data from the plain text file into the application.
/// 8. Open graphs/charts.
/// 9. Choose different types of graphs/charts, such as: PieChart, AreaChart, LineChart, DoughnutChart,
/// CandleStickChart, BubbleChaty, ColumnChart, FunnelChart.
/// 10. Sort all record by the salaray in descending order.
/// 11. Save everything into txt file
/// 12. Log files

*/

namespace WindowsFormsApp1
{
    // The mainForm class
    public partial class mainForm : MetroFramework.Forms.MetroForm
    {
        // Initializng all components
        public mainForm()
        {
            InitializeComponent();
        }

        int IDnum; // Variable to navigate through listviewitem
        int AMOUNT = 500; // Maximum amount of employees
        int amountEmp = 0; // Amount of employees by default

        // Created 500 instances by default
        employeeClass[] empl = new employeeClass[500];

        // Creating strings for localization
        String amountGroup, addE, editE, removeE, sortE, uploadE, infoGroup, dataGroup, budgetGroup, REPORT,
        nameE, surnameE, educationE, skipped, performanceE, budgetE, wPremiumE, calculate, developerE, DeleteALL,
        loggedAsAdmin, meanSalary, medianSalary, lowerSalary, upperSalary, standardDeviation, IQRE, openChart;

        // String to store education levels
        String SECONDARY, HIGH, COLLEGE, UNIVERSITY, MASTER,
            LIMIT, SKIPPED, EDUCATION, EMPTY, BUDGET,
            IMAGESIZE,
            namess, usser;

        // Strings
        String NOTHING = "";            // Nothing
        String SPACE = " ";             // Space
        String TABS = "\n      ";       // It's used instead of \t
        String IMAGE;                   // Variable to store image location
        String NOIMAGE = "noimage.jpg"; // Noimage file location
        String FZERO = "0.00";          // ZERO VALUE FLOAT
        String IZERO = "0";
        String SAVEDTT = "Saved!";
        String SAVEDEMPL = "Saved into \"employees.txt\"";
        String YEARDAYS = "365";
        String DEVELOPER = " The \"Salary Calculator\" " +
                "\n Created by Sagindyk Urazayev, using Visual Studio 2017" +
                "\n Hope you are enjoying the application!";        //Developer

        // File names:
        String EMPLOYEEST = "employees.txt";
        String LOGINT = "login.txt";
        String NAMEST = "names.txt";
        String AMOUNTT = "amount.txt";
        String STATT = "stat.txt";
        String SC = "report.txt";

        // Access levels
        String ADMINAL = "admin";
        String ACCOUNTANTAL = "accountant";
        String USERAL = "user";

        // Temporary variable for seleting and editing records
        employeeClass tempss = new employeeClass();

        // Function that activates particular localization
        private void setThings()
        {
            amountGR.Text = amountGroup + SPACE + amountEmp;
            AddButton.Text = addE;
            EditButton.Text = editE;
            RemoveButton.Text = removeE;
            SortButton.Text = sortE;
            uploadB.Text = uploadE;
            emplGR.Text = infoGroup;
            analyzedGR.Text = dataGroup;
            preferGR.Text = budgetGroup;
            nameLB.Text = nameE;
            surnameLB.Text = surnameE;
            eduLB.Text = educationE;
            skipLB.Text = skipped;
            perfLB.Text = performanceE;
            budgetLB.Text = budgetE;
            premLB.Text = wPremiumE;
            Calculate.Text = calculate;
            developerLB.Text = developerE;
            loggedL.Text = loggedAsAdmin;
            averageSalaryLB.Text = meanSalary;
            medianLB.Text = medianSalary;
            lower.Text = lowerSalary;
            upper.Text = upperSalary;
            deviationLB.Text = standardDeviation;
            IQR.Text = IQRE;
            openGraphB.Text = openChart;
            DELALL.Text = DeleteALL;
            rep.Text = REPORT;

            eduC.Items[0] = SECONDARY;
            eduC.Items[1] = HIGH;
            eduC.Items[2] = COLLEGE;
            eduC.Items[3] = UNIVERSITY;
            eduC.Items[4] = MASTER;

            imsize.Text = IMAGESIZE;
        }

        // This is russian localization
        public void setRussian()
        {
            amountGroup = "Кол-во сотрудников:";
            addE = "Доб.";
            editE = "Изм.";
            removeE = "Удалить";
            sortE = "Сорт.";
            uploadE = "Выбрать";
            infoGroup = "Информация о сотруднике";
            dataGroup = "Статистика";
            budgetGroup = "Настройки Бюджета";
            nameE = "Имя";
            surnameE = "Фамилия";
            educationE = "Образование";
            skipped = "Кол-во проп. дней";
            performanceE = "Профессионализм";
            budgetE = "Бюджет";
            wPremiumE = "С премией";
            calculate = "Рассчитать!";
            developerE = "Разработано и тестировано Сагиндыком Уразаевым.";
            loggedAsAdmin = "Добро пожаловать.";
            meanSalary = "Средняя зарплата:";
            medianSalary = "Медиана:";
            lowerSalary = "Нижний квартиль:";
            upperSalary = "Верхний квартиль:";
            standardDeviation = "Стандартное отклонение:";
            IQRE = "Разница в квартилях:";
            openChart = "Открыть график";
            DeleteALL = "ВСЕ УДАЛ.";
            REPORT = "Вывести доклад";

            SECONDARY = "Средняя школа";
            HIGH = "Старшая школа";
            COLLEGE = "Колледж";
            UNIVERSITY = "Университет";
            MASTER = "Магистр";

            LIMIT = "ЛИМИТ БЫЛ ДОСТИГНУТ!";
            SKIPPED = "Пожалуйста заполните верное количество пропущенных дней!";
            EDUCATION = "Пожалуйста заполните графу образования!";
            EMPTY = "Пожалуйста заполните все пустые поля!";
            BUDGET = "Графа бюджета пуста!";

            IMAGESIZE = "Рекоммендуется \n      110x150";

            setThings();
        }

        // This is english localization. Set by default.
        private void setEnglish()
        {
            amountGroup = "Amount of employees:";
            addE = "Add";
            editE = "Edit";
            removeE = "Remove";
            sortE = "Sort";
            uploadE = "Upload";
            infoGroup = "Employees' Information";
            dataGroup = "Analyzed Data";
            budgetGroup = "Budget Preferences";
            nameE = "Name";
            surnameE = "Surname";
            educationE = "Academic Degree";
            skipped = "Number of Skipped Days";
            performanceE = "Professionalism";
            budgetE = "Budget";
            wPremiumE = "With Premium";
            calculate = "Calculate!";
            developerE = "Developed and tested by Sagindyk Urazayev.";
            loggedAsAdmin = "Welcome, " + namess;
            meanSalary = "Average Salary:";
            medianSalary = "Median:";
            lowerSalary = "Lower Quartile:";
            upperSalary = "Upper Quartile:";
            standardDeviation = "Standard Deviation:";
            IQRE = "Interquartile Range:";
            openChart = "Open Salary Chart";
            DeleteALL = "DELETE ALL";
            REPORT = "Output Report";

            SECONDARY = "Secondary School";
            HIGH = "High School";
            COLLEGE = "College";
            UNIVERSITY = "University";
            MASTER = "Masters Degree";

            LIMIT = "THE LIMIT HAS BEEN REACHED!";
            SKIPPED = "Please fill the correct number of skipped days!";
            EDUCATION = "Please fill the education check box!";
            EMPTY = "Please fill all the empty gaps!";
            BUDGET = "The Budget Field Is Empty!";

            IMAGESIZE = "Recommended Size \n        110x150";

            setThings();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            try
            {
                StreamWriter swr = new StreamWriter(SC);
                int sec, high, coll, uni, master;
                String educc = "";
                sec = high = coll = uni = master = 0;
                for (int i = 0; i < amountEmp; i++)
                {
                    if (empl[i].getEducationLevel() == 0) sec++;
                    if (empl[i].getEducationLevel() == 1) high++;
                    if (empl[i].getEducationLevel() == 2) coll++;
                    if (empl[i].getEducationLevel() == 3) uni++;
                    if (empl[i].getEducationLevel() == 4) master++;
                }

                swr.WriteLine("Complete processed data from Salary Calculator");
                swr.WriteLine();
                swr.WriteLine("Amount of employees: " + amountEmp);
                swr.WriteLine();
                swr.WriteLine("Amount of employees with different levels of education:  ");
                swr.WriteLine();
                swr.WriteLine("\tSecondary School Education:    " + sec);
                swr.WriteLine("\tHigh School Education:         " + high);
                swr.WriteLine("\tCollege Education:             " + coll);
                swr.WriteLine("\tUniversity Education:          " + uni);
                swr.WriteLine("\tMasters Degree Education:      " + master);
                swr.WriteLine();

                swr.WriteLine("Budget information:  ");
                swr.WriteLine();
                swr.WriteLine("\tOverall budget:    " + Budget.ToString(FZERO));
                swr.WriteLine("\tSalary budget:     " + newBudget.ToString(FZERO));
                swr.WriteLine("\tPremium budget:    " + newPremium.ToString(FZERO));
                swr.WriteLine();

                swr.WriteLine("Processed data:  ");
                swr.WriteLine();
                swr.WriteLine(averageSalaryLB.Text);
                swr.WriteLine(medianLB.Text);
                swr.WriteLine(lower.Text);
                swr.WriteLine(upper.Text);
                swr.WriteLine(IQR.Text);
                swr.WriteLine(deviationLB.Text);
                swr.WriteLine();

                swr.WriteLine("List of employees:");
                swr.WriteLine();
                for (int i = 0; i < amountEmp; i++)
                {
                    swr.WriteLine("\t" + empl[i].getName() + empl[i].getSurname());
                    swr.WriteLine("\t\tSalary this month:       " + empl[i].getSalary().ToString(FZERO));
                    swr.WriteLine("\t\tPremium this month:      " + empl[i].getPremium().ToString(FZERO));
                    for (int l = 0; l < 5; l++)
                    {
                        if (empl[i].getEducationLevel() == 0) educc = "Secondary School";
                        if (empl[i].getEducationLevel() == 1) educc = "High School";
                        if (empl[i].getEducationLevel() == 2) educc = "College";
                        if (empl[i].getEducationLevel() == 3) educc = "University";
                        if (empl[i].getEducationLevel() == 4) educc = "Masters Degree";
                    }
                    swr.WriteLine("\t\tEducation level:         " + educc);
                    swr.WriteLine("\t\tNumber of skipped days:  " + empl[i].getSkippedDays());
                    swr.WriteLine("\t\tOverall performance:     " + empl[i].getPerformance());
                    swr.WriteLine();
                }
                swr.Close();

                MessageBox.Show("Saved into report.txt");
                StreamWriter log = new StreamWriter("logs.txt", true);
                log.WriteLine("[" + DateTime.Today.ToString("dd-MM-yyyy") + "|" + DateTime.Now.ToString("h:mm:ss tt") + "]" + " Successfully saved the full report. ");
                log.Close();
            }
            catch
            {
                MessageBox.Show("Something went wrong...");
                StreamWriter log = new StreamWriter("logs.txt", true);
                log.WriteLine("[" + DateTime.Today.ToString("dd-MM-yyyy") + "|" + DateTime.Now.ToString("h:mm:ss tt") + "]" + " Unsuccessfully saved the full report. ");
                log.Close();
            }

        }

        // Load profile
        private void LoadProfile_Tick(object sender, EventArgs e)
        {/*
            if (profilePicture.Image != null) profilePicture.Image.Dispose();
            try
            {
                tempss = empl[Int32.Parse(employeeL.SelectedItems[0].SubItems[3].Text)];
            }
            catch { return; }
            try
            {
                profilePicture.Image = Image.FromFile(tempss.getImage());
            }
            catch { profilePicture.Image = Image.FromFile(NOIMAGE); }
            nameT.Text = tempss.getName();
            surnameT.Text = tempss.getSurname();
            eduC.SetItemCheckState(tempss.getEducationLevel(), CheckState.Checked);
            skipT.Text = tempss.getSkippedDays().ToString();
            finT.Text = tempss.getPerformance().ToString();*/
            // OLD WAY TO SHOW INFORMATION.
            // CAUSE NUMEROUS BUGS AND MEMORY LEAKS
        }

        private void imsize_Click(object sender, EventArgs e)
        {
            //profilePicture.Image = null;
            //TEST CODE TO CHECK HOW IMAGE IS DELETED
        }

        private void employeeL_Click(object sender, EventArgs e)
        {
            IMAGE = NOTHING;
            if (profilePicture.Image != null) profilePicture.Image.Dispose();
            try
            {
                tempss = empl[Int32.Parse(employeeL.SelectedItems[0].SubItems[3].Text)];
            }
            catch
            {
                return;
            }
            try
            {
                IMAGE = tempss.getImage();
                profilePicture.Image = Image.FromFile(tempss.getImage());
            }
            catch
            {
                File.SetAttributes(NOIMAGE, FileAttributes.Normal);
                profilePicture.Image = Image.FromFile(NOIMAGE);
                File.SetAttributes(NOIMAGE, FileAttributes.Hidden);
            }
            nameT.Text = tempss.getName();
            surnameT.Text = tempss.getSurname();
            eduC.SetItemCheckState(tempss.getEducationLevel(), CheckState.Checked);
            skipT.Text = tempss.getSkippedDays().ToString();
            finT.Text = tempss.getPerformance().ToString();
        }

        private void savanim_Tick(object sender, EventArgs e)
        {
            SAVEDT.Text = NOTHING; //*CAN BE MODIFIED
            savanim.Enabled = false; //ANIMATION
        }

        private void employeeL_MouseUp(object sender, MouseEventArgs e)
        {
            //CLEARING THE ALL TEXT BOXES, IMAGE AND CHECK BOX
            if (employeeL.SelectedItems.Count == 0)
            {
                inputClear();
            }
        }

        // INSTRUCTIONS WHEN MAIN FORM IS LOADING
        private void Form1_Load(object sender, EventArgs e)
        {

            StreamWriter log = new StreamWriter("logs.txt", true);
            log.WriteLine("[" + DateTime.Today.ToString("dd-MM-yyyy") + "|" 
                + DateTime.Now.ToString("h:mm:ss tt") 
                + "] Salary Calculator has been successfuly executed.");

            // Opening the file login.txt to check the active user
            // (selected user from previous form)
            StreamReader str = new StreamReader(LOGINT);
            usser = str.ReadLine(); // Reading the account type
            namess = str.ReadLine(); // and gender
            str.Close(); // Closing the file
            if (File.Exists(LOGINT)) File.Delete(LOGINT); //Deleting the login file

            // Editing accountant privileges
            if (usser == ACCOUNTANTAL)
            {
                RemoveButton.Visible = false;
                DELALL.Visible = false;
            }

            // Editing user privileges
            if (usser == USERAL)
            {
                Calculate.Visible = false;
                RemoveButton.Visible = false;
                DELALL.Visible = false;
                loading.Visible = false;
            }


            log.WriteLine("[" + DateTime.Today.ToString("dd-MM-yyyy") + "|" + DateTime.Now.ToString("h:mm:ss tt") + "] Logged as " + usser + ".");
            // Activating all empl array instances (objects)
            for (int j = 0; j < AMOUNT; j++)
            {
                empl[j] = new employeeClass();
            }

            // Setting the progressBar animation duration
            loading.Minimum = 0;
            loading.Maximum = 1;

            // Filling the listviewitem (employeeL)
            if (amountEmp > 0)
            {
                for (int i = 0; i < amountEmp; i++)
                {
                    ListViewItem lvi = new ListViewItem(empl[amountEmp].getName() + SPACE + empl[amountEmp].getSurname());
                    employeeL.Items.Add(lvi);
                    amountEmp++;
                }

            }


            // Setting english localiztion by default
            setEnglish();
            log.WriteLine("[" + DateTime.Today.ToString("dd-MM-yyyy") + "|" + DateTime.Now.ToString("h:mm:ss tt") + "] Successfully set the language by default- ENGLISH.");

            // Checking the there is a save file
            if (File.Exists(EMPLOYEEST))
            {
                // Loading all the data
                int ammm = 0;
                StreamReader swread = new StreamReader(EMPLOYEEST);
                ammm = Int32.Parse(swread.ReadLine());
                log.WriteLine("[" + DateTime.Today.ToString("dd-MM-yyyy") + "|" + DateTime.Now.ToString("h:mm:ss tt") + "] Amount of loaded records - " + ammm + ".");
                for (int i = 0; i < ammm; i++)
                {
                    nameT.Text = swread.ReadLine();
                    surnameT.Text = swread.ReadLine();
                    eduC.SetItemChecked(Int32.Parse(swread.ReadLine()), true);
                    skipT.Text = swread.ReadLine();
                    finT.Text = swread.ReadLine();
                    IMAGE = swread.ReadLine();
                    add();
                }
                swread.Close(); // Closing the document
                log.WriteLine("[" + DateTime.Today.ToString("dd-MM-yyyy") + "|" + DateTime.Now.ToString("h:mm:ss tt") + "] Successfully loaded all records.");
            }
            log.Close();
        }

        // The add new employee button
        private void add()
        {
            // Checking if it didnt exceed the max amount of employees
            if (amountEmp > AMOUNT - 1)
            {
                MessageBox.Show(LIMIT);
                return;
            }

            // Verifying data from skippedDays box
            if (skipT.Text != NOTHING && Int32.Parse(skipT.Text) > 365)
            {
                MessageBox.Show(SKIPPED);
                skipT.Text = YEARDAYS;
                return;
            }

            // Validating that the boxes aren't empty
            if (nameT.Text != NOTHING && surnameT.Text != NOTHING && skipT.Text != NOTHING && finT.Text != NOTHING)
            {
                // Verifying if the education check box isn't empty
                try {
                    empl[amountEmp].setEducationLevel(eduC.CheckedIndices[0]);
                }
                catch {
                    MessageBox.Show(EDUCATION);
                    return;
                }

                // Setting the values from text boxes and all inputs into the employee by index
                empl[amountEmp].setName(nameT.Text);
                empl[amountEmp].setSurname(surnameT.Text);
                empl[amountEmp].setSkippedDays(Int32.Parse(skipT.Text));
                empl[amountEmp].setPerformance(Int32.Parse(finT.Text));
                empl[amountEmp].setCount((byte)amountEmp);
                empl[amountEmp].setImage(IMAGE);
                empl[amountEmp].setID(IDnum);

                // Clearing all input fields
                inputClear();

                // Filling the listviewitem
                ListViewItem lvi = new ListViewItem(empl[amountEmp].getName() + SPACE + empl[amountEmp].getSurname());
                lvi.SubItems.Add(empl[amountEmp].getSalary().ToString(FZERO));
                lvi.SubItems.Add(empl[amountEmp].getPremium().ToString(FZERO));
                lvi.SubItems.Add(empl[amountEmp].getID().ToString());
                employeeL.Items.Add(lvi);

                // Incrementing the amount of employees
                IDnum++;
                amountEmp++;
                // P.S. DO NOT CHANGE THE SEQUENCE OF THESE LINES

                // Resetting the image location
                IMAGE = NOTHING;
            }
            else
            {
                MessageBox.Show(EMPTY);
                return;
            }

            // Output the valid amount of employees
            amountGR.Text = (amountGroup + SPACE + amountEmp);
        }



        // The AddButtton event
        private void addB_Click(object sender, EventArgs e)
        {
            // Avoid copying
            if (employeeL.SelectedItems.Count == 1) return;
            add();
            StreamWriter log = new StreamWriter("logs.txt", true);
            log.WriteLine("[" + DateTime.Today.ToString("dd-MM-yyyy") + "|" + DateTime.Now.ToString("h:mm:ss tt") + "]" + " New record has been successfully added. ID " + (amountEmp - 1).ToString() + " {" + empl[amountEmp - 1].getName() + "," + empl[amountEmp - 1].getSurname() + "}");
            log.Close();
        }

        // The EDIT function
        private void update()
        {
            // Verifying data from skippedDays box
            if (skipT.Text != NOTHING && Int32.Parse(skipT.Text) > 365)
            {
                MessageBox.Show(SKIPPED);
                skipT.Text = "365";
                return;
            }

            if (nameT.Text == NOTHING || surnameT.Text == NOTHING || skipT.Text == NOTHING || finT.Text == NOTHING)
            {
                MessageBox.Show(EMPTY);
                return;
            }

            // Updating all variables from input boxes
            int selectedRow = Int32.Parse(employeeL.SelectedItems[0].SubItems[3].Text);

            try
            {
                empl[selectedRow].setEducationLevel(eduC.CheckedIndices[0]);
            }
            catch
            {
                MessageBox.Show(EDUCATION);
                return;
            }
            empl[selectedRow].setName(nameT.Text);
            empl[selectedRow].setSurname(surnameT.Text);
            empl[selectedRow].setSkippedDays(Int32.Parse(skipT.Text));
            empl[selectedRow].setPerformance(Int32.Parse(finT.Text));
            empl[selectedRow].setCount((byte)amountEmp);
            empl[selectedRow].setImage(IMAGE);
            empl[selectedRow].setID(IDnum);

            // Clearing the input boxes
            inputClear();

            // Claring the listviewitem
            listClear();

            // Filling the listviewitem again
            for (int k = 0; k < amountEmp; k++)
            {
                string[] row = { empl[k].getName() + SPACE + empl[k].getSurname(), empl[k].getSalary().ToString(FZERO), empl[k].getPremium().ToString(FZERO), k.ToString() };
                ListViewItem lvc = new ListViewItem(row);
                employeeL.Items.Add(lvc);
            }

            // Clearing the IMAGE location
            IMAGE = NOTHING;
        }

        // Edit Button event
        private void editB_Click(object sender, EventArgs e)
        {
            try
            {
                String bname = empl[Int32.Parse(employeeL.SelectedItems[0].SubItems[3].Text)].getName();
                String bsurname = empl[Int32.Parse(employeeL.SelectedItems[0].SubItems[3].Text)].getSurname();
                int bid = Int32.Parse(employeeL.SelectedItems[0].SubItems[3].Text);
                StreamWriter log = new StreamWriter("logs.txt", true);
                log.WriteLine("[" + DateTime.Today.ToString("dd-MM-yyyy") + "|" + DateTime.Now.ToString("h:mm:ss tt") + "]" + " The record has been successfully updated. ID " + bid.ToString() + " {" + bname + "," + bsurname + "}");
                log.Close();
            }
            catch { }
            try
            {
                update();
            }
            catch { return; }
        }

        // Deleting 1 row
        private void delete()
        {
            try
            {
                // Shifting the whole array to load images
                for (int i = Int32.Parse(employeeL.SelectedItems[0].SubItems[3].Text); i <= amountEmp; i++)
                {
                    employeeClass temp = new employeeClass();
                    temp = empl[i];
                    empl[i] = empl[i + 1];
                    empl[i + 1] = temp;
                }

                // Decrementing the amount of employees and ID track number
                IDnum--;
                amountEmp--;

                // Deleting the row
                employeeL.Items.RemoveAt(employeeL.SelectedIndices[0]);

                //Clearing the listviewiew item (employeeL)
                listClear();

                // Filling the employeeL
                for (int k = 0; k < amountEmp; k++)
                {
                    string[] row = { empl[k].getName() + SPACE + empl[k].getSurname(), empl[k].getSalary().ToString(FZERO), empl[k].getPremium().ToString(FZERO), k.ToString() };
                    ListViewItem lvc = new ListViewItem(row);
                    employeeL.Items.Add(lvc);
                }

                // Clearing input
                inputClear();

                // Output amount of employees
                amountGR.Text = (amountGroup + SPACE + amountEmp);
            }
            catch { }
        }

        // Back to the login screen
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            LoginWindow log = new LoginWindow();
            log.Show();
            this.Hide();
        }

        // DEBUG TOOL
        private void averageSalaryLB_Click(object sender, EventArgs e)
        {
            if (usser != ADMINAL) return;
            DEBIG.Visible = true;
            StreamWriter log = new StreamWriter("logs.txt", true);
            log.WriteLine("[" + DateTime.Today.ToString("dd-MM-yyyy") + "|" + DateTime.Now.ToString("h:mm:ss tt") + "]" + " Successfully activated debug tools. ");
            log.Close();
        }

        // Remove Button event
        private void removeB_Click(object sender, EventArgs e)
        {
            try
            {
                String bname = empl[Int32.Parse(employeeL.SelectedItems[0].SubItems[3].Text)].getName();
                String bsurname = empl[Int32.Parse(employeeL.SelectedItems[0].SubItems[3].Text)].getSurname();
                int bid = Int32.Parse(employeeL.SelectedItems[0].SubItems[3].Text);
                StreamWriter log = new StreamWriter("logs.txt", true);
                log.WriteLine("[" + DateTime.Today.ToString("dd-MM-yyyy") + "|" + DateTime.Now.ToString("h:mm:ss tt") + "]" + " The record has been successfully deleted. ID " + bid.ToString() + " {" + bname + "," + bsurname + "}");
                log.Close();
            }
            catch { }
            delete();
        }

        // ONLY DIGITS
        private void skipT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
             (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        // SELECT ONLY 1 CHECK FIELD
        private void eduC_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < eduC.Items.Count; ++ix)
                if (ix != e.Index) eduC.SetItemChecked(ix, false);
        }

        // ONLY DIGITS
        private void finT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
             (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        //CALCULATING THE SALARY PROPORCIAL
        private void calcProp()
        {
            for (int k = 0; k < amountEmp; k++)
            {
                if (empl[k].getEducationLevel() == 0) empl[k].setSalaryProporcial(1);
                if (empl[k].getEducationLevel() == 1) empl[k].setSalaryProporcial(1.18);
                if (empl[k].getEducationLevel() == 2) empl[k].setSalaryProporcial(2.69);
                if (empl[k].getEducationLevel() == 3) empl[k].setSalaryProporcial(7.67);
                if (empl[k].getEducationLevel() == 4) empl[k].setSalaryProporcial(10.13);
            }
        }

        // Budget
        double Budget = 0;
        double newBudget = 0;
        double newPremium = 0;

        // The Calculate button event
        private void button1_Click(object sender, EventArgs e)
        {
            // Conditions
            if (amountEmp == 0) return;

            // Animation
            loadTimer.Start();
            loading.Value = 0;

            // If budget text box is empty
            if (budgetT.Text == NOTHING)
            {
                MessageBox.Show(BUDGET);
                return;
            }

            //Clearing the employeeL
            listClear();

            // Setting up the budget and premium variables
            Budget = Int32.Parse(budgetT.Text);
            newBudget = Budget;
            bool premiumZ = false;

            // If premium is checked
            premiumZ = premiumC.Checked;

            // If it is checked, continue calculating
            if (premiumZ)
            {
                newBudget = 0.89 * Budget;
                newPremium = 0.21 * Budget;
            }

            // Proportials
            calcProp();

            // Proportial sum
            double sumProp = 0;
            for (int k = 0; k < amountEmp; k++) sumProp += empl[k].getSalaryProporcial();

            // Simple math to find exact budget per employee
            double odin = 0;
            odin = newBudget / sumProp;

            for (int k = 0; k < amountEmp; k++)
            {
                // CALCULATING THE SALARY
                empl[k].setSalary(empl[k].getSalaryProporcial() * odin);

                // CALCULATING OVERALL PERFORMANCE
                empl[k].setScore(2000 + 10 * (empl[k].getPerformance()) - 100 * empl[k].getSkippedDays());

                // GETTING THE PREMIUM PERCENTAGES
                if (empl[k].getScore() >= 2400) empl[k].setPremiumPercentage(1);
                if (empl[k].getScore() < 2400 && empl[k].getScore() >= 2300) empl[k].setPremiumPercentage(0.8);
                if (empl[k].getScore() < 1300 && empl[k].getScore() >= 2200) empl[k].setPremiumPercentage(0.65);
                if (empl[k].getScore() < 2200 && empl[k].getScore() >= 2100) empl[k].setPremiumPercentage(0.45);
                if (empl[k].getScore() < 2100 && empl[k].getScore() >= 2000) empl[k].setPremiumPercentage(0.2);
                if (empl[k].getScore() < 2000) empl[k].setPremiumPercentage(0);

                // CALCULATING ONE PREMIUM PROPOR
                double summ = 0;
                for (int l = 0; l < amountEmp; l++)
                {
                    summ += empl[l].getPremiumPercentage();
                }

                // CALCULATING THE PREMIUM
                double oddin = 0;
                oddin = newPremium / summ;
                for (int l = 0; l < amountEmp; l++)
                {
                    empl[l].setPremium(empl[l].getPremiumPercentage() * oddin);
                }

                // ADDING ELEMENTS TO LISTVIEW
                string[] row = { empl[k].getName() + SPACE + empl[k].getSurname(),
                    empl[k].getSalary().ToString(FZERO),
                    empl[k].getPremium().ToString(FZERO), k.ToString() };
                ListViewItem lvc = new ListViewItem(row);
                employeeL.Items.Add(lvc);

                // CALCULATING AVERAGE
                double average = newBudget / amountEmp;
                averageSalaryLB.Text = meanSalary + TABS + average.ToString(FZERO);

                // CALCULATING MEDIAN
                double[] salM = new double[amountEmp];
                for (int i = 0; i < amountEmp; i++) salM[i] = empl[i].getSalary();
                Array.Sort(salM);
                medianLB.Text = medianSalary + TABS + salM[(int)(amountEmp / 2)].ToString(FZERO);
                lower.Text = lowerSalary + TABS + salM[(int)(amountEmp * 0.25)].ToString(FZERO);
                upper.Text = upperSalary + TABS + salM[(int)(amountEmp * 0.75)].ToString(FZERO);
                IQR.Text = IQRE + TABS + (salM[(int)(amountEmp * 0.75)] - salM[(int)(amountEmp * 0.25)]).ToString(FZERO);

                // Standars Deviation
                double somm = 0;
                for (int i = 0; i < amountEmp; i++)
                {
                    somm += Math.Pow(((newBudget / amountEmp) - empl[i].getSalary()), 2.0);
                }
                double deviation = Math.Sqrt((somm / amountEmp));

                deviationLB.Text = standardDeviation + TABS + deviation.ToString(FZERO);
            }
            StreamWriter log = new StreamWriter("logs.txt", true);
            log.WriteLine("[" + DateTime.Today.ToString("dd-MM-yyyy") + "|" + DateTime.Now.ToString("h:mm:ss tt") + "]" + " Successfully calculated salaries. ");
            log.Close();
        }

        // Animation for progress bar
        private void loadTimer_Tick(object sender, EventArgs e)
        {
            loading.Value++;
            if (loading.Value == 1) loadTimer.Stop();
        }

        // ONLY DIGIT
        private void budgetT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
             (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        // Developer info
        private void developer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DEVELOPER);
        }

        // NOT USED CODE.
        private void saveFile_Click(object sender, EventArgs e)
        {
            if (amountEmp == 0) return;
            MessageBox.Show(SAVEDEMPL);
        }

        private void sortB_Click(object sender, EventArgs e)
        {
            // STARTING THE ANIMATION
            loadTimer.Start();
            loading.Value = 0;

            // RESETTING THE WHOLE LISTVIEW
            listClear();

            // BUBBLE SORT
            for (int i = 0; i < amountEmp; i++)
            {
                for (int j = 0; j < amountEmp - i - 1; j++)
                {
                    if (empl[j].getSalary() < empl[j + 1].getSalary())
                    {
                        employeeClass temp = new employeeClass();
                        temp = empl[j];
                        empl[j] = empl[j + 1];
                        empl[j + 1] = temp;
                    }
                }
            }

            // REFILLING THE LISTVIEW
            for (int k = 0; k < amountEmp; k++)
            {
                string[] row = { empl[k].getName() + SPACE + empl[k].getSurname(),
                    empl[k].getSalary().ToString(FZERO),
                    empl[k].getPremium().ToString(FZERO),
                    k.ToString() };
                ListViewItem lvc = new ListViewItem(row);
                employeeL.Items.Add(lvc);
            }
            StreamWriter log = new StreamWriter("logs.txt", true);
            log.WriteLine("[" + DateTime.Today.ToString("dd-MM-yyyy") + "|" 
                + DateTime.Now.ToString("h:mm:ss tt") + "]" 
                + " All records have been successfully sorted. ");
            log.Close();
        }

        // SAVE THE DATA
        private void SEE_Tick(object sender, EventArgs e)
        {
            File.SetAttributes(EMPLOYEEST, FileAttributes.Normal);

            // File.Decrypt(EMPLOYEEST);
            StreamWriter swr = new StreamWriter(EMPLOYEEST);
            swr.WriteLine(amountEmp);
            for (int i = 0; i < amountEmp; i++)
            {
                swr.WriteLine(empl[i].getName());
                swr.WriteLine(empl[i].getSurname());
                swr.WriteLine(empl[i].getEducationLevel().ToString());
                swr.WriteLine(empl[i].getSkippedDays().ToString());
                swr.WriteLine(empl[i].getPerformance().ToString());
                swr.WriteLine(empl[i].getImage());
            }
            swr.Close();

            // File.Encrypt(EMPLOYEEST);
            File.SetAttributes(EMPLOYEEST, FileAttributes.Hidden);
            SAVEDT.Text = SAVEDTT;
            savanim.Enabled = true;

            // budgetT.Text = employeeL.SelectedItems.Count.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // SELECTING THE PICTURE
            OpenFileDialog OPF = new OpenFileDialog();
            OPF.Filter = "Images only. |*.jpg; *.jpeg; *.bmp; *.png;";

            // UPLOADING THE PICTURE
            DialogResult dr = OPF.ShowDialog();
            try
            {
                profilePicture.Image = Image.FromFile(OPF.FileName);
                IMAGE = OPF.FileName;
            }
            catch
            {
                StreamWriter log = new StreamWriter("logs.txt", true);
                log.WriteLine("[" + DateTime.Today.ToString("dd-MM-yyyy") 
                    + "|" + DateTime.Now.ToString("h:mm:ss tt") + "]" 
                    + " No image has been uploaded. ");
                log.Close();
            }
        }

        // DEBUG BUTTON
        private void showChart_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                Random rnd = new Random();
                nameT.Text = i.ToString();
                surnameT.Text = (i * 10).ToString();
                eduC.SetItemChecked(rnd.Next(5), true);
                skipT.Text = rnd.Next(24).ToString();
                finT.Text = rnd.Next(25, 95).ToString();
                add();
            }
        }

        private void openGraphB_Click(object sender, EventArgs e)
        {
            //SALARY
            StreamWriter sw = new StreamWriter(STATT);
            StreamWriter swn = new StreamWriter(NAMEST);
            StreamWriter swa = new StreamWriter(AMOUNTT);
            swa.WriteLine(amountEmp);
            for (int i = 0; i < amountEmp; i++) sw.WriteLine(empl[i].getSalary().ToString(FZERO));
            for (int i = 0; i < amountEmp; i++) swn.WriteLine(empl[i].getName() + SPACE + empl[i].getSurname());

            //CLOSING FILE
            swa.Close();
            swn.Close();
            sw.Close();
            Statistics s = new Statistics();
            s.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Upload Image
            try
            {
                int ammm = 0;
                OpenFileDialog OPF = new OpenFileDialog();
                OPF.Filter = "Text files only. |*.txt; *.csw;";
                DialogResult dr = OPF.ShowDialog();
                StreamReader swread = new StreamReader(OPF.FileName);
                ammm = Int32.Parse(swread.ReadLine());
                for (int i = 0; i < ammm; i++)
                {
                    nameT.Text = swread.ReadLine();
                    surnameT.Text = swread.ReadLine();
                    eduC.SetItemChecked(Int32.Parse(swread.ReadLine()), true);
                    skipT.Text = swread.ReadLine();
                    finT.Text = swread.ReadLine();
                    add();
                }
            }
            catch { }
        }

        // Set English localization
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            setEnglish();
            StreamWriter log = new StreamWriter("logs.txt", true);
            log.WriteLine("[" + DateTime.Today.ToString("dd-MM-yyyy") + "|" + DateTime.Now.ToString("h:mm:ss tt") + "]" + " Successfully set the language to ENGLISH. ");
            log.Close();
        }

        // Set Russian localization
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            setRussian();
            StreamWriter log = new StreamWriter("logs.txt", true);
            log.WriteLine("[" + DateTime.Today.ToString("dd-MM-yyyy") + "|" + DateTime.Now.ToString("h:mm:ss tt") + "]" + " Successfully set the language to RUSSIAN. ");
            log.Close();
        }

        // Function to clear the listviewitem
        private void listClear()
        {
            employeeL.Items.Clear();
            employeeL.Update();
            employeeL.Refresh();
        }

        private void inputClear()
        {
            nameT.Text = NOTHING;
            surnameT.Text = NOTHING;
            skipT.Text = IZERO;
            finT.Text = IZERO;
            profilePicture.Image = null;
            IMAGE = "";
            for (int i = 0; i < eduC.Items.Count; i++) eduC.SetItemCheckState(i, CheckState.Unchecked);
        }

        // To DELETE ALL
        private void button1_Click_2(object sender, EventArgs e)
        {
            listClear();
            amountEmp = 0;
            IDnum = 0;
            amountGR.Text = (amountGroup + SPACE + amountEmp);
            StreamWriter log = new StreamWriter("logs.txt", true);
            log.WriteLine("[" + DateTime.Today.ToString("dd-MM-yyyy") + "|" + DateTime.Now.ToString("h:mm:ss tt") + "]" + " All records have been successfully deleted. ");
            log.Close();
        }

        // Quit the application
        public void quit()
        {
            Application.Exit();
        }

        // Full exit
        private void label1_Click(object sender, EventArgs e)
        {
            quit();
            StreamWriter log = new StreamWriter("logs.txt", true);
            log.WriteLine("[" + DateTime.Today.ToString("dd-MM-yyyy") + "|" + DateTime.Now.ToString("h:mm:ss tt") + "]" + " Successfully terminated the session ");
            log.Close();
        }

        // Full exit
        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            quit();
            StreamWriter log = new StreamWriter("logs.txt", true);
            log.WriteLine("[" + DateTime.Today.ToString("dd-MM-yyyy") + "|" + DateTime.Now.ToString("h:mm:ss tt") + "]" + " Successfully terminated the session ");
            log.Close();
        }

        // Full exit
        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            quit();
        }
    }

    class employeeClass
    {
        //VARIABLES
        private int SkippedDays = 0;
        private int PerformanceLevel = 0;
        private byte edu = 0;
        private double datPremium = 0;
        private double razmerPremium = 0;
        private double zarplataPoroporc = 0;
        private double Zarplata = 0;
        private double Score = 0;
        private byte count = 0;
        private String name;
        private String surname;

        private int ID = 0;
        private String imLocation;

        //ACCESSORS
        public String getName()
        {
            return name;
        }
        public String getSurname()
        {
            return surname;
        }
        public int getSkippedDays()
        {
            return SkippedDays;
        }
        public int getPerformance()
        {
            return PerformanceLevel;
        }
        public int getEducationLevel()
        {
            return edu;
        }
        public double getPremiumPercentage()
        {
            return datPremium;
        }
        public double getPremium()
        {
            return razmerPremium;
        }
        public double getSalaryProporcial()
        {
            return zarplataPoroporc;
        }
        public double getSalary()
        {
            return Zarplata;
        }
        public double getScore()
        {
            return Score;
        }
        public int getCount()
        {
            return count;
        }
        public int getID()
        {
            return ID;
        }
        public String getImage()
        {
            return imLocation;
        }

        //MUTATORS
        public void setName(String nameIn)
        {
            name = nameIn;
        }
        public void setSurname(String surnameIn)
        {
            surname = surnameIn;
        }
        public void setSkippedDays(int skipIn)
        {
            SkippedDays = skipIn;
        }
        public void setPerformance(int projIn)
        {
            PerformanceLevel = projIn;
        }
        public void setEducationLevel(int eduIn)
        {
            edu = (byte)eduIn;
        }
        public void setPremiumPercentage(double validIn)
        {
            datPremium = validIn;
        }
        public void setPremium(double premIn)
        {
            razmerPremium = premIn;
        }
        public void setSalaryProporcial(double propIn)
        {
            zarplataPoroporc = propIn;
        }
        public void setSalary(double salaryIn)
        {
            Zarplata = salaryIn;
        }
        public void setScore(double scoreIn)
        {
            Score = scoreIn;
        }
        public void setCount(byte countIn)
        {
            count = countIn;
        }
        public void setID(int IDin)
        {
            ID = IDin;
        }
        public void setImage(String ImageIn)
        {
            imLocation = ImageIn;
        }

    }
}