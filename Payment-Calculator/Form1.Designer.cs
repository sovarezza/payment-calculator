namespace Payment_Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelMonStartTime = new Label();
            labelMonFinishTime = new Label();
            inputMonStartTimePicker = new DateTimePicker();
            inputMonFinishTimePicker = new DateTimePicker();
            calculateHoursbutton1 = new Button();
            payInformationgroupBox1 = new GroupBox();
            resultNetPay = new Label();
            labelNetPay = new Label();
            resultTaxAmount = new Label();
            labelTaxAmount = new Label();
            resultMonGrossPay = new Label();
            resultMonBreaks = new Label();
            resultMonHoursScheduled = new Label();
            labelMonGrossPay = new Label();
            labelMonBreaks = new Label();
            labelMonHoursScheduled = new Label();
            panel1 = new Panel();
            gbSunInfo = new GroupBox();
            inputSunStartTimePicker = new DateTimePicker();
            inputSunFinishTimePicker = new DateTimePicker();
            labelSunStartTime = new Label();
            resultSunGrossPay = new Label();
            labelSunFinishTime = new Label();
            labelSunHoursScheduled = new Label();
            labelSunGrossPay = new Label();
            resultSunBreaks = new Label();
            resultSunHoursScheduled = new Label();
            labelSunBreaks = new Label();
            gbSatInfo = new GroupBox();
            inputSatStartTimePicker = new DateTimePicker();
            inputSatFinishTimePicker = new DateTimePicker();
            labelSatStartTime = new Label();
            resultSatGrossPay = new Label();
            labelSatFinishTime = new Label();
            labelSatHoursScheduled = new Label();
            labelSatGrossPay = new Label();
            resultSatBreaks = new Label();
            resultSatHoursScheduled = new Label();
            labelSatBreaks = new Label();
            gbFriInfo = new GroupBox();
            inputFriStartTimePicker = new DateTimePicker();
            inputFriFinishTimePicker = new DateTimePicker();
            labelFriStartTime = new Label();
            resultFriGrossPay = new Label();
            labelFriFinishTime = new Label();
            labelFriHoursScheduled = new Label();
            labelFriGrossPay = new Label();
            resultFriBreaks = new Label();
            resultFriHoursScheduled = new Label();
            labelFriBreaks = new Label();
            gbThuInfo = new GroupBox();
            inputThurStartTimePicker = new DateTimePicker();
            inputThurFinishTimePicker = new DateTimePicker();
            labelThurStartTime = new Label();
            resultThurGrossPay = new Label();
            labelThurFinishTime = new Label();
            labelThurHoursScheduled = new Label();
            labelThurGrossPay = new Label();
            resultThurBreaks = new Label();
            resultThurHoursScheduled = new Label();
            labelThurBreaks = new Label();
            gbWedInfo = new GroupBox();
            inputWedStartTimePicker = new DateTimePicker();
            inputWedFinishTimePicker = new DateTimePicker();
            labelWedStartTime = new Label();
            resultWedGrossPay = new Label();
            labelWedFinishTime = new Label();
            labelWedHoursScheduled = new Label();
            labelWedGrossPay = new Label();
            resultWedBreaks = new Label();
            resultWedHoursScheduled = new Label();
            labelWedBreaks = new Label();
            gbTueInfo = new GroupBox();
            inputTueStartTimePicker = new DateTimePicker();
            inputTueFinishTimePicker = new DateTimePicker();
            labelTueStartTime = new Label();
            resultTueGrossPay = new Label();
            labelTueFinishTime = new Label();
            labelTueHoursScheduled = new Label();
            labelTueGrossPay = new Label();
            resultTueBreaks = new Label();
            resultTueHoursScheduled = new Label();
            labelTueBreaks = new Label();
            gbMonInfo = new GroupBox();
            payInformationgroupBox1.SuspendLayout();
            panel1.SuspendLayout();
            gbSunInfo.SuspendLayout();
            gbSatInfo.SuspendLayout();
            gbFriInfo.SuspendLayout();
            gbThuInfo.SuspendLayout();
            gbWedInfo.SuspendLayout();
            gbTueInfo.SuspendLayout();
            gbMonInfo.SuspendLayout();
            SuspendLayout();
            // 
            // labelMonStartTime
            // 
            labelMonStartTime.AutoSize = true;
            labelMonStartTime.Location = new Point(6, 28);
            labelMonStartTime.Name = "labelMonStartTime";
            labelMonStartTime.Size = new Size(63, 15);
            labelMonStartTime.TabIndex = 1;
            labelMonStartTime.Text = "Start Time:";
            // 
            // labelMonFinishTime
            // 
            labelMonFinishTime.AutoSize = true;
            labelMonFinishTime.Location = new Point(6, 57);
            labelMonFinishTime.Name = "labelMonFinishTime";
            labelMonFinishTime.Size = new Size(70, 15);
            labelMonFinishTime.TabIndex = 2;
            labelMonFinishTime.Text = "Finish Time:";
            // 
            // inputMonStartTimePicker
            // 
            inputMonStartTimePicker.CustomFormat = "HH:mm";
            inputMonStartTimePicker.Format = DateTimePickerFormat.Custom;
            inputMonStartTimePicker.Location = new Point(109, 22);
            inputMonStartTimePicker.Name = "inputMonStartTimePicker";
            inputMonStartTimePicker.ShowUpDown = true;
            inputMonStartTimePicker.Size = new Size(58, 23);
            inputMonStartTimePicker.TabIndex = 1;
            inputMonStartTimePicker.Value = new DateTime(2023, 12, 7, 0, 0, 0, 0);
            // 
            // inputMonFinishTimePicker
            // 
            inputMonFinishTimePicker.CustomFormat = "HH:mm";
            inputMonFinishTimePicker.Format = DateTimePickerFormat.Custom;
            inputMonFinishTimePicker.Location = new Point(109, 51);
            inputMonFinishTimePicker.Name = "inputMonFinishTimePicker";
            inputMonFinishTimePicker.ShowUpDown = true;
            inputMonFinishTimePicker.Size = new Size(58, 23);
            inputMonFinishTimePicker.TabIndex = 2;
            inputMonFinishTimePicker.Value = new DateTime(2023, 12, 7, 0, 0, 0, 0);
            inputMonFinishTimePicker.ValueChanged += Mon_Calculations;
            // 
            // calculateHoursbutton1
            // 
            calculateHoursbutton1.Location = new Point(164, 243);
            calculateHoursbutton1.Name = "calculateHoursbutton1";
            calculateHoursbutton1.Size = new Size(101, 23);
            calculateHoursbutton1.TabIndex = 15;
            calculateHoursbutton1.Text = "Calculate Hours";
            calculateHoursbutton1.UseVisualStyleBackColor = true;
            calculateHoursbutton1.Click += Do_Calculations;
            // 
            // payInformationgroupBox1
            // 
            payInformationgroupBox1.Controls.Add(resultNetPay);
            payInformationgroupBox1.Controls.Add(labelNetPay);
            payInformationgroupBox1.Controls.Add(resultTaxAmount);
            payInformationgroupBox1.Controls.Add(labelTaxAmount);
            payInformationgroupBox1.Location = new Point(12, 188);
            payInformationgroupBox1.Name = "payInformationgroupBox1";
            payInformationgroupBox1.Size = new Size(146, 78);
            payInformationgroupBox1.TabIndex = 7;
            payInformationgroupBox1.TabStop = false;
            payInformationgroupBox1.Text = "Pay Information";
            // 
            // resultNetPay
            // 
            resultNetPay.AutoSize = true;
            resultNetPay.Location = new Point(103, 48);
            resultNetPay.Name = "resultNetPay";
            resultNetPay.Size = new Size(34, 15);
            resultNetPay.TabIndex = 8;
            resultNetPay.Text = "$0.00";
            // 
            // labelNetPay
            // 
            labelNetPay.AutoSize = true;
            labelNetPay.Location = new Point(8, 48);
            labelNetPay.Name = "labelNetPay";
            labelNetPay.Size = new Size(51, 15);
            labelNetPay.TabIndex = 8;
            labelNetPay.Text = "Net Pay:";
            // 
            // resultTaxAmount
            // 
            resultTaxAmount.AutoSize = true;
            resultTaxAmount.Location = new Point(103, 22);
            resultTaxAmount.Name = "resultTaxAmount";
            resultTaxAmount.Size = new Size(34, 15);
            resultTaxAmount.TabIndex = 9;
            resultTaxAmount.Text = "$0.00";
            // 
            // labelTaxAmount
            // 
            labelTaxAmount.AutoSize = true;
            labelTaxAmount.Location = new Point(8, 22);
            labelTaxAmount.Name = "labelTaxAmount";
            labelTaxAmount.Size = new Size(27, 15);
            labelTaxAmount.TabIndex = 8;
            labelTaxAmount.Text = "Tax:";
            // 
            // resultMonGrossPay
            // 
            resultMonGrossPay.AutoSize = true;
            resultMonGrossPay.Location = new Point(109, 144);
            resultMonGrossPay.Name = "resultMonGrossPay";
            resultMonGrossPay.Size = new Size(34, 15);
            resultMonGrossPay.TabIndex = 5;
            resultMonGrossPay.Text = "$0.00";
            // 
            // resultMonBreaks
            // 
            resultMonBreaks.AutoSize = true;
            resultMonBreaks.Location = new Point(115, 115);
            resultMonBreaks.Name = "resultMonBreaks";
            resultMonBreaks.Size = new Size(28, 15);
            resultMonBreaks.TabIndex = 4;
            resultMonBreaks.Text = "0:00";
            // 
            // resultMonHoursScheduled
            // 
            resultMonHoursScheduled.AutoSize = true;
            resultMonHoursScheduled.Location = new Point(115, 86);
            resultMonHoursScheduled.Name = "resultMonHoursScheduled";
            resultMonHoursScheduled.Size = new Size(28, 15);
            resultMonHoursScheduled.TabIndex = 3;
            resultMonHoursScheduled.Text = "0:00";
            // 
            // labelMonGrossPay
            // 
            labelMonGrossPay.AutoSize = true;
            labelMonGrossPay.Location = new Point(6, 144);
            labelMonGrossPay.Name = "labelMonGrossPay";
            labelMonGrossPay.Size = new Size(64, 15);
            labelMonGrossPay.TabIndex = 2;
            labelMonGrossPay.Text = "Gross Pay: ";
            // 
            // labelMonBreaks
            // 
            labelMonBreaks.AutoSize = true;
            labelMonBreaks.Location = new Point(6, 115);
            labelMonBreaks.Name = "labelMonBreaks";
            labelMonBreaks.Size = new Size(47, 15);
            labelMonBreaks.TabIndex = 1;
            labelMonBreaks.Text = "Breaks: ";
            // 
            // labelMonHoursScheduled
            // 
            labelMonHoursScheduled.AutoSize = true;
            labelMonHoursScheduled.Location = new Point(6, 86);
            labelMonHoursScheduled.Name = "labelMonHoursScheduled";
            labelMonHoursScheduled.Size = new Size(103, 15);
            labelMonHoursScheduled.TabIndex = 0;
            labelMonHoursScheduled.Text = "Hours Scheduled: ";
            // 
            // panel1
            // 
            panel1.Controls.Add(gbSunInfo);
            panel1.Controls.Add(gbSatInfo);
            panel1.Controls.Add(gbFriInfo);
            panel1.Controls.Add(gbThuInfo);
            panel1.Controls.Add(gbWedInfo);
            panel1.Controls.Add(gbTueInfo);
            panel1.Controls.Add(gbMonInfo);
            panel1.Controls.Add(calculateHoursbutton1);
            panel1.Controls.Add(payInformationgroupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1305, 277);
            panel1.TabIndex = 8;
            // 
            // gbSunInfo
            // 
            gbSunInfo.Controls.Add(inputSunStartTimePicker);
            gbSunInfo.Controls.Add(inputSunFinishTimePicker);
            gbSunInfo.Controls.Add(labelSunStartTime);
            gbSunInfo.Controls.Add(resultSunGrossPay);
            gbSunInfo.Controls.Add(labelSunFinishTime);
            gbSunInfo.Controls.Add(labelSunHoursScheduled);
            gbSunInfo.Controls.Add(labelSunGrossPay);
            gbSunInfo.Controls.Add(resultSunBreaks);
            gbSunInfo.Controls.Add(resultSunHoursScheduled);
            gbSunInfo.Controls.Add(labelSunBreaks);
            gbSunInfo.Location = new Point(1116, 12);
            gbSunInfo.Name = "gbSunInfo";
            gbSunInfo.Size = new Size(178, 170);
            gbSunInfo.TabIndex = 10;
            gbSunInfo.TabStop = false;
            gbSunInfo.Text = "Sunday";
            // 
            // inputSunStartTimePicker
            // 
            inputSunStartTimePicker.CustomFormat = "HH:mm";
            inputSunStartTimePicker.Format = DateTimePickerFormat.Custom;
            inputSunStartTimePicker.Location = new Point(109, 22);
            inputSunStartTimePicker.Name = "inputSunStartTimePicker";
            inputSunStartTimePicker.ShowUpDown = true;
            inputSunStartTimePicker.Size = new Size(58, 23);
            inputSunStartTimePicker.TabIndex = 13;
            inputSunStartTimePicker.Value = new DateTime(2023, 12, 7, 0, 0, 0, 0);
            // 
            // inputSunFinishTimePicker
            // 
            inputSunFinishTimePicker.CustomFormat = "HH:mm";
            inputSunFinishTimePicker.Format = DateTimePickerFormat.Custom;
            inputSunFinishTimePicker.Location = new Point(109, 51);
            inputSunFinishTimePicker.Name = "inputSunFinishTimePicker";
            inputSunFinishTimePicker.ShowUpDown = true;
            inputSunFinishTimePicker.Size = new Size(58, 23);
            inputSunFinishTimePicker.TabIndex = 14;
            inputSunFinishTimePicker.Value = new DateTime(2023, 12, 7, 0, 0, 0, 0);
            inputSunFinishTimePicker.ValueChanged += Sun_Calculations;
            // 
            // labelSunStartTime
            // 
            labelSunStartTime.AutoSize = true;
            labelSunStartTime.Location = new Point(6, 28);
            labelSunStartTime.Name = "labelSunStartTime";
            labelSunStartTime.Size = new Size(63, 15);
            labelSunStartTime.TabIndex = 1;
            labelSunStartTime.Text = "Start Time:";
            // 
            // resultSunGrossPay
            // 
            resultSunGrossPay.AutoSize = true;
            resultSunGrossPay.Location = new Point(109, 144);
            resultSunGrossPay.Name = "resultSunGrossPay";
            resultSunGrossPay.Size = new Size(34, 15);
            resultSunGrossPay.TabIndex = 5;
            resultSunGrossPay.Text = "$0.00";
            // 
            // labelSunFinishTime
            // 
            labelSunFinishTime.AutoSize = true;
            labelSunFinishTime.Location = new Point(6, 57);
            labelSunFinishTime.Name = "labelSunFinishTime";
            labelSunFinishTime.Size = new Size(70, 15);
            labelSunFinishTime.TabIndex = 2;
            labelSunFinishTime.Text = "Finish Time:";
            // 
            // labelSunHoursScheduled
            // 
            labelSunHoursScheduled.AutoSize = true;
            labelSunHoursScheduled.Location = new Point(6, 86);
            labelSunHoursScheduled.Name = "labelSunHoursScheduled";
            labelSunHoursScheduled.Size = new Size(103, 15);
            labelSunHoursScheduled.TabIndex = 0;
            labelSunHoursScheduled.Text = "Hours Scheduled: ";
            // 
            // labelSunGrossPay
            // 
            labelSunGrossPay.AutoSize = true;
            labelSunGrossPay.Location = new Point(6, 144);
            labelSunGrossPay.Name = "labelSunGrossPay";
            labelSunGrossPay.Size = new Size(64, 15);
            labelSunGrossPay.TabIndex = 2;
            labelSunGrossPay.Text = "Gross Pay: ";
            // 
            // resultSunBreaks
            // 
            resultSunBreaks.AutoSize = true;
            resultSunBreaks.Location = new Point(115, 115);
            resultSunBreaks.Name = "resultSunBreaks";
            resultSunBreaks.Size = new Size(28, 15);
            resultSunBreaks.TabIndex = 4;
            resultSunBreaks.Text = "0:00";
            // 
            // resultSunHoursScheduled
            // 
            resultSunHoursScheduled.AutoSize = true;
            resultSunHoursScheduled.Location = new Point(115, 86);
            resultSunHoursScheduled.Name = "resultSunHoursScheduled";
            resultSunHoursScheduled.Size = new Size(28, 15);
            resultSunHoursScheduled.TabIndex = 3;
            resultSunHoursScheduled.Text = "0:00";
            // 
            // labelSunBreaks
            // 
            labelSunBreaks.AutoSize = true;
            labelSunBreaks.Location = new Point(6, 115);
            labelSunBreaks.Name = "labelSunBreaks";
            labelSunBreaks.Size = new Size(47, 15);
            labelSunBreaks.TabIndex = 1;
            labelSunBreaks.Text = "Breaks: ";
            // 
            // gbSatInfo
            // 
            gbSatInfo.Controls.Add(inputSatStartTimePicker);
            gbSatInfo.Controls.Add(inputSatFinishTimePicker);
            gbSatInfo.Controls.Add(labelSatStartTime);
            gbSatInfo.Controls.Add(resultSatGrossPay);
            gbSatInfo.Controls.Add(labelSatFinishTime);
            gbSatInfo.Controls.Add(labelSatHoursScheduled);
            gbSatInfo.Controls.Add(labelSatGrossPay);
            gbSatInfo.Controls.Add(resultSatBreaks);
            gbSatInfo.Controls.Add(resultSatHoursScheduled);
            gbSatInfo.Controls.Add(labelSatBreaks);
            gbSatInfo.Location = new Point(932, 12);
            gbSatInfo.Name = "gbSatInfo";
            gbSatInfo.Size = new Size(178, 170);
            gbSatInfo.TabIndex = 10;
            gbSatInfo.TabStop = false;
            gbSatInfo.Text = "Saturday";
            // 
            // inputSatStartTimePicker
            // 
            inputSatStartTimePicker.CustomFormat = "HH:mm";
            inputSatStartTimePicker.Format = DateTimePickerFormat.Custom;
            inputSatStartTimePicker.Location = new Point(109, 22);
            inputSatStartTimePicker.Name = "inputSatStartTimePicker";
            inputSatStartTimePicker.ShowUpDown = true;
            inputSatStartTimePicker.Size = new Size(58, 23);
            inputSatStartTimePicker.TabIndex = 11;
            inputSatStartTimePicker.Value = new DateTime(2023, 12, 7, 0, 0, 0, 0);
            // 
            // inputSatFinishTimePicker
            // 
            inputSatFinishTimePicker.CustomFormat = "HH:mm";
            inputSatFinishTimePicker.Format = DateTimePickerFormat.Custom;
            inputSatFinishTimePicker.Location = new Point(109, 51);
            inputSatFinishTimePicker.Name = "inputSatFinishTimePicker";
            inputSatFinishTimePicker.ShowUpDown = true;
            inputSatFinishTimePicker.Size = new Size(58, 23);
            inputSatFinishTimePicker.TabIndex = 12;
            inputSatFinishTimePicker.Value = new DateTime(2023, 12, 7, 0, 0, 0, 0);
            inputSatFinishTimePicker.ValueChanged += Sat_Calculations;
            // 
            // labelSatStartTime
            // 
            labelSatStartTime.AutoSize = true;
            labelSatStartTime.Location = new Point(6, 28);
            labelSatStartTime.Name = "labelSatStartTime";
            labelSatStartTime.Size = new Size(63, 15);
            labelSatStartTime.TabIndex = 1;
            labelSatStartTime.Text = "Start Time:";
            // 
            // resultSatGrossPay
            // 
            resultSatGrossPay.AutoSize = true;
            resultSatGrossPay.Location = new Point(109, 144);
            resultSatGrossPay.Name = "resultSatGrossPay";
            resultSatGrossPay.Size = new Size(34, 15);
            resultSatGrossPay.TabIndex = 5;
            resultSatGrossPay.Text = "$0.00";
            // 
            // labelSatFinishTime
            // 
            labelSatFinishTime.AutoSize = true;
            labelSatFinishTime.Location = new Point(6, 57);
            labelSatFinishTime.Name = "labelSatFinishTime";
            labelSatFinishTime.Size = new Size(70, 15);
            labelSatFinishTime.TabIndex = 2;
            labelSatFinishTime.Text = "Finish Time:";
            // 
            // labelSatHoursScheduled
            // 
            labelSatHoursScheduled.AutoSize = true;
            labelSatHoursScheduled.Location = new Point(6, 86);
            labelSatHoursScheduled.Name = "labelSatHoursScheduled";
            labelSatHoursScheduled.Size = new Size(103, 15);
            labelSatHoursScheduled.TabIndex = 0;
            labelSatHoursScheduled.Text = "Hours Scheduled: ";
            // 
            // labelSatGrossPay
            // 
            labelSatGrossPay.AutoSize = true;
            labelSatGrossPay.Location = new Point(6, 144);
            labelSatGrossPay.Name = "labelSatGrossPay";
            labelSatGrossPay.Size = new Size(64, 15);
            labelSatGrossPay.TabIndex = 2;
            labelSatGrossPay.Text = "Gross Pay: ";
            // 
            // resultSatBreaks
            // 
            resultSatBreaks.AutoSize = true;
            resultSatBreaks.Location = new Point(115, 115);
            resultSatBreaks.Name = "resultSatBreaks";
            resultSatBreaks.Size = new Size(28, 15);
            resultSatBreaks.TabIndex = 4;
            resultSatBreaks.Text = "0:00";
            // 
            // resultSatHoursScheduled
            // 
            resultSatHoursScheduled.AutoSize = true;
            resultSatHoursScheduled.Location = new Point(115, 86);
            resultSatHoursScheduled.Name = "resultSatHoursScheduled";
            resultSatHoursScheduled.Size = new Size(28, 15);
            resultSatHoursScheduled.TabIndex = 3;
            resultSatHoursScheduled.Text = "0:00";
            // 
            // labelSatBreaks
            // 
            labelSatBreaks.AutoSize = true;
            labelSatBreaks.Location = new Point(6, 115);
            labelSatBreaks.Name = "labelSatBreaks";
            labelSatBreaks.Size = new Size(47, 15);
            labelSatBreaks.TabIndex = 1;
            labelSatBreaks.Text = "Breaks: ";
            // 
            // gbFriInfo
            // 
            gbFriInfo.Controls.Add(inputFriStartTimePicker);
            gbFriInfo.Controls.Add(inputFriFinishTimePicker);
            gbFriInfo.Controls.Add(labelFriStartTime);
            gbFriInfo.Controls.Add(resultFriGrossPay);
            gbFriInfo.Controls.Add(labelFriFinishTime);
            gbFriInfo.Controls.Add(labelFriHoursScheduled);
            gbFriInfo.Controls.Add(labelFriGrossPay);
            gbFriInfo.Controls.Add(resultFriBreaks);
            gbFriInfo.Controls.Add(resultFriHoursScheduled);
            gbFriInfo.Controls.Add(labelFriBreaks);
            gbFriInfo.Location = new Point(748, 12);
            gbFriInfo.Name = "gbFriInfo";
            gbFriInfo.Size = new Size(178, 170);
            gbFriInfo.TabIndex = 10;
            gbFriInfo.TabStop = false;
            gbFriInfo.Text = "Friday";
            // 
            // inputFriStartTimePicker
            // 
            inputFriStartTimePicker.CustomFormat = "HH:mm";
            inputFriStartTimePicker.Format = DateTimePickerFormat.Custom;
            inputFriStartTimePicker.Location = new Point(109, 22);
            inputFriStartTimePicker.Name = "inputFriStartTimePicker";
            inputFriStartTimePicker.ShowUpDown = true;
            inputFriStartTimePicker.Size = new Size(58, 23);
            inputFriStartTimePicker.TabIndex = 9;
            inputFriStartTimePicker.Value = new DateTime(2023, 12, 7, 0, 0, 0, 0);
            // 
            // inputFriFinishTimePicker
            // 
            inputFriFinishTimePicker.CustomFormat = "HH:mm";
            inputFriFinishTimePicker.Format = DateTimePickerFormat.Custom;
            inputFriFinishTimePicker.Location = new Point(109, 51);
            inputFriFinishTimePicker.Name = "inputFriFinishTimePicker";
            inputFriFinishTimePicker.ShowUpDown = true;
            inputFriFinishTimePicker.Size = new Size(58, 23);
            inputFriFinishTimePicker.TabIndex = 10;
            inputFriFinishTimePicker.Value = new DateTime(2023, 12, 7, 0, 0, 0, 0);
            inputFriFinishTimePicker.ValueChanged += Fri_Calculations;
            // 
            // labelFriStartTime
            // 
            labelFriStartTime.AutoSize = true;
            labelFriStartTime.Location = new Point(6, 28);
            labelFriStartTime.Name = "labelFriStartTime";
            labelFriStartTime.Size = new Size(63, 15);
            labelFriStartTime.TabIndex = 1;
            labelFriStartTime.Text = "Start Time:";
            // 
            // resultFriGrossPay
            // 
            resultFriGrossPay.AutoSize = true;
            resultFriGrossPay.Location = new Point(109, 144);
            resultFriGrossPay.Name = "resultFriGrossPay";
            resultFriGrossPay.Size = new Size(34, 15);
            resultFriGrossPay.TabIndex = 5;
            resultFriGrossPay.Text = "$0.00";
            // 
            // labelFriFinishTime
            // 
            labelFriFinishTime.AutoSize = true;
            labelFriFinishTime.Location = new Point(6, 57);
            labelFriFinishTime.Name = "labelFriFinishTime";
            labelFriFinishTime.Size = new Size(70, 15);
            labelFriFinishTime.TabIndex = 2;
            labelFriFinishTime.Text = "Finish Time:";
            // 
            // labelFriHoursScheduled
            // 
            labelFriHoursScheduled.AutoSize = true;
            labelFriHoursScheduled.Location = new Point(6, 86);
            labelFriHoursScheduled.Name = "labelFriHoursScheduled";
            labelFriHoursScheduled.Size = new Size(103, 15);
            labelFriHoursScheduled.TabIndex = 0;
            labelFriHoursScheduled.Text = "Hours Scheduled: ";
            // 
            // labelFriGrossPay
            // 
            labelFriGrossPay.AutoSize = true;
            labelFriGrossPay.Location = new Point(6, 144);
            labelFriGrossPay.Name = "labelFriGrossPay";
            labelFriGrossPay.Size = new Size(64, 15);
            labelFriGrossPay.TabIndex = 2;
            labelFriGrossPay.Text = "Gross Pay: ";
            // 
            // resultFriBreaks
            // 
            resultFriBreaks.AutoSize = true;
            resultFriBreaks.Location = new Point(115, 115);
            resultFriBreaks.Name = "resultFriBreaks";
            resultFriBreaks.Size = new Size(28, 15);
            resultFriBreaks.TabIndex = 4;
            resultFriBreaks.Text = "0:00";
            // 
            // resultFriHoursScheduled
            // 
            resultFriHoursScheduled.AutoSize = true;
            resultFriHoursScheduled.Location = new Point(115, 86);
            resultFriHoursScheduled.Name = "resultFriHoursScheduled";
            resultFriHoursScheduled.Size = new Size(28, 15);
            resultFriHoursScheduled.TabIndex = 3;
            resultFriHoursScheduled.Text = "0:00";
            // 
            // labelFriBreaks
            // 
            labelFriBreaks.AutoSize = true;
            labelFriBreaks.Location = new Point(6, 115);
            labelFriBreaks.Name = "labelFriBreaks";
            labelFriBreaks.Size = new Size(47, 15);
            labelFriBreaks.TabIndex = 1;
            labelFriBreaks.Text = "Breaks: ";
            // 
            // gbThuInfo
            // 
            gbThuInfo.Controls.Add(inputThurStartTimePicker);
            gbThuInfo.Controls.Add(inputThurFinishTimePicker);
            gbThuInfo.Controls.Add(labelThurStartTime);
            gbThuInfo.Controls.Add(resultThurGrossPay);
            gbThuInfo.Controls.Add(labelThurFinishTime);
            gbThuInfo.Controls.Add(labelThurHoursScheduled);
            gbThuInfo.Controls.Add(labelThurGrossPay);
            gbThuInfo.Controls.Add(resultThurBreaks);
            gbThuInfo.Controls.Add(resultThurHoursScheduled);
            gbThuInfo.Controls.Add(labelThurBreaks);
            gbThuInfo.Location = new Point(564, 12);
            gbThuInfo.Name = "gbThuInfo";
            gbThuInfo.Size = new Size(178, 170);
            gbThuInfo.TabIndex = 10;
            gbThuInfo.TabStop = false;
            gbThuInfo.Text = "Thursday";
            // 
            // inputThurStartTimePicker
            // 
            inputThurStartTimePicker.CustomFormat = "HH:mm";
            inputThurStartTimePicker.Format = DateTimePickerFormat.Custom;
            inputThurStartTimePicker.Location = new Point(109, 22);
            inputThurStartTimePicker.Name = "inputThurStartTimePicker";
            inputThurStartTimePicker.ShowUpDown = true;
            inputThurStartTimePicker.Size = new Size(58, 23);
            inputThurStartTimePicker.TabIndex = 7;
            inputThurStartTimePicker.Value = new DateTime(2023, 12, 7, 0, 0, 0, 0);
            // 
            // inputThurFinishTimePicker
            // 
            inputThurFinishTimePicker.CustomFormat = "HH:mm";
            inputThurFinishTimePicker.Format = DateTimePickerFormat.Custom;
            inputThurFinishTimePicker.Location = new Point(109, 51);
            inputThurFinishTimePicker.Name = "inputThurFinishTimePicker";
            inputThurFinishTimePicker.ShowUpDown = true;
            inputThurFinishTimePicker.Size = new Size(58, 23);
            inputThurFinishTimePicker.TabIndex = 8;
            inputThurFinishTimePicker.Value = new DateTime(2023, 12, 7, 0, 0, 0, 0);
            inputThurFinishTimePicker.ValueChanged += Thu_Calculations;
            // 
            // labelThurStartTime
            // 
            labelThurStartTime.AutoSize = true;
            labelThurStartTime.Location = new Point(6, 28);
            labelThurStartTime.Name = "labelThurStartTime";
            labelThurStartTime.Size = new Size(63, 15);
            labelThurStartTime.TabIndex = 1;
            labelThurStartTime.Text = "Start Time:";
            // 
            // resultThurGrossPay
            // 
            resultThurGrossPay.AutoSize = true;
            resultThurGrossPay.Location = new Point(109, 144);
            resultThurGrossPay.Name = "resultThurGrossPay";
            resultThurGrossPay.Size = new Size(34, 15);
            resultThurGrossPay.TabIndex = 5;
            resultThurGrossPay.Text = "$0.00";
            // 
            // labelThurFinishTime
            // 
            labelThurFinishTime.AutoSize = true;
            labelThurFinishTime.Location = new Point(6, 57);
            labelThurFinishTime.Name = "labelThurFinishTime";
            labelThurFinishTime.Size = new Size(70, 15);
            labelThurFinishTime.TabIndex = 2;
            labelThurFinishTime.Text = "Finish Time:";
            // 
            // labelThurHoursScheduled
            // 
            labelThurHoursScheduled.AutoSize = true;
            labelThurHoursScheduled.Location = new Point(6, 86);
            labelThurHoursScheduled.Name = "labelThurHoursScheduled";
            labelThurHoursScheduled.Size = new Size(103, 15);
            labelThurHoursScheduled.TabIndex = 0;
            labelThurHoursScheduled.Text = "Hours Scheduled: ";
            // 
            // labelThurGrossPay
            // 
            labelThurGrossPay.AutoSize = true;
            labelThurGrossPay.Location = new Point(6, 144);
            labelThurGrossPay.Name = "labelThurGrossPay";
            labelThurGrossPay.Size = new Size(64, 15);
            labelThurGrossPay.TabIndex = 2;
            labelThurGrossPay.Text = "Gross Pay: ";
            // 
            // resultThurBreaks
            // 
            resultThurBreaks.AutoSize = true;
            resultThurBreaks.Location = new Point(115, 115);
            resultThurBreaks.Name = "resultThurBreaks";
            resultThurBreaks.Size = new Size(28, 15);
            resultThurBreaks.TabIndex = 4;
            resultThurBreaks.Text = "0:00";
            // 
            // resultThurHoursScheduled
            // 
            resultThurHoursScheduled.AutoSize = true;
            resultThurHoursScheduled.Location = new Point(115, 86);
            resultThurHoursScheduled.Name = "resultThurHoursScheduled";
            resultThurHoursScheduled.Size = new Size(28, 15);
            resultThurHoursScheduled.TabIndex = 3;
            resultThurHoursScheduled.Text = "0:00";
            // 
            // labelThurBreaks
            // 
            labelThurBreaks.AutoSize = true;
            labelThurBreaks.Location = new Point(6, 115);
            labelThurBreaks.Name = "labelThurBreaks";
            labelThurBreaks.Size = new Size(47, 15);
            labelThurBreaks.TabIndex = 1;
            labelThurBreaks.Text = "Breaks: ";
            // 
            // gbWedInfo
            // 
            gbWedInfo.Controls.Add(inputWedStartTimePicker);
            gbWedInfo.Controls.Add(inputWedFinishTimePicker);
            gbWedInfo.Controls.Add(labelWedStartTime);
            gbWedInfo.Controls.Add(resultWedGrossPay);
            gbWedInfo.Controls.Add(labelWedFinishTime);
            gbWedInfo.Controls.Add(labelWedHoursScheduled);
            gbWedInfo.Controls.Add(labelWedGrossPay);
            gbWedInfo.Controls.Add(resultWedBreaks);
            gbWedInfo.Controls.Add(resultWedHoursScheduled);
            gbWedInfo.Controls.Add(labelWedBreaks);
            gbWedInfo.Location = new Point(380, 12);
            gbWedInfo.Name = "gbWedInfo";
            gbWedInfo.Size = new Size(178, 170);
            gbWedInfo.TabIndex = 10;
            gbWedInfo.TabStop = false;
            gbWedInfo.Text = "Wednesday";
            // 
            // inputWedStartTimePicker
            // 
            inputWedStartTimePicker.CustomFormat = "HH:mm";
            inputWedStartTimePicker.Format = DateTimePickerFormat.Custom;
            inputWedStartTimePicker.Location = new Point(109, 22);
            inputWedStartTimePicker.Name = "inputWedStartTimePicker";
            inputWedStartTimePicker.ShowUpDown = true;
            inputWedStartTimePicker.Size = new Size(58, 23);
            inputWedStartTimePicker.TabIndex = 5;
            inputWedStartTimePicker.Value = new DateTime(2023, 12, 7, 0, 0, 0, 0);
            // 
            // inputWedFinishTimePicker
            // 
            inputWedFinishTimePicker.CustomFormat = "HH:mm";
            inputWedFinishTimePicker.Format = DateTimePickerFormat.Custom;
            inputWedFinishTimePicker.Location = new Point(109, 51);
            inputWedFinishTimePicker.Name = "inputWedFinishTimePicker";
            inputWedFinishTimePicker.ShowUpDown = true;
            inputWedFinishTimePicker.Size = new Size(58, 23);
            inputWedFinishTimePicker.TabIndex = 6;
            inputWedFinishTimePicker.Value = new DateTime(2023, 12, 7, 0, 0, 0, 0);
            inputWedFinishTimePicker.ValueChanged += Wed_Calculations;
            // 
            // labelWedStartTime
            // 
            labelWedStartTime.AutoSize = true;
            labelWedStartTime.Location = new Point(6, 28);
            labelWedStartTime.Name = "labelWedStartTime";
            labelWedStartTime.Size = new Size(63, 15);
            labelWedStartTime.TabIndex = 1;
            labelWedStartTime.Text = "Start Time:";
            // 
            // resultWedGrossPay
            // 
            resultWedGrossPay.AutoSize = true;
            resultWedGrossPay.Location = new Point(109, 144);
            resultWedGrossPay.Name = "resultWedGrossPay";
            resultWedGrossPay.Size = new Size(34, 15);
            resultWedGrossPay.TabIndex = 5;
            resultWedGrossPay.Text = "$0.00";
            // 
            // labelWedFinishTime
            // 
            labelWedFinishTime.AutoSize = true;
            labelWedFinishTime.Location = new Point(6, 57);
            labelWedFinishTime.Name = "labelWedFinishTime";
            labelWedFinishTime.Size = new Size(70, 15);
            labelWedFinishTime.TabIndex = 2;
            labelWedFinishTime.Text = "Finish Time:";
            // 
            // labelWedHoursScheduled
            // 
            labelWedHoursScheduled.AutoSize = true;
            labelWedHoursScheduled.Location = new Point(6, 86);
            labelWedHoursScheduled.Name = "labelWedHoursScheduled";
            labelWedHoursScheduled.Size = new Size(103, 15);
            labelWedHoursScheduled.TabIndex = 0;
            labelWedHoursScheduled.Text = "Hours Scheduled: ";
            // 
            // labelWedGrossPay
            // 
            labelWedGrossPay.AutoSize = true;
            labelWedGrossPay.Location = new Point(6, 144);
            labelWedGrossPay.Name = "labelWedGrossPay";
            labelWedGrossPay.Size = new Size(64, 15);
            labelWedGrossPay.TabIndex = 2;
            labelWedGrossPay.Text = "Gross Pay: ";
            // 
            // resultWedBreaks
            // 
            resultWedBreaks.AutoSize = true;
            resultWedBreaks.Location = new Point(115, 115);
            resultWedBreaks.Name = "resultWedBreaks";
            resultWedBreaks.Size = new Size(28, 15);
            resultWedBreaks.TabIndex = 4;
            resultWedBreaks.Text = "0:00";
            // 
            // resultWedHoursScheduled
            // 
            resultWedHoursScheduled.AutoSize = true;
            resultWedHoursScheduled.Location = new Point(115, 86);
            resultWedHoursScheduled.Name = "resultWedHoursScheduled";
            resultWedHoursScheduled.Size = new Size(28, 15);
            resultWedHoursScheduled.TabIndex = 3;
            resultWedHoursScheduled.Text = "0:00";
            // 
            // labelWedBreaks
            // 
            labelWedBreaks.AutoSize = true;
            labelWedBreaks.Location = new Point(6, 115);
            labelWedBreaks.Name = "labelWedBreaks";
            labelWedBreaks.Size = new Size(47, 15);
            labelWedBreaks.TabIndex = 1;
            labelWedBreaks.Text = "Breaks: ";
            // 
            // gbTueInfo
            // 
            gbTueInfo.Controls.Add(inputTueStartTimePicker);
            gbTueInfo.Controls.Add(inputTueFinishTimePicker);
            gbTueInfo.Controls.Add(labelTueStartTime);
            gbTueInfo.Controls.Add(resultTueGrossPay);
            gbTueInfo.Controls.Add(labelTueFinishTime);
            gbTueInfo.Controls.Add(labelTueHoursScheduled);
            gbTueInfo.Controls.Add(labelTueGrossPay);
            gbTueInfo.Controls.Add(resultTueBreaks);
            gbTueInfo.Controls.Add(resultTueHoursScheduled);
            gbTueInfo.Controls.Add(labelTueBreaks);
            gbTueInfo.Location = new Point(196, 12);
            gbTueInfo.Name = "gbTueInfo";
            gbTueInfo.Size = new Size(178, 170);
            gbTueInfo.TabIndex = 9;
            gbTueInfo.TabStop = false;
            gbTueInfo.Text = "Tuesday";
            // 
            // inputTueStartTimePicker
            // 
            inputTueStartTimePicker.CustomFormat = "HH:mm";
            inputTueStartTimePicker.Format = DateTimePickerFormat.Custom;
            inputTueStartTimePicker.Location = new Point(109, 22);
            inputTueStartTimePicker.Name = "inputTueStartTimePicker";
            inputTueStartTimePicker.ShowUpDown = true;
            inputTueStartTimePicker.Size = new Size(58, 23);
            inputTueStartTimePicker.TabIndex = 3;
            inputTueStartTimePicker.Value = new DateTime(2023, 12, 7, 0, 0, 0, 0);
            // 
            // inputTueFinishTimePicker
            // 
            inputTueFinishTimePicker.CustomFormat = "HH:mm";
            inputTueFinishTimePicker.Format = DateTimePickerFormat.Custom;
            inputTueFinishTimePicker.Location = new Point(109, 51);
            inputTueFinishTimePicker.Name = "inputTueFinishTimePicker";
            inputTueFinishTimePicker.ShowUpDown = true;
            inputTueFinishTimePicker.Size = new Size(58, 23);
            inputTueFinishTimePicker.TabIndex = 4;
            inputTueFinishTimePicker.Value = new DateTime(2023, 12, 7, 0, 0, 0, 0);
            inputTueFinishTimePicker.ValueChanged += Tue_Calculations;
            // 
            // labelTueStartTime
            // 
            labelTueStartTime.AutoSize = true;
            labelTueStartTime.Location = new Point(6, 28);
            labelTueStartTime.Name = "labelTueStartTime";
            labelTueStartTime.Size = new Size(63, 15);
            labelTueStartTime.TabIndex = 1;
            labelTueStartTime.Text = "Start Time:";
            // 
            // resultTueGrossPay
            // 
            resultTueGrossPay.AutoSize = true;
            resultTueGrossPay.Location = new Point(109, 144);
            resultTueGrossPay.Name = "resultTueGrossPay";
            resultTueGrossPay.Size = new Size(34, 15);
            resultTueGrossPay.TabIndex = 5;
            resultTueGrossPay.Text = "$0.00";
            // 
            // labelTueFinishTime
            // 
            labelTueFinishTime.AutoSize = true;
            labelTueFinishTime.Location = new Point(6, 57);
            labelTueFinishTime.Name = "labelTueFinishTime";
            labelTueFinishTime.Size = new Size(70, 15);
            labelTueFinishTime.TabIndex = 2;
            labelTueFinishTime.Text = "Finish Time:";
            // 
            // labelTueHoursScheduled
            // 
            labelTueHoursScheduled.AutoSize = true;
            labelTueHoursScheduled.Location = new Point(6, 86);
            labelTueHoursScheduled.Name = "labelTueHoursScheduled";
            labelTueHoursScheduled.Size = new Size(103, 15);
            labelTueHoursScheduled.TabIndex = 0;
            labelTueHoursScheduled.Text = "Hours Scheduled: ";
            // 
            // labelTueGrossPay
            // 
            labelTueGrossPay.AutoSize = true;
            labelTueGrossPay.Location = new Point(6, 144);
            labelTueGrossPay.Name = "labelTueGrossPay";
            labelTueGrossPay.Size = new Size(64, 15);
            labelTueGrossPay.TabIndex = 2;
            labelTueGrossPay.Text = "Gross Pay: ";
            // 
            // resultTueBreaks
            // 
            resultTueBreaks.AutoSize = true;
            resultTueBreaks.Location = new Point(115, 115);
            resultTueBreaks.Name = "resultTueBreaks";
            resultTueBreaks.Size = new Size(28, 15);
            resultTueBreaks.TabIndex = 4;
            resultTueBreaks.Text = "0:00";
            // 
            // resultTueHoursScheduled
            // 
            resultTueHoursScheduled.AutoSize = true;
            resultTueHoursScheduled.Location = new Point(115, 86);
            resultTueHoursScheduled.Name = "resultTueHoursScheduled";
            resultTueHoursScheduled.Size = new Size(28, 15);
            resultTueHoursScheduled.TabIndex = 3;
            resultTueHoursScheduled.Text = "0:00";
            // 
            // labelTueBreaks
            // 
            labelTueBreaks.AutoSize = true;
            labelTueBreaks.Location = new Point(6, 115);
            labelTueBreaks.Name = "labelTueBreaks";
            labelTueBreaks.Size = new Size(47, 15);
            labelTueBreaks.TabIndex = 1;
            labelTueBreaks.Text = "Breaks: ";
            // 
            // gbMonInfo
            // 
            gbMonInfo.Controls.Add(inputMonStartTimePicker);
            gbMonInfo.Controls.Add(inputMonFinishTimePicker);
            gbMonInfo.Controls.Add(labelMonStartTime);
            gbMonInfo.Controls.Add(resultMonGrossPay);
            gbMonInfo.Controls.Add(labelMonFinishTime);
            gbMonInfo.Controls.Add(labelMonHoursScheduled);
            gbMonInfo.Controls.Add(labelMonGrossPay);
            gbMonInfo.Controls.Add(resultMonBreaks);
            gbMonInfo.Controls.Add(resultMonHoursScheduled);
            gbMonInfo.Controls.Add(labelMonBreaks);
            gbMonInfo.Location = new Point(12, 12);
            gbMonInfo.Name = "gbMonInfo";
            gbMonInfo.Size = new Size(178, 170);
            gbMonInfo.TabIndex = 8;
            gbMonInfo.TabStop = false;
            gbMonInfo.Text = "Monday";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1305, 277);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            Text = "Coles Pay Calculator";
            payInformationgroupBox1.ResumeLayout(false);
            payInformationgroupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            gbSunInfo.ResumeLayout(false);
            gbSunInfo.PerformLayout();
            gbSatInfo.ResumeLayout(false);
            gbSatInfo.PerformLayout();
            gbFriInfo.ResumeLayout(false);
            gbFriInfo.PerformLayout();
            gbThuInfo.ResumeLayout(false);
            gbThuInfo.PerformLayout();
            gbWedInfo.ResumeLayout(false);
            gbWedInfo.PerformLayout();
            gbTueInfo.ResumeLayout(false);
            gbTueInfo.PerformLayout();
            gbMonInfo.ResumeLayout(false);
            gbMonInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelMonStartTime;
        private Label labelMonFinishTime;
        private DateTimePicker inputMonStartTimePicker;
        private DateTimePicker inputMonFinishTimePicker;
        private Button calculateHoursbutton1;
        private GroupBox payInformationgroupBox1;
        private Label resultMonGrossPay;
        private Label resultMonBreaks;
        private Label resultMonHoursScheduled;
        private Label labelMonGrossPay;
        private Label labelMonBreaks;
        private Label labelMonHoursScheduled;
        private Label resultNetPay;
        private Label labelNetPay;
        private Label resultTaxAmount;
        private Label labelTaxAmount;
        private Panel panel1;
        private GroupBox gbMonInfo;
        private GroupBox gbTueInfo;
        private DateTimePicker inputTueStartTimePicker;
        private DateTimePicker inputTueFinishTimePicker;
        private Label labelTueStartTime;
        private Label resultTueGrossPay;
        private Label labelTueFinishTime;
        private Label labelTueHoursScheduled;
        private Label labelTueGrossPay;
        private Label resultTueBreaks;
        private Label resultTueHoursScheduled;
        private Label labelTueBreaks;
        private GroupBox gbSunInfo;
        private DateTimePicker inputSunStartTimePicker;
        private DateTimePicker inputSunFinishTimePicker;
        private Label labelSunStartTime;
        private Label resultSunGrossPay;
        private Label labelSunFinishTime;
        private Label labelSunHoursScheduled;
        private Label labelSunGrossPay;
        private Label resultSunBreaks;
        private Label resultSunHoursScheduled;
        private Label labelSunBreaks;
        private GroupBox gbSatInfo;
        private DateTimePicker inputSatStartTimePicker;
        private DateTimePicker inputSatFinishTimePicker;
        private Label labelSatStartTime;
        private Label resultSatGrossPay;
        private Label labelSatFinishTime;
        private Label labelSatHoursScheduled;
        private Label labelSatGrossPay;
        private Label resultSatBreaks;
        private Label resultSatHoursScheduled;
        private Label labelSatBreaks;
        private GroupBox gbFriInfo;
        private DateTimePicker inputFriStartTimePicker;
        private DateTimePicker inputFriFinishTimePicker;
        private Label labelFriStartTime;
        private Label resultFriGrossPay;
        private Label labelFriFinishTime;
        private Label labelFriHoursScheduled;
        private Label labelFriGrossPay;
        private Label resultFriBreaks;
        private Label resultFriHoursScheduled;
        private Label labelFriBreaks;
        private GroupBox gbThuInfo;
        private DateTimePicker inputThurStartTimePicker;
        private DateTimePicker inputThurFinishTimePicker;
        private Label labelThurStartTime;
        private Label resultThurGrossPay;
        private Label labelThurFinishTime;
        private Label labelThurHoursScheduled;
        private Label labelThurGrossPay;
        private Label resultThurBreaks;
        private Label resultThurHoursScheduled;
        private Label labelThurBreaks;
        private GroupBox gbWedInfo;
        private DateTimePicker inputWedStartTimePicker;
        private DateTimePicker inputWedFinishTimePicker;
        private Label labelWedStartTime;
        private Label resultWedGrossPay;
        private Label labelWedFinishTime;
        private Label labelWedHoursScheduled;
        private Label labelWedGrossPay;
        private Label resultWedBreaks;
        private Label resultWedHoursScheduled;
        private Label labelWedBreaks;
    }
}