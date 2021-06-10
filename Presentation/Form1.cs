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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            productRepository = new ProductRepository();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Product p = new Product()
            {
                Name = "Galleta",
                Brand = "Nabisco",
                Model = "Oreo",
                Description = "Galleta de chocolate",
                Price = 10M,
                Stock = 10,
                ImageURL = ""
            };

            productRepository.Create(p);
         }

        private void Button1_Click(object sender, EventArgs e)
        {
            List<Product> products = productRepository.GetAll().ToList();

            products.ForEach(p => Console.WriteLine($"Nombre: {p.Name}"));
        }
    }
}
