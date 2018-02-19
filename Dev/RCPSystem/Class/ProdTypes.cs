using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace RCPSystem.Class
{
    class ProdTypes
    {
        EFModel context;
        TreeView Tree;
        Button Add;
        Button Delete;
        TextBox Name;
        TreeNode Node;
        List<zadType> Types;
        public ProdTypes(TreeView _tree,Button _add,Button _delete,TextBox _name)
        {

            context = new EFModel();              
            this.Tree = _tree;
            this.Add = _add;
            this.Delete = _delete;
            this.Name = _name;
            Types = new List<zadType>();
            TreeLoad(Node);
            

        }

        public void TreeLoad(TreeNode node)
        {
            var Types= context.zadTypes.ToList();//Find(x => x.IdHigherOrgUnit == null).ToList();
            
            Types.ForEach(delegate (zadType dep)
            {
                node = new TreeNode();
                if (dep.Active)
                {
                    node.Text = dep.TypeName;
                    node.Name = dep.IdType.ToString();
                    this.Tree.Nodes.Add(node);
                }
            }
            );
        }
        public void ButtonAdd(string Name)
        {
            try
            {
                var zad = new zadType();
                zad.TypeName = Name;
                zad.Active = true;
                context.zadTypes.Add(zad);
                context.SaveChanges();
            }
            catch(Exception ex)
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
                var zad = context.zadTypes.FirstOrDefault(z => z.IdType == Id);
                zad.Active = false;
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
