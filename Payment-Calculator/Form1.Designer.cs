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
            startTimeLabel = new Label();
            finishTimeLabel = new Label();
            startdateTimePicker1 = new DateTimePicker();
            finishTimePicker2 = new DateTimePicker();
            calculateHoursbutton1 = new Button();
            payInformationgroupBox1 = new GroupBox();
            hoursWorkedlabel1 = new Label();
            breakslabel1 = new Label();
            grossPaylabel1 = new Label();
            hoursWorkedlabel2 = new Label();
            breakslabel2 = new Label();
            grossPaylabel2 = new Label();
            payInformationgroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.Location = new Point(27, 60);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new Size(60, 15);
            startTimeLabel.TabIndex = 1;
            startTimeLabel.Text = "Start Time";
            // 
            // finishTimeLabel
            // 
            finishTimeLabel.AutoSize = true;
            finishTimeLabel.Location = new Point(20, 89);
            finishTimeLabel.Name = "finishTimeLabel";
            finishTimeLabel.Size = new Size(67, 15);
            finishTimeLabel.TabIndex = 2;
            finishTimeLabel.Text = "Finish Time";
            // 
            // startdateTimePicker1
            // 
            startdateTimePicker1.CustomFormat = "HH:mm";
            startdateTimePicker1.Format = DateTimePickerFormat.Custom;
            startdateTimePicker1.Location = new Point(93, 54);
            startdateTimePicker1.Name = "startdateTimePicker1";
            startdateTimePicker1.Size = new Size(200, 23);
            startdateTimePicker1.TabIndex = 4;
            // 
            // finishTimePicker2
            // 
            finishTimePicker2.CustomFormat = "HH:mm";
            finishTimePicker2.Format = DateTimePickerFormat.Custom;
            finishTimePicker2.Location = new Point(93, 83);
            finishTimePicker2.Name = "finishTimePicker2";
            finishTimePicker2.Size = new Size(200, 23);
            finishTimePicker2.TabIndex = 5;
            // 
            // calculateHoursbutton1
            // 
            calculateHoursbutton1.Location = new Point(135, 112);
            calculateHoursbutton1.Name = "calculateHoursbutton1";
            calculateHoursbutton1.Size = new Size(101, 23);
            calculateHoursbutton1.TabIndex = 6;
            calculateHoursbutton1.Text = "Calculate Hours";
            calculateHoursbutton1.UseVisualStyleBackColor = true;
            // 
            // payInformationgroupBox1
            // 
            payInformationgroupBox1.Controls.Add(grossPaylabel2);
            payInformationgroupBox1.Controls.Add(breakslabel2);
            payInformationgroupBox1.Controls.Add(hoursWorkedlabel2);
            payInformationgroupBox1.Controls.Add(grossPaylabel1);
            payInformationgroupBox1.Controls.Add(breakslabel1);
            payInformationgroupBox1.Controls.Add(hoursWorkedlabel1);
            payInformationgroupBox1.Location = new Point(93, 161);
            payInformationgroupBox1.Name = "payInformationgroupBox1";
            payInformationgroupBox1.Size = new Size(200, 106);
            payInformationgroupBox1.TabIndex = 7;
            payInformationgroupBox1.TabStop = false;
            payInformationgroupBox1.Text = "Pay Information";
            payInformationgroupBox1.Enter += groupBox1_Enter;
            // 
            // hoursWorkedlabel1
            // 
            hoursWorkedlabel1.AutoSize = true;
            hoursWorkedlabel1.Location = new Point(6, 19);
            hoursWorkedlabel1.Name = "hoursWorkedlabel1";
            hoursWorkedlabel1.Size = new Size(89, 15);
            hoursWorkedlabel1.TabIndex = 0;
            hoursWorkedlabel1.Text = "Hours Worked: ";
            // 
            // breakslabel1
            // 
            breakslabel1.AutoSize = true;
            breakslabel1.Location = new Point(6, 43);
            breakslabel1.Name = "breakslabel1";
            breakslabel1.Size = new Size(47, 15);
            breakslabel1.TabIndex = 1;
            breakslabel1.Text = "Breaks: ";
            // 
            // grossPaylabel1
            // 
            grossPaylabel1.AutoSize = true;
            grossPaylabel1.Location = new Point(6, 68);
            grossPaylabel1.Name = "grossPaylabel1";
            grossPaylabel1.Size = new Size(64, 15);
            grossPaylabel1.TabIndex = 2;
            grossPaylabel1.Text = "Gross Pay: ";
            // 
            // hoursWorkedlabel2
            // 
            hoursWorkedlabel2.AutoSize = true;
            hoursWorkedlabel2.Location = new Point(101, 19);
            hoursWorkedlabel2.Name = "hoursWorkedlabel2";
            hoursWorkedlabel2.Size = new Size(28, 15);
            hoursWorkedlabel2.TabIndex = 3;
            hoursWorkedlabel2.Text = "0:00";
            // 
            // breakslabel2
            // 
            breakslabel2.AutoSize = true;
            breakslabel2.Location = new Point(101, 43);
            breakslabel2.Name = "breakslabel2";
            breakslabel2.Size = new Size(28, 15);
            breakslabel2.TabIndex = 4;
            breakslabel2.Text = "0:00";
            // 
            // grossPaylabel2
            // 
            grossPaylabel2.AutoSize = true;
            grossPaylabel2.Location = new Point(101, 68);
            grossPaylabel2.Name = "grossPaylabel2";
            grossPaylabel2.Size = new Size(34, 15);
            grossPaylabel2.TabIndex = 5;
            grossPaylabel2.Text = "$0.00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 456);
            Controls.Add(payInformationgroupBox1);
            Controls.Add(calculateHoursbutton1);
            Controls.Add(finishTimePicker2);
            Controls.Add(startdateTimePicker1);
            Controls.Add(finishTimeLabel);
            Controls.Add(startTimeLabel);
            Name = "Form1";
            Text = "Form1";
            payInformationgroupBox1.ResumeLayout(false);
            payInformationgroupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label startTimeLabel;
        private Label finishTimeLabel;
        private DateTimePicker startdateTimePicker1;
        private DateTimePicker finishTimePicker2;
        private Button calculateHoursbutton1;
        private GroupBox payInformationgroupBox1;
        private Label grossPaylabel2;
        private Label breakslabel2;
        private Label hoursWorkedlabel2;
        private Label grossPaylabel1;
        private Label breakslabel1;
        private Label hoursWorkedlabel1;
    }
}