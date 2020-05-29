namespace test
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
            this.btTomarExamen = new System.Windows.Forms.Button();
            this.tbNota1 = new System.Windows.Forms.TextBox();
            this.tbNota2 = new System.Windows.Forms.TextBox();
            this.tbNota3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btTomarExamen
            // 
            this.btTomarExamen.Location = new System.Drawing.Point(281, 159);
            this.btTomarExamen.Name = "btTomarExamen";
            this.btTomarExamen.Size = new System.Drawing.Size(110, 47);
            this.btTomarExamen.TabIndex = 0;
            this.btTomarExamen.Text = "TOMAR EXAMEN SEXY";
            this.btTomarExamen.UseVisualStyleBackColor = true;
            this.btTomarExamen.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbNota1
            // 
            this.tbNota1.Location = new System.Drawing.Point(291, 112);
            this.tbNota1.Name = "tbNota1";
            this.tbNota1.Size = new System.Drawing.Size(100, 20);
            this.tbNota1.TabIndex = 1;
            // 
            // tbNota2
            // 
            this.tbNota2.Location = new System.Drawing.Point(98, 112);
            this.tbNota2.Name = "tbNota2";
            this.tbNota2.Size = new System.Drawing.Size(100, 20);
            this.tbNota2.TabIndex = 2;
            // 
            // tbNota3
            // 
            this.tbNota3.Location = new System.Drawing.Point(291, 64);
            this.tbNota3.Name = "tbNota3";
            this.tbNota3.Size = new System.Drawing.Size(100, 20);
            this.tbNota3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(422, 436);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNota3);
            this.Controls.Add(this.tbNota2);
            this.Controls.Add(this.tbNota1);
            this.Controls.Add(this.btTomarExamen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btTomarExamen;
        private System.Windows.Forms.TextBox tbNota1;
        private System.Windows.Forms.TextBox tbNota2;
        private System.Windows.Forms.TextBox tbNota3;
        private System.Windows.Forms.Label label1;
    }
}

