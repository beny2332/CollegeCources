namespace CollegeCources.Views
{
    partial class CourseCreationForm
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
            label_CourseCreate = new Label();
            label_StartDate = new Label();
            dateTimePicker1 = new DateTimePicker();
            label_WeekdaysSelection = new Label();
            textBox_DaysSelection = new TextBox();
            textBox_SetPrice = new TextBox();
            label_SetPrice = new Label();
            button_CreateCourse = new Button();
            label_StartTime = new Label();
            dateTimePicker_startTime = new DateTimePicker();
            dateTimePicker_endTime = new DateTimePicker();
            label_EndTime = new Label();
            label_CourseDetails = new Label();
            SuspendLayout();
            // 
            // label_CourseCreate
            // 
            label_CourseCreate.AutoSize = true;
            label_CourseCreate.Location = new Point(343, 27);
            label_CourseCreate.Name = "label_CourseCreate";
            label_CourseCreate.Size = new Size(110, 20);
            label_CourseCreate.TabIndex = 0;
            label_CourseCreate.Text = "CourseCreation";
            // 
            // label_StartDate
            // 
            label_StartDate.AutoSize = true;
            label_StartDate.Location = new Point(52, 82);
            label_StartDate.Name = "label_StartDate";
            label_StartDate.Size = new Size(141, 20);
            label_StartDate.TabIndex = 1;
            label_StartDate.Text = "Choose a start date ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(52, 114);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // label_WeekdaysSelection
            // 
            label_WeekdaysSelection.AutoSize = true;
            label_WeekdaysSelection.Location = new Point(52, 155);
            label_WeekdaysSelection.Name = "label_WeekdaysSelection";
            label_WeekdaysSelection.Size = new Size(133, 20);
            label_WeekdaysSelection.TabIndex = 3;
            label_WeekdaysSelection.Text = "Enter days of week";
            // 
            // textBox_DaysSelection
            // 
            textBox_DaysSelection.Location = new Point(55, 190);
            textBox_DaysSelection.Name = "textBox_DaysSelection";
            textBox_DaysSelection.Size = new Size(150, 27);
            textBox_DaysSelection.TabIndex = 4;
            textBox_DaysSelection.Text = "Example: sun,mon,fri.";
            // 
            // textBox_SetPrice
            // 
            textBox_SetPrice.Location = new Point(55, 261);
            textBox_SetPrice.Name = "textBox_SetPrice";
            textBox_SetPrice.Size = new Size(125, 27);
            textBox_SetPrice.TabIndex = 5;
            // 
            // label_SetPrice
            // 
            label_SetPrice.AutoSize = true;
            label_SetPrice.Location = new Point(55, 229);
            label_SetPrice.Name = "label_SetPrice";
            label_SetPrice.Size = new Size(187, 20);
            label_SetPrice.TabIndex = 6;
            label_SetPrice.Text = "Set the price for the course";
            // 
            // button_CreateCourse
            // 
            button_CreateCourse.Location = new Point(322, 346);
            button_CreateCourse.Name = "button_CreateCourse";
            button_CreateCourse.Size = new Size(144, 29);
            button_CreateCourse.TabIndex = 7;
            button_CreateCourse.Text = "Create course";
            button_CreateCourse.UseVisualStyleBackColor = true;
            // 
            // label_StartTime
            // 
            label_StartTime.AutoSize = true;
            label_StartTime.Location = new Point(355, 165);
            label_StartTime.Name = "label_StartTime";
            label_StartTime.Size = new Size(74, 20);
            label_StartTime.TabIndex = 8;
            label_StartTime.Text = "Start time";
            // 
            // dateTimePicker_startTime
            // 
            dateTimePicker_startTime.CustomFormat = "HH:mm";
            dateTimePicker_startTime.Format = DateTimePickerFormat.Custom;
            dateTimePicker_startTime.Location = new Point(355, 199);
            dateTimePicker_startTime.Name = "dateTimePicker_startTime";
            dateTimePicker_startTime.Size = new Size(83, 27);
            dateTimePicker_startTime.TabIndex = 9;
            // 
            // dateTimePicker_endTime
            // 
            dateTimePicker_endTime.CustomFormat = "HH:mm";
            dateTimePicker_endTime.Format = DateTimePickerFormat.Custom;
            dateTimePicker_endTime.Location = new Point(355, 259);
            dateTimePicker_endTime.Name = "dateTimePicker_endTime";
            dateTimePicker_endTime.Size = new Size(83, 27);
            dateTimePicker_endTime.TabIndex = 10;
            // 
            // label_EndTime
            // 
            label_EndTime.AutoSize = true;
            label_EndTime.Location = new Point(355, 229);
            label_EndTime.Name = "label_EndTime";
            label_EndTime.Size = new Size(68, 20);
            label_EndTime.TabIndex = 11;
            label_EndTime.Text = "End time";
            // 
            // label_CourseDetails
            // 
            label_CourseDetails.AutoSize = true;
            label_CourseDetails.Location = new Point(581, 117);
            label_CourseDetails.Name = "label_CourseDetails";
            label_CourseDetails.Size = new Size(104, 20);
            label_CourseDetails.TabIndex = 12;
            label_CourseDetails.Text = "Course Details";
            // 
            // CourseCreationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label_CourseDetails);
            Controls.Add(label_EndTime);
            Controls.Add(dateTimePicker_endTime);
            Controls.Add(dateTimePicker_startTime);
            Controls.Add(label_StartTime);
            Controls.Add(button_CreateCourse);
            Controls.Add(label_SetPrice);
            Controls.Add(textBox_SetPrice);
            Controls.Add(textBox_DaysSelection);
            Controls.Add(label_WeekdaysSelection);
            Controls.Add(dateTimePicker1);
            Controls.Add(label_StartDate);
            Controls.Add(label_CourseCreate);
            Name = "CourseCreationForm";
            Text = "CourseCreation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_CourseCreate;
        private Label label_StartDate;
        private DateTimePicker dateTimePicker1;
        private Label label_WeekdaysSelection;
        private TextBox textBox_DaysSelection;
        private TextBox textBox_SetPrice;
        private Label label_SetPrice;
        private Button button_CreateCourse;
        private Label label_StartTime;
        private DateTimePicker dateTimePicker_startTime;
        private DateTimePicker dateTimePicker_endTime;
        private Label label_EndTime;
        private Label label_CourseDetails;
    }
}