using BusinessLogicLayer.Abstractions;
using BusinessLogicLayer.Dtos;
using DataAccessLayer.Entities;
using PresentationLayer.Forms.AdminForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Forms.CustomerForms
{
    public partial class CustomerHomeForm : Form
    {
        private readonly ICarService _carService;
        private List<CarDto> _cars;
        public CustomerHomeForm(ICarService carService)
        {
            _carService = carService;
            _cars = _carService.ShowAvailableCars().Cars.ToList();
            InitializeComponent();
        }

       
        

        private void CustomerHomeForm_Load(object sender, EventArgs e)
        {
            int startX = 10;
            int startY = 10;
            int currentX = startX;
            int currentY = startY;

            int panelWidth = 220;
            int panelHeight = 130;
            int padding = 10;

            int formWidth = this.ClientSize.Width;

            foreach (var car in _cars)
            {
                if (currentX + panelWidth + padding > formWidth)
                {
                    currentX = startX;
                    currentY += panelHeight + padding;
                }

                Panel carPanel = new Panel();
                carPanel.Size = new Size(panelWidth, panelHeight);
                carPanel.Location = new Point(currentX, currentY);
                carPanel.BorderStyle = BorderStyle.FixedSingle;

                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new Size(90, 90);
                pictureBox.Location = new Point(10, 10);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                if (car.ImagePath != null)
                {
                    pictureBox.Image = Image.FromFile(car.ImagePath);
                }

                Label lblModel = new Label();
                lblModel.Text = $"Model:  {car.Model}";
                lblModel.Location = new Point(110, 20);
                lblModel.AutoSize = true;

                Button btnDetails = new Button();
                btnDetails.Text = "Show Details";
                btnDetails.Size = new Size(80, 25);
                btnDetails.Location = new Point(110, 60);
                btnDetails.Click += (s, eArgs) =>
                {
                    var carDetialsForm = new CustomerCarDetails(_carService, car);
                    carDetialsForm.Show();
                };

                carPanel.Controls.Add(pictureBox);
                carPanel.Controls.Add(lblModel);
                carPanel.Controls.Add(btnDetails);

                this.Controls.Add(carPanel);

                currentX += panelWidth + padding;
            }

            this.AutoScroll = true;
        }
    }
}
