namespace puissance4
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
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnJVJ = new System.Windows.Forms.Button();
            this.btnIAVJ = new System.Windows.Forms.Button();
            this.btnJVIA = new System.Windows.Forms.Button();
            this.btnIAVIA = new System.Windows.Forms.Button();
            this.btnJouer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 32);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 0;
            this.btn1.Tag = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Visible = false;
            this.btn1.Click += new System.EventHandler(this.btnJouer_click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(93, 32);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 1;
            this.btn2.Tag = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Visible = false;
            this.btn2.Click += new System.EventHandler(this.btnJouer_click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(174, 32);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 23);
            this.btn3.TabIndex = 2;
            this.btn3.Tag = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Visible = false;
            this.btn3.Click += new System.EventHandler(this.btnJouer_click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(255, 32);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 23);
            this.btn4.TabIndex = 3;
            this.btn4.Tag = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Visible = false;
            this.btn4.Click += new System.EventHandler(this.btnJouer_click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(336, 32);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 23);
            this.btn5.TabIndex = 4;
            this.btn5.Tag = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Visible = false;
            this.btn5.Click += new System.EventHandler(this.btnJouer_click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(417, 32);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 23);
            this.btn6.TabIndex = 5;
            this.btn6.Tag = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Visible = false;
            this.btn6.Click += new System.EventHandler(this.btnJouer_click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(498, 32);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 23);
            this.btn7.TabIndex = 6;
            this.btn7.Tag = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Visible = false;
            this.btn7.Click += new System.EventHandler(this.btnJouer_click);
            // 
            // btnJVJ
            // 
            this.btnJVJ.Location = new System.Drawing.Point(19, 335);
            this.btnJVJ.Name = "btnJVJ";
            this.btnJVJ.Size = new System.Drawing.Size(75, 23);
            this.btnJVJ.TabIndex = 49;
            this.btnJVJ.Tag = "JVJ";
            this.btnJVJ.Text = "JVJ";
            this.btnJVJ.UseVisualStyleBackColor = true;
            this.btnJVJ.Visible = false;
            this.btnJVJ.Click += new System.EventHandler(this.btnDefinirJoueur);
            // 
            // btnIAVJ
            // 
            this.btnIAVJ.Location = new System.Drawing.Point(150, 335);
            this.btnIAVJ.Name = "btnIAVJ";
            this.btnIAVJ.Size = new System.Drawing.Size(75, 23);
            this.btnIAVJ.TabIndex = 50;
            this.btnIAVJ.Tag = "IAVJ";
            this.btnIAVJ.Text = "IAVJ";
            this.btnIAVJ.UseVisualStyleBackColor = true;
            this.btnIAVJ.Visible = false;
            this.btnIAVJ.Click += new System.EventHandler(this.btnDefinirJoueur);
            // 
            // btnJVIA
            // 
            this.btnJVIA.Location = new System.Drawing.Point(310, 335);
            this.btnJVIA.Name = "btnJVIA";
            this.btnJVIA.Size = new System.Drawing.Size(75, 23);
            this.btnJVIA.TabIndex = 51;
            this.btnJVIA.Tag = "JVIA";
            this.btnJVIA.Text = "JVIA";
            this.btnJVIA.UseVisualStyleBackColor = true;
            this.btnJVIA.Visible = false;
            this.btnJVIA.Click += new System.EventHandler(this.btnDefinirJoueur);
            // 
            // btnIAVIA
            // 
            this.btnIAVIA.Location = new System.Drawing.Point(467, 335);
            this.btnIAVIA.Name = "btnIAVIA";
            this.btnIAVIA.Size = new System.Drawing.Size(75, 23);
            this.btnIAVIA.TabIndex = 52;
            this.btnIAVIA.Tag = "IAVIA";
            this.btnIAVIA.Text = "IAVIA";
            this.btnIAVIA.UseVisualStyleBackColor = true;
            this.btnIAVIA.Visible = false;
            this.btnIAVIA.Click += new System.EventHandler(this.btnDefinirJoueur);
            // 
            // btnJouer
            // 
            this.btnJouer.Location = new System.Drawing.Point(232, 383);
            this.btnJouer.Name = "btnJouer";
            this.btnJouer.Size = new System.Drawing.Size(75, 23);
            this.btnJouer.TabIndex = 53;
            this.btnJouer.Tag = "JVIA";
            this.btnJouer.Text = "jouer";
            this.btnJouer.UseVisualStyleBackColor = true;
            this.btnJouer.Click += new System.EventHandler(this.btnJouer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 630);
            this.Controls.Add(this.btnJouer);
            this.Controls.Add(this.btnIAVIA);
            this.Controls.Add(this.btnJVIA);
            this.Controls.Add(this.btnIAVJ);
            this.Controls.Add(this.btnJVJ);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnJVJ;
        private System.Windows.Forms.Button btnIAVJ;
        private System.Windows.Forms.Button btnJVIA;
        private System.Windows.Forms.Button btnIAVIA;
        private System.Windows.Forms.Button btnJouer;
    }
}

