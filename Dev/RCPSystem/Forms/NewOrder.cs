﻿using System;
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
        public int OrderId { get; set; }
        public event ReloadValue Reload;

        List<zadClient> ClientList = new List<zadClient>();
        List<zadProduct> ProductList= new List<zadProduct>();
        List<zadProduct> SelectedProduct = new List<zadProduct>();
        List<zadOrderProduct> OrderProducts; //= new List<zadOrderProduct>();
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
            List<zadProduct> ProdToTask = new List<zadProduct>();
            ProdToTask = (from prod in context.zadProducts
                          join ordered in context.zadOrderProducts on prod.IdProduct equals ordered.IdProduct
                          where ordered.IdOrder == OrderId
                          select prod).ToList();
            try
            {
                foreach (var prod in ProdToTask)
                {
                    int quantity = 0;
                    var temp = from q in context.zadOrderProducts
                               where q.IdProduct == prod.IdProduct
                               select q.Quantity;
                    quantity = Convert.ToInt32(temp.FirstOrDefault().ToString());

                    var elements = new List<zadProdElem>();
                    elements = (from element in context.zadProdElems
                                where prod.IdProduct == element.IdProduct
                                select element).ToList();

                    foreach (var elem in elements)
                    {
                        var NewTask = new zadTaskList()
                        {
                            Active = true,
                            Done = false,
                            IdElement = elem.IdElement,
                            IdOrder = OrderId,
                            Quantity = elem.Quantity * quantity

                        };
                        context.zadTaskLists.Add(NewTask);
                        context.SaveChanges();

                    }
                }

                Reload(this, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
           
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text != String.Empty)
            {
                int clientId = Convert.ToInt32(cmbClient.SelectedValue);
                Client = context.zadClients.FirstOrDefault(c => c.IdClient == clientId);
                cmbProduct.Enabled = true;
                txtQuant.Enabled = true;
                btnAddProduct.Enabled = true;
                //wyłączamy
                btnAccept.Enabled = false;
                cmbClient.Enabled = false;
                txtDescription.Enabled = false;
                //

                NewOrderClick = new zadOrder()
                {
                    IdUser = UserId,
                    CreateDate = DateTime.Now,
                    Description = txtDescription.Text,
                    Done = false,
                    Active = true,
                    IdClient = Client.IdClient
                };
                try
                {
                    context.zadOrders.Add(NewOrderClick);
                    context.SaveChanges();
                    OrderId = NewOrderClick.IdOrder;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Trzeba dodać opis");//do zmiany na pointera
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            int quantity;
            bool ValCheck=Int32.TryParse(txtQuant.Text, out quantity);

            if (ValCheck)
            {
                int ProdId = Convert.ToInt32(cmbProduct.SelectedValue);
                zadOrderProduct prod = new zadOrderProduct()
                {
                    IdOrder = OrderId,
                    IdProduct = ProdId,
                    Quantity = quantity,
                    Active = true
                };
                try
                {
                    context.zadOrderProducts.Add(prod);
                    context.SaveChanges();
                    btnSave.Enabled = true;
                    dgvLoad(OrderId);

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Podaj wartość liczbową w polu!");
            }

        }
        public void dgvLoad(int OrderId)
        {

            OrderProducts = new List<zadOrderProduct>();
            OrderProducts = context.zadOrderProducts.ToList();

            var source = (from order in OrderProducts
                          join prod in context.zadProducts on order.IdProduct equals prod.IdProduct
                          where order.IdOrder == OrderId
                          select new { Nazwa = prod.Name, Ilosc = order.Quantity, Id = order.IdKey }).ToList();

            dgvProd.DataSource = source;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //zamówienia
            try
            {
                //produkty zamówienia
                var orderProd = context.zadOrderProducts.ToList();
                orderProd = orderProd.FindAll(o => o.IdOrder == OrderId);

                foreach (var op in orderProd)
                {
                    
                    op.Active = false;
                    context.Entry(op).State = System.Data.Entity.EntityState.Modified;
                    //_auctionContext.Entry(paymentAttempt).State = EntityState.Modified;

                    context.SaveChanges();
                }

                var order = context.zadOrders.FirstOrDefault(o => o.IdOrder == OrderId);
                order.Active = false;
                context.Entry(order).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
         
                //Taski
                //var tasks = context.zadTaskLists.ToList();
                //tasks = tasks.FindAll(t => t.IdOrder == OrderId);
                //foreach(var t in tasks)
                //{
                //    t.Active = false;
                //    context.zadTaskLists.Attach(t);
                //    context.SaveChanges();
                //}
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
