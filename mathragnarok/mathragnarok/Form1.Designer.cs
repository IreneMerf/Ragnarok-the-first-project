namespace mathragnarok
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox_A = new System.Windows.Forms.TextBox();
            this.textBox_B = new System.Windows.Forms.TextBox();
            this.textBox_A_two = new System.Windows.Forms.TextBox();
            this.label_A = new System.Windows.Forms.Label();
            this.label_B = new System.Windows.Forms.Label();
            this.label_A_two = new System.Windows.Forms.Label();
            this.button_otvet = new System.Windows.Forms.Button();
            this.label_otvet = new System.Windows.Forms.Label();
            this.textBox_B_two = new System.Windows.Forms.TextBox();
            this.label_B_two = new System.Windows.Forms.Label();
            this.button_two = new System.Windows.Forms.Button();
            this.label_two = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_A
            // 
            this.textBox_A.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_A.Location = new System.Drawing.Point(426, 196);
            this.textBox_A.Name = "textBox_A";
            this.textBox_A.Size = new System.Drawing.Size(43, 33);
            this.textBox_A.TabIndex = 0;
            // 
            // textBox_B
            // 
            this.textBox_B.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_B.Location = new System.Drawing.Point(514, 196);
            this.textBox_B.Name = "textBox_B";
            this.textBox_B.Size = new System.Drawing.Size(40, 33);
            this.textBox_B.TabIndex = 1;
            // 
            // textBox_A_two
            // 
            this.textBox_A_two.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_A_two.Location = new System.Drawing.Point(491, 333);
            this.textBox_A_two.Name = "textBox_A_two";
            this.textBox_A_two.Size = new System.Drawing.Size(43, 33);
            this.textBox_A_two.TabIndex = 2;
            this.textBox_A_two.TextChanged += new System.EventHandler(this.textBox_A_two_TextChanged);
            // 
            // label_A
            // 
            this.label_A.AutoSize = true;
            this.label_A.Location = new System.Drawing.Point(434, 178);
            this.label_A.Name = "label_A";
            this.label_A.Size = new System.Drawing.Size(18, 15);
            this.label_A.TabIndex = 3;
            this.label_A.Text = " A";
            // 
            // label_B
            // 
            this.label_B.AutoSize = true;
            this.label_B.Location = new System.Drawing.Point(526, 178);
            this.label_B.Name = "label_B";
            this.label_B.Size = new System.Drawing.Size(17, 15);
            this.label_B.TabIndex = 4;
            this.label_B.Text = " B";
            // 
            // label_A_two
            // 
            this.label_A_two.AutoSize = true;
            this.label_A_two.Location = new System.Drawing.Point(504, 315);
            this.label_A_two.Name = "label_A_two";
            this.label_A_two.Size = new System.Drawing.Size(15, 15);
            this.label_A_two.TabIndex = 5;
            this.label_A_two.Text = "A";
            this.label_A_two.Click += new System.EventHandler(this.label3_Click);
            // 
            // button_otvet
            // 
            this.button_otvet.Location = new System.Drawing.Point(145, 151);
            this.button_otvet.Name = "button_otvet";
            this.button_otvet.Size = new System.Drawing.Size(92, 68);
            this.button_otvet.TabIndex = 6;
            this.button_otvet.Text = "Вычислить Площадь";
            this.button_otvet.UseVisualStyleBackColor = true;
            this.button_otvet.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_otvet
            // 
            this.label_otvet.AutoSize = true;
            this.label_otvet.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_otvet.Location = new System.Drawing.Point(396, 417);
            this.label_otvet.Name = "label_otvet";
            this.label_otvet.Size = new System.Drawing.Size(0, 25);
            this.label_otvet.TabIndex = 7;
            // 
            // textBox_B_two
            // 
            this.textBox_B_two.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_B_two.Location = new System.Drawing.Point(586, 333);
            this.textBox_B_two.Name = "textBox_B_two";
            this.textBox_B_two.Size = new System.Drawing.Size(43, 33);
            this.textBox_B_two.TabIndex = 8;
            this.textBox_B_two.TextChanged += new System.EventHandler(this.textBox_B_two_TextChanged);
            // 
            // label_B_two
            // 
            this.label_B_two.AutoSize = true;
            this.label_B_two.Location = new System.Drawing.Point(599, 315);
            this.label_B_two.Name = "label_B_two";
            this.label_B_two.Size = new System.Drawing.Size(14, 15);
            this.label_B_two.TabIndex = 9;
            this.label_B_two.Text = "B";
            this.label_B_two.Click += new System.EventHandler(this.label_B_two_Click);
            // 
            // button_two
            // 
            this.button_two.Location = new System.Drawing.Point(145, 288);
            this.button_two.Name = "button_two";
            this.button_two.Size = new System.Drawing.Size(92, 68);
            this.button_two.TabIndex = 10;
            this.button_two.Text = "Вычислить Периметр";
            this.button_two.UseVisualStyleBackColor = true;
            this.button_two.Click += new System.EventHandler(this.button_two_Click);
            // 
            // label_two
            // 
            this.label_two.AutoSize = true;
            this.label_two.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_two.Location = new System.Drawing.Point(572, 417);
            this.label_two.Name = "label_two";
            this.label_two.Size = new System.Drawing.Size(0, 25);
            this.label_two.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(641, 454);
            this.Controls.Add(this.label_two);
            this.Controls.Add(this.button_two);
            this.Controls.Add(this.label_B_two);
            this.Controls.Add(this.textBox_B_two);
            this.Controls.Add(this.label_otvet);
            this.Controls.Add(this.button_otvet);
            this.Controls.Add(this.label_A_two);
            this.Controls.Add(this.label_B);
            this.Controls.Add(this.label_A);
            this.Controls.Add(this.textBox_A_two);
            this.Controls.Add(this.textBox_B);
            this.Controls.Add(this.textBox_A);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вычисление площади и периметра квадрата";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_A;
        private TextBox textBox_B;
        private TextBox textBox_A_two;
        private Label label_A;
        private Label label_B;
        private Label label_A_two;
        private Button button_otvet;
        private Label label_otvet;
        private TextBox textBox_B_two;
        private Label label_B_two;
        private Button button_two;
        private Label label_two;
    }
}