using BusinessLogicLayer.Abstractions;
using BusinessLogicLayer.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PresentationLayer.Program;

namespace PresentationLayer.Forms.CustomerForms
{
    public partial class CustomerCarDetails : Form
    {
        private readonly ICarService _carService;
        private CarDto _car;

        private TextBox txtId, txtModel, txtDescription, txtRentPrice;
        private Button btnRent;
        public CustomerCarDetails(ICarService carService, CarDto car)
        {
            InitializeComponent();
            _carService = carService;
            _car = car;

            Label lblId = new Label { Text = "ID:", Location = new Point(20, 20), AutoSize = true };
            txtId = new TextBox { Location = new Point(120, 20), Width = 200, ReadOnly = true };

            Label lblModel = new Label { Text = "Model:", Location = new Point(20, 60), AutoSize = true };
            txtModel = new TextBox { Location = new Point(120, 60), Width = 200 };

            Label lblDescription = new Label { Text = "Description:", Location = new Point(20, 100), AutoSize = true };
            txtDescription = new TextBox { Location = new Point(120, 100), Width = 200, Height = 60, Multiline = true };

            Label lblIsRented = new Label { Text = "Is Rented:", Location = new Point(20, 180), AutoSize = true };

            Label lblRentPrice = new Label { Text = "Rent Price:", Location = new Point(20, 220), AutoSize = true };
            txtRentPrice = new TextBox { Location = new Point(120, 220), Width = 200 };

            btnRent = new Button { Text = "Rent", Location = new Point(50, 270), Width = 100 };

            btnRent.Click += btnRent_Click;

            this.Controls.AddRange(new Control[]
            {
            lblId, txtId,
            lblModel, txtModel,
            lblDescription, txtDescription,
            lblRentPrice, txtRentPrice,
            });

        }

        private void CustomerCarDetails_Load(object sender, EventArgs e)
        {

            this.txtId.Text = _car.Id.ToString();
            txtModel.Text = _car.Model;
            txtDescription.Text = _car.Decription;
            txtRentPrice.Text = _car.RentPrice.ToString();
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            _car.IsRented = true;
            _carService.UpdateCar(_car);
            this.Close();
            var customerHome = new CustomerHomeForm(ServicesManager.CarService);
        }
    }
}
