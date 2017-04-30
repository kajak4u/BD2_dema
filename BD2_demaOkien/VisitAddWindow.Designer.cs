﻿using System;
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
            this.DataPanel = new System.Windows.Forms.Panel();
            this.dayScheduler = new BD2_demaOkien.DayScheduler();
            this.ResultPanel = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.CalendarPanel = new System.Windows.Forms.Panel();
            this.dateTimeVisitDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimeVisitTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxDoctor = new System.Windows.Forms.ComboBox();
            this.buttonChooseDoctor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPatient = new System.Windows.Forms.TextBox();
            this.buttonChoosePatient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DataPanel.SuspendLayout();
            this.ResultPanel.SuspendLayout();
            this.CalendarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataPanel
            // 
            this.DataPanel.AutoScroll = true;
            this.DataPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataPanel.Controls.Add(this.dayScheduler);
            this.DataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataPanel.Location = new System.Drawing.Point(0, 105);
            this.DataPanel.Name = "DataPanel";
            this.DataPanel.Size = new System.Drawing.Size(456, 348);
            this.DataPanel.TabIndex = 0;
            // 
            // dayScheduler
            // 
            this.dayScheduler.AllowItemEdit = false;
            this.dayScheduler.AllowNew = false;
            this.dayScheduler.CalendarTimeFormat = WindowsFormsCalendar.CalendarTimeFormat.TwentyFourHour;
            this.dayScheduler.dayBegin = System.TimeSpan.Parse("08:00:00");
            this.dayScheduler.dayEnd = System.TimeSpan.Parse("16:00:00");
            this.dayScheduler.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dayScheduler.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dayScheduler.ItemsBackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dayScheduler.ItemsFont = null;
            this.dayScheduler.ItemsForeColor = System.Drawing.Color.Black;
            this.dayScheduler.Location = new System.Drawing.Point(0, -780);
            this.dayScheduler.Name = "dayScheduler";
            this.dayScheduler.Size = new System.Drawing.Size(435, 1518);
            this.dayScheduler.TabIndex = 24;
            this.dayScheduler.Text = "dayScheduler";
            this.dayScheduler.TimeScale = WindowsFormsCalendar.CalendarTimeScale.FifteenMinutes;
            // 
            // ResultPanel
            // 
            this.ResultPanel.AutoSize = true;
            this.ResultPanel.Controls.Add(this.buttonCancel);
            this.ResultPanel.Controls.Add(this.buttonApply);
            this.ResultPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ResultPanel.Location = new System.Drawing.Point(0, 453);
            this.ResultPanel.Name = "ResultPanel";
            this.ResultPanel.Size = new System.Drawing.Size(456, 35);
            this.ResultPanel.TabIndex = 23;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCancel.Location = new System.Drawing.Point(118, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 30);
            this.buttonCancel.TabIndex = 19;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonApply
            // 
            this.buttonApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonApply.Location = new System.Drawing.Point(12, 2);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(100, 30);
            this.buttonApply.TabIndex = 18;
            this.buttonApply.Text = "Zatwierdź";
            this.buttonApply.UseVisualStyleBackColor = true;
            // 
            // CalendarPanel
            // 
            this.CalendarPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CalendarPanel.Controls.Add(this.dateTimeVisitDate);
            this.CalendarPanel.Controls.Add(this.dateTimeVisitTime);
            this.CalendarPanel.Controls.Add(this.label3);
            this.CalendarPanel.Controls.Add(this.comboBoxDoctor);
            this.CalendarPanel.Controls.Add(this.buttonChooseDoctor);
            this.CalendarPanel.Controls.Add(this.label2);
            this.CalendarPanel.Controls.Add(this.textBoxPatient);
            this.CalendarPanel.Controls.Add(this.buttonChoosePatient);
            this.CalendarPanel.Controls.Add(this.label1);
            this.CalendarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CalendarPanel.Location = new System.Drawing.Point(0, 0);
            this.CalendarPanel.Name = "CalendarPanel";
            this.CalendarPanel.Size = new System.Drawing.Size(456, 105);
            this.CalendarPanel.TabIndex = 25;
            // 
            // dateTimeVisitDate
            // 
            this.dateTimeVisitDate.Checked = false;
            this.dateTimeVisitDate.CustomFormat = "";
            this.dateTimeVisitDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::BD2_demaOkien.Properties.Settings.Default, "chosenDateTime", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dateTimeVisitDate.Location = new System.Drawing.Point(94, 69);
            this.dateTimeVisitDate.Name = "dateTimeVisitDate";
            this.dateTimeVisitDate.Size = new System.Drawing.Size(207, 20);
            this.dateTimeVisitDate.TabIndex = 31;
            this.dateTimeVisitDate.Value = global::BD2_demaOkien.Properties.Settings.Default.chosenDateTime;
            this.dateTimeVisitDate.ValueChanged += new System.EventHandler(this.dateTimeVisitDate_ValueChanged);
            // 
            // dateTimeVisitTime
            // 
            this.dateTimeVisitTime.CustomFormat = "HH:mm";
            this.dateTimeVisitTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::BD2_demaOkien.Properties.Settings.Default, "chosenDateTime", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dateTimeVisitTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeVisitTime.Location = new System.Drawing.Point(307, 69);
            this.dateTimeVisitTime.Name = "dateTimeVisitTime";
            this.dateTimeVisitTime.ShowUpDown = true;
            this.dateTimeVisitTime.Size = new System.Drawing.Size(60, 20);
            this.dateTimeVisitTime.TabIndex = 30;
            this.dateTimeVisitTime.Value = global::BD2_demaOkien.Properties.Settings.Default.chosenDateTime;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(13, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Termin           ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // comboBoxDoctor
            // 
            this.comboBoxDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxDoctor.FormattingEnabled = true;
            this.comboBoxDoctor.Location = new System.Drawing.Point(94, 42);
            this.comboBoxDoctor.Name = "comboBoxDoctor";
            this.comboBoxDoctor.Size = new System.Drawing.Size(322, 21);
            this.comboBoxDoctor.TabIndex = 27;
            // 
            // buttonChooseDoctor
            // 
            this.buttonChooseDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChooseDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonChooseDoctor.Location = new System.Drawing.Point(414, 41);
            this.buttonChooseDoctor.Name = "buttonChooseDoctor";
            this.buttonChooseDoctor.Size = new System.Drawing.Size(25, 23);
            this.buttonChooseDoctor.TabIndex = 28;
            this.buttonChooseDoctor.Text = "...";
            this.buttonChooseDoctor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonChooseDoctor.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Lekarz           ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // textBoxPatient
            // 
            this.textBoxPatient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPatient.Location = new System.Drawing.Point(94, 17);
            this.textBoxPatient.Name = "textBoxPatient";
            this.textBoxPatient.Size = new System.Drawing.Size(322, 20);
            this.textBoxPatient.TabIndex = 24;
            // 
            // buttonChoosePatient
            // 
            this.buttonChoosePatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChoosePatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonChoosePatient.Location = new System.Drawing.Point(414, 16);
            this.buttonChoosePatient.Name = "buttonChoosePatient";
            this.buttonChoosePatient.Size = new System.Drawing.Size(25, 22);
            this.buttonChoosePatient.TabIndex = 25;
            this.buttonChoosePatient.Text = "...";
            this.buttonChoosePatient.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonChoosePatient.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Pacjent           ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // VisitAddWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 488);
            this.Controls.Add(this.DataPanel);
            this.Controls.Add(this.CalendarPanel);
            this.Controls.Add(this.ResultPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VisitAddWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nowa wizyta";
            this.DataPanel.ResumeLayout(false);
            this.ResultPanel.ResumeLayout(false);
            this.CalendarPanel.ResumeLayout(false);
            this.CalendarPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel DataPanel;
        private Panel ResultPanel;
        private Button buttonCancel;
        private Button buttonApply;
        private DayScheduler dayScheduler;
        private Panel CalendarPanel;
        private DateTimePicker dateTimeVisitDate;
        private DateTimePicker dateTimeVisitTime;
        private Label label3;
        private ComboBox comboBoxDoctor;
        private Button buttonChooseDoctor;
        private Label label2;
        private TextBox textBoxPatient;
        private Button buttonChoosePatient;
        private Label label1;
    }
}