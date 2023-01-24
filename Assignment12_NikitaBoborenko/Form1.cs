using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment12_NikitaBoborenko
{
    public partial class Form1 : Form
    {
        ProductionWorker[] workers=new ProductionWorker[10];
        int workersCreated = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void input_button_Click(object sender, EventArgs e)
        {
            if (workersCreated != 8)
            {
                try
                {
                    int selectedShift = shiftNumberComboBox.SelectedIndex+1;
                    workers[workersCreated] = CreateProductionWorker(nameTextBox.Text, numberTextBox.Text, selectedShift, int.Parse(payRateTextBox.Text));
                    workersCreated++;
                    refreshPanel();
                }
                catch
                {
                    MessageBox.Show("Wrong input");
                }
            }
        }
        public void refreshPanel()
        {
            panelScreen.Controls.Clear();
            for (int i = 0; i < 10; i++)
            {
                if (workers[i] != null)
                {
                    Label newLabel = new Label
                    {
                        Text ="Name: "+  workers[i].getEmployeeName + " Number: " + workers[i].getEmployeeNumber + " Shift " + workers[i].getShiftNumberString + " Payrate: " + workers[i].GetPayrateNumberString

                    };
                    panelScreen.Controls.Add(newLabel);
                    newLabel.AutoSize = false;
                    newLabel.Size = new System.Drawing.Size(500, 27);
                    newLabel.Location = new Point(1, i * 25);
                }
            }
        }
        private ProductionWorker CreateProductionWorker(String name,String number,int shift, int payrate)
        {
            ProductionWorker objProductionWorker = new ProductionWorker();
            objProductionWorker.setEmployeeName(name);
            objProductionWorker.setShiftNumber(shift);
            objProductionWorker.setPayrateNumber(payrate);
            objProductionWorker.setEmployeeNumber(number);
            return objProductionWorker;
        }

        private void numberTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class Employee
    {
        private string employeeName;
        private string employeeNumber;
        public void setEmployeeName(string name)
        {
            employeeName = name;
        }
        public void setEmployeeNumber(string number)
        {
            employeeNumber = number;
        }
        public string getEmployeeName
        {
            get { return employeeName; }
        }
        public string getEmployeeNumber
        {
            get { return employeeNumber; }
        }
        


    }
    public class ProductionWorker : Employee
    {
        private int ShiftNumber;
        private int PayrateNumber;

        public void setShiftNumber(int shiftNumber)
        {
            ShiftNumber = shiftNumber;
        }
        public void setPayrateNumber(int payrateNumber)
        {
            PayrateNumber = payrateNumber;
        }
        public int getShiftNumber()
        {
            return ShiftNumber;
        }
        public int GetPayrateNumber()
        {
            return PayrateNumber;
        }
        public String getShiftNumberString
        {
            get { return ShiftNumber.ToString(); }
        }
        public String GetPayrateNumberString
        {
            get {return PayrateNumber.ToString(); }
        }
}
}
