namespace OOTPiSP__2
{
    partial class frmAdmin
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
            this.msAdmin = new System.Windows.Forms.MenuStrip();
            this.mSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mOpenFrom = new System.Windows.Forms.ToolStripMenuItem();
            this.tcAdmin = new System.Windows.Forms.TabControl();
            this.tpAicraft = new System.Windows.Forms.TabPage();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.bDel = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.lEditAdm = new System.Windows.Forms.Label();
            this.bAdd = new System.Windows.Forms.Button();
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.tpOrders = new System.Windows.Forms.TabPage();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.msAdmin.SuspendLayout();
            this.tcAdmin.SuspendLayout();
            this.tpAicraft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            this.tpOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // msAdmin
            // 
            this.msAdmin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.msAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mSaveAs,
            this.mOpenFrom});
            this.msAdmin.Location = new System.Drawing.Point(0, 0);
            this.msAdmin.Name = "msAdmin";
            this.msAdmin.Size = new System.Drawing.Size(903, 29);
            this.msAdmin.TabIndex = 13;
            // 
            // mSaveAs
            // 
            this.mSaveAs.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mSaveAs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mSaveAs.Name = "mSaveAs";
            this.mSaveAs.Size = new System.Drawing.Size(132, 25);
            this.mSaveAs.Text = "Сохранить как..";
            this.mSaveAs.Click += new System.EventHandler(this.mSaveAs_Click);
            // 
            // mOpenFrom
            // 
            this.mOpenFrom.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mOpenFrom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mOpenFrom.Name = "mOpenFrom";
            this.mOpenFrom.Size = new System.Drawing.Size(110, 25);
            this.mOpenFrom.Text = "Открыть из..";
            this.mOpenFrom.Click += new System.EventHandler(this.mOpenFrom_Click);
            // 
            // tcAdmin
            // 
            this.tcAdmin.Controls.Add(this.tpAicraft);
            this.tcAdmin.Controls.Add(this.tpOrders);
            this.tcAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tcAdmin.Location = new System.Drawing.Point(0, 29);
            this.tcAdmin.Name = "tcAdmin";
            this.tcAdmin.SelectedIndex = 0;
            this.tcAdmin.Size = new System.Drawing.Size(903, 548);
            this.tcAdmin.TabIndex = 14;
            // 
            // tpAicraft
            // 
            this.tpAicraft.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tpAicraft.Controls.Add(this.cbType);
            this.tpAicraft.Controls.Add(this.bDel);
            this.tpAicraft.Controls.Add(this.bEdit);
            this.tpAicraft.Controls.Add(this.lEditAdm);
            this.tpAicraft.Controls.Add(this.bAdd);
            this.tpAicraft.Controls.Add(this.dgvAdmin);
            this.tpAicraft.Location = new System.Drawing.Point(4, 29);
            this.tpAicraft.Name = "tpAicraft";
            this.tpAicraft.Padding = new System.Windows.Forms.Padding(3);
            this.tpAicraft.Size = new System.Drawing.Size(895, 515);
            this.tpAicraft.TabIndex = 0;
            this.tpAicraft.Text = "Аппараты";
            // 
            // cbType
            // 
            this.cbType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbType.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(674, 8);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(213, 32);
            this.cbType.TabIndex = 18;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // bDel
            // 
            this.bDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bDel.BackColor = System.Drawing.SystemColors.Control;
            this.bDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bDel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.bDel.Location = new System.Drawing.Point(636, 49);
            this.bDel.Name = "bDel";
            this.bDel.Size = new System.Drawing.Size(251, 40);
            this.bDel.TabIndex = 17;
            this.bDel.Text = "УДАЛИТЬ";
            this.bDel.UseVisualStyleBackColor = false;
            this.bDel.Click += new System.EventHandler(this.bDel_Click);
            // 
            // bEdit
            // 
            this.bEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bEdit.ForeColor = System.Drawing.SystemColors.Window;
            this.bEdit.Location = new System.Drawing.Point(360, 49);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(270, 40);
            this.bEdit.TabIndex = 16;
            this.bEdit.Text = "ИЗМЕНИТЬ";
            this.bEdit.UseVisualStyleBackColor = false;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // lEditAdm
            // 
            this.lEditAdm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lEditAdm.AutoSize = true;
            this.lEditAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lEditAdm.Location = new System.Drawing.Point(89, 11);
            this.lEditAdm.Name = "lEditAdm";
            this.lEditAdm.Size = new System.Drawing.Size(576, 24);
            this.lEditAdm.TabIndex = 15;
            this.lEditAdm.Text = "Для просмотра списка летательных аппаратов, выберите тип:";
            // 
            // bAdd
            // 
            this.bAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAdd.ForeColor = System.Drawing.SystemColors.Window;
            this.bAdd.Location = new System.Drawing.Point(93, 49);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(261, 40);
            this.bAdd.TabIndex = 14;
            this.bAdd.Text = "ДОБАВИТЬ";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.AllowUserToAddRows = false;
            this.dgvAdmin.AllowUserToDeleteRows = false;
            this.dgvAdmin.AllowUserToOrderColumns = true;
            this.dgvAdmin.AllowUserToResizeColumns = false;
            this.dgvAdmin.AllowUserToResizeRows = false;
            this.dgvAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAdmin.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmin.Location = new System.Drawing.Point(0, 95);
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.ReadOnly = true;
            this.dgvAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdmin.Size = new System.Drawing.Size(887, 416);
            this.dgvAdmin.TabIndex = 13;
            // 
            // tpOrders
            // 
            this.tpOrders.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tpOrders.Controls.Add(this.dgvOrders);
            this.tpOrders.Location = new System.Drawing.Point(4, 29);
            this.tpOrders.Name = "tpOrders";
            this.tpOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tpOrders.Size = new System.Drawing.Size(895, 515);
            this.tpOrders.TabIndex = 1;
            this.tpOrders.Text = "Заказы";
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.AllowUserToOrderColumns = true;
            this.dgvOrders.AllowUserToResizeColumns = false;
            this.dgvOrders.AllowUserToResizeRows = false;
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvOrders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.Location = new System.Drawing.Point(3, 3);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(889, 509);
            this.dgvOrders.TabIndex = 0;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 577);
            this.Controls.Add(this.tcAdmin);
            this.Controls.Add(this.msAdmin);
            this.MainMenuStrip = this.msAdmin;
            this.Name = "frmAdmin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.msAdmin.ResumeLayout(false);
            this.msAdmin.PerformLayout();
            this.tcAdmin.ResumeLayout(false);
            this.tpAicraft.ResumeLayout(false);
            this.tpAicraft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            this.tpOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip msAdmin;
        private System.Windows.Forms.ToolStripMenuItem mSaveAs;
        private System.Windows.Forms.ToolStripMenuItem mOpenFrom;
        private System.Windows.Forms.TabControl tcAdmin;
        private System.Windows.Forms.TabPage tpAicraft;
        protected internal System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Button bDel;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Label lEditAdm;
        private System.Windows.Forms.Button bAdd;
        protected internal System.Windows.Forms.DataGridView dgvAdmin;
        private System.Windows.Forms.TabPage tpOrders;
        private System.Windows.Forms.DataGridView dgvOrders;
    }
}