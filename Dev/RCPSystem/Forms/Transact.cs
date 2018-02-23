using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RCPSystem.Forms
{
    public partial class Transact : Form
    {
        EFModel context;
        public int UserID { get; set; }
        public int TaskID { get; set; }
        public string ErrorMessage { get; set; }
        public Transact(int _userId)
        {
            this.UserID = _userId;
            context = new EFModel();
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var tranType = context.rcpTranTypes.FirstOrDefault(t => t.Name.Equals("Start"));
            TranAdd(tranType.IdTranType,out string ErrorMessage);
            if (ErrorMessage != String.Empty)
            {
                MessageBox.Show(ErrorMessage);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            
            var tranType = context.rcpTranTypes.FirstOrDefault(t => t.Name.Equals("Stop"));
            TranAdd(tranType.IdTranType, out string ErrorMessage);
            if (ErrorMessage != String.Empty)
            {
                MessageBox.Show(ErrorMessage);
            }
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            var tranType = context.rcpTranTypes.FirstOrDefault(t => t.Name.Equals("Przerwa"));
            TranAdd(tranType.IdTranType, out string ErrorMessage);
            if (ErrorMessage != String.Empty)
            {
                MessageBox.Show(ErrorMessage);
            }
        }

        private void btnBreakOff_Click(object sender, EventArgs e)
        {
            var tranType = context.rcpTranTypes.FirstOrDefault(t => t.Name.Equals("Koniec przerwy"));
            TranAdd(tranType.IdTranType, out string ErrorMessage);
            if (ErrorMessage != String.Empty)
            {
                MessageBox.Show(ErrorMessage);
            }
        }

        private void btnStartZad_Click(object sender, EventArgs e)
        {
            if (dgvTask.SelectedRows.Count > 0)
            {
                try
                {
                    TaskID = Convert.ToInt32(dgvTask.SelectedRows[0].Cells["IdTask"].FormattedValue.ToString());
                    zadTaskProduction task = new zadTaskProduction()
                    {
                        IdUser = UserID,
                        Start = DateTime.Now,
                        Active = true,
                        Stop = null
                    };
                    context.zadTaskProductions.Add(task);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Wybierz zadanie z listy");
            }
        }

        private void btnTaskEnd_Click(object sender, EventArgs e)
        {
            //TODO: jak będzie moduł z zadaniami to wtedy 
            if (dgvMyTasks.SelectedRows.Count > 0)
            {
                try
                {
                    TaskID = Convert.ToInt32(dgvTask.SelectedRows[0].Cells["IdTask"].FormattedValue.ToString());
                   // var tas = context.
                    zadTaskProduction task = new zadTaskProduction()
                    {
                        IdUser = UserID,
                        Start = DateTime.Now,
                        Active = true,
                        Stop = null
                    };
                    context.zadTaskProductions.Add(task);
                    context.SaveChanges();     
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    //dgv Reload
                    //dgvMyTask Reload
                }

            }
            else
            {
                MessageBox.Show("Wybierz zadanie z listy");
            }
        }

        private void TranAdd(int TranType,out string errorMessage)
        {
            errorMessage = String.Empty;
            bool save;
            try
            {
                rcpTransactionAll tran = new rcpTransactionAll()
                {
                    DateAndTime = DateTime.Now,
                    IdUser = this.UserID,
                    IdTransType = TranType
                };
                context.rcpTransactionAlls.Add(tran);
                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    errorMessage=ex.Message;
                }
            }
            catch (Exception ex)
            {
                errorMessage=ex.Message;
            }
        }
    }
}
