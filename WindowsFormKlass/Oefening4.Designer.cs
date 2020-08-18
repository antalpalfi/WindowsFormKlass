namespace WindowsFormKlass
{
    partial class Oefening4
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numLenght = new System.Windows.Forms.NumericUpDown();
            this.numDept = new System.Windows.Forms.NumericUpDown();
            this.numBreed = new System.Windows.Forms.NumericUpDown();
            this.btKalk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numLenght)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBreed)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zwembad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lengte:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Depte:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Breedte:";
            // 
            // numLenght
            // 
            this.numLenght.Location = new System.Drawing.Point(49, 49);
            this.numLenght.Name = "numLenght";
            this.numLenght.Size = new System.Drawing.Size(51, 20);
            this.numLenght.TabIndex = 4;
            // 
            // numDept
            // 
            this.numDept.Location = new System.Drawing.Point(49, 111);
            this.numDept.Name = "numDept";
            this.numDept.Size = new System.Drawing.Size(51, 20);
            this.numDept.TabIndex = 5;
            // 
            // numBreed
            // 
            this.numBreed.Location = new System.Drawing.Point(49, 79);
            this.numBreed.Name = "numBreed";
            this.numBreed.Size = new System.Drawing.Size(51, 20);
            this.numBreed.TabIndex = 6;
            // 
            // btKalk
            // 
            this.btKalk.Location = new System.Drawing.Point(26, 137);
            this.btKalk.Name = "btKalk";
            this.btKalk.Size = new System.Drawing.Size(51, 23);
            this.btKalk.TabIndex = 7;
            this.btKalk.Text = "Kalk";
            this.btKalk.UseVisualStyleBackColor = true;
            this.btKalk.Click += new System.EventHandler(this.btKalk_Click);
            // 
            // Oefening4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(138, 185);
            this.Controls.Add(this.btKalk);
            this.Controls.Add(this.numBreed);
            this.Controls.Add(this.numDept);
            this.Controls.Add(this.numLenght);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Oefening4";
            this.Text = "Oefening4";
            ((System.ComponentModel.ISupportInitialize)(this.numLenght)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBreed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numLenght;
        private System.Windows.Forms.NumericUpDown numDept;
        private System.Windows.Forms.NumericUpDown numBreed;
        private System.Windows.Forms.Button btKalk;
    }
}