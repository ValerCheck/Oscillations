namespace Oscillations
{
    partial class Voltage
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
            this.voltpan = new System.Windows.Forms.Panel();
            this.turnvoltb = new System.Windows.Forms.Button();
            this.coefZtab = new System.Windows.Forms.TrackBar();
            this.coefVal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.capCol = new System.Windows.Forms.Panel();
            this.indCol = new System.Windows.Forms.Panel();
            this.IndU = new System.Windows.Forms.RadioButton();
            this.CapU = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.coefZtab)).BeginInit();
            this.SuspendLayout();
            // 
            // voltpan
            // 
            this.voltpan.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.voltpan.Location = new System.Drawing.Point(13, 13);
            this.voltpan.Name = "voltpan";
            this.voltpan.Size = new System.Drawing.Size(614, 501);
            this.voltpan.TabIndex = 0;
            this.voltpan.Paint += new System.Windows.Forms.PaintEventHandler(this.voltpan_Paint);
            // 
            // turnvoltb
            // 
            this.turnvoltb.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.turnvoltb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.turnvoltb.Location = new System.Drawing.Point(674, 12);
            this.turnvoltb.Name = "turnvoltb";
            this.turnvoltb.Size = new System.Drawing.Size(108, 34);
            this.turnvoltb.TabIndex = 1;
            this.turnvoltb.Text = "Увімкнути";
            this.turnvoltb.UseVisualStyleBackColor = false;
            this.turnvoltb.Click += new System.EventHandler(this.turnvoltb_Click);
            // 
            // coefZtab
            // 
            this.coefZtab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.coefZtab.Location = new System.Drawing.Point(633, 196);
            this.coefZtab.Maximum = 100;
            this.coefZtab.Minimum = 5;
            this.coefZtab.Name = "coefZtab";
            this.coefZtab.Size = new System.Drawing.Size(171, 56);
            this.coefZtab.TabIndex = 2;
            this.coefZtab.TickFrequency = 10;
            this.coefZtab.Value = 5;
            this.coefZtab.ValueChanged += new System.EventHandler(this.coefZtab_ValueChanged);
            // 
            // coefVal
            // 
            this.coefVal.Location = new System.Drawing.Point(754, 168);
            this.coefVal.Name = "coefVal";
            this.coefVal.ReadOnly = true;
            this.coefVal.Size = new System.Drawing.Size(50, 22);
            this.coefVal.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(671, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Затухання";
            // 
            // capCol
            // 
            this.capCol.Location = new System.Drawing.Point(633, 286);
            this.capCol.Name = "capCol";
            this.capCol.Size = new System.Drawing.Size(33, 19);
            this.capCol.TabIndex = 5;
            // 
            // indCol
            // 
            this.indCol.Location = new System.Drawing.Point(633, 311);
            this.indCol.Name = "indCol";
            this.indCol.Size = new System.Drawing.Size(33, 19);
            this.indCol.TabIndex = 6;
            // 
            // IndU
            // 
            this.IndU.AutoSize = true;
            this.IndU.Location = new System.Drawing.Point(633, 79);
            this.IndU.Name = "IndU";
            this.IndU.Size = new System.Drawing.Size(156, 21);
            this.IndU.TabIndex = 7;
            this.IndU.TabStop = true;
            this.IndU.Text = "Індуктивна напруга\r\n";
            this.IndU.UseVisualStyleBackColor = true;
            this.IndU.CheckedChanged += new System.EventHandler(this.IndU_CheckedChanged);
            // 
            // CapU
            // 
            this.CapU.AutoSize = true;
            this.CapU.Location = new System.Drawing.Point(633, 52);
            this.CapU.Name = "CapU";
            this.CapU.Size = new System.Drawing.Size(137, 21);
            this.CapU.TabIndex = 8;
            this.CapU.TabStop = true;
            this.CapU.Text = "Ємнісна напруга";
            this.CapU.UseVisualStyleBackColor = true;
            this.CapU.CheckedChanged += new System.EventHandler(this.CapU_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(673, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ємнісна напруга";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(673, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Індуктивна напруга";
            // 
            // Voltage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 526);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CapU);
            this.Controls.Add(this.IndU);
            this.Controls.Add(this.indCol);
            this.Controls.Add(this.capCol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.coefVal);
            this.Controls.Add(this.coefZtab);
            this.Controls.Add(this.turnvoltb);
            this.Controls.Add(this.voltpan);
            this.Name = "Voltage";
            this.Text = "Voltage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Voltage_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.coefZtab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel voltpan;
        private System.Windows.Forms.Button turnvoltb;
        private System.Windows.Forms.TrackBar coefZtab;
        private System.Windows.Forms.TextBox coefVal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel capCol;
        private System.Windows.Forms.Panel indCol;
        private System.Windows.Forms.RadioButton IndU;
        private System.Windows.Forms.RadioButton CapU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}