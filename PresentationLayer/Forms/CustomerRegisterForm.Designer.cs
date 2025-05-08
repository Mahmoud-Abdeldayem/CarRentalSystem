namespace PresentationLayer.Forms
{
    partial class CustomerRegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerRegisterForm));
            FirstNameInp = new TextBox();
            PasswordInp = new TextBox();
            LastNameInp = new TextBox();
            EmailInp = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Registerbtn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // FirstNameInp
            // 
            FirstNameInp.Location = new Point(11, 114);
            FirstNameInp.Name = "FirstNameInp";
            FirstNameInp.Size = new Size(282, 27);
            FirstNameInp.TabIndex = 0;
            FirstNameInp.TextChanged += textBox1_TextChanged;
            // 
            // PasswordInp
            // 
            PasswordInp.Location = new Point(10, 273);
            PasswordInp.Name = "PasswordInp";
            PasswordInp.Size = new Size(282, 27);
            PasswordInp.TabIndex = 1;
            // 
            // LastNameInp
            // 
            LastNameInp.Location = new Point(12, 167);
            LastNameInp.Name = "LastNameInp";
            LastNameInp.Size = new Size(282, 27);
            LastNameInp.TabIndex = 2;
            // 
            // EmailInp
            // 
            EmailInp.Location = new Point(11, 220);
            EmailInp.Name = "EmailInp";
            EmailInp.Size = new Size(282, 27);
            EmailInp.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(11, 197);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 4;
            label1.Text = "Email:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(10, 91);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 5;
            label2.Text = "First Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(10, 250);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 6;
            label3.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(12, 144);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 7;
            label4.Text = "Last Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(0, 192, 0);
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(221, 67);
            label5.TabIndex = 8;
            label5.Text = "Register";
            // 
            // Registerbtn
            // 
            Registerbtn.BackColor = Color.FromArgb(0, 192, 0);
            Registerbtn.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            Registerbtn.Location = new Point(12, 353);
            Registerbtn.Name = "Registerbtn";
            Registerbtn.Size = new Size(282, 51);
            Registerbtn.TabIndex = 11;
            Registerbtn.Text = "Register";
            Registerbtn.UseVisualStyleBackColor = false;
            Registerbtn.Click += Registerbtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(299, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(499, 441);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // CustomerRegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(Registerbtn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(EmailInp);
            Controls.Add(LastNameInp);
            Controls.Add(PasswordInp);
            Controls.Add(FirstNameInp);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CustomerRegisterForm";
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox FirstNameInp;
        private TextBox PasswordInp;
        private TextBox LastNameInp;
        private TextBox EmailInp;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button Registerbtn;
        private PictureBox pictureBox1;
    }
}