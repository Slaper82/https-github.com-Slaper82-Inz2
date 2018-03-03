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
    public delegate void ReloadValue(object sender, EventArgs e);
    public partial class Orders : Form
    {
        public int UserId { get; set; }
        NewOrder NewOrder;

        public Orders(int userId)
        {
            this.UserId = userId;
            InitializeComponent();
        }



        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            NewOrder = new NewOrder(UserId);
            NewOrder.Reload +=GridReload;
            NewOrder.ShowDialog();
        }

        private void GridReload(object sender, EventArgs e)
        {
            //przeładowanie grida
        }
    }
}
