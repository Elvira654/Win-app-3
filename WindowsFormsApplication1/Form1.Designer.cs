namespace WindowsFormsApplication1
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
            this.Dorucak = new System.Windows.Forms.CheckBox();
            this.Rucak = new System.Windows.Forms.CheckBox();
            this.Vecera = new System.Windows.Forms.CheckBox();
            this.Posalji = new System.Windows.Forms.Button();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Dorucak
            // 
            this.Dorucak.AutoSize = true;
            this.Dorucak.Location = new System.Drawing.Point(24, 36);
            this.Dorucak.Name = "Dorucak";
            this.Dorucak.Size = new System.Drawing.Size(67, 17);
            this.Dorucak.TabIndex = 0;
            this.Dorucak.Text = "Dorucak";
            this.Dorucak.UseVisualStyleBackColor = true;
            this.Dorucak.CheckedChanged += new System.EventHandler(this.Dorucak_CheckedChanged);
            // 
            // Rucak
            // 
            this.Rucak.AutoSize = true;
            this.Rucak.Location = new System.Drawing.Point(24, 68);
            this.Rucak.Name = "Rucak";
            this.Rucak.Size = new System.Drawing.Size(58, 17);
            this.Rucak.TabIndex = 1;
            this.Rucak.Text = "Rucak";
            this.Rucak.UseVisualStyleBackColor = true;
            this.Rucak.CheckedChanged += new System.EventHandler(this.Rucak_CheckedChanged);
            // 
            // Vecera
            // 
            this.Vecera.AutoSize = true;
            this.Vecera.Location = new System.Drawing.Point(24, 100);
            this.Vecera.Name = "Vecera";
            this.Vecera.Size = new System.Drawing.Size(60, 17);
            this.Vecera.TabIndex = 2;
            this.Vecera.Text = "Vecera";
            this.Vecera.UseVisualStyleBackColor = true;
            this.Vecera.CheckedChanged += new System.EventHandler(this.Vecera_CheckedChanged);
            // 
            // Posalji
            // 
            this.Posalji.Location = new System.Drawing.Point(29, 179);
            this.Posalji.Name = "Posalji";
            this.Posalji.Size = new System.Drawing.Size(75, 23);
            this.Posalji.TabIndex = 3;
            this.Posalji.Text = "&Posalji";
            this.Posalji.UseVisualStyleBackColor = true;
            this.Posalji.Click += new System.EventHandler(this.Posalji_Click);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(157, 183);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(105, 17);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Text = "Sakri porudzbinu";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.Posalji);
            this.Controls.Add(this.Vecera);
            this.Controls.Add(this.Rucak);
            this.Controls.Add(this.Dorucak);
            this.Name = "Form1";
            this.Text = "Upotreba CheckBox kontrole";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Dorucak;
        private System.Windows.Forms.CheckBox Rucak;
        private System.Windows.Forms.CheckBox Vecera;
        private System.Windows.Forms.Button Posalji;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.TextBox textBox1;
    }
}

