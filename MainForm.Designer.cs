namespace BMICalculatorApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpPersonInfo = new System.Windows.Forms.GroupBox();
            this.txtInches = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtFeetHeight = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPersonName = new System.Windows.Forms.Label();
            this.grpUnit = new System.Windows.Forms.GroupBox();
            this.rbtnUSUnit = new System.Windows.Forms.RadioButton();
            this.rbtnMatric = new System.Windows.Forms.RadioButton();
            this.btnCalculateBmi = new System.Windows.Forms.Button();
            this.grpResultBMI = new System.Windows.Forms.GroupBox();
            this.lblLowHighWeight_USunit = new System.Windows.Forms.Label();
            this.lblLowHightWeightDisplay_Metric = new System.Windows.Forms.Label();
            this.lblWeightCatagory = new System.Windows.Forms.Label();
            this.lblBMIResult = new System.Windows.Forms.Label();
            this.lblweightCat = new System.Windows.Forms.Label();
            this.lblBmi = new System.Windows.Forms.Label();
            this.grpBMRCal = new System.Windows.Forms.GroupBox();
            this.lblBmrResults = new System.Windows.Forms.Label();
            this.grpActivityLevel = new System.Windows.Forms.GroupBox();
            this.rbtnVeryActive = new System.Windows.Forms.RadioButton();
            this.rbtnModeratlyActive = new System.Windows.Forms.RadioButton();
            this.rbtnLightlyActive = new System.Windows.Forms.RadioButton();
            this.rbtnNOExercise = new System.Windows.Forms.RadioButton();
            this.btnCalculateBMR = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.grpGenderSelect = new System.Windows.Forms.GroupBox();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.grpSavingPlan = new System.Windows.Forms.GroupBox();
            this.lblFee = new System.Windows.Forms.Label();
            this.txtFee = new System.Windows.Forms.TextBox();
            this.txtGrowth = new System.Windows.Forms.TextBox();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.txtPeriods = new System.Windows.Forms.TextBox();
            this.lblPeriods = new System.Windows.Forms.Label();
            this.lblMonthlyDeposit = new System.Windows.Forms.Label();
            this.txtMonthlyDeposite = new System.Windows.Forms.TextBox();
            this.txtInitDeposit = new System.Windows.Forms.TextBox();
            this.lblInitDeposit = new System.Windows.Forms.Label();
            this.btnCalculateSaving = new System.Windows.Forms.Button();
            this.grpFutureValue = new System.Windows.Forms.GroupBox();
            this.lblDisplayTotalFee = new System.Windows.Forms.Label();
            this.lblDisplayFinalBalance = new System.Windows.Forms.Label();
            this.lblDisplayAmountEarned = new System.Windows.Forms.Label();
            this.lblDisplayAmountPaid = new System.Windows.Forms.Label();
            this.lblTotalfee = new System.Windows.Forms.Label();
            this.lblFinalBalance = new System.Windows.Forms.Label();
            this.lblAmountEarned = new System.Windows.Forms.Label();
            this.lblAmountPaid = new System.Windows.Forms.Label();
            this.grpPersonInfo.SuspendLayout();
            this.grpUnit.SuspendLayout();
            this.grpResultBMI.SuspendLayout();
            this.grpBMRCal.SuspendLayout();
            this.grpActivityLevel.SuspendLayout();
            this.grpGenderSelect.SuspendLayout();
            this.grpSavingPlan.SuspendLayout();
            this.grpFutureValue.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPersonInfo
            // 
            this.grpPersonInfo.Controls.Add(this.txtInches);
            this.grpPersonInfo.Controls.Add(this.lblWeight);
            this.grpPersonInfo.Controls.Add(this.txtWeight);
            this.grpPersonInfo.Controls.Add(this.txtFeetHeight);
            this.grpPersonInfo.Controls.Add(this.lblHeight);
            this.grpPersonInfo.Controls.Add(this.txtName);
            this.grpPersonInfo.Controls.Add(this.lblPersonName);
            this.grpPersonInfo.Location = new System.Drawing.Point(12, 12);
            this.grpPersonInfo.Name = "grpPersonInfo";
            this.grpPersonInfo.Size = new System.Drawing.Size(337, 140);
            this.grpPersonInfo.TabIndex = 8;
            this.grpPersonInfo.TabStop = false;
            this.grpPersonInfo.Text = "Person\'s Information";
            // 
            // txtInches
            // 
            this.txtInches.Location = new System.Drawing.Point(219, 68);
            this.txtInches.Name = "txtInches";
            this.txtInches.Size = new System.Drawing.Size(51, 22);
            this.txtInches.TabIndex = 15;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(5, 102);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(75, 16);
            this.lblWeight.TabIndex = 14;
            this.lblWeight.Text = "Weight (kg)";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(95, 104);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 22);
            this.txtWeight.TabIndex = 3;
            // 
            // txtFeetHeight
            // 
            this.txtFeetHeight.Location = new System.Drawing.Point(95, 67);
            this.txtFeetHeight.Name = "txtFeetHeight";
            this.txtFeetHeight.Size = new System.Drawing.Size(100, 22);
            this.txtFeetHeight.TabIndex = 2;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(3, 70);
            this.lblHeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(75, 16);
            this.lblHeight.TabIndex = 11;
            this.lblHeight.Text = "Height (cm)";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(95, 32);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(226, 22);
            this.txtName.TabIndex = 1;
            // 
            // lblPersonName
            // 
            this.lblPersonName.AutoSize = true;
            this.lblPersonName.Location = new System.Drawing.Point(3, 35);
            this.lblPersonName.Name = "lblPersonName";
            this.lblPersonName.Size = new System.Drawing.Size(75, 16);
            this.lblPersonName.TabIndex = 8;
            this.lblPersonName.Text = "Your Name";
            // 
            // grpUnit
            // 
            this.grpUnit.Controls.Add(this.rbtnUSUnit);
            this.grpUnit.Controls.Add(this.rbtnMatric);
            this.grpUnit.Location = new System.Drawing.Point(367, 12);
            this.grpUnit.Name = "grpUnit";
            this.grpUnit.Size = new System.Drawing.Size(165, 102);
            this.grpUnit.TabIndex = 9;
            this.grpUnit.TabStop = false;
            this.grpUnit.Text = "Unit";
            // 
            // rbtnUSUnit
            // 
            this.rbtnUSUnit.AutoSize = true;
            this.rbtnUSUnit.Location = new System.Drawing.Point(7, 49);
            this.rbtnUSUnit.Name = "rbtnUSUnit";
            this.rbtnUSUnit.Size = new System.Drawing.Size(133, 20);
            this.rbtnUSUnit.TabIndex = 5;
            this.rbtnUSUnit.TabStop = true;
            this.rbtnUSUnit.Text = "US Unit (foot , lbs)";
            this.rbtnUSUnit.UseVisualStyleBackColor = true;
            // 
            // rbtnMatric
            // 
            this.rbtnMatric.AutoSize = true;
            this.rbtnMatric.Location = new System.Drawing.Point(7, 22);
            this.rbtnMatric.Name = "rbtnMatric";
            this.rbtnMatric.Size = new System.Drawing.Size(143, 20);
            this.rbtnMatric.TabIndex = 4;
            this.rbtnMatric.TabStop = true;
            this.rbtnMatric.Text = "Metric Unit (kg , cm)";
            this.rbtnMatric.UseVisualStyleBackColor = true;
            this.rbtnMatric.CheckedChanged += new System.EventHandler(this.rbtnMatric_CheckedChanged);
            // 
            // btnCalculateBmi
            // 
            this.btnCalculateBmi.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnCalculateBmi.Location = new System.Drawing.Point(188, 168);
            this.btnCalculateBmi.Name = "btnCalculateBmi";
            this.btnCalculateBmi.Size = new System.Drawing.Size(208, 50);
            this.btnCalculateBmi.TabIndex = 6;
            this.btnCalculateBmi.Text = "Calculate your BMI";
            this.btnCalculateBmi.UseVisualStyleBackColor = false;
            this.btnCalculateBmi.Click += new System.EventHandler(this.btnCalculateBmi_Click);
            // 
            // grpResultBMI
            // 
            this.grpResultBMI.Controls.Add(this.lblLowHighWeight_USunit);
            this.grpResultBMI.Controls.Add(this.lblLowHightWeightDisplay_Metric);
            this.grpResultBMI.Controls.Add(this.lblWeightCatagory);
            this.grpResultBMI.Controls.Add(this.lblBMIResult);
            this.grpResultBMI.Controls.Add(this.lblweightCat);
            this.grpResultBMI.Controls.Add(this.lblBmi);
            this.grpResultBMI.Location = new System.Drawing.Point(12, 240);
            this.grpResultBMI.Name = "grpResultBMI";
            this.grpResultBMI.Size = new System.Drawing.Size(384, 148);
            this.grpResultBMI.TabIndex = 10;
            this.grpResultBMI.TabStop = false;
            this.grpResultBMI.Text = "Result of BMI ";
            // 
            // lblLowHighWeight_USunit
            // 
            this.lblLowHighWeight_USunit.BackColor = System.Drawing.SystemColors.Control;
            this.lblLowHighWeight_USunit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLowHighWeight_USunit.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowHighWeight_USunit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblLowHighWeight_USunit.Location = new System.Drawing.Point(20, 113);
            this.lblLowHighWeight_USunit.Name = "lblLowHighWeight_USunit";
            this.lblLowHighWeight_USunit.Size = new System.Drawing.Size(358, 25);
            this.lblLowHighWeight_USunit.TabIndex = 10;
            this.lblLowHighWeight_USunit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLowHightWeightDisplay_Metric
            // 
            this.lblLowHightWeightDisplay_Metric.BackColor = System.Drawing.SystemColors.Control;
            this.lblLowHightWeightDisplay_Metric.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLowHightWeightDisplay_Metric.Location = new System.Drawing.Point(22, 85);
            this.lblLowHightWeightDisplay_Metric.Name = "lblLowHightWeightDisplay_Metric";
            this.lblLowHightWeightDisplay_Metric.Size = new System.Drawing.Size(356, 21);
            this.lblLowHightWeightDisplay_Metric.TabIndex = 9;
            this.lblLowHightWeightDisplay_Metric.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWeightCatagory
            // 
            this.lblWeightCatagory.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblWeightCatagory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWeightCatagory.Location = new System.Drawing.Point(160, 48);
            this.lblWeightCatagory.Name = "lblWeightCatagory";
            this.lblWeightCatagory.Size = new System.Drawing.Size(218, 25);
            this.lblWeightCatagory.TabIndex = 8;
            // 
            // lblBMIResult
            // 
            this.lblBMIResult.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBMIResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBMIResult.Location = new System.Drawing.Point(161, 17);
            this.lblBMIResult.Name = "lblBMIResult";
            this.lblBMIResult.Size = new System.Drawing.Size(122, 22);
            this.lblBMIResult.TabIndex = 7;
            this.lblBMIResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblweightCat
            // 
            this.lblweightCat.AutoSize = true;
            this.lblweightCat.Location = new System.Drawing.Point(18, 46);
            this.lblweightCat.Name = "lblweightCat";
            this.lblweightCat.Size = new System.Drawing.Size(107, 16);
            this.lblweightCat.TabIndex = 1;
            this.lblweightCat.Text = "Weight Catagory";
            // 
            // lblBmi
            // 
            this.lblBmi.AutoSize = true;
            this.lblBmi.Location = new System.Drawing.Point(17, 23);
            this.lblBmi.Name = "lblBmi";
            this.lblBmi.Size = new System.Drawing.Size(30, 16);
            this.lblBmi.TabIndex = 0;
            this.lblBmi.Text = "BMI";
            // 
            // grpBMRCal
            // 
            this.grpBMRCal.Controls.Add(this.lblBmrResults);
            this.grpBMRCal.Controls.Add(this.grpActivityLevel);
            this.grpBMRCal.Controls.Add(this.btnCalculateBMR);
            this.grpBMRCal.Controls.Add(this.txtAge);
            this.grpBMRCal.Controls.Add(this.lblAge);
            this.grpBMRCal.Controls.Add(this.grpGenderSelect);
            this.grpBMRCal.Location = new System.Drawing.Point(18, 386);
            this.grpBMRCal.Name = "grpBMRCal";
            this.grpBMRCal.Size = new System.Drawing.Size(931, 253);
            this.grpBMRCal.TabIndex = 11;
            this.grpBMRCal.TabStop = false;
            this.grpBMRCal.Text = "BMR Calculator";
            // 
            // lblBmrResults
            // 
            this.lblBmrResults.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBmrResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBmrResults.Location = new System.Drawing.Point(473, 32);
            this.lblBmrResults.Name = "lblBmrResults";
            this.lblBmrResults.Size = new System.Drawing.Size(433, 211);
            this.lblBmrResults.TabIndex = 5;
            // 
            // grpActivityLevel
            // 
            this.grpActivityLevel.Controls.Add(this.rbtnVeryActive);
            this.grpActivityLevel.Controls.Add(this.rbtnModeratlyActive);
            this.grpActivityLevel.Controls.Add(this.rbtnLightlyActive);
            this.grpActivityLevel.Controls.Add(this.rbtnNOExercise);
            this.grpActivityLevel.Location = new System.Drawing.Point(156, 28);
            this.grpActivityLevel.Name = "grpActivityLevel";
            this.grpActivityLevel.Size = new System.Drawing.Size(300, 146);
            this.grpActivityLevel.TabIndex = 4;
            this.grpActivityLevel.TabStop = false;
            this.grpActivityLevel.Text = "Weekly Activity Level";
            // 
            // rbtnVeryActive
            // 
            this.rbtnVeryActive.AutoSize = true;
            this.rbtnVeryActive.Location = new System.Drawing.Point(23, 114);
            this.rbtnVeryActive.Name = "rbtnVeryActive";
            this.rbtnVeryActive.Size = new System.Drawing.Size(141, 20);
            this.rbtnVeryActive.TabIndex = 3;
            this.rbtnVeryActive.TabStop = true;
            this.rbtnVeryActive.Text = "Very Active ( 6 to 8)";
            this.rbtnVeryActive.UseVisualStyleBackColor = true;
            // 
            // rbtnModeratlyActive
            // 
            this.rbtnModeratlyActive.AutoSize = true;
            this.rbtnModeratlyActive.Location = new System.Drawing.Point(23, 88);
            this.rbtnModeratlyActive.Name = "rbtnModeratlyActive";
            this.rbtnModeratlyActive.Size = new System.Drawing.Size(173, 20);
            this.rbtnModeratlyActive.TabIndex = 2;
            this.rbtnModeratlyActive.TabStop = true;
            this.rbtnModeratlyActive.Text = "Moderatly Active ( 3 to 5)";
            this.rbtnModeratlyActive.UseVisualStyleBackColor = true;
            // 
            // rbtnLightlyActive
            // 
            this.rbtnLightlyActive.AutoSize = true;
            this.rbtnLightlyActive.Location = new System.Drawing.Point(22, 60);
            this.rbtnLightlyActive.Name = "rbtnLightlyActive";
            this.rbtnLightlyActive.Size = new System.Drawing.Size(154, 20);
            this.rbtnLightlyActive.TabIndex = 1;
            this.rbtnLightlyActive.TabStop = true;
            this.rbtnLightlyActive.Text = "Lightly Active  ( 1 to 3)";
            this.rbtnLightlyActive.UseVisualStyleBackColor = true;
            // 
            // rbtnNOExercise
            // 
            this.rbtnNOExercise.AutoSize = true;
            this.rbtnNOExercise.Location = new System.Drawing.Point(22, 33);
            this.rbtnNOExercise.Name = "rbtnNOExercise";
            this.rbtnNOExercise.Size = new System.Drawing.Size(145, 20);
            this.rbtnNOExercise.TabIndex = 0;
            this.rbtnNOExercise.TabStop = true;
            this.rbtnNOExercise.Text = "Little or No exercise";
            this.rbtnNOExercise.UseVisualStyleBackColor = true;
            // 
            // btnCalculateBMR
            // 
            this.btnCalculateBMR.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnCalculateBMR.Location = new System.Drawing.Point(120, 195);
            this.btnCalculateBMR.Name = "btnCalculateBMR";
            this.btnCalculateBMR.Size = new System.Drawing.Size(161, 42);
            this.btnCalculateBMR.TabIndex = 3;
            this.btnCalculateBMR.Text = "Calculate BMR";
            this.btnCalculateBMR.UseVisualStyleBackColor = false;
            this.btnCalculateBMR.Click += new System.EventHandler(this.btnCalculateBMR_Click);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(62, 133);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(83, 22);
            this.txtAge.TabIndex = 2;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(21, 135);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(32, 16);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "Age";
            // 
            // grpGenderSelect
            // 
            this.grpGenderSelect.Controls.Add(this.rbtnMale);
            this.grpGenderSelect.Controls.Add(this.rbtnFemale);
            this.grpGenderSelect.Location = new System.Drawing.Point(17, 27);
            this.grpGenderSelect.Name = "grpGenderSelect";
            this.grpGenderSelect.Size = new System.Drawing.Size(128, 90);
            this.grpGenderSelect.TabIndex = 0;
            this.grpGenderSelect.TabStop = false;
            this.grpGenderSelect.Text = "Gender";
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(7, 49);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(58, 20);
            this.rbtnMale.TabIndex = 1;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(7, 22);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(74, 20);
            this.rbtnFemale.TabIndex = 0;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // grpSavingPlan
            // 
            this.grpSavingPlan.Controls.Add(this.lblFee);
            this.grpSavingPlan.Controls.Add(this.txtFee);
            this.grpSavingPlan.Controls.Add(this.txtGrowth);
            this.grpSavingPlan.Controls.Add(this.lblPercentage);
            this.grpSavingPlan.Controls.Add(this.txtPeriods);
            this.grpSavingPlan.Controls.Add(this.lblPeriods);
            this.grpSavingPlan.Controls.Add(this.lblMonthlyDeposit);
            this.grpSavingPlan.Controls.Add(this.txtMonthlyDeposite);
            this.grpSavingPlan.Controls.Add(this.txtInitDeposit);
            this.grpSavingPlan.Controls.Add(this.lblInitDeposit);
            this.grpSavingPlan.Location = new System.Drawing.Point(601, 12);
            this.grpSavingPlan.Name = "grpSavingPlan";
            this.grpSavingPlan.Size = new System.Drawing.Size(347, 173);
            this.grpSavingPlan.TabIndex = 12;
            this.grpSavingPlan.TabStop = false;
            this.grpSavingPlan.Text = "Saving plan";
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.Location = new System.Drawing.Point(11, 131);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(59, 16);
            this.lblFee.TabIndex = 9;
            this.lblFee.Text = "Fee in %";
            // 
            // txtFee
            // 
            this.txtFee.Location = new System.Drawing.Point(156, 136);
            this.txtFee.Name = "txtFee";
            this.txtFee.Size = new System.Drawing.Size(180, 22);
            this.txtFee.TabIndex = 8;
            // 
            // txtGrowth
            // 
            this.txtGrowth.Location = new System.Drawing.Point(156, 107);
            this.txtGrowth.Name = "txtGrowth";
            this.txtGrowth.Size = new System.Drawing.Size(180, 22);
            this.txtGrowth.TabIndex = 7;
            this.txtGrowth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Location = new System.Drawing.Point(9, 107);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(136, 16);
            this.lblPercentage.TabIndex = 6;
            this.lblPercentage.Text = "Growth ( Interest ) in %";
            // 
            // txtPeriods
            // 
            this.txtPeriods.Location = new System.Drawing.Point(156, 78);
            this.txtPeriods.Name = "txtPeriods";
            this.txtPeriods.Size = new System.Drawing.Size(179, 22);
            this.txtPeriods.TabIndex = 5;
            this.txtPeriods.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPeriods
            // 
            this.lblPeriods.AutoSize = true;
            this.lblPeriods.Location = new System.Drawing.Point(9, 81);
            this.lblPeriods.Name = "lblPeriods";
            this.lblPeriods.Size = new System.Drawing.Size(97, 16);
            this.lblPeriods.TabIndex = 4;
            this.lblPeriods.Text = "Period ( Years)";
            // 
            // lblMonthlyDeposit
            // 
            this.lblMonthlyDeposit.AutoSize = true;
            this.lblMonthlyDeposit.Location = new System.Drawing.Point(9, 53);
            this.lblMonthlyDeposit.Name = "lblMonthlyDeposit";
            this.lblMonthlyDeposit.Size = new System.Drawing.Size(103, 16);
            this.lblMonthlyDeposit.TabIndex = 3;
            this.lblMonthlyDeposit.Text = "Monthly Deposit";
            // 
            // txtMonthlyDeposite
            // 
            this.txtMonthlyDeposite.Location = new System.Drawing.Point(156, 50);
            this.txtMonthlyDeposite.Name = "txtMonthlyDeposite";
            this.txtMonthlyDeposite.Size = new System.Drawing.Size(180, 22);
            this.txtMonthlyDeposite.TabIndex = 2;
            // 
            // txtInitDeposit
            // 
            this.txtInitDeposit.Location = new System.Drawing.Point(156, 22);
            this.txtInitDeposit.Name = "txtInitDeposit";
            this.txtInitDeposit.Size = new System.Drawing.Size(180, 22);
            this.txtInitDeposit.TabIndex = 1;
            this.txtInitDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblInitDeposit
            // 
            this.lblInitDeposit.AutoSize = true;
            this.lblInitDeposit.Location = new System.Drawing.Point(9, 27);
            this.lblInitDeposit.Name = "lblInitDeposit";
            this.lblInitDeposit.Size = new System.Drawing.Size(93, 16);
            this.lblInitDeposit.TabIndex = 0;
            this.lblInitDeposit.Text = "Initial deposite";
            // 
            // btnCalculateSaving
            // 
            this.btnCalculateSaving.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCalculateSaving.Location = new System.Drawing.Point(711, 198);
            this.btnCalculateSaving.Name = "btnCalculateSaving";
            this.btnCalculateSaving.Size = new System.Drawing.Size(138, 36);
            this.btnCalculateSaving.TabIndex = 13;
            this.btnCalculateSaving.Text = "Calculate Savings";
            this.btnCalculateSaving.UseVisualStyleBackColor = false;
            // 
            // grpFutureValue
            // 
            this.grpFutureValue.Controls.Add(this.lblDisplayTotalFee);
            this.grpFutureValue.Controls.Add(this.lblDisplayFinalBalance);
            this.grpFutureValue.Controls.Add(this.lblDisplayAmountEarned);
            this.grpFutureValue.Controls.Add(this.lblDisplayAmountPaid);
            this.grpFutureValue.Controls.Add(this.lblTotalfee);
            this.grpFutureValue.Controls.Add(this.lblFinalBalance);
            this.grpFutureValue.Controls.Add(this.lblAmountEarned);
            this.grpFutureValue.Controls.Add(this.lblAmountPaid);
            this.grpFutureValue.Location = new System.Drawing.Point(601, 241);
            this.grpFutureValue.Name = "grpFutureValue";
            this.grpFutureValue.Size = new System.Drawing.Size(346, 147);
            this.grpFutureValue.TabIndex = 14;
            this.grpFutureValue.TabStop = false;
            this.grpFutureValue.Text = "Future Value";
            // 
            // lblDisplayTotalFee
            // 
            this.lblDisplayTotalFee.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblDisplayTotalFee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisplayTotalFee.Location = new System.Drawing.Point(156, 117);
            this.lblDisplayTotalFee.Name = "lblDisplayTotalFee";
            this.lblDisplayTotalFee.Size = new System.Drawing.Size(173, 21);
            this.lblDisplayTotalFee.TabIndex = 7;
            this.lblDisplayTotalFee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDisplayFinalBalance
            // 
            this.lblDisplayFinalBalance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblDisplayFinalBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisplayFinalBalance.Location = new System.Drawing.Point(156, 83);
            this.lblDisplayFinalBalance.Name = "lblDisplayFinalBalance";
            this.lblDisplayFinalBalance.Size = new System.Drawing.Size(172, 25);
            this.lblDisplayFinalBalance.TabIndex = 6;
            // 
            // lblDisplayAmountEarned
            // 
            this.lblDisplayAmountEarned.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblDisplayAmountEarned.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisplayAmountEarned.Location = new System.Drawing.Point(156, 49);
            this.lblDisplayAmountEarned.Name = "lblDisplayAmountEarned";
            this.lblDisplayAmountEarned.Size = new System.Drawing.Size(173, 26);
            this.lblDisplayAmountEarned.TabIndex = 5;
            this.lblDisplayAmountEarned.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDisplayAmountPaid
            // 
            this.lblDisplayAmountPaid.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblDisplayAmountPaid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisplayAmountPaid.Location = new System.Drawing.Point(156, 19);
            this.lblDisplayAmountPaid.Name = "lblDisplayAmountPaid";
            this.lblDisplayAmountPaid.Size = new System.Drawing.Size(174, 23);
            this.lblDisplayAmountPaid.TabIndex = 4;
            this.lblDisplayAmountPaid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalfee
            // 
            this.lblTotalfee.AutoSize = true;
            this.lblTotalfee.Location = new System.Drawing.Point(13, 112);
            this.lblTotalfee.Name = "lblTotalfee";
            this.lblTotalfee.Size = new System.Drawing.Size(67, 16);
            this.lblTotalfee.TabIndex = 3;
            this.lblTotalfee.Text = "Total fees";
            // 
            // lblFinalBalance
            // 
            this.lblFinalBalance.AutoSize = true;
            this.lblFinalBalance.Location = new System.Drawing.Point(12, 84);
            this.lblFinalBalance.Name = "lblFinalBalance";
            this.lblFinalBalance.Size = new System.Drawing.Size(89, 16);
            this.lblFinalBalance.TabIndex = 2;
            this.lblFinalBalance.Text = "Final Balance";
            // 
            // lblAmountEarned
            // 
            this.lblAmountEarned.AutoSize = true;
            this.lblAmountEarned.Location = new System.Drawing.Point(12, 55);
            this.lblAmountEarned.Name = "lblAmountEarned";
            this.lblAmountEarned.Size = new System.Drawing.Size(99, 16);
            this.lblAmountEarned.TabIndex = 1;
            this.lblAmountEarned.Text = "Amount Earned";
            // 
            // lblAmountPaid
            // 
            this.lblAmountPaid.AutoSize = true;
            this.lblAmountPaid.Location = new System.Drawing.Point(12, 26);
            this.lblAmountPaid.Name = "lblAmountPaid";
            this.lblAmountPaid.Size = new System.Drawing.Size(83, 16);
            this.lblAmountPaid.TabIndex = 0;
            this.lblAmountPaid.Text = "Amount Paid";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 646);
            this.Controls.Add(this.grpFutureValue);
            this.Controls.Add(this.btnCalculateSaving);
            this.Controls.Add(this.grpSavingPlan);
            this.Controls.Add(this.grpBMRCal);
            this.Controls.Add(this.grpResultBMI);
            this.Controls.Add(this.btnCalculateBmi);
            this.Controls.Add(this.grpUnit);
            this.Controls.Add(this.grpPersonInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpPersonInfo.ResumeLayout(false);
            this.grpPersonInfo.PerformLayout();
            this.grpUnit.ResumeLayout(false);
            this.grpUnit.PerformLayout();
            this.grpResultBMI.ResumeLayout(false);
            this.grpResultBMI.PerformLayout();
            this.grpBMRCal.ResumeLayout(false);
            this.grpBMRCal.PerformLayout();
            this.grpActivityLevel.ResumeLayout(false);
            this.grpActivityLevel.PerformLayout();
            this.grpGenderSelect.ResumeLayout(false);
            this.grpGenderSelect.PerformLayout();
            this.grpSavingPlan.ResumeLayout(false);
            this.grpSavingPlan.PerformLayout();
            this.grpFutureValue.ResumeLayout(false);
            this.grpFutureValue.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPersonInfo;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtFeetHeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPersonName;
        private System.Windows.Forms.GroupBox grpUnit;
        private System.Windows.Forms.RadioButton rbtnUSUnit;
        private System.Windows.Forms.RadioButton rbtnMatric;
        private System.Windows.Forms.Button btnCalculateBmi;
        private System.Windows.Forms.GroupBox grpResultBMI;
        private System.Windows.Forms.Label lblWeightCatagory;
        private System.Windows.Forms.Label lblBMIResult;
        private System.Windows.Forms.Label lblweightCat;
        private System.Windows.Forms.Label lblBmi;
        private System.Windows.Forms.GroupBox grpBMRCal;
        private System.Windows.Forms.GroupBox grpGenderSelect;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.GroupBox grpActivityLevel;
        private System.Windows.Forms.Button btnCalculateBMR;
        private System.Windows.Forms.RadioButton rbtnNOExercise;
        private System.Windows.Forms.RadioButton rbtnVeryActive;
        private System.Windows.Forms.RadioButton rbtnModeratlyActive;
        private System.Windows.Forms.RadioButton rbtnLightlyActive;
        private System.Windows.Forms.Label lblBmrResults;
        private System.Windows.Forms.GroupBox grpSavingPlan;
        private System.Windows.Forms.TextBox txtPeriods;
        private System.Windows.Forms.Label lblPeriods;
        private System.Windows.Forms.Label lblMonthlyDeposit;
        private System.Windows.Forms.TextBox txtMonthlyDeposite;
        private System.Windows.Forms.TextBox txtInitDeposit;
        private System.Windows.Forms.Label lblInitDeposit;
        private System.Windows.Forms.Label lblFee;
        private System.Windows.Forms.TextBox txtFee;
        private System.Windows.Forms.TextBox txtGrowth;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Button btnCalculateSaving;
        private System.Windows.Forms.GroupBox grpFutureValue;
        private System.Windows.Forms.Label lblDisplayTotalFee;
        private System.Windows.Forms.Label lblDisplayFinalBalance;
        private System.Windows.Forms.Label lblDisplayAmountEarned;
        private System.Windows.Forms.Label lblDisplayAmountPaid;
        private System.Windows.Forms.Label lblTotalfee;
        private System.Windows.Forms.Label lblFinalBalance;
        private System.Windows.Forms.Label lblAmountEarned;
        private System.Windows.Forms.Label lblAmountPaid;
        private System.Windows.Forms.TextBox txtInches;
        private System.Windows.Forms.Label lblLowHighWeight_USunit;
        private System.Windows.Forms.Label lblLowHightWeightDisplay_Metric;
    }
}

