namespace Gurtmaß_Rechner
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label4;
            this.LaengeInput = new System.Windows.Forms.TextBox();
            this.BreiteInput = new System.Windows.Forms.TextBox();
            this.HeightInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rechnenButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.gurtmassresult = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LaengeInput
            // 
            this.LaengeInput.Location = new System.Drawing.Point(349, 113);
            this.LaengeInput.Name = "LaengeInput";
            this.LaengeInput.Size = new System.Drawing.Size(195, 20);
            this.LaengeInput.TabIndex = 0;
            // 
            // BreiteInput
            // 
            this.BreiteInput.Location = new System.Drawing.Point(349, 139);
            this.BreiteInput.Name = "BreiteInput";
            this.BreiteInput.Size = new System.Drawing.Size(195, 20);
            this.BreiteInput.TabIndex = 1;
            // 
            // HeightInput
            // 
            this.HeightInput.Location = new System.Drawing.Point(349, 165);
            this.HeightInput.Name = "HeightInput";
            this.HeightInput.Size = new System.Drawing.Size(195, 20);
            this.HeightInput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Länge (Längste Seite)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Breite";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Höhe";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Bahnschrift", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(241, 40);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(303, 42);
            label4.TabIndex = 6;
            label4.Text = "Gurtmaß-Rechner";
            // 
            // rechnenButton
            // 
            this.rechnenButton.Location = new System.Drawing.Point(469, 206);
            this.rechnenButton.Name = "rechnenButton";
            this.rechnenButton.Size = new System.Drawing.Size(75, 23);
            this.rechnenButton.TabIndex = 7;
            this.rechnenButton.Text = "Rechnen";
            this.rechnenButton.UseVisualStyleBackColor = true;
            this.rechnenButton.Click += new System.EventHandler(this.rechnenButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Gurtmaß";
            // 
            // gurtmassresult
            // 
            this.gurtmassresult.Location = new System.Drawing.Point(349, 307);
            this.gurtmassresult.Name = "gurtmassresult";
            this.gurtmassresult.Size = new System.Drawing.Size(195, 20);
            this.gurtmassresult.TabIndex = 8;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "DHL National",
            "DHL International",
            "GLS",
            "DPD"});
            this.checkedListBox1.Location = new System.Drawing.Point(620, 307);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(168, 124);
            this.checkedListBox1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(636, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Kann versendet werden mit:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gurtmassresult);
            this.Controls.Add(this.rechnenButton);
            this.Controls.Add(label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HeightInput);
            this.Controls.Add(this.BreiteInput);
            this.Controls.Add(this.LaengeInput);
            this.Name = "Form1";
            this.Text = "Gurtmaß-Rechner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LaengeInput;
        private System.Windows.Forms.TextBox BreiteInput;
        private System.Windows.Forms.TextBox HeightInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button rechnenButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox gurtmassresult;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label6;
    }
}

