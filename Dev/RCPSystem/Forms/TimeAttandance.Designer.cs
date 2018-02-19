namespace RCPSystem
{
    partial class TimeAttandance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tvUsers = new System.Windows.Forms.TreeView();
            this.tcTimeAtt = new System.Windows.Forms.TabControl();
            this.tHarmo = new System.Windows.Forms.TabPage();
            this.tTransactions = new System.Windows.Forms.TabPage();
            this.tPairs = new System.Windows.Forms.TabPage();
            this.gbTime = new System.Windows.Forms.GroupBox();
            this.dtpStop = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBegin = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.tcTimeAtt.SuspendLayout();
            this.gbTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvUsers
            // 
            this.tvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvUsers.Location = new System.Drawing.Point(16, 230);
            this.tvUsers.Name = "tvUsers";
            this.tvUsers.Size = new System.Drawing.Size(325, 712);
            this.tvUsers.TabIndex = 0;
            // 
            // tcTimeAtt
            // 
            this.tcTimeAtt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcTimeAtt.Controls.Add(this.tHarmo);
            this.tcTimeAtt.Controls.Add(this.tTransactions);
            this.tcTimeAtt.Controls.Add(this.tPairs);
            this.tcTimeAtt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tcTimeAtt.Location = new System.Drawing.Point(369, 230);
            this.tcTimeAtt.Name = "tcTimeAtt";
            this.tcTimeAtt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tcTimeAtt.SelectedIndex = 0;
            this.tcTimeAtt.Size = new System.Drawing.Size(1471, 712);
            this.tcTimeAtt.TabIndex = 1;
            // 
            // tHarmo
            // 
            this.tHarmo.Location = new System.Drawing.Point(4, 37);
            this.tHarmo.Name = "tHarmo";
            this.tHarmo.Padding = new System.Windows.Forms.Padding(3);
            this.tHarmo.Size = new System.Drawing.Size(1463, 671);
            this.tHarmo.TabIndex = 0;
            this.tHarmo.Text = "Harmonogram";
            this.tHarmo.UseVisualStyleBackColor = true;
            // 
            // tTransactions
            // 
            this.tTransactions.Location = new System.Drawing.Point(4, 37);
            this.tTransactions.Name = "tTransactions";
            this.tTransactions.Padding = new System.Windows.Forms.Padding(3);
            this.tTransactions.Size = new System.Drawing.Size(1463, 671);
            this.tTransactions.TabIndex = 1;
            this.tTransactions.Text = "Transakcje";
            this.tTransactions.UseVisualStyleBackColor = true;
            // 
            // tPairs
            // 
            this.tPairs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tPairs.Location = new System.Drawing.Point(4, 37);
            this.tPairs.Name = "tPairs";
            this.tPairs.Padding = new System.Windows.Forms.Padding(3);
            this.tPairs.Size = new System.Drawing.Size(1463, 671);
            this.tPairs.TabIndex = 2;
            this.tPairs.Text = "Pary transakcji";
            this.tPairs.UseVisualStyleBackColor = true;
            // 
            // gbTime
            // 
            this.gbTime.Controls.Add(this.btnEnd);
            this.gbTime.Controls.Add(this.btnBegin);
            this.gbTime.Controls.Add(this.dtpStop);
            this.gbTime.Controls.Add(this.dtpStart);
            this.gbTime.Controls.Add(this.label2);
            this.gbTime.Controls.Add(this.label1);
            this.gbTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbTime.Location = new System.Drawing.Point(16, 29);
            this.gbTime.Name = "gbTime";
            this.gbTime.Size = new System.Drawing.Size(533, 174);
            this.gbTime.TabIndex = 2;
            this.gbTime.TabStop = false;
            this.gbTime.Text = "Zakres raportu";
            // 
            // dtpStop
            // 
            this.dtpStop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpStop.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStop.Location = new System.Drawing.Point(12, 116);
            this.dtpStop.Name = "dtpStop";
            this.dtpStop.Size = new System.Drawing.Size(261, 34);
            this.dtpStop.TabIndex = 3;
            // 
            // dtpStart
            // 
            this.dtpStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(10, 55);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(263, 34);
            this.dtpStart.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(9, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Koniec";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Początek";
            // 
            // btnBegin
            // 
            this.btnBegin.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBegin.Location = new System.Drawing.Point(298, 55);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(188, 34);
            this.btnBegin.TabIndex = 4;
            this.btnBegin.Text = "Początek okresu";
            this.btnBegin.UseVisualStyleBackColor = true;
            // 
            // btnEnd
            // 
            this.btnEnd.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEnd.Location = new System.Drawing.Point(298, 116);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(188, 34);
            this.btnEnd.TabIndex = 5;
            this.btnEnd.Text = "Koniec okresu";
            this.btnEnd.UseVisualStyleBackColor = true;
            // 
            // TimeAttandance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1874, 917);
            this.Controls.Add(this.gbTime);
            this.Controls.Add(this.tcTimeAtt);
            this.Controls.Add(this.tvUsers);
            this.Name = "TimeAttandance";
            this.Text = "TimeAttandance";
            this.tcTimeAtt.ResumeLayout(false);
            this.gbTime.ResumeLayout(false);
            this.gbTime.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvUsers;
        private System.Windows.Forms.TabControl tcTimeAtt;
        private System.Windows.Forms.TabPage tHarmo;
        private System.Windows.Forms.TabPage tTransactions;
        private System.Windows.Forms.TabPage tPairs;
        private System.Windows.Forms.GroupBox gbTime;
        private System.Windows.Forms.DateTimePicker dtpStop;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnBegin;
    }
}