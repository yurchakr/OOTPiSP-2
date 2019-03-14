namespace OOTPiSP__2
{
    partial class frmAircraft
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
            this.bDelVeh = new System.Windows.Forms.Button();
            this.bAddVeh = new System.Windows.Forms.Button();
            this.tbType = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbTailNum = new System.Windows.Forms.TextBox();
            this.tbMaxSp = new System.Windows.Forms.TextBox();
            this.tbFlDist = new System.Windows.Forms.TextBox();
            this.tbLoadCap = new System.Windows.Forms.TextBox();
            this.tbRotDiam = new System.Windows.Forms.TextBox();
            this.tbEngPwr = new System.Windows.Forms.TextBox();
            this.tbWingspan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bDelVeh
            // 
            this.bDelVeh.BackColor = System.Drawing.SystemColors.Control;
            this.bDelVeh.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bDelVeh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bDelVeh.ForeColor = System.Drawing.SystemColors.InfoText;
            this.bDelVeh.Location = new System.Drawing.Point(279, 286);
            this.bDelVeh.Name = "bDelVeh";
            this.bDelVeh.Size = new System.Drawing.Size(251, 40);
            this.bDelVeh.TabIndex = 13;
            this.bDelVeh.Text = "ОТМЕНА";
            this.bDelVeh.UseVisualStyleBackColor = false;
            // 
            // bAddVeh
            // 
            this.bAddVeh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bAddVeh.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bAddVeh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAddVeh.ForeColor = System.Drawing.SystemColors.Window;
            this.bAddVeh.Location = new System.Drawing.Point(12, 286);
            this.bAddVeh.Name = "bAddVeh";
            this.bAddVeh.Size = new System.Drawing.Size(261, 40);
            this.bAddVeh.TabIndex = 12;
            this.bAddVeh.Text = "ПРИНЯТЬ";
            this.bAddVeh.UseVisualStyleBackColor = false;
            // 
            // tbType
            // 
            this.tbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbType.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbType.Location = new System.Drawing.Point(12, 12);
            this.tbType.Name = "tbType";
            this.tbType.ReadOnly = true;
            this.tbType.Size = new System.Drawing.Size(518, 31);
            this.tbType.TabIndex = 14;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbName.Location = new System.Drawing.Point(12, 49);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(518, 31);
            this.tbName.TabIndex = 15;
            this.tbName.Text = "Введите название летательного аппарата";
            this.tbName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbName_MouseDown);
            // 
            // tbTailNum
            // 
            this.tbTailNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTailNum.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbTailNum.Location = new System.Drawing.Point(12, 86);
            this.tbTailNum.Name = "tbTailNum";
            this.tbTailNum.Size = new System.Drawing.Size(518, 31);
            this.tbTailNum.TabIndex = 16;
            this.tbTailNum.Text = "Введите бортовой номер";
            this.tbTailNum.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbTailNum_MouseDown);
            // 
            // tbMaxSp
            // 
            this.tbMaxSp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMaxSp.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbMaxSp.Location = new System.Drawing.Point(12, 123);
            this.tbMaxSp.Name = "tbMaxSp";
            this.tbMaxSp.Size = new System.Drawing.Size(518, 31);
            this.tbMaxSp.TabIndex = 17;
            this.tbMaxSp.Text = "Введите максимальную скорость, км/ч";
            this.tbMaxSp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMaxSp_KeyPress);
            this.tbMaxSp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbMaxSp_MouseDown);
            // 
            // tbFlDist
            // 
            this.tbFlDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFlDist.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbFlDist.Location = new System.Drawing.Point(12, 160);
            this.tbFlDist.Name = "tbFlDist";
            this.tbFlDist.Size = new System.Drawing.Size(518, 31);
            this.tbFlDist.TabIndex = 18;
            this.tbFlDist.Text = "Введите максимальную дистанцию полета, км";
            this.tbFlDist.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFlDist_KeyPress);
            this.tbFlDist.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbFlDist_MouseDown);
            // 
            // tbLoadCap
            // 
            this.tbLoadCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLoadCap.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbLoadCap.Location = new System.Drawing.Point(12, 197);
            this.tbLoadCap.Name = "tbLoadCap";
            this.tbLoadCap.Size = new System.Drawing.Size(518, 31);
            this.tbLoadCap.TabIndex = 19;
            this.tbLoadCap.Text = "Введите грузоподъемность";
            this.tbLoadCap.Visible = false;
            this.tbLoadCap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLoadCap_KeyPress);
            this.tbLoadCap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbLoadCap_MouseDown);
            // 
            // tbRotDiam
            // 
            this.tbRotDiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRotDiam.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbRotDiam.Location = new System.Drawing.Point(12, 197);
            this.tbRotDiam.Name = "tbRotDiam";
            this.tbRotDiam.Size = new System.Drawing.Size(518, 31);
            this.tbRotDiam.TabIndex = 20;
            this.tbRotDiam.Text = "Введите диаметр винта, м";
            this.tbRotDiam.Visible = false;
            this.tbRotDiam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRotDiam_KeyPress);
            this.tbRotDiam.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbRotDiam_MouseDown);
            // 
            // tbEngPwr
            // 
            this.tbEngPwr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEngPwr.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbEngPwr.Location = new System.Drawing.Point(12, 234);
            this.tbEngPwr.Name = "tbEngPwr";
            this.tbEngPwr.Size = new System.Drawing.Size(518, 31);
            this.tbEngPwr.TabIndex = 21;
            this.tbEngPwr.Text = "Введите мощность двигателя";
            this.tbEngPwr.Visible = false;
            this.tbEngPwr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEngPwr_KeyPress);
            this.tbEngPwr.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbEngPwr_MouseDown);
            // 
            // tbWingspan
            // 
            this.tbWingspan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbWingspan.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbWingspan.Location = new System.Drawing.Point(12, 234);
            this.tbWingspan.Name = "tbWingspan";
            this.tbWingspan.Size = new System.Drawing.Size(518, 31);
            this.tbWingspan.TabIndex = 22;
            this.tbWingspan.Text = "Введите размах крыльев, м";
            this.tbWingspan.Visible = false;
            this.tbWingspan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbWingspan_KeyPress);
            this.tbWingspan.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbWingspan_MouseDown);
            // 
            // frmAircraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 338);
            this.Controls.Add(this.tbWingspan);
            this.Controls.Add(this.tbEngPwr);
            this.Controls.Add(this.tbRotDiam);
            this.Controls.Add(this.tbLoadCap);
            this.Controls.Add(this.tbFlDist);
            this.Controls.Add(this.tbMaxSp);
            this.Controls.Add(this.tbTailNum);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.bDelVeh);
            this.Controls.Add(this.bAddVeh);
            this.Name = "frmAircraft";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bDelVeh;
        private System.Windows.Forms.Button bAddVeh;
        protected internal System.Windows.Forms.TextBox tbType;
        protected internal System.Windows.Forms.TextBox tbName;
        protected internal System.Windows.Forms.TextBox tbTailNum;
        protected internal System.Windows.Forms.TextBox tbMaxSp;
        protected internal System.Windows.Forms.TextBox tbFlDist;
        protected internal System.Windows.Forms.TextBox tbLoadCap;
        protected internal System.Windows.Forms.TextBox tbRotDiam;
        protected internal System.Windows.Forms.TextBox tbEngPwr;
        protected internal System.Windows.Forms.TextBox tbWingspan;
    }
}