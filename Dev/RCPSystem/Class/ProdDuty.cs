using RCPSystem.DbClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RCPSystem.Class
{
    public class ProdDuty
    {
        EFModel context;    
        TextBox Name; 
        ListBox listBox;
        ComboBox combo;
        DataGridView dgvDuty;
        DataGridView dgvTask;

        public ProdDuty(TextBox _name,ListBox _list, DataGridView _dgvDuty, DataGridView _dgvTask)
        {
            context = new EFModel();
            context.Configuration.ProxyCreationEnabled = false;
            this.dgvDuty = _dgvDuty;
            this.dgvTask = _dgvTask;
            this.Name = _name;
            this.listBox = _list;
            //ComboLoad();
            GridDutyLoad();
        }
        public void GridDutyLoad()
        {
            var duties = context.zadDutys.ToList();
            dgvDuty.DataSource = duties;
            dgvDuty.Refresh();
        }

        public void GridDutyTaskLoad(int DutyID)
        {
            var list = context.zadTypes.ToList();
            var Source = (from type in context.zadTypes
                          join duty in context.zadDutyTypes on type.IdType equals duty.IdType
                          where duty.IdDuty == DutyID
                          select type).ToList();
            List<zadType> zad = Source.ToList();

            var duties = context.zadDutys.ToList();
            dgvTask.DataSource = zad;
            dgvTask.Refresh();
        }
        public void ListBoxLoad(int DutyId)
        {
            listBox.DataSource = null;
            var list = context.zadTypes.ToList();
            var Source = (from type in context.zadTypes
                                 join duty in context.zadDutyTypes on type.IdType equals duty.IdType
                                 where duty.IdDuty == DutyId
                                 select type).ToList();
            List<zadType> zad= Source.ToList();
            listBox.DataSource = zad;
            listBox.ValueMember = "IdType";
            listBox.DisplayMember = "TypeName";
           // listView.Items.A = context.zadTypes.ToList();
        }
        //public void ComboLoad()
        //{
        //    var list = context.zadTypes.ToList();
        //    combo.DataSource = list.FindAll(l => l.Active != false);
        //    combo.ValueMember = "IdType";
        //    combo.DisplayMember = "TypeName";
        //}
        //public void TreeLoad(TreeNode node)
        //{
        //    var Types = context.zadDutys.ToList();//zmienić typ na nowy

        //    Types.ForEach(delegate (zadDuty dep)
        //    {
        //        node = new TreeNode();           
        //            node.Text = dep.Name;
        //            node.Name = dep.IdDuty.ToString();
        //            this.Tree.Nodes.Add(node);             
        //    }
        //    );
        //}
        public void ButtonAdd(string Name)
        {
            zadDuty zad = new zadDuty();
            try
            {
                zad.Name = Name;
                context.zadDutys.Add(zad);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                GridDutyLoad();
                this.Name.Text = String.Empty;
            }
        }
        public void ButtonDelete(int DutyId)
        {
            var listType = context.zadDutyTypes.ToList();
            listType = listType.FindAll(d => d.IdDuty == DutyId);
            var duty = context.zadDutys.FirstOrDefault(d => d.IdDuty == DutyId);
            try
            {
                foreach(zadDutyType z in listType)
                {
                    context.zadDutyTypes.Attach(z);
                    context.zadDutyTypes.Remove(z);
                    context.SaveChanges();
                }
                context.zadDutys.Attach(duty);
                context.zadDutys.Remove(duty);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                GridDutyLoad();
                listBox.DataSource = null;
                this.Name.Text = String.Empty;

            }
        }
        public void ButtonTypeAdd(int DutyId, int TypeId)
        {
            zadDutyType zadTyp = new zadDutyType();
            try
            {
                zadTyp.IdDuty = DutyId;
                zadTyp.IdType = TypeId;
               context.zadDutyTypes.Add(zadTyp);
                //zad.Active = false;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                GridDutyTaskLoad(DutyId);
                //ListBoxLoad(DutyId);
                //listView.Load pewnie contextem.
                this.Name.Text = String.Empty;

            }
        }
        public void ButtonTypeDelete(int DutyId,int TypeId)
        {
            zadDutyType zadTyp = new zadDutyType();
            zadTyp = context.zadDutyTypes.FirstOrDefault(du => du.IdDuty == DutyId && du.IdType == TypeId);
            try
            {
                context.zadDutyTypes.Attach(zadTyp);
                context.zadDutyTypes.Remove(zadTyp);
                context.SaveChanges();
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
                GridDutyTaskLoad(DutyId);
                //ListBoxLoad(DutyId);
                //listView.Load pewnie contextem.
                this.Name.Text = String.Empty;

            }
        }
    }
}
