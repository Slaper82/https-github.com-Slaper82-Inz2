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
    public partial class FrmElements : Form
    {
        EFModel context;
        public int TypeID { get; set; }
        List<zadElement> ElemList;
        public FrmElements(int _typeID)
        {
            ElemList = new List<zadElement>();
            context = new EFModel();
            this.TypeID = _typeID;
            InitializeComponent();
            ListLoad();
        }
        public void ListLoad()
        {
            ElemList = context.zadElements.ToList();
            lbElems.DataSource = ElemList;
            lbElems.DisplayMember = "Name";
            lbElems.ValueMember = "IdElement";
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            try
            {
                int elementID = Convert.ToInt32(lbElems.SelectedValue);
                var elem = context.zadElements.FirstOrDefault(el => el.IdElement == elementID);
                elem.IdType = TypeID;
                context.Entry(elem).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
               // context.zadElements.Attach(elem);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
