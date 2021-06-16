using Core;
using Core.Poco;
using Infraestructure.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Form1 : Form
    {
        private ProductRepository productRepository;
        private IClientRepository clientRepository;
        public Form1(IClientRepository clientRepository)
        {
            this.clientRepository = clientRepository;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            productRepository = new ProductRepository();
            //clientRepository = new ClientRepository();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Product p = new Product()
            {
                Name = "Galleta",
                Brand = "Nabisco",
                Model = "Oreo",
                Description = "Galleta de Vainilla",
                Price = 10M,
                Stock = 10,
                ImageURL = ""
            };

            productRepository.Create(p);
            //Client client = new Client()
            //{
            //    Name = "Paul",
            //    Lastname = "Vaso",
            //    Email = "p.vaso@gmail.com",
            //    Phone = "85967414"
            //};
            //clientRepository.Create(client);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            List<Product> products = productRepository.GetAll().ToList();
            if (products == null || products.Count == 0)
            {
                Console.WriteLine("No data");
            }

            products.ForEach(p => Console.WriteLine($"Id: {p.Id} Name: {p.Model}"));

            //List<Client> clients = clientRepository.GetAll().ToList();

            //clients.ForEach(c => Console.WriteLine($"Id: {c.Id} Name: {c.Name}"));
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            List<Product> products = productRepository.Find(p => p.Model.Equals("Oreo", StringComparison.InvariantCultureIgnoreCase))
                                                      .ToList();

            products.ForEach(p => Console.WriteLine($"Nombre: {p.Model}"));
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Product prod = productRepository.Find(p => p.Id == 1).FirstOrDefault();
            if (productRepository.Delete(prod))
            {
                MessageBox.Show($"Product with Id{prod.Id} was deleted.");
            }
        }
    }
}
