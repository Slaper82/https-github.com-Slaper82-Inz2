using RCPSystem.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RCPSystem.Forms
{
    public partial class Dict : Form
    {
        ProdTypes type;
        ProdDuty duty;
        ProdElem elem;
        Product product;
        EFModel context;
        TreeNode Node;
        public int UnitID { get; set; }
        public int TypeID { get; set; }
        public int DutyID { get; set; }
        public int DutyTypeID { get; set; }
        public int ElemeID { get; set; }
        public int ProductID { get; set; }

        public Dict()
        {
            context = new EFModel();
            InitializeComponent();
            StructTreeLoad(Node);
            tvStruct.ExpandAll();
            type = new ProdTypes(tvProd, btnAddType, btnDeleteType, txtTypeName);
            duty = new ProdDuty(tvDuty,txtDutyName,lbProd,cmbDutyTypes);
            elem = new ProdElem(tvElem,txtElemName,cmbElem);
            product = new Product(tvProduct, txtProdName, cmbProdElem, txtProdDescript,dgvElem,txtQuan);
        }
        #region Struct
        public void StructTreeLoad(TreeNode node)
        {
            List<genOrgUnit> listaDzialGl = context.genOrgUnits.ToList();//Find(x => x.IdHigherOrgUnit == null).ToList();
            listaDzialGl = listaDzialGl.FindAll(l => l.IdHigherOrgUnit == null);
            listaDzialGl.ForEach(delegate (genOrgUnit dep)
            {
                node = new TreeNode();
                node.Text = dep.Name;
                node.Name = dep.IdOrgUnit.ToString();
                tvStruct.Nodes.Add(node);
                bool IsParent = (context.genOrgUnits.Count(d => d.IdHigherOrgUnit == dep.IdOrgUnit)) > 0;

                if (IsParent)
                {
                    var listaDzialPdr = context.genOrgUnits.ToList();
                    listaDzialPdr = listaDzialPdr.FindAll(x => x.IdHigherOrgUnit == dep.IdOrgUnit).ToList();
                    GetChildNodes(listaDzialPdr, node);
                }
            }
            );
        }
        public void GetChildNodes(List<genOrgUnit> listaDzialPdr, TreeNode node)
        {
            var ListaDep = context.genOrgUnits.ToList();
            TreeNode childNode;
            listaDzialPdr.ForEach(delegate (genOrgUnit Child_dep)
            {
                childNode = new TreeNode();
                childNode.Text = Child_dep.Name;
                childNode.Name = Child_dep.IdOrgUnit.ToString();
                childNode.ImageIndex = 0;
                childNode.SelectedImageIndex = 0;
                node.Nodes.Add(childNode);
                int DepId = Convert.ToInt32(childNode.Name);

                bool IsParent = (context.genOrgUnits.Count(d => d.IdHigherOrgUnit == Child_dep.IdOrgUnit)) > 0;

                if (IsParent)
                {
                    listaDzialPdr = ListaDep.FindAll(x => x.IdOrgUnit == Child_dep.IdOrgUnit);
                    GetChildNodes(listaDzialPdr, childNode);
                }

            });
            
        }

        private void tvStruct_AfterSelect(object sender, TreeViewEventArgs e)
        {
            UnitID = Convert.ToInt32(e.Node.Name);
        }

        private void btnAddBranch_Click(object sender, EventArgs e)
        {
            var Unit = new genOrgUnit();
            try
            {
                Unit.Name = txtBranch.Text;
                Unit.IdHigherOrgUnit = null;
                context.genOrgUnits.Add(Unit);
                context.SaveChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            tvStruct.Nodes.Clear();
            StructTreeLoad(Node);
            tvStruct.ExpandAll();
        }

        private void btnAddBranchLow_Click(object sender, EventArgs e)
        {
            var Unit = new genOrgUnit();
            try
            {
                Unit.Name = txtBranchLow.Text;
                Unit.IdHigherOrgUnit = Convert.ToInt32(cmbBranch.SelectedValue);
                context.genOrgUnits.Add(Unit);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            tvStruct.Nodes.Clear();
            StructTreeLoad(Node);
            tvStruct.ExpandAll();
        }

        private void tpStruct_Enter(object sender, EventArgs e)
        {
            cmbBranch.DataSource = context.genOrgUnits.ToList();
            cmbBranch.ValueMember = "IdOrgUnit";
            cmbBranch.DisplayMember = "Name";
        }

        private void btnDeleteStruct_Click(object sender, EventArgs e)
        {
            if (UnitID > 0)
            {
                try
                {
                    var Unit = new genOrgUnit();
                    Unit = context.genOrgUnits.FirstOrDefault(u => u.IdOrgUnit == UnitID);
                    context.genOrgUnits.Attach(Unit);
                    context.genOrgUnits.Remove(Unit);
                    context.SaveChanges();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    txtBranch.Text = String.Empty;
                    txtBranchLow.Text = String.Empty;
                    tvStruct.Nodes.Clear();
                    StructTreeLoad(Node);
                    tvStruct.ExpandAll();
                }
            }
            else
            {
                MessageBox.Show("Wybierz wydział do usunięcia!");
            }
        }
        #endregion
        #region Types
        private void btnAddType_Click(object sender, EventArgs e)
        {
            type.ButtonAdd(txtTypeName.Text);
            TypeID = 0;
            elem.ComboLoad();
            duty.ComboLoad();
        }

        private void btnDeleteType_Click(object sender, EventArgs e)
        {
            if (TypeID > 0) type.ButtonDelete(TypeID);
            else MessageBox.Show("Wybierz typ!");
            TypeID = 0;
        }

        private void tvProd_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TypeID = Convert.ToInt32(e.Node.Name);
        }

        #endregion
        #region Duty
        private void tvDuty_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DutyID = Convert.ToInt32(e.Node.Name);
            duty.ListBoxLoad(DutyID);
            duty.ComboLoad();

        }
      
        private void btnDutySave_Click(object sender, EventArgs e)
        {
            duty.ButtonAdd(txtDutyName.Text);
        }

        private void btnDutyDelete_Click(object sender, EventArgs e)
        {
            duty.ButtonDelete(DutyID);
        }

        private void btnAddTypeDuty_Click(object sender, EventArgs e)
        {
            if (DutyID > 0)
            {
                duty.ButtonTypeAdd(DutyID, Convert.ToInt32(cmbDutyTypes.SelectedValue));
            }
            else
            {
                MessageBox.Show("Wybierz obowiązek!");
            }
        }

        private void btnDutyTypeDelete_Click(object sender, EventArgs e)
        {
            duty.ButtonTypeDelete(DutyID,DutyTypeID);
        }
        private void lbProd_SelectedIndexChanged(object sender, EventArgs e)
        {         
            zadType t = new zadType();
            t = (zadType)lbProd.SelectedItem;
            if (t != null) DutyTypeID = t.IdType;
            else DutyTypeID = 0;
        }
        #endregion
        #region Element
        private void btnElemAdd_Click(object sender, EventArgs e)
        {
            try
            {
                elem.ButtonAdd(txtElemName.Text, Convert.ToInt32(cmbElem.SelectedValue));
                product.ComboLoad();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                txtElemName.Text = String.Empty;
                elem.TreeLoad(Node);
                ElemeID = 0;
            }
        }
       

        private void tvElem_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ElemeID = Convert.ToInt32(e.Node.Name);
        }

        private void btnElemDel_Click(object sender, EventArgs e)
        {
            if (ElemeID > 0)
            {
                elem.ButtonDelete(ElemeID);
            }
            ElemeID = 0;
        }
        #endregion
        #region Product
        private void btnProdAdd_Click(object sender, EventArgs e)
        {
            zadProduct prod = new zadProduct();
            try
            {
                prod.Active = true;
                prod.Description = txtProdDescript.Text;
                prod.Name = txtProdName.Text;
                context.zadProducts.Add(prod);
                context.SaveChanges();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                product.TreeLoad(Node);
                txtProdDescript.Text = String.Empty;
                txtProdName.Text = String.Empty;
            }
        }

        private void btnProdDel_Click(object sender, EventArgs e)
        {
            if (ProductID > 0)
            {
                DialogResult res = MessageBox.Show("Czy na pewno usunąć wybrany produkt?", "Usuwanie", MessageBoxButtons.OKCancel);
                if (res == DialogResult.OK)
                {
                    try
                    {
                        product.ButtonDelete(ProductID);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        txtProdDescript.Text = String.Empty;
                        txtQuan.Text = String.Empty;
                        txtProdName.Text = String.Empty;
                        product.TreeLoad(Node);
                    }
                }
            }
            else
            {
                MessageBox.Show("Wybierz produkt!");
            }
        }

        private void btnProdElemAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int ElementId = Convert.ToInt32(cmbProdElem.SelectedValue);
                int Quan = Convert.ToInt32(txtQuan.Text);
                product.ButtonElemAdd(ProductID, ElementId, Quan);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dgvElem.DataSource = null;
                product.BindGrid(ProductID);
            }
        }

        private void btnPodElemeDel_Click(object sender, EventArgs e)
        {
            if (ProductID > 0 && dgvElem.SelectedRows.Count>0)
            {
                try
                {
                    
                    ElemeID= Convert.ToInt32(dgvElem.SelectedRows[0].Cells["ElemId"].FormattedValue .ToString());
                    product.ButtonElemDelete(ProductID, ElemeID);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    product.BindData(ProductID);
                }
            }
            else
            {
                MessageBox.Show("Wybierz produkt i jego element!");
            }

        }

        private void tvProduct_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ProductID = Convert.ToInt32(e.Node.Name);
            if (ProductID > 0)
            {
                product.BindData(ProductID);
            }
        }

        private void btnSaveProdData_Click(object sender, EventArgs e)
        {
            if (ProductID > 0)
            {
                product.ButtonSave(ProductID);
                
            }
            else
            {
                MessageBox.Show("Wybierz produkt!");
            }
        }
        #endregion
    }
}
