namespace Oscillations
{
    partial class Form1
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
            this.резонансніВлеичиеиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.струмToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вільніКоливанняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зарядToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.напругаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.резонансніВлеичиеиToolStripMenuItem,
            this.проПрограмуToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(436, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // резонансніВлеичиеиToolStripMenuItem
            // 
            this.резонансніВлеичиеиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.струмToolStripMenuItem,
            this.вільніКоливанняToolStripMenuItem});
            this.резонансніВлеичиеиToolStripMenuItem.Name = "резонансніВлеичиеиToolStripMenuItem";
            this.резонансніВлеичиеиToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.резонансніВлеичиеиToolStripMenuItem.Text = "Меню";
            // 
            // струмToolStripMenuItem
            // 
            this.струмToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.напругаToolStripMenuItem});
            this.струмToolStripMenuItem.Name = "струмToolStripMenuItem";
            this.струмToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.струмToolStripMenuItem.Text = "Вимушені коливання";
            // 
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.проПрограмуToolStripMenuItem.Text = "Про програму";
            this.проПрограмуToolStripMenuItem.Click += new System.EventHandler(this.проПрограмуToolStripMenuItem_Click);
            // 
            // вільніКоливанняToolStripMenuItem
            // 
            this.вільніКоливанняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.зарядToolStripMenuItem1});
            this.вільніКоливанняToolStripMenuItem.Name = "вільніКоливанняToolStripMenuItem";
            this.вільніКоливанняToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.вільніКоливанняToolStripMenuItem.Text = "Вільні коливання";
            // 
            // зарядToolStripMenuItem1
            // 
            this.зарядToolStripMenuItem1.Name = "зарядToolStripMenuItem1";
            this.зарядToolStripMenuItem1.Size = new System.Drawing.Size(152, 24);
            this.зарядToolStripMenuItem1.Text = "Заряд";
            this.зарядToolStripMenuItem1.Click += new System.EventHandler(this.зарядToolStripMenuItem1_Click);
            // 
            // напругаToolStripMenuItem
            // 
            this.напругаToolStripMenuItem.Name = "напругаToolStripMenuItem";
            this.напругаToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.напругаToolStripMenuItem.Text = "Напруга";
            this.напругаToolStripMenuItem.Click += new System.EventHandler(this.напругаToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 236);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Електромагнітні коливання";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem резонансніВлеичиеиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem струмToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem напругаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вільніКоливанняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зарядToolStripMenuItem1;
    }
}

