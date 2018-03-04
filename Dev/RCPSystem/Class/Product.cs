using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RCPSystem.DbClass;

namespace RCPSystem.Class
{

    class Product
    {
        EFModel context;
        TreeView Tree;
        TextBox Name;
        TextBox Description;
        TextBox Quant;
        TreeNode Node;
        ComboBox combo;
        DataGridView dgv;
        List<zadProduct> ProdList;
        public Product(TreeView _tree, TextBox _name, ComboBox _combo,TextBox _descr,DataGridView _dgv,TextBox _quant)
        {

            context = new EFModel();
            this.Tree = _tree;
            this.Name = _name;
            this.combo = _combo;
            this.Description = _descr;
            this.dgv = _dgv;
            this.Quant = _quant;
            ProdList = new List<zadProduct>();
            TreeLoad(Node);
            ComboLoad();
        }
        public void ComboLoad()
        {
            var List = context.zadElements.ToList();
            List = List.FindAll(l => l.Active != false);
            combo.DataSource = List;
            combo.ValueMember = "IdElement";
            combo.DisplayMember = "Name";
        }
        public void TreeLoad(TreeNode node)
        {
            Tree.Nodes.Clear();
            var Types = context.zadProducts.ToList();//Find(x => x.IdHigherOrgUnit == null).ToList();

            Types.ForEach(delegate (zadProduct dep)
            {
                node = new TreeNode();
                if (dep.Active)
                {
                    node.Text = dep.Name;
                    node.Name = dep.IdProduct.ToString();
                    this.Tree.Nodes.Add(node);
                }
            }
            );
            Tree.ExpandAll();
        }
        public void ButtonAdd(string Name,string Description)
        {
            zadProduct prod = new zadProduct();
            try
            {
                prod.Name = Name;
                prod.Description = Description;
                prod.Active = true;
                context.zadProducts.Add(prod);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Tree.Nodes.Clear();
                TreeLoad(Node);
                Tree.ExpandAll();
                this.Name.Text = String.Empty;

            }
        }

        public void BindData(int ProductID)
        {
            try
            {
                zadProduct prod = new zadProduct();
                prod = context.zadProducts.FirstOrDefault(p => p.IdProduct == ProductID);
                this.Name.Text = prod.Name;
                this.Description.Text = prod.Description;
                BindGrid(ProductID);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void BindGrid(int ProductID)
        {
            dgv.DataSource = null;
            var ListElem = (from elem in context.zadElements
                        join pro in context.zadProdElems on elem.IdElement equals pro.IdElement
                        where pro.IdProduct == ProductID
                        select new {Nazwa=elem.Name ,Ilosc = pro.Quantity ,ElemId = elem.IdElement }).ToList();
            dgv.DataSource = ListElem;
        }

        public void ButtonDelete(int ProductID)
        {
            var listElem = context.zadProdElems.ToList();
            listElem = listElem.FindAll(e => e.IdProduct == ProductID);
            var Prod= context.zadProducts.FirstOrDefault(p => p.IdProduct== ProductID);
            try
            {
                foreach (zadProdElem z in listElem)
                {
                    context.zadProdElems.Attach(z);
                    context.zadProdElems.Remove(z);
                    context.SaveChanges();
                }
                context.zadProducts.Attach(Prod);
                context.zadProducts.Remove(Prod);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Tree.Nodes.Clear();
                TreeLoad(Node);
                Tree.ExpandAll();
                dgv.DataSource = null;
                this.Name.Text = String.Empty;

            }
        }
        public void ButtonElemAdd(int ProductId,int ElementId,int Quantity)
        {
           
            try
            {
                zadProdElem ProdElem = new zadProdElem
                {
                    IdProduct = ProductId,
                    IdElement = ElementId,
                    Quantity = Quantity
                };
                context.zadProdElems.Add(ProdElem);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dgv.DataSource = null;
                BindGrid(ProductId);
                this.Quant.Text = String.Empty;
            }
        }
        public void ButtonElemDelete(int ProductId, int ElemId)
        {
            var elem = context.zadProdElems.FirstOrDefault(e => e.IdProduct == ProductId && e.IdElement == ElemId);

            try
            {
               context.zadProdElems.Attach(elem);
               context.zadProdElems.Remove(elem);
               context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Name.Text = String.Empty;
                BindData(ProductId);
            }
        }
        public void ButtonSave(int ProductID)
        {
            try
            {
                var prod = context.zadProducts.FirstOrDefault(p => p.IdProduct == ProductID);
                prod.Description = Description.Text;
                prod.Name = Name.Text;
                context.SaveChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                BindData(ProductID);
                TreeLoad(Node);
            }
        }
    }
}
