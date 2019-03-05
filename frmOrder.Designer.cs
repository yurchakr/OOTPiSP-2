namespace OOTPiSP__2
{
    partial class frmOrder
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
            this.gbUser = new System.Windows.Forms.GroupBox();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lWelc = new System.Windows.Forms.Label();
            this.gbAircraft = new System.Windows.Forms.GroupBox();
            this.tbMaxDist = new System.Windows.Forms.TextBox();
            this.tbMaxSp = new System.Windows.Forms.TextBox();
            this.tbTailNum = new System.Windows.Forms.TextBox();
            this.tbAcName = new System.Windows.Forms.TextBox();
            this.tbFlDur = new System.Windows.Forms.TextBox();
            this.dtpWhen = new System.Windows.Forms.DateTimePicker();
            this.bCancel = new System.Windows.Forms.Button();
            this.bOk = new System.Windows.Forms.Button();
            this.lWhen = new System.Windows.Forms.Label();
            this.cbPilot = new System.Windows.Forms.CheckBox();
            this.gbUser.SuspendLayout();
            this.gbAircraft.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbUser
            // 
            this.gbUser.BackColor = System.Drawing.SystemColors.Info;
            this.gbUser.Controls.Add(this.tbMail);
            this.gbUser.Controls.Add(this.tbName);
            this.gbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbUser.Location = new System.Drawing.Point(12, 70);
            this.gbUser.Name = "gbUser";
            this.gbUser.Size = new System.Drawing.Size(534, 113);
            this.gbUser.TabIndex = 0;
            this.gbUser.TabStop = false;
            this.gbUser.Text = "Личные данные";
            // 
            // tbMail
            // 
            this.tbMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbMail.Location = new System.Drawing.Point(6, 62);
            this.tbMail.Name = "tbMail";
            this.tbMail.ReadOnly = true;
            this.tbMail.Size = new System.Drawing.Size(518, 31);
            this.tbMail.TabIndex = 16;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbName.Location = new System.Drawing.Point(6, 25);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(518, 31);
            this.tbName.TabIndex = 15;
            // 
            // lWelc
            // 
            this.lWelc.AutoSize = true;
            this.lWelc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lWelc.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lWelc.Location = new System.Drawing.Point(149, 22);
            this.lWelc.Name = "lWelc";
            this.lWelc.Size = new System.Drawing.Size(255, 25);
            this.lWelc.TabIndex = 9;
            this.lWelc.Text = "ОФОРМЛЕНИЕ ЗАКАЗА";
            // 
            // gbAircraft
            // 
            this.gbAircraft.BackColor = System.Drawing.SystemColors.Info;
            this.gbAircraft.Controls.Add(this.tbMaxDist);
            this.gbAircraft.Controls.Add(this.tbMaxSp);
            this.gbAircraft.Controls.Add(this.tbTailNum);
            this.gbAircraft.Controls.Add(this.tbAcName);
            this.gbAircraft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbAircraft.Location = new System.Drawing.Point(12, 189);
            this.gbAircraft.Name = "gbAircraft";
            this.gbAircraft.Size = new System.Drawing.Size(534, 181);
            this.gbAircraft.TabIndex = 17;
            this.gbAircraft.TabStop = false;
            this.gbAircraft.Text = "Летательный аппарат";
            // 
            // tbMaxDist
            // 
            this.tbMaxDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMaxDist.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbMaxDist.Location = new System.Drawing.Point(6, 136);
            this.tbMaxDist.Name = "tbMaxDist";
            this.tbMaxDist.ReadOnly = true;
            this.tbMaxDist.Size = new System.Drawing.Size(518, 31);
            this.tbMaxDist.TabIndex = 18;
            // 
            // tbMaxSp
            // 
            this.tbMaxSp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMaxSp.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbMaxSp.Location = new System.Drawing.Point(6, 99);
            this.tbMaxSp.Name = "tbMaxSp";
            this.tbMaxSp.ReadOnly = true;
            this.tbMaxSp.Size = new System.Drawing.Size(518, 31);
            this.tbMaxSp.TabIndex = 17;
            // 
            // tbTailNum
            // 
            this.tbTailNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTailNum.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbTailNum.Location = new System.Drawing.Point(6, 62);
            this.tbTailNum.Name = "tbTailNum";
            this.tbTailNum.ReadOnly = true;
            this.tbTailNum.Size = new System.Drawing.Size(518, 31);
            this.tbTailNum.TabIndex = 16;
            // 
            // tbAcName
            // 
            this.tbAcName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAcName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbAcName.Location = new System.Drawing.Point(6, 25);
            this.tbAcName.Name = "tbAcName";
            this.tbAcName.ReadOnly = true;
            this.tbAcName.Size = new System.Drawing.Size(518, 31);
            this.tbAcName.TabIndex = 15;
            // 
            // tbFlDur
            // 
            this.tbFlDur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFlDur.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbFlDur.Location = new System.Drawing.Point(18, 376);
            this.tbFlDur.Name = "tbFlDur";
            this.tbFlDur.Size = new System.Drawing.Size(518, 31);
            this.tbFlDur.TabIndex = 19;
            this.tbFlDur.Text = "Введите продолжительность полета, мин";
            this.tbFlDur.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbFlDur_MouseDown);
            // 
            // dtpWhen
            // 
            this.dtpWhen.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpWhen.CalendarForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtpWhen.CalendarTitleForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtpWhen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpWhen.Location = new System.Drawing.Point(265, 424);
            this.dtpWhen.Name = "dtpWhen";
            this.dtpWhen.Size = new System.Drawing.Size(271, 26);
            this.dtpWhen.TabIndex = 20;
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancel.BackColor = System.Drawing.SystemColors.Control;
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCancel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.bCancel.Location = new System.Drawing.Point(288, 517);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(251, 40);
            this.bCancel.TabIndex = 22;
            this.bCancel.Text = "ОТМЕНА";
            this.bCancel.UseVisualStyleBackColor = false;
            // 
            // bOk
            // 
            this.bOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bOk.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bOk.ForeColor = System.Drawing.SystemColors.Window;
            this.bOk.Location = new System.Drawing.Point(12, 517);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(270, 40);
            this.bOk.TabIndex = 21;
            this.bOk.Text = "ПОДТВЕРДИТЬ";
            this.bOk.UseVisualStyleBackColor = false;
            // 
            // lWhen
            // 
            this.lWhen.AutoSize = true;
            this.lWhen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lWhen.Location = new System.Drawing.Point(26, 424);
            this.lWhen.Name = "lWhen";
            this.lWhen.Size = new System.Drawing.Size(219, 24);
            this.lWhen.TabIndex = 23;
            this.lWhen.Text = "Выберите дату полета:";
            // 
            // cbPilot
            // 
            this.cbPilot.AutoSize = true;
            this.cbPilot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbPilot.Location = new System.Drawing.Point(30, 467);
            this.cbPilot.Name = "cbPilot";
            this.cbPilot.Size = new System.Drawing.Size(405, 28);
            this.cbPilot.TabIndex = 26;
            this.cbPilot.Text = "Нуждаетесь в клафицированном пилоте?";
            this.cbPilot.UseVisualStyleBackColor = true;
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 568);
            this.Controls.Add(this.cbPilot);
            this.Controls.Add(this.lWhen);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.dtpWhen);
            this.Controls.Add(this.tbFlDur);
            this.Controls.Add(this.gbAircraft);
            this.Controls.Add(this.lWelc);
            this.Controls.Add(this.gbUser);
            this.Name = "frmOrder";
            this.gbUser.ResumeLayout(false);
            this.gbUser.PerformLayout();
            this.gbAircraft.ResumeLayout(false);
            this.gbAircraft.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUser;
        private System.Windows.Forms.Label lWelc;
        protected internal System.Windows.Forms.TextBox tbName;
        protected internal System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.GroupBox gbAircraft;
        protected internal System.Windows.Forms.TextBox tbTailNum;
        protected internal System.Windows.Forms.TextBox tbAcName;
        protected internal System.Windows.Forms.TextBox tbFlDur;
        protected internal System.Windows.Forms.TextBox tbMaxDist;
        protected internal System.Windows.Forms.TextBox tbMaxSp;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.Label lWhen;
        protected internal System.Windows.Forms.DateTimePicker dtpWhen;
        protected internal System.Windows.Forms.CheckBox cbPilot;
    }
}