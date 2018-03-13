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
    public partial class FrmElement : Form
    {
        EFModel context;
        public int ProdId { get; set; }
        public event Refresh Added;

        public FrmElement(int _prodId)
        {
            this.ProdId = _prodId;
            context = new EFModel();
            InitializeComponent();
            GridLoad();
        }

        public void GridLoad()
        {
            var elems = context.zadProdElems.ToList();
            elems = elems.FindAll(e => e.IdProduct == ProdId);
            dgvElem.DataSource = elems;
        }

        private void btnAddElem_Click(object sender, EventArgs e)
        {
            if (txtName.Text != String.Empty && txtSymbol.Text != String.Empty && txtQuan.Text != String.Empty)
            {
                try
                {
                    var elem = new zadElement()
                    {
                        Name = txtName.Text,
                        Active = true,
                        Symbol = txtSymbol.Text,
                        IdType = 1
                    };
                    context.zadElements.Add(elem);
                    context.SaveChanges();
                    int idelement = elem.IdElement;
                    var prodElem = new zadProdElem()
                    {
                        IdElement = idelement,
                        IdProduct = ProdId,
                        Quantity = Convert.ToInt32(txtQuan.Text)
                    };
                    context.zadProdElems.Add(prodElem);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    GridLoad();
                    Added(ProdId);
                }
            }
            else
            {
                MessageBox.Show("Uzupełnij wszystkie pola!");
            } 
        }
    }
}
