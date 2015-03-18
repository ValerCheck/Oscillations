namespace Oscillations
{
    partial class Charge
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
            this.charpan = new System.Windows.Forms.Panel();
            this.chargeb = new System.Windows.Forms.Button();
            this.charbar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.chartb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.charbar)).BeginInit();
            this.SuspendLayout();
            // 
            // charpan
            // 
            this.charpan.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.charpan.Location = new System.Drawing.Point(13, 13);
            this.charpan.Name = "charpan";
            this.charpan.Size = new System.Drawing.Size(484, 402);
            this.charpan.TabIndex = 0;
            this.charpan.Paint += new System.Windows.Forms.PaintEventHandler(this.charpan_Paint);
            // 
            // chargeb
            // 
            this.chargeb.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.chargeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chargeb.Location = new System.Drawing.Point(521, 13);
            this.chargeb.Name = "chargeb";
            this.chargeb.Size = new System.Drawing.Size(128, 40);
            this.chargeb.TabIndex = 1;
            this.chargeb.Text = "Увімкнути";
            this.chargeb.UseVisualStyleBackColor = false;
            this.chargeb.Click += new System.EventHandler(this.chargeb_Click);
            // 
            // charbar
            // 
            this.charbar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.charbar.Location = new System.Drawing.Point(521, 97);
            this.charbar.Maximum = 40;
            this.charbar.Minimum = 2;
            this.charbar.Name = "charbar";
            this.charbar.Size = new System.Drawing.Size(128, 56);
            this.charbar.TabIndex = 2;
            this.charbar.TickFrequency = 7;
            this.charbar.Value = 2;
            this.charbar.ValueChanged += new System.EventHandler(this.charbar_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(518, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Заряд qm";
            // 
            // chartb
            // 
            this.chartb.Location = new System.Drawing.Point(600, 73);
            this.chartb.Name = "chartb";
            this.chartb.ReadOnly = true;
            this.chartb.Size = new System.Drawing.Size(48, 22);
            this.chartb.TabIndex = 4;
            // 
            // Charge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 427);
            this.Controls.Add(this.chartb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.charbar);
            this.Controls.Add(this.chargeb);
            this.Controls.Add(this.charpan);
            this.Name = "Charge";
            this.Text = "Коливання заряду";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Charge_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.charbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel charpan;
        private System.Windows.Forms.Button chargeb;
        private System.Windows.Forms.TrackBar charbar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox chartb;
    }
}