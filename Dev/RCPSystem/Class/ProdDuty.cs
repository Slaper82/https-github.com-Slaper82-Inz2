using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RCPSystem.Class
{
    class ProdDuty
    {
        EFModel context;
        TreeView Tree;      
        TextBox Name;
        TreeNode Node;
        ListView listView;
        List<zadType> Types;

        public ProdDuty(TreeView _tree, TextBox _name,ListView _list)
        {
            context = new EFModel();
            this.Tree = _tree;
            this.Name = _name;
            this.listView = _list;
        }
        public void TreeLoad(TreeNode node)
        {
            var Types = context.zadTypes.ToList();//zmienić typ na nowy

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
        public void ButtonAdd()
        {
            try
            {
               
                //context.zadTypes.Add(zad);
                //context.SaveChanges();
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
        public void ButtonDelete(int DutyId)
        {
            try
            {
                //var zad = context.zadTypes.FirstOrDefault(z => z.IdType == Id);
                //zad.Active = false;
                //context.SaveChanges();
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
        public void ButtonTypeAdd(int TypeId)
        {
            try
            {
                //var zad = context.zadTypes.FirstOrDefault(z => z.IdType == Id);
                //zad.Active = false;
                //context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                listView.Items.Clear();//czy coś takiego
                //listView.Load pewnie contextem.
                this.Name.Text = String.Empty;

            }
        }
        public void ButtonTypeDelete()
        {
            try
            {
                //var zad = context.zadTypes.FirstOrDefault(z => z.IdType == Id);
                //zad.Active = false;
                //context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {              
                this.Name.Text = String.Empty;
                listView.Items.Clear();//czy coś takiego
                //listView.Load

            }
        }
    }
}
