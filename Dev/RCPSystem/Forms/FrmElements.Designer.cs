namespace RCPSystem.Forms
{
    partial class FrmElements
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
            this.btnChoose = new System.Windows.Forms.Button();
            this.lbElems = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(119, 371);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(190, 58);
            this.btnChoose.TabIndex = 0;
            this.btnChoose.Text = "Wybierz zaznaczony element";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // lbElems
            // 
            this.lbElems.FormattingEnabled = true;
            this.lbElems.ItemHeight = 16;
            this.lbElems.Location = new System.Drawing.Point(58, 31);
            this.lbElems.Name = "lbElems";
            this.lbElems.Size = new System.Drawing.Size(330, 260);
            this.lbElems.TabIndex = 1;
            // 
            // FrmElements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 498);
            this.Controls.Add(this.lbElems);
            this.Controls.Add(this.btnChoose);
            this.Name = "FrmElements";
            this.Text = "Wybierz element";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.ListBox lbElems;
    }
}