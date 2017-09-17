namespace BD2_demaOkien
{
    partial class ExaminationsDictionariesDetails
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.ResultPanel = new System.Windows.Forms.Panel();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonApply = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.ResultPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.radioButton2);
			this.panel1.Controls.Add(this.radioButton1);
			this.panel1.Controls.Add(this.textBox2);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(507, 158);
			this.panel1.TabIndex = 36;
			// 
			// radioButton2
			// 
			this.radioButton2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.radioButton2.FlatAppearance.BorderSize = 2;
			this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
			this.radioButton2.Location = new System.Drawing.Point(5, 76);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(165, 24);
			this.radioButton2.TabIndex = 4;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Badanie laboratoryjne ";
			this.radioButton2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.radioButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.radioButton2.UseVisualStyleBackColor = true;
			radioButton2.IsAccessible = false;
			// 
			// radioButton1
			// 
			this.radioButton1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.radioButton1.FlatAppearance.BorderSize = 2;
			this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
			this.radioButton1.Location = new System.Drawing.Point(5, 53);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(165, 24);
			this.radioButton1.TabIndex = 3;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Badanie fizykalne        ";
			this.radioButton1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.radioButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.radioButton1.UseVisualStyleBackColor = true;
			radioButton1.IsAccessible = false;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(157, 7);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(90, 20);
			this.textBox2.TabIndex = 1;
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.Location = new System.Drawing.Point(157, 30);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(336, 20);
			this.textBox1.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(8, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(162, 20);
			this.label1.TabIndex = 57;
			this.label1.Text = "Nazwa badania               ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.Location = new System.Drawing.Point(8, 7);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(162, 20);
			this.label3.TabIndex = 31;
			this.label3.Text = "Kod badania                  ";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// ResultPanel
			// 
			this.ResultPanel.AutoSize = true;
			this.ResultPanel.Controls.Add(this.buttonCancel);
			this.ResultPanel.Controls.Add(this.buttonApply);
			this.ResultPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.ResultPanel.Location = new System.Drawing.Point(0, 123);
			this.ResultPanel.Name = "ResultPanel";
			this.ResultPanel.Size = new System.Drawing.Size(507, 35);
			this.ResultPanel.TabIndex = 37;
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonCancel.Location = new System.Drawing.Point(111, 2);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(100, 30);
			this.buttonCancel.TabIndex = 6;
			this.buttonCancel.Text = "Porzuć";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// buttonApply
			// 
			this.buttonApply.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonApply.Location = new System.Drawing.Point(5, 2);
			this.buttonApply.Name = "buttonApply";
			this.buttonApply.Size = new System.Drawing.Size(100, 30);
			this.buttonApply.TabIndex = 5;
			this.buttonApply.Text = "Zatwierdź";
			this.buttonApply.UseVisualStyleBackColor = true;
			this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
			// 
			// ExaminationsDictionariesDetails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(507, 158);
			this.Controls.Add(this.ResultPanel);
			this.Controls.Add(this.panel1);
			this.Name = "ExaminationsDictionariesDetails";
			this.Text = "Dodaj badanie";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResultPanel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel ResultPanel;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox2;
    }
}