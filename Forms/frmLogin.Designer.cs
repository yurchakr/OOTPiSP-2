namespace OOTPiSP__2
{
    partial class frmLogin
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lWelcome = new System.Windows.Forms.Label();
            this.pLogin = new System.Windows.Forms.Panel();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.bMakeAcc = new System.Windows.Forms.Button();
            this.bLogIn = new System.Windows.Forms.Button();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.bRegister = new System.Windows.Forms.Button();
            this.bBack = new System.Windows.Forms.Button();
            this.lWelc = new System.Windows.Forms.Label();
            this.pLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lWelcome
            // 
            this.lWelcome.AutoSize = true;
            this.lWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lWelcome.Location = new System.Drawing.Point(4, 17);
            this.lWelcome.Name = "lWelcome";
            this.lWelcome.Size = new System.Drawing.Size(447, 24);
            this.lWelcome.TabIndex = 0;
            this.lWelcome.Text = "Для использования сервиса необходимо войти:";
            // 
            // pLogin
            // 
            this.pLogin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pLogin.Controls.Add(this.tbMail);
            this.pLogin.Controls.Add(this.tbName);
            this.pLogin.Controls.Add(this.bMakeAcc);
            this.pLogin.Controls.Add(this.bLogIn);
            this.pLogin.Controls.Add(this.tbPass);
            this.pLogin.Controls.Add(this.tbUserName);
            this.pLogin.Controls.Add(this.lWelcome);
            this.pLogin.Location = new System.Drawing.Point(164, 98);
            this.pLogin.Name = "pLogin";
            this.pLogin.Size = new System.Drawing.Size(451, 270);
            this.pLogin.TabIndex = 1;
            // 
            // tbMail
            // 
            this.tbMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbMail.Location = new System.Drawing.Point(27, 212);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(399, 31);
            this.tbMail.TabIndex = 6;
            this.tbMail.Text = "Введите адрес вашей почты";
            this.tbMail.Visible = false;
            this.tbMail.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbMail_MouseDown);
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbName.Location = new System.Drawing.Point(27, 166);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(399, 31);
            this.tbName.TabIndex = 5;
            this.tbName.Text = "Введите ваше имя";
            this.tbName.Visible = false;
            this.tbName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbName_MouseDown);
            // 
            // bMakeAcc
            // 
            this.bMakeAcc.BackColor = System.Drawing.SystemColors.Control;
            this.bMakeAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bMakeAcc.ForeColor = System.Drawing.SystemColors.InfoText;
            this.bMakeAcc.Location = new System.Drawing.Point(27, 212);
            this.bMakeAcc.Name = "bMakeAcc";
            this.bMakeAcc.Size = new System.Drawing.Size(399, 40);
            this.bMakeAcc.TabIndex = 4;
            this.bMakeAcc.Text = "СОЗДАТЬ АККАУНТ!";
            this.bMakeAcc.UseVisualStyleBackColor = false;
            this.bMakeAcc.Click += new System.EventHandler(this.bMakeAcc_Click);
            // 
            // bLogIn
            // 
            this.bLogIn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bLogIn.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.bLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bLogIn.ForeColor = System.Drawing.SystemColors.Window;
            this.bLogIn.Location = new System.Drawing.Point(27, 166);
            this.bLogIn.Name = "bLogIn";
            this.bLogIn.Size = new System.Drawing.Size(399, 40);
            this.bLogIn.TabIndex = 3;
            this.bLogIn.Text = "ВОЙТИ!";
            this.bLogIn.UseVisualStyleBackColor = false;
            // 
            // tbPass
            // 
            this.tbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPass.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbPass.Location = new System.Drawing.Point(27, 117);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(399, 31);
            this.tbPass.TabIndex = 2;
            this.tbPass.Text = "Введите ваш пароль";
            this.tbPass.TextChanged += new System.EventHandler(this.tbPass_TextChanged);
            this.tbPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbPass_MouseDown);
            // 
            // tbUserName
            // 
            this.tbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUserName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbUserName.Location = new System.Drawing.Point(27, 69);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(399, 31);
            this.tbUserName.TabIndex = 1;
            this.tbUserName.Text = "Введите ваше имя пользователя";
            this.tbUserName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbUserName_MouseDown);
            // 
            // bRegister
            // 
            this.bRegister.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bRegister.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bRegister.ForeColor = System.Drawing.SystemColors.Window;
            this.bRegister.Location = new System.Drawing.Point(191, 356);
            this.bRegister.Name = "bRegister";
            this.bRegister.Size = new System.Drawing.Size(399, 40);
            this.bRegister.TabIndex = 6;
            this.bRegister.Text = "СОЗДАТЬ АККАУНТ!";
            this.bRegister.UseVisualStyleBackColor = false;
            this.bRegister.Visible = false;
            // 
            // bBack
            // 
            this.bBack.BackColor = System.Drawing.SystemColors.Control;
            this.bBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bBack.ForeColor = System.Drawing.SystemColors.InfoText;
            this.bBack.Location = new System.Drawing.Point(191, 402);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(399, 40);
            this.bBack.TabIndex = 7;
            this.bBack.Text = "ВЕРНУТЬСЯ НАЗАД";
            this.bBack.UseVisualStyleBackColor = false;
            this.bBack.Visible = false;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // lWelc
            // 
            this.lWelc.AutoSize = true;
            this.lWelc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lWelc.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lWelc.Location = new System.Drawing.Point(21, 36);
            this.lWelc.Name = "lWelc";
            this.lWelc.Size = new System.Drawing.Size(767, 25);
            this.lWelc.TabIndex = 8;
            this.lWelc.Text = "ДОБРО ПОЖАЛОВАТЬ НА СЕРВИС ЗАКАЗА ЛЕТАТЕЛЬНЫХ АППАРАТОВ!";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.lWelc);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.bRegister);
            this.Controls.Add(this.pLogin);
            this.Name = "frmLogin";
            this.pLogin.ResumeLayout(false);
            this.pLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lWelcome;
        private System.Windows.Forms.Panel pLogin;
        private System.Windows.Forms.Button bMakeAcc;
        private System.Windows.Forms.Button bLogIn;
        private System.Windows.Forms.Button bRegister;
        private System.Windows.Forms.Button bBack;
        protected internal System.Windows.Forms.TextBox tbName;
        protected internal System.Windows.Forms.TextBox tbPass;
        protected internal System.Windows.Forms.TextBox tbMail;
        protected internal System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label lWelc;
    }
}

