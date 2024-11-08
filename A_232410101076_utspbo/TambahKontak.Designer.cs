namespace A_232410101076_utspbo
{
    partial class TambahKontak
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 97);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Nama:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(366, 35);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 1;
            label2.Text = "Kontak Baru";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 149);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(72, 194);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 3;
            label4.Text = "No HP:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(191, 94);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 27);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(191, 146);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(185, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(191, 194);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(185, 27);
            textBox3.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(329, 322);
            button1.Name = "button1";
            button1.Size = new Size(148, 29);
            button1.TabIndex = 7;
            button1.Text = "Tambah Kontak";
            button1.UseVisualStyleBackColor = true;
            // 
            // TambahKontak
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TambahKontak";
            Text = "TambahKontak";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
    }
}