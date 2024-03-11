using DocumentFormat.OpenXml.Drawing.Charts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace BMICalculatorApp
{
    internal class BMICalculator
    {
        private double height;
        private double weight;
        private double inches;
        private int age;

        private UnitType unit;
        private Gender genderType;
        public BMICalculator()
        {
            unit = UnitType.Metric;
        }
        /////////// getter setter///////////////////
        public double GetHeight()
        {
            return height;
        }
        public void SetHeight(double inputHeight)
        {
            if (inputHeight > 0.0)
                height = inputHeight;
        }
        public double GetInches()
        {
            return inches;
        }
        public void SetInches(double inchesInput)
        {
            if (inchesInput > 0.0)
            {
                inches = inchesInput;
            }
        }
        public double GetWeight()
        {
            return weight;
        }
        public void SetWeight(double inputWidth)
        {
            if (inputWidth > 0.0)
                weight = inputWidth;
        }

        public UnitType GetUnitType()
        {
            return unit;
        }
        public void SetUnitType(UnitType inputUnit)
        {
            unit = inputUnit;
        }
        // Getter setter for BMR calculator
        public Gender GetGender()
        { 
            return genderType;
        }
        public void SetGender(Gender inputGender)
        {
            genderType = inputGender;
        }
        public int GetAge()
        {
            return age;
        }
        public void SetAge(int inputAge)
        {
            age = inputAge;
        }
        ///////////////////// calculation part
        ///
        public double CalculateBmi()
        {
            double bmiValue = 0.0;
            double factor = 1.0;
            if (unit == UnitType.USUnit)
                factor = 703.0;
            bmiValue = factor * (weight / (height * height));
            return bmiValue;
        }
        public string ShowWieghtValue()
        {
            double lowWeight;
            double highWeight;
            double factor;
            string outStringResult;
            if (unit == UnitType.USUnit)
            {
                factor = 703.0;
                double lowerBMI = 18.5;
                double upperBMI = 24.9;

                double lowerWeightRange = lowerBMI * (height * height) / factor; // Convert height to meters
                double upperWeightRange = upperBMI * (height * height) / factor;

                // Display the BMI range in the label
                outStringResult = $"Weight Range: {lowerWeightRange:F2} to {upperWeightRange:F2} in lbs";
            
            }
            else
            {
                factor = 1.0;
                double lowerBMI = 18.5;
                double upperBMI = 24.9;

                double lowerWeightRange = lowerBMI * (height * height) / factor; // Convert height to meters
                double upperWeightRange = upperBMI * (height * height) / factor;
                
                // Display the BMI range in the label
                outStringResult = $"Weight Range: {lowerWeightRange:F2} to {upperWeightRange:F2} in kg";
            }

           return outStringResult;

        }
        public double CalculateBmr()
        {
            double bmrValue = 0.0;
           if (genderType==Gender.Male)
                bmrValue = 10 * weight + 6.25 * height - 5 * age + 5;
           if (genderType==Gender.Female)
                bmrValue = 10 * weight + 6.25 * height - 5 * age - 161;
           return bmrValue;
        }
        
        public string BmiWeightCategory()
        {
            double bmi=CalculateBmi();
            string stringOut = string.Empty;

            if (bmi < 18.5)
                stringOut = "Under weight";
            else if (bmi <= 24.5)
                stringOut = "Normal weight ";
            else if (bmi <= 29.5)
                stringOut = "Overwight  - pre obsessity";
            else if (bmi <= 34.5)
                stringOut = "Over weight , Class 1 ";
            else if (bmi <= 39.5)
                stringOut = "Over weight , Class 2";
            else if (bmi >= 39.5)
                stringOut = "Over weight , Class 3";
            return stringOut;
        }
    }
}
