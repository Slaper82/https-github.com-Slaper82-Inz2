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


        EFModel context;
        TreeNode Node;
        public int UnitID { get; set; }
        public int TypeID { get; set; }
        public int DutyID { get; set; }
        public Dict()
        {
            context = new EFModel();
            InitializeComponent();
            StructTreeLoad(Node);
            tvStruct.ExpandAll();
            type = new ProdTypes(tvProd, btnAddType, btnDeleteType, txtTypeName);
            duty = new ProdDuty(tvDuty,txtDutyName,lvProd);
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

        }
      
        private void btnDutySave_Click(object sender, EventArgs e)
        {
            duty.ButtonAdd();
        }

        private void btnDutyDelete_Click(object sender, EventArgs e)
        {
            duty.ButtonDelete(DutyID);
        }

        private void btnAddTypeDuty_Click(object sender, EventArgs e)
        {
            //duty.ButtonTypeAdd();
        }

        private void btnDutyTypeDelete_Click(object sender, EventArgs e)
        {
            duty.ButtonTypeDelete();
        }
        #endregion
    }
}
