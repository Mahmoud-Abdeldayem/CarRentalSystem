namespace PresentationLayer.Forms.AdminForms
{
    partial class AdminHomeForm
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
            Button ShowAllCarsBtn;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHomeForm));
            AddCarBtn = new Button();
            ShowAvailableCarsBts = new Button();
            ShowCurrRentalsBtn = new Button();
            LogoutBtn = new Button();
            ShowRentedCarBtn = new Button();
            ShowAllCarsBtn = new Button();
            SuspendLayout();
            // 
            // ShowAllCarsBtn
            // 
            ShowAllCarsBtn.BackColor = Color.FromArgb(128, 255, 128);
            ShowAllCarsBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ShowAllCarsBtn.Location = new Point(61, 84);
            ShowAllCarsBtn.Name = "ShowAllCarsBtn";
            ShowAllCarsBtn.Size = new Size(246, 57);
            ShowAllCarsBtn.TabIndex = 2;
            ShowAllCarsBtn.Text = "Show All Cars";
            ShowAllCarsBtn.UseVisualStyleBackColor = false;
            //ShowAllCarsBtn.Click += ShowAllCarsBtn_Click;
            // 
            // AddCarBtn
            // 
            AddCarBtn.BackColor = Color.FromArgb(192, 255, 192);
            AddCarBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            AddCarBtn.Location = new Point(61, 12);
            AddCarBtn.Name = "AddCarBtn";
            AddCarBtn.Size = new Size(246, 57);
            AddCarBtn.TabIndex = 0;
            AddCarBtn.Text = "Add Car";
            AddCarBtn.UseVisualStyleBackColor = false;
            // 
            // ShowAvailableCarsBts
            // 
            ShowAvailableCarsBts.BackColor = Color.FromArgb(192, 192, 255);
            ShowAvailableCarsBts.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ShowAvailableCarsBts.Location = new Point(61, 159);
            ShowAvailableCarsBts.Name = "ShowAvailableCarsBts";
            ShowAvailableCarsBts.Size = new Size(246, 57);
            ShowAvailableCarsBts.TabIndex = 1;
            ShowAvailableCarsBts.Text = "Show Available Cars";
            ShowAvailableCarsBts.UseVisualStyleBackColor = false;
            // 
            // ShowCurrRentalsBtn
            // 
            ShowCurrRentalsBtn.BackColor = Color.FromArgb(192, 255, 255);
            ShowCurrRentalsBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ShowCurrRentalsBtn.Location = new Point(61, 308);
            ShowCurrRentalsBtn.Name = "ShowCurrRentalsBtn";
            ShowCurrRentalsBtn.Size = new Size(246, 57);
            ShowCurrRentalsBtn.TabIndex = 3;
            ShowCurrRentalsBtn.Text = "Show Current Rentals";
            ShowCurrRentalsBtn.UseVisualStyleBackColor = false;
            ShowCurrRentalsBtn.Click += button4_Click;
            // 
            // LogoutBtn
            // 
            LogoutBtn.BackColor = Color.FromArgb(255, 128, 128);
            LogoutBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LogoutBtn.Location = new Point(61, 381);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(246, 57);
            LogoutBtn.TabIndex = 4;
            LogoutBtn.Text = "Logout";
            LogoutBtn.UseVisualStyleBackColor = false;
            // 
            // ShowRentedCarBtn
            // 
            ShowRentedCarBtn.BackColor = Color.Cyan;
            ShowRentedCarBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ShowRentedCarBtn.Location = new Point(61, 233);
            ShowRentedCarBtn.Name = "ShowRentedCarBtn";
            ShowRentedCarBtn.Size = new Size(246, 57);
            ShowRentedCarBtn.TabIndex = 5;
            ShowRentedCarBtn.Text = "Show Rented Cars";
            ShowRentedCarBtn.UseVisualStyleBackColor = false;
            // 
            // AdminHomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 450);
            Controls.Add(ShowRentedCarBtn);
            Controls.Add(LogoutBtn);
            Controls.Add(ShowCurrRentalsBtn);
            Controls.Add(ShowAllCarsBtn);
            Controls.Add(ShowAvailableCarsBts);
            Controls.Add(AddCarBtn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminHomeForm";
            Text = "AdminHomeForm";
            ResumeLayout(false);
        }

        #endregion

        private Button AddCarBtn;
        private Button ShowAvailableCarsBts;
        private Button ShowAllCarsBtn;
        private Button ShowCurrRentalsBtn;
        private Button LogoutBtn;
        private Button ShowRentedCarBtn;
    }
}