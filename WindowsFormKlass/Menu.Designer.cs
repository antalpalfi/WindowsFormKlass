namespace WindowsFormKlass
{
    partial class Menu
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
            this.btnOefening1 = new System.Windows.Forms.Button();
            this.btnOefening2 = new System.Windows.Forms.Button();
            this.btnOefening3 = new System.Windows.Forms.Button();
            this.btnOefening4 = new System.Windows.Forms.Button();
            this.btnOefening5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOefening1
            // 
            this.btnOefening1.Location = new System.Drawing.Point(23, 12);
            this.btnOefening1.Name = "btnOefening1";
            this.btnOefening1.Size = new System.Drawing.Size(75, 23);
            this.btnOefening1.TabIndex = 0;
            this.btnOefening1.Text = "Oefening1";
            this.btnOefening1.UseVisualStyleBackColor = true;
            this.btnOefening1.Click += new System.EventHandler(this.btnOefening1_Click);
            // 
            // btnOefening2
            // 
            this.btnOefening2.Location = new System.Drawing.Point(23, 44);
            this.btnOefening2.Name = "btnOefening2";
            this.btnOefening2.Size = new System.Drawing.Size(75, 23);
            this.btnOefening2.TabIndex = 1;
            this.btnOefening2.Text = "Oefening2";
            this.btnOefening2.UseVisualStyleBackColor = true;
            this.btnOefening2.Click += new System.EventHandler(this.btnOefening2_Click);
            // 
            // btnOefening3
            // 
            this.btnOefening3.Location = new System.Drawing.Point(23, 73);
            this.btnOefening3.Name = "btnOefening3";
            this.btnOefening3.Size = new System.Drawing.Size(75, 23);
            this.btnOefening3.TabIndex = 2;
            this.btnOefening3.Text = "Oefening3";
            this.btnOefening3.UseVisualStyleBackColor = true;
            this.btnOefening3.Click += new System.EventHandler(this.btnOefening3_Click);
            // 
            // btnOefening4
            // 
            this.btnOefening4.Location = new System.Drawing.Point(23, 102);
            this.btnOefening4.Name = "btnOefening4";
            this.btnOefening4.Size = new System.Drawing.Size(75, 23);
            this.btnOefening4.TabIndex = 3;
            this.btnOefening4.Text = "Oefening4";
            this.btnOefening4.UseVisualStyleBackColor = true;
            this.btnOefening4.Click += new System.EventHandler(this.btnOefening4_Click);
            // 
            // btnOefening5
            // 
            this.btnOefening5.Location = new System.Drawing.Point(23, 131);
            this.btnOefening5.Name = "btnOefening5";
            this.btnOefening5.Size = new System.Drawing.Size(75, 23);
            this.btnOefening5.TabIndex = 4;
            this.btnOefening5.Text = "Oefening5";
            this.btnOefening5.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 168);
            this.Controls.Add(this.btnOefening5);
            this.Controls.Add(this.btnOefening4);
            this.Controls.Add(this.btnOefening3);
            this.Controls.Add(this.btnOefening2);
            this.Controls.Add(this.btnOefening1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOefening1;
        private System.Windows.Forms.Button btnOefening2;
        private System.Windows.Forms.Button btnOefening3;
        private System.Windows.Forms.Button btnOefening4;
        private System.Windows.Forms.Button btnOefening5;
    }
}