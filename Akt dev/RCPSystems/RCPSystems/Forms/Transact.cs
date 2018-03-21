﻿using System;
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

namespace RCPSystems.Forms
{
    public partial class Transact : Form
    {
        EFModel context;
        public int UserID { get; set; }
        public int TaskID { get; set; }

        public int MyTaskID { get; set; }
        public string ErrorMessage { get; set; }
        public Transact(int _userId)
        {
            this.UserID = _userId;
            context = new EFModel();
            InitializeComponent();
            dgvTaskLoad();
            dgvMyTaskLoad();
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
        private void btnPause_Click(object sender, EventArgs e)
        {
            if (MyTaskID > 0)
            {
                bool isPaused = (context.zadTaskProductions.FirstOrDefault(t => t.IdTask == MyTaskID && t.Start == null && t.Stop == null)) != null;
                
                if (!isPaused)
                {
                    var Mytask = context.zadTaskProductions.FirstOrDefault(t => t.IdTask == MyTaskID);
                    Mytask.Stop = DateTime.Now;
                    Mytask.AddInfo = "Zatrzymano pracę: " + DateTime.Now;

                    context.Entry(Mytask).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();

                    var MyPauseTask = new zadTaskProduction
                    {
                        IdUser = Mytask.IdUser,
                        IdTask = Mytask.IdTask,
                        Active = true,
                        Start = null,
                        Stop = null
                    };
                    context.zadTaskProductions.Add(MyPauseTask);
                    context.SaveChanges();
                    dgvMyTaskLoad();
                }
            }
        }
        private void btnRun_Click(object sender, EventArgs e)
        {
            if (MyTaskID > 0)
            {
                bool isPaused = (context.zadTaskProductions.FirstOrDefault(t => t.IdTask == MyTaskID && t.Start == null && t.Stop == null)) != null;

                if (isPaused)
                {
                    var Mytask = context.zadTaskProductions.FirstOrDefault(t => t.IdTask == MyTaskID && t.Start == null && t.Stop == null);
                    Mytask.Start = DateTime.Now;
                    context.Entry(Mytask).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                    dgvMyTaskLoad();
                }
            }
        }

        private void btnStartZad_Click(object sender, EventArgs e)
        {
            if (TaskID > 0)
            {
                try
                {                 
                    zadTaskProduction task = new zadTaskProduction()
                    {
                        IdUser = UserID,
                        IdTask=TaskID,
                        Start = DateTime.Now,
                        Active = true,
                        Stop = null
                    };
                   context.zadTaskProductions.Add(task);
                    context.SaveChanges();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    dgvTaskLoad();
                    dgvMyTaskLoad();
                }

            }
            else
            {
                MessageBox.Show("Wybierz zadanie z listy");
            }
        }

        private void dgvTaskLoad()
        {
            context.Dispose();
            context = new EFModel();

              var TaskIds = (from id in context.zadTaskProductions
                           select id.IdTask).ToList();

            var tasks = (context.zadTaskLists.Where(t => !TaskIds.Any(tp => tp.Value == t.IdTask))).ToList();

            var TaskForUser = (from t in tasks
                              join elem in context.zadElements on t.IdElement equals elem.IdElement
                              join type in context.zadTypes on elem.IdType equals type.IdType
                              join dutTyp in context.zadDutyTypes on type.IdType equals dutTyp.IdType
                              join userDut in context.zadUserDuties on dutTyp.IdDuty equals userDut.IdDuty
                              where userDut.IdUser == UserID && t.Active==true
                              select t).ToList();



           // tasks = tasks.FindAll(t => t.Active == true);



            var ds = (from t in TaskForUser
                     select new { t.IdTask, t.IdOrder, t.Quantity, t.Done }).ToList();

            
            dgvTask.AutoGenerateColumns = false;
            dgvTask.DataSource = ds;
            dgvTask.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvTask.AutoResizeColumns();

        }
        private void dgvMyTaskLoad()
        {
            var task = context.zadTaskProductions.ToList();
            task = task.FindAll(t => t.IdUser.Equals(UserID));

            var ds = (from t in task
                      select new { t.IdTask, t.Start, t.Stop, t.AddInfo }).ToList();

            dgvMyTasks.AutoGenerateColumns = false;
            dgvMyTasks.DataSource = ds;
            dgvMyTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvMyTasks.AutoResizeColumns();
        }

        private void btnTaskEnd_Click(object sender, EventArgs e)
        {
            if (MyTaskID > 0)
            {
                try
                {
                    var Mytask = context.zadTaskProductions.FirstOrDefault(t => t.IdTask == MyTaskID);

                    Mytask.Stop = DateTime.Now;
                    
                    context.Entry(Mytask).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    dgvTaskLoad();
                    dgvMyTaskLoad();
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvTaskLoad();
        }

        private void dgvTask_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected && e.Row.Index >= 0) return;
            else
            {
                if (dgvTask.SelectedRows.Count > 0)
                {
                    TaskID = Convert.ToInt32(dgvTask.SelectedRows[0].Cells["IdTask"].Value.ToString());
                }

            }
        }

        private void dgvMyTasks_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected && e.Row.Index >= 0) return;
            else
            {
                if (dgvMyTasks.SelectedRows.Count > 0)
                {
                    MyTaskID = Convert.ToInt32(dgvMyTasks.SelectedRows[0].Cells["IdMyTask"].Value.ToString());
                }

            }
        }

     
    }
}
