using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsCalendar;

namespace BD2_demaOkien
{
    partial class VisitAddWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.calendar1 = new DayScheduler();// WindowsFormsCalendar.Calendar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Pacjent           ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(93, 9);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(326, 20);
            this.textBoxName.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(417, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 22);
            this.button1.TabIndex = 15;
            this.button1.Text = "...";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Lekarz           ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(93, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(326, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(417, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "...";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Termin           ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // calendar1
            // 
            this.calendar1.AllowItemEdit = false;
            this.calendar1.AllowNew = false;
            this.calendar1.CalendarTimeFormat = WindowsFormsCalendar.CalendarTimeFormat.TwentyFourHour;
            this.calendar1.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calendar1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.calendar1.ItemsBackgroundColor = System.Drawing.Color.RoyalBlue;
            this.calendar1.ItemsFont = null;
            this.calendar1.ItemsForeColor = System.Drawing.Color.Black;
            this.calendar1.Location = new System.Drawing.Point(0, -780);
            this.calendar1.Name = "calendar1";
            this.calendar1.Size = new System.Drawing.Size(439, 1518);
            this.calendar1.TabIndex = 24;
            this.calendar1.Text = "calendar1";
            this.calendar1.TimeScale = WindowsFormsCalendar.CalendarTimeScale.FifteenMinutes;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.calendar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 363);
            this.panel1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "HH:mm";
            this.dateTimePicker2.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::BD2_demaOkien.Properties.Settings.Default, "chosenDateTime", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(306, 61);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(60, 20);
            this.dateTimePicker2.TabIndex = 21;
            this.dateTimePicker2.Value = global::BD2_demaOkien.Properties.Settings.Default.chosenDateTime;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Checked = false;
            this.dateTimePicker3.CustomFormat = "";
            this.dateTimePicker3.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::BD2_demaOkien.Properties.Settings.Default, "chosenDateTime", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dateTimePicker3.Location = new System.Drawing.Point(93, 61);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(207, 20);
            this.dateTimePicker3.TabIndex = 22;
            this.dateTimePicker3.Value = global::BD2_demaOkien.Properties.Settings.Default.chosenDateTime;
            this.dateTimePicker3.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // VisitAddWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 453);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VisitAddWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nowa wizyta";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private WindowsFormsCalendar.Calendar calendar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
    }
}