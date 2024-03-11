using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Vml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculatorApp
{
    public partial class MainForm : Form
    {
        private string name= string.Empty;
        private int age;
       // Object created
        private BMICalculator BMICal= new BMICalculator();
 
        public MainForm()
        {
            InitializeComponent();
            InitializationApp();
        }
        private void InitializationApp()
        {


        }

        private void btnCalculateBmi_Click(object sender, EventArgs e)
        {
            bool ok=ReadInputBMI();
            if(ok)
             CalculateAndDisplayResults();
        }

        private void CalculateAndDisplayResults()
        {
            double bmi=BMICal.CalculateBmi();
            lblBMIResult.Text = bmi.ToString("0.00");
            lblWeightCatagory.Text = BMICal.BmiWeightCategory();
            lblLowHightWeightDisplay_Metric.Text = $"Normal BMI Range: {18.5} to {24.9} ";
            lblLowHighWeight_USunit.Text = BMICal.ShowWieghtValue();
        }
        private bool ReadInputBMI()
        {
            ReadName();
            ReadUnits();
            bool heightOk=ReadHeight();
            bool weightOk= ReadWeight();
            return heightOk && weightOk;
        }
        private void ReadUnits()
        {
            if (rbtnMatric.Checked)
                BMICal.SetUnitType(UnitType.Metric);
            if(rbtnUSUnit.Checked)
                BMICal.SetUnitType(UnitType.USUnit);
        }

        private void ReadName()
        {
            name = txtName.Text.Trim();
            grpResultBMI.Text = name + " 's BMI :";
        }
        private bool ReadHeight()
        {
            double height = 0.0;
            bool ok = double.TryParse(txtFeetHeight.Text, out height);
            if (!ok)
            {
                MessageBox.Show("The Height value is invalid !", " Error ");
                return false;
            }
            double inches = 0.0;
            if (rbtnUSUnit.Checked)
            {
                ok = ok && double.TryParse(txtInches.Text, out inches);
                if (!ok)
                {
                    MessageBox.Show("The inches value is invalid !", " Error ");
                    return false;
                }
                BMICal.SetInches(inches);
            }

            if (BMICal.GetUnitType() == UnitType.Metric)
            {
                height = height / 100;
            }
            else
            {
                height = height * 12 + inches;
            }
            BMICal.SetHeight(height);
            return ok;
        }
        private bool ReadWeight()
        {
            double wieght = 0.0;
            bool ok = double.TryParse(txtWeight.Text, out wieght);
            if (!ok)
            {
                MessageBox.Show("The Weight value is invalid !", "Error ");
            }
            BMICal.SetWeight(wieght);
            return ok;
        }
        private void UpdateHeightText()
        {
            if(rbtnMatric.Checked)
            {
                lblHeight.Text = "Height (cm)";
                lblWeight.Text = "Weight (kg)";
                txtInches.Visible=false;
                lblBMIResult.Text = "";
                lblWeightCatagory.Text = "";

            }
            else
            {
                lblHeight.Text = "Height (ft , in)";
                lblWeight.Text = "Weight (lbs)";
                txtInches.Visible = true;
                txtInches.Text = "";
                lblBMIResult.Text = "";
                lblWeightCatagory.Text = "";
               
            }
            txtFeetHeight.Text = "";
            txtWeight.Text = "";
            lblLowHighWeight_USunit.Text = " ";
            lblLowHightWeightDisplay_Metric.Text = "";
            lblBmrResults.Text = "";
            txtAge.Text = "";
        }

        private void rbtnMatric_CheckedChanged(object sender, EventArgs e)
        {
            UpdateHeightText();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            rbtnMatric.Select();
        }
        /// <summary>
        /// ///////////////////// BMR calculation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculateBMR_Click(object sender, EventArgs e)
        {
            bool ok = ReadInputBMR();
            if (ok)
                CalculateDisplayBMRResult();
        }
        private bool ReadInputBMR()
        {
            ReadGender();
            bool okAge=ReadAge();
            ReadWeekActivityLevel();
            return okAge;
        }
        private void ReadGender()
        {
            if (rbtnFemale.Checked)
                BMICal.SetGender(Gender.Female);
            if (rbtnMale.Checked)
                BMICal.SetGender(Gender.Male);
        }
        private bool ReadAge()
        {
            bool ok = int.TryParse(txtAge.Text, out age);
            if (!ok)
            {
                MessageBox.Show("The Height value is invalid !", " Error ");
                return false;
            }
            BMICal.SetAge(age);
            return true;
        }
        private double ReadWeekActivityLevel()
        {
            double activeLevelMultiplier = 1.0;
            if (rbtnNOExercise.Checked)
                activeLevelMultiplier = 1.2;
            if (rbtnLightlyActive.Checked)
                activeLevelMultiplier = 1.38; 
            if (rbtnModeratlyActive.Checked)
                activeLevelMultiplier = 1.55; 
            if (rbtnVeryActive.Checked)
                activeLevelMultiplier = 1.9;
            return activeLevelMultiplier;
        }
        private void CalculateDisplayBMRResult()
        {
            double bmr = BMICal.CalculateBmr();
            double totalCalories = bmr * ReadWeekActivityLevel();
           lblBmrResults.Text = " Your Basal Metabolic Rate (BMR) is: " + totalCalories.ToString("0.00") + " calories per day";
        }

    }   
}
