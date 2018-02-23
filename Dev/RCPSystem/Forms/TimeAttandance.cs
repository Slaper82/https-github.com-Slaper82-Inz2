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

namespace RCPSystem
{
    public partial class TimeAttandance : Form
    {
        EFModel context;
        TreeNode Node;
        FrmHelpers helper;
        public int UserID { get; set; }
        public genUser Users { get; set; }
        public List<genOrgUnit> ListaDep { get; set; }
        public List<genUser> UsersList { get; set; }

        public List<rcpTransactionAll>TransactionList { get; set; }

        public TimeAttandance()
        {
            context = new EFModel();
            InitializeComponent();
            ListaDep = context.genOrgUnits.ToList();
            UsersList = context.genUsers.ToList();
            helper = new FrmHelpers(tvUsers);
            helper.TreeLoad();
            TransactionList = new List<rcpTransactionAll>();
            TransactionList = context.rcpTransactionAlls.ToList();
        }
        public void FormReload()
        {
            TransactionList = context.rcpTransactionAlls.ToList();
        }
        public void DgvReload(int UserID)
        {
            dgvTransactions.DataSource = null;
            var trans =( from t in context.rcpTransactionAlls
                        join user in context.genUsers on t.IdUser equals user.IdUser
                        join typ in context.rcpTranTypes on t.IdTransType equals typ.IdTranType
                        where t.IdUser == UserID
                        select new { Id = t.IdTrans, Data = t.DateAndTime, Typ_Transakcji = typ.Name, Nazwa_uzytkownika = user.Name+" " + user.Surname }).ToList();



            if (trans.Count > 0)
            {
                dgvTransactions.DataSource = trans;
                
                dgvTransactions.RowsDefaultCellStyle.BackColor = Color.LightBlue;
                dgvTransactions.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
                dgvTransactions.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dgvTransactions.Font = new Font("SegoeUI", 14);
            }
            else
            {
                dgvTransactions.DataSource = null;
            }
        }

        private void tvUsers_AfterSelect(object sender, TreeViewEventArgs e)
        {
            int index = e.Node.ImageIndex;
            UserID = 0;
            this.Users = null;
            if (index > 0)
            {
                UserID = Convert.ToInt32(e.Node.Name);
                DgvReload(UserID);
            }
        }

        private void dgvTransactions_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dgvTransactions.Rows[e.RowIndex].Cells["lp"].Value = (e.RowIndex + 1).ToString();
        }
    }
}
