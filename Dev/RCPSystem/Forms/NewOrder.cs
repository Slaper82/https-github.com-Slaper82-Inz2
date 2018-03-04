using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RCPSystem.DbClass;
namespace RCPSystem.Forms
{
    public partial class NewOrder : Form
    {
        EFModel context;
        public int UserId { get; set; }
        public event ReloadValue Reload;

        List<zadClient> ClientList = new List<zadClient>();
        List<zadProduct> ProductList= new List<zadProduct>();
        List<zadProduct> SelectedProduct = new List<zadProduct>();
        List<int> ProdQuant = new List<int>();

        zadClient Client = new zadClient();
        zadProduct Product = new zadProduct();
        zadOrder NewOrderClick;
        zadOrderProduct NewProduct;



        public NewOrder(int userId)
        {

            this.UserId = userId;
            InitializeComponent();
            context = new EFModel();
            ComboLoad(Client);
            ComboLoad(Product);

        }

        private void ComboLoad(object o)
        {
            if(o is zadClient)
            {
                ClientList = context.zadClients.ToList();

                cmbClient.DataSource = ClientList;
                cmbClient.DisplayMember = "Name";
                cmbClient.ValueMember = "IdClient";
            }
            if(o is zadProduct)
            {
                ProductList = context.zadProducts.ToList();
                cmbProduct.DataSource = ProductList;
                cmbProduct.DisplayMember = "Name";
                cmbProduct.ValueMember = "IdProduct";
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            Reload(this, e);
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            int clientId = Convert.ToInt32(cmbClient.SelectedValue);
            Client = context.zadClients.FirstOrDefault(c => c.IdClient == clientId);
            cmbProduct.Enabled = true;
            txtQuant.Enabled = true;
            btnAddProduct.Enabled = true;

            NewOrderClick = new zadOrder()
            {
                IdUser = UserId,
                CreateDate= DateTime.Now,
                Description= txtDescription.Text,
                Done = false,
                Active=true,
                IdClient=Client.IdClient 
            };
            context.zadOrders.Add(NewOrderClick);
            context.SaveChanges();
            
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            int quantity;
            bool ValCheck=Int32.TryParse(txtQuant.Text, out quantity);

            if (ValCheck)
            {
                int ProdId = Convert.ToInt32(cmbProduct.SelectedValue);
                Product = context.zadProducts.FirstOrDefault(p => p.IdProduct == ProdId);
                //NewProduct = 
                btnSave.Enabled = true;
            }
            else
            {
                MessageBox.Show("Podaj wartość liczbową w polu!");
            }

        }
    }
}
