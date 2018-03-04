using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RCPSystem.Class
{
    class ProdElem
    {
        EFModel context;
        TreeView Tree;     
        TextBox Name;
        TreeNode Node;
        ComboBox combo;
        List<zadElement> Elem;
        public ProdElem(TreeView _tree, TextBox _name,ComboBox _combo)
        {

            context = new EFModel();
            this.Tree = _tree;
            this.Name = _name;
            this.combo = _combo;
            Elem = new List<zadElement>();
            TreeLoad(Node);
            ComboLoad();
        }
        public void ComboLoad()
        {
            var List = context.zadTypes.ToList();
            List = List.FindAll(l => l.Active != false);
            combo.DataSource = List;
            combo.ValueMember = "IdType";
            combo.DisplayMember = "TypeName"; 
        }
        public void TreeLoad(TreeNode node)
        {
            Tree.Nodes.Clear();
            var Types = context.zadElements.ToList();//Find(x => x.IdHigherOrgUnit == null).ToList();

            Types.ForEach(delegate (zadElement dep)
            {
                node = new TreeNode();
                if (dep.Active)
                {
                    node.Text = dep.Name;
                    node.Name = dep.IdElement.ToString();

                    this.Tree.Nodes.Add(node);
                }
            }
            );
            Tree.ExpandAll();
        }
        public void ButtonAdd(string Name,int TypeId)
        {
            try
            {
                var elem = new zadElement();
                elem.Name = Name;
                elem.Active = true;
                elem.IdType = TypeId;
                context.zadElements.Add(elem);
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
        public void ButtonDelete(int Id)
        {
            try
            {
                var elem = context.zadElements.FirstOrDefault(z => z.IdElement == Id);
                elem.Active = false;
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
    }
}
