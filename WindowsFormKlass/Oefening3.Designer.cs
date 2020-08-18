namespace WindowsFormKlass
{
    partial class Oefening3
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
            this.lbWiskunde = new System.Windows.Forms.Label();
            this.lbComp = new System.Windows.Forms.Label();
            this.lbGrammatica = new System.Windows.Forms.Label();
            this.btnWiskunde = new System.Windows.Forms.Button();
            this.btnComputer = new System.Windows.Forms.Button();
            this.btnGrammatica = new System.Windows.Forms.Button();
            this.listBoxWiskunde = new System.Windows.Forms.ListBox();
            this.listBoxComputer = new System.Windows.Forms.ListBox();
            this.listBoxGramm = new System.Windows.Forms.ListBox();
            this.labelWiskunde = new System.Windows.Forms.Label();
            this.labelComp = new System.Windows.Forms.Label();
            this.labelGramm = new System.Windows.Forms.Label();
            this.btnWisRem = new System.Windows.Forms.Button();
            this.btnCompRem = new System.Windows.Forms.Button();
            this.btnGrammRem = new System.Windows.Forms.Button();
            this.txtWiskunde = new System.Windows.Forms.TextBox();
            this.txtCom = new System.Windows.Forms.TextBox();
            this.txtGram = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbWiskunde
            // 
            this.lbWiskunde.AutoSize = true;
            this.lbWiskunde.Location = new System.Drawing.Point(11, 13);
            this.lbWiskunde.Name = "lbWiskunde";
            this.lbWiskunde.Size = new System.Drawing.Size(55, 13);
            this.lbWiskunde.TabIndex = 0;
            this.lbWiskunde.Text = "Wiskunde";
            // 
            // lbComp
            // 
            this.lbComp.AutoSize = true;
            this.lbComp.Location = new System.Drawing.Point(155, 13);
            this.lbComp.Name = "lbComp";
            this.lbComp.Size = new System.Drawing.Size(52, 13);
            this.lbComp.TabIndex = 1;
            this.lbComp.Text = "Computer";
            // 
            // lbGrammatica
            // 
            this.lbGrammatica.AutoSize = true;
            this.lbGrammatica.Location = new System.Drawing.Point(295, 9);
            this.lbGrammatica.Name = "lbGrammatica";
            this.lbGrammatica.Size = new System.Drawing.Size(63, 13);
            this.lbGrammatica.TabIndex = 2;
            this.lbGrammatica.Text = "Grammatica";
            // 
            // btnWiskunde
            // 
            this.btnWiskunde.Location = new System.Drawing.Point(72, 32);
            this.btnWiskunde.Name = "btnWiskunde";
            this.btnWiskunde.Size = new System.Drawing.Size(33, 23);
            this.btnWiskunde.TabIndex = 6;
            this.btnWiskunde.Text = "=>";
            this.btnWiskunde.UseVisualStyleBackColor = true;
            this.btnWiskunde.Click += new System.EventHandler(this.btnWiskunde_Click);
            // 
            // btnComputer
            // 
            this.btnComputer.Location = new System.Drawing.Point(215, 35);
            this.btnComputer.Name = "btnComputer";
            this.btnComputer.Size = new System.Drawing.Size(33, 20);
            this.btnComputer.TabIndex = 7;
            this.btnComputer.Text = "=>";
            this.btnComputer.UseVisualStyleBackColor = true;
            this.btnComputer.Click += new System.EventHandler(this.btnComputer_Click);
            // 
            // btnGrammatica
            // 
            this.btnGrammatica.Location = new System.Drawing.Point(355, 32);
            this.btnGrammatica.Name = "btnGrammatica";
            this.btnGrammatica.Size = new System.Drawing.Size(33, 23);
            this.btnGrammatica.TabIndex = 8;
            this.btnGrammatica.Text = "=>";
            this.btnGrammatica.UseVisualStyleBackColor = true;
            this.btnGrammatica.Click += new System.EventHandler(this.btnGrammatica_Click);
            // 
            // listBoxWiskunde
            // 
            this.listBoxWiskunde.FormattingEnabled = true;
            this.listBoxWiskunde.Location = new System.Drawing.Point(12, 58);
            this.listBoxWiskunde.Name = "listBoxWiskunde";
            this.listBoxWiskunde.Size = new System.Drawing.Size(66, 95);
            this.listBoxWiskunde.TabIndex = 9;
            // 
            // listBoxComputer
            // 
            this.listBoxComputer.FormattingEnabled = true;
            this.listBoxComputer.Location = new System.Drawing.Point(158, 58);
            this.listBoxComputer.Name = "listBoxComputer";
            this.listBoxComputer.Size = new System.Drawing.Size(66, 95);
            this.listBoxComputer.TabIndex = 10;
            // 
            // listBoxGramm
            // 
            this.listBoxGramm.FormattingEnabled = true;
            this.listBoxGramm.Location = new System.Drawing.Point(298, 58);
            this.listBoxGramm.Name = "listBoxGramm";
            this.listBoxGramm.Size = new System.Drawing.Size(66, 95);
            this.listBoxGramm.TabIndex = 11;
            // 
            // labelWiskunde
            // 
            this.labelWiskunde.AutoSize = true;
            this.labelWiskunde.Location = new System.Drawing.Point(12, 160);
            this.labelWiskunde.Name = "labelWiskunde";
            this.labelWiskunde.Size = new System.Drawing.Size(63, 13);
            this.labelWiskunde.TabIndex = 12;
            this.labelWiskunde.Text = "Gemiddelde";
            // 
            // labelComp
            // 
            this.labelComp.AutoSize = true;
            this.labelComp.Location = new System.Drawing.Point(158, 160);
            this.labelComp.Name = "labelComp";
            this.labelComp.Size = new System.Drawing.Size(63, 13);
            this.labelComp.TabIndex = 13;
            this.labelComp.Text = "Gemiddelde";
            // 
            // labelGramm
            // 
            this.labelGramm.AutoSize = true;
            this.labelGramm.Location = new System.Drawing.Point(298, 160);
            this.labelGramm.Name = "labelGramm";
            this.labelGramm.Size = new System.Drawing.Size(63, 13);
            this.labelGramm.TabIndex = 14;
            this.labelGramm.Text = "Gemiddelde";
            // 
            // btnWisRem
            // 
            this.btnWisRem.Location = new System.Drawing.Point(84, 94);
            this.btnWisRem.Name = "btnWisRem";
            this.btnWisRem.Size = new System.Drawing.Size(68, 23);
            this.btnWisRem.TabIndex = 15;
            this.btnWisRem.Text = "Remove";
            this.btnWisRem.UseVisualStyleBackColor = true;
            this.btnWisRem.Click += new System.EventHandler(this.btnWisRem_Click);
            // 
            // btnCompRem
            // 
            this.btnCompRem.Location = new System.Drawing.Point(230, 94);
            this.btnCompRem.Name = "btnCompRem";
            this.btnCompRem.Size = new System.Drawing.Size(68, 23);
            this.btnCompRem.TabIndex = 16;
            this.btnCompRem.Text = "Remove";
            this.btnCompRem.UseVisualStyleBackColor = true;
            this.btnCompRem.Click += new System.EventHandler(this.btnCompRem_Click);
            // 
            // btnGrammRem
            // 
            this.btnGrammRem.Location = new System.Drawing.Point(370, 94);
            this.btnGrammRem.Name = "btnGrammRem";
            this.btnGrammRem.Size = new System.Drawing.Size(68, 23);
            this.btnGrammRem.TabIndex = 17;
            this.btnGrammRem.Text = "Remove";
            this.btnGrammRem.UseVisualStyleBackColor = true;
            this.btnGrammRem.Click += new System.EventHandler(this.btnGrammRem_Click);
            // 
            // txtWiskunde
            // 
            this.txtWiskunde.Location = new System.Drawing.Point(15, 35);
            this.txtWiskunde.Name = "txtWiskunde";
            this.txtWiskunde.Size = new System.Drawing.Size(37, 20);
            this.txtWiskunde.TabIndex = 21;
            // 
            // txtCom
            // 
            this.txtCom.Location = new System.Drawing.Point(158, 34);
            this.txtCom.Name = "txtCom";
            this.txtCom.Size = new System.Drawing.Size(33, 20);
            this.txtCom.TabIndex = 22;
            // 
            // txtGram
            // 
            this.txtGram.Location = new System.Drawing.Point(298, 32);
            this.txtGram.Name = "txtGram";
            this.txtGram.Size = new System.Drawing.Size(33, 20);
            this.txtGram.TabIndex = 23;
            // 
            // Oefening3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 188);
            this.Controls.Add(this.txtGram);
            this.Controls.Add(this.txtCom);
            this.Controls.Add(this.txtWiskunde);
            this.Controls.Add(this.btnGrammRem);
            this.Controls.Add(this.btnCompRem);
            this.Controls.Add(this.btnWisRem);
            this.Controls.Add(this.labelGramm);
            this.Controls.Add(this.labelComp);
            this.Controls.Add(this.labelWiskunde);
            this.Controls.Add(this.listBoxGramm);
            this.Controls.Add(this.listBoxComputer);
            this.Controls.Add(this.listBoxWiskunde);
            this.Controls.Add(this.btnGrammatica);
            this.Controls.Add(this.btnComputer);
            this.Controls.Add(this.btnWiskunde);
            this.Controls.Add(this.lbGrammatica);
            this.Controls.Add(this.lbComp);
            this.Controls.Add(this.lbWiskunde);
            this.Name = "Oefening3";
            this.Text = "Oefening3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWiskunde;
        private System.Windows.Forms.Label lbComp;
        private System.Windows.Forms.Label lbGrammatica;
        private System.Windows.Forms.Button btnWiskunde;
        private System.Windows.Forms.Button btnComputer;
        private System.Windows.Forms.Button btnGrammatica;
        private System.Windows.Forms.ListBox listBoxWiskunde;
        private System.Windows.Forms.ListBox listBoxComputer;
        private System.Windows.Forms.ListBox listBoxGramm;
        private System.Windows.Forms.Label labelWiskunde;
        private System.Windows.Forms.Label labelComp;
        private System.Windows.Forms.Label labelGramm;
        private System.Windows.Forms.Button btnWisRem;
        private System.Windows.Forms.Button btnCompRem;
        private System.Windows.Forms.Button btnGrammRem;
        private System.Windows.Forms.TextBox txtWiskunde;
        private System.Windows.Forms.TextBox txtCom;
        private System.Windows.Forms.TextBox txtGram;
    }
}