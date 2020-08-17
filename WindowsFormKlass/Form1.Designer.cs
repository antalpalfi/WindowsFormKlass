namespace WindowsFormKlass
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnBekijk = new System.Windows.Forms.Button();
            this.btnVerhoog = new System.Windows.Forms.Button();
            this.btnVerlaag = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnEind = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-357, -117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnBekijk
            // 
            this.btnBekijk.Location = new System.Drawing.Point(3, 30);
            this.btnBekijk.Name = "btnBekijk";
            this.btnBekijk.Size = new System.Drawing.Size(147, 23);
            this.btnBekijk.TabIndex = 1;
            this.btnBekijk.Text = "Bekijk Getal";
            this.btnBekijk.UseVisualStyleBackColor = true;
            this.btnBekijk.Click += new System.EventHandler(this.btnBekijk_Click);
            // 
            // btnVerhoog
            // 
            this.btnVerhoog.Location = new System.Drawing.Point(3, 59);
            this.btnVerhoog.Name = "btnVerhoog";
            this.btnVerhoog.Size = new System.Drawing.Size(147, 23);
            this.btnVerhoog.TabIndex = 3;
            this.btnVerhoog.Text = "Verhoog getal";
            this.btnVerhoog.UseVisualStyleBackColor = true;
            this.btnVerhoog.Click += new System.EventHandler(this.btnVerhoog_Click);
            // 
            // btnVerlaag
            // 
            this.btnVerlaag.Location = new System.Drawing.Point(3, 88);
            this.btnVerlaag.Name = "btnVerlaag";
            this.btnVerlaag.Size = new System.Drawing.Size(147, 23);
            this.btnVerlaag.TabIndex = 2;
            this.btnVerlaag.Text = "Verlaag getal";
            this.btnVerlaag.UseVisualStyleBackColor = true;
            this.btnVerlaag.Click += new System.EventHandler(this.btnVerlaag_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(3, 117);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(147, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset teller";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnEind
            // 
            this.btnEind.Location = new System.Drawing.Point(3, 146);
            this.btnEind.Name = "btnEind";
            this.btnEind.Size = new System.Drawing.Size(147, 23);
            this.btnEind.TabIndex = 5;
            this.btnEind.Text = "Close";
            this.btnEind.UseVisualStyleBackColor = true;
            this.btnEind.Click += new System.EventHandler(this.btnEind_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(163, 203);
            this.Controls.Add(this.btnEind);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnVerhoog);
            this.Controls.Add(this.btnVerlaag);
            this.Controls.Add(this.btnBekijk);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBekijk;
        private System.Windows.Forms.Button btnVerhoog;
        private System.Windows.Forms.Button btnVerlaag;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnEind;
    }
}

