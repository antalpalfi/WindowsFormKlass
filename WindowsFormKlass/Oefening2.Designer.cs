namespace WindowsFormKlass
{
    partial class Oefening2
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
            this.lbVolume = new System.Windows.Forms.Label();
            this.btnVolPlus = new System.Windows.Forms.Button();
            this.btnVolMin = new System.Windows.Forms.Button();
            this.lbKanaal = new System.Windows.Forms.Label();
            this.btnKanPlus = new System.Windows.Forms.Button();
            this.btnKanMin = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbKanaalVeranderen = new System.Windows.Forms.Label();
            this.btnKanalKiez = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbVolume
            // 
            this.lbVolume.AutoSize = true;
            this.lbVolume.Location = new System.Drawing.Point(12, 9);
            this.lbVolume.Name = "lbVolume";
            this.lbVolume.Size = new System.Drawing.Size(42, 13);
            this.lbVolume.TabIndex = 0;
            this.lbVolume.Text = "Volume";
            // 
            // btnVolPlus
            // 
            this.btnVolPlus.Location = new System.Drawing.Point(12, 29);
            this.btnVolPlus.Name = "btnVolPlus";
            this.btnVolPlus.Size = new System.Drawing.Size(75, 23);
            this.btnVolPlus.TabIndex = 1;
            this.btnVolPlus.Text = "+";
            this.btnVolPlus.UseVisualStyleBackColor = true;
            this.btnVolPlus.Click += new System.EventHandler(this.btnVolPlus_Click);
            // 
            // btnVolMin
            // 
            this.btnVolMin.Location = new System.Drawing.Point(12, 58);
            this.btnVolMin.Name = "btnVolMin";
            this.btnVolMin.Size = new System.Drawing.Size(75, 23);
            this.btnVolMin.TabIndex = 2;
            this.btnVolMin.Text = "-";
            this.btnVolMin.UseVisualStyleBackColor = true;
            this.btnVolMin.Click += new System.EventHandler(this.btnVolMin_Click);
            // 
            // lbKanaal
            // 
            this.lbKanaal.AutoSize = true;
            this.lbKanaal.Location = new System.Drawing.Point(105, 9);
            this.lbKanaal.Name = "lbKanaal";
            this.lbKanaal.Size = new System.Drawing.Size(40, 13);
            this.lbKanaal.TabIndex = 3;
            this.lbKanaal.Text = "Kanaal";
            // 
            // btnKanPlus
            // 
            this.btnKanPlus.Location = new System.Drawing.Point(108, 29);
            this.btnKanPlus.Name = "btnKanPlus";
            this.btnKanPlus.Size = new System.Drawing.Size(75, 23);
            this.btnKanPlus.TabIndex = 4;
            this.btnKanPlus.Text = "+";
            this.btnKanPlus.UseVisualStyleBackColor = true;
            this.btnKanPlus.Click += new System.EventHandler(this.btnKanPlus_Click);
            // 
            // btnKanMin
            // 
            this.btnKanMin.Location = new System.Drawing.Point(108, 57);
            this.btnKanMin.Name = "btnKanMin";
            this.btnKanMin.Size = new System.Drawing.Size(75, 23);
            this.btnKanMin.TabIndex = 5;
            this.btnKanMin.Text = "-";
            this.btnKanMin.UseVisualStyleBackColor = true;
            this.btnKanMin.Click += new System.EventHandler(this.btnKanMin_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // lbKanaalVeranderen
            // 
            this.lbKanaalVeranderen.AutoSize = true;
            this.lbKanaalVeranderen.Location = new System.Drawing.Point(12, 81);
            this.lbKanaalVeranderen.Name = "lbKanaalVeranderen";
            this.lbKanaalVeranderen.Size = new System.Drawing.Size(83, 13);
            this.lbKanaalVeranderen.TabIndex = 7;
            this.lbKanaalVeranderen.Text = "Kiez een kanaal";
            // 
            // btnKanalKiez
            // 
            this.btnKanalKiez.Location = new System.Drawing.Point(118, 97);
            this.btnKanalKiez.Name = "btnKanalKiez";
            this.btnKanalKiez.Size = new System.Drawing.Size(75, 23);
            this.btnKanalKiez.TabIndex = 8;
            this.btnKanalKiez.Text = "Druk";
            this.btnKanalKiez.UseVisualStyleBackColor = true;
            this.btnKanalKiez.Click += new System.EventHandler(this.button1_Click);
            // 
            // Oefening2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 132);
            this.Controls.Add(this.btnKanalKiez);
            this.Controls.Add(this.lbKanaalVeranderen);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnKanMin);
            this.Controls.Add(this.btnKanPlus);
            this.Controls.Add(this.lbKanaal);
            this.Controls.Add(this.btnVolMin);
            this.Controls.Add(this.btnVolPlus);
            this.Controls.Add(this.lbVolume);
            this.Name = "Oefening2";
            this.Text = "Oefening2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbVolume;
        private System.Windows.Forms.Button btnVolPlus;
        private System.Windows.Forms.Button btnVolMin;
        private System.Windows.Forms.Label lbKanaal;
        private System.Windows.Forms.Button btnKanPlus;
        private System.Windows.Forms.Button btnKanMin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbKanaalVeranderen;
        private System.Windows.Forms.Button btnKanalKiez;
    }
}