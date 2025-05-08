using BusinessLogicLayer.Abstractions;
using BusinessLogicLayer.Dtos;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Forms.AdminForms
{
    public partial class CarDetialsForm : Form
    {

        private readonly ICarService _carService;
        private CarDto _car;

        private TextBox txtId, txtModel, txtDescription, txtRentPrice;
        private Button btnUpdate, btnDelete;
        public CarDetialsForm(ICarService carService , CarDto car)
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

            btnUpdate = new Button { Text = "Update", Location = new Point(50, 270), Width = 100 };
            btnDelete = new Button { Text = "Delete", Location = new Point(170, 270), Width = 100 };

            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;

            this.Controls.AddRange(new Control[]
            {
            lblId, txtId,
            lblModel, txtModel,
            lblDescription, txtDescription,
            lblRentPrice, txtRentPrice,
            btnUpdate, btnDelete
            });

        }

        private void CarDetialsForm_Load(object sender, EventArgs e)
        {

            this.txtId.Text = _car.Id.ToString();
            txtModel.Text = _car.Model;
            txtDescription.Text = _car.Decription;
            txtRentPrice.Text = _car.RentPrice.ToString();
        }
        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _car.Model = txtModel.Text;
            _car.Decription = txtDescription.Text;
            _car.RentPrice = decimal.TryParse(txtRentPrice.Text, out var price) ? price : 0;

            if (_car.Decription == null || _car.Model == null || _car.Brand == null)
                MessageBox.Show("You Must Fill All Car info");

            var updateCar =  _carService.UpdateCar(_car);
            _car = updateCar.Car;
            MessageBox.Show("Car Update Successfully");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Areyou sure to delete the car!", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                _carService.DeleteCar(_car.Id);
                MessageBox.Show("Car Deleted Successfuly");
                this.Close();
            }
        }
    }
}
