namespace BD2_demaOkien
{
    partial class MainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rejestratorkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacjenciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wizytyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wynikibadańToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lekarzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wizytyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.przeglądMoichWizytToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.badaniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laborantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.badaniaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kierLabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.badaniaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.użytkownicyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.słownikBadańToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rejestratorkaToolStripMenuItem,
            this.lekarzToolStripMenuItem,
            this.laborantToolStripMenuItem,
            this.kierLabToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(701, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rejestratorkaToolStripMenuItem
            // 
            this.rejestratorkaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacjenciToolStripMenuItem,
            this.wizytyToolStripMenuItem,
            this.wynikibadańToolStripMenuItem});
            this.rejestratorkaToolStripMenuItem.Name = "rejestratorkaToolStripMenuItem";
            this.rejestratorkaToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.rejestratorkaToolStripMenuItem.Text = "&Rejestratorka";
            this.rejestratorkaToolStripMenuItem.Visible = false;
            // 
            // pacjenciToolStripMenuItem
            // 
            this.pacjenciToolStripMenuItem.Name = "pacjenciToolStripMenuItem";
            this.pacjenciToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.pacjenciToolStripMenuItem.Text = "&Pacjenci";
            this.pacjenciToolStripMenuItem.Click += new System.EventHandler(this.pacjenciToolStripMenuItem_Click);
            // 
            // wizytyToolStripMenuItem
            // 
            this.wizytyToolStripMenuItem.Enabled = false;
            this.wizytyToolStripMenuItem.Name = "wizytyToolStripMenuItem";
            this.wizytyToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.wizytyToolStripMenuItem.Text = "&Wizyty";
            this.wizytyToolStripMenuItem.Click += new System.EventHandler(this.wizytyToolStripMenuItem_Click);
            // 
            // wynikibadańToolStripMenuItem
            // 
            this.wynikibadańToolStripMenuItem.Name = "wynikibadańToolStripMenuItem";
            this.wynikibadańToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.wynikibadańToolStripMenuItem.Text = "Wyniki &badań";
            this.wynikibadańToolStripMenuItem.Click += new System.EventHandler(this.badaniaToolStripMenuItem_Click);
            // 
            // lekarzToolStripMenuItem
            // 
            this.lekarzToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wizytyToolStripMenuItem1,
            this.przeglądMoichWizytToolStripMenuItem,
            this.badaniaToolStripMenuItem});
            this.lekarzToolStripMenuItem.Name = "lekarzToolStripMenuItem";
            this.lekarzToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.lekarzToolStripMenuItem.Text = "&Lekarz";
            this.lekarzToolStripMenuItem.Visible = false;
            // 
            // wizytyToolStripMenuItem1
            // 
            this.wizytyToolStripMenuItem1.Name = "wizytyToolStripMenuItem1";
            this.wizytyToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.wizytyToolStripMenuItem1.Text = "&Wizyty";
            this.wizytyToolStripMenuItem1.Click += new System.EventHandler(this.wizytyToolStripMenuItem_Click);
            // 
            // przeglądMoichWizytToolStripMenuItem
            // 
            this.przeglądMoichWizytToolStripMenuItem.Name = "przeglądMoichWizytToolStripMenuItem";
            this.przeglądMoichWizytToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.przeglądMoichWizytToolStripMenuItem.Text = "&Przegląd moich wizyt";
            this.przeglądMoichWizytToolStripMenuItem.Click += new System.EventHandler(this.przeglądMoichWizytToolStripMenuItem_Click);
            // 
            // badaniaToolStripMenuItem
            // 
            this.badaniaToolStripMenuItem.Name = "badaniaToolStripMenuItem";
            this.badaniaToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.badaniaToolStripMenuItem.Text = "&Badania";
            this.badaniaToolStripMenuItem.Click += new System.EventHandler(this.badaniaToolStripMenuItem_Click);
            // 
            // laborantToolStripMenuItem
            // 
            this.laborantToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.badaniaToolStripMenuItem1});
            this.laborantToolStripMenuItem.Name = "laborantToolStripMenuItem";
            this.laborantToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.laborantToolStripMenuItem.Text = "&Pracownik Lab";
            this.laborantToolStripMenuItem.Visible = false;
            // 
            // badaniaToolStripMenuItem1
            // 
            this.badaniaToolStripMenuItem1.Name = "badaniaToolStripMenuItem1";
            this.badaniaToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.badaniaToolStripMenuItem1.Text = "&Badania";
            this.badaniaToolStripMenuItem1.Click += new System.EventHandler(this.badaniaToolStripMenuItem_Click);
            // 
            // kierLabToolStripMenuItem
            // 
            this.kierLabToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.badaniaToolStripMenuItem2});
            this.kierLabToolStripMenuItem.Name = "kierLabToolStripMenuItem";
            this.kierLabToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.kierLabToolStripMenuItem.Text = "&Kier Lab";
            this.kierLabToolStripMenuItem.Visible = false;
            // 
            // badaniaToolStripMenuItem2
            // 
            this.badaniaToolStripMenuItem2.Name = "badaniaToolStripMenuItem2";
            this.badaniaToolStripMenuItem2.Size = new System.Drawing.Size(116, 22);
            this.badaniaToolStripMenuItem2.Text = "&Badania";
            this.badaniaToolStripMenuItem2.Click += new System.EventHandler(this.badaniaToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.użytkownicyToolStripMenuItem,
            this.słownikBadańToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "&Admin";
            this.adminToolStripMenuItem.Visible = false;
            // 
            // użytkownicyToolStripMenuItem
            // 
            this.użytkownicyToolStripMenuItem.Name = "użytkownicyToolStripMenuItem";
            this.użytkownicyToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.użytkownicyToolStripMenuItem.Text = "&Użytkownicy";
            // 
            // słownikBadańToolStripMenuItem
            // 
            this.słownikBadańToolStripMenuItem.Name = "słownikBadańToolStripMenuItem";
            this.słownikBadańToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.słownikBadańToolStripMenuItem.Text = "&Słownik badań";
            this.słownikBadańToolStripMenuItem.Click += new System.EventHandler(this.słownikBadańToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 498);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rejestratorkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacjenciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wizytyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wynikibadańToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lekarzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wizytyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem przeglądMoichWizytToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem badaniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laborantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem badaniaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kierLabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem badaniaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem użytkownicyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem słownikBadańToolStripMenuItem;
    }
}