namespace P02
{
    partial class Form2
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radio_sestupne = new System.Windows.Forms.RadioButton();
            this.radio_vzestupne = new System.Windows.Forms.RadioButton();
            this.execute = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_secmin = new System.Windows.Forms.Label();
            this.label_secmax = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(50, 60);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(100, 20);
            this.textBoxN.TabIndex = 0;
            this.textBoxN.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zadej N:";
            // 
            // radio_sestupne
            // 
            this.radio_sestupne.AutoSize = true;
            this.radio_sestupne.Checked = true;
            this.radio_sestupne.Location = new System.Drawing.Point(50, 99);
            this.radio_sestupne.Name = "radio_sestupne";
            this.radio_sestupne.Size = new System.Drawing.Size(68, 17);
            this.radio_sestupne.TabIndex = 2;
            this.radio_sestupne.TabStop = true;
            this.radio_sestupne.Text = "sestupně";
            this.radio_sestupne.UseVisualStyleBackColor = true;
            // 
            // radio_vzestupne
            // 
            this.radio_vzestupne.AutoSize = true;
            this.radio_vzestupne.Location = new System.Drawing.Point(50, 122);
            this.radio_vzestupne.Name = "radio_vzestupne";
            this.radio_vzestupne.Size = new System.Drawing.Size(74, 17);
            this.radio_vzestupne.TabIndex = 3;
            this.radio_vzestupne.Text = "vzestupně";
            this.radio_vzestupne.UseVisualStyleBackColor = true;
            // 
            // execute
            // 
            this.execute.Location = new System.Drawing.Point(156, 58);
            this.execute.Name = "execute";
            this.execute.Size = new System.Drawing.Size(75, 23);
            this.execute.TabIndex = 4;
            this.execute.Text = "zadat";
            this.execute.UseVisualStyleBackColor = true;
            this.execute.Click += new System.EventHandler(this.execute_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(237, 58);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 186);
            this.listBox1.TabIndex = 5;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(375, 58);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 186);
            this.listBox2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "pole 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "pole 2";
            // 
            // label_secmin
            // 
            this.label_secmin.AutoSize = true;
            this.label_secmin.Location = new System.Drawing.Point(47, 154);
            this.label_secmin.Name = "label_secmin";
            this.label_secmin.Size = new System.Drawing.Size(62, 13);
            this.label_secmin.TabIndex = 9;
            this.label_secmin.Text = "2. nejmenší";
            // 
            // label_secmax
            // 
            this.label_secmax.AutoSize = true;
            this.label_secmax.Location = new System.Drawing.Point(47, 177);
            this.label_secmax.Name = "label_secmax";
            this.label_secmax.Size = new System.Drawing.Size(57, 13);
            this.label_secmax.TabIndex = 10;
            this.label_secmax.Text = "2. největší";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_secmax);
            this.Controls.Add(this.label_secmin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.execute);
            this.Controls.Add(this.radio_vzestupne);
            this.Controls.Add(this.radio_sestupne);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxN);
            this.Name = "Form2";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radio_sestupne;
        private System.Windows.Forms.RadioButton radio_vzestupne;
        private System.Windows.Forms.Button execute;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_secmin;
        private System.Windows.Forms.Label label_secmax;
    }
}

