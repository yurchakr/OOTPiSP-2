namespace OOTPiSP__2.Forms
{
    partial class frmSerialize
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
            this.bOk = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.rbDAT = new System.Windows.Forms.RadioButton();
            this.rbXML = new System.Windows.Forms.RadioButton();
            this.rbJSON = new System.Windows.Forms.RadioButton();
            this.rbTXT = new System.Windows.Forms.RadioButton();
            this.gbSerialType = new System.Windows.Forms.GroupBox();
            this.gbSerialType.SuspendLayout();
            this.SuspendLayout();
            // 
            // bOk
            // 
            this.bOk.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bOk.ForeColor = System.Drawing.SystemColors.Window;
            this.bOk.Location = new System.Drawing.Point(12, 295);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(150, 40);
            this.bOk.TabIndex = 15;
            this.bOk.Text = "ОК";
            this.bOk.UseVisualStyleBackColor = false;
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.SystemColors.Control;
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCancel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.bCancel.Location = new System.Drawing.Point(168, 295);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(159, 40);
            this.bCancel.TabIndex = 18;
            this.bCancel.Text = "ОТМЕНА";
            this.bCancel.UseVisualStyleBackColor = false;
            // 
            // rbDAT
            // 
            this.rbDAT.AutoSize = true;
            this.rbDAT.Checked = true;
            this.rbDAT.ForeColor = System.Drawing.SystemColors.Highlight;
            this.rbDAT.Location = new System.Drawing.Point(10, 48);
            this.rbDAT.Name = "rbDAT";
            this.rbDAT.Size = new System.Drawing.Size(71, 29);
            this.rbDAT.TabIndex = 0;
            this.rbDAT.TabStop = true;
            this.rbDAT.Text = "DAT";
            this.rbDAT.UseVisualStyleBackColor = true;
            // 
            // rbXML
            // 
            this.rbXML.AutoSize = true;
            this.rbXML.ForeColor = System.Drawing.SystemColors.Highlight;
            this.rbXML.Location = new System.Drawing.Point(10, 97);
            this.rbXML.Name = "rbXML";
            this.rbXML.Size = new System.Drawing.Size(72, 29);
            this.rbXML.TabIndex = 1;
            this.rbXML.Text = "XML";
            this.rbXML.UseVisualStyleBackColor = true;
            // 
            // rbJSON
            // 
            this.rbJSON.AutoSize = true;
            this.rbJSON.ForeColor = System.Drawing.SystemColors.Highlight;
            this.rbJSON.Location = new System.Drawing.Point(10, 150);
            this.rbJSON.Name = "rbJSON";
            this.rbJSON.Size = new System.Drawing.Size(85, 29);
            this.rbJSON.TabIndex = 2;
            this.rbJSON.Text = "JSON";
            this.rbJSON.UseVisualStyleBackColor = true;
            // 
            // rbTXT
            // 
            this.rbTXT.AutoSize = true;
            this.rbTXT.ForeColor = System.Drawing.SystemColors.Highlight;
            this.rbTXT.Location = new System.Drawing.Point(10, 206);
            this.rbTXT.Name = "rbTXT";
            this.rbTXT.Size = new System.Drawing.Size(70, 29);
            this.rbTXT.TabIndex = 3;
            this.rbTXT.Text = "TXT";
            this.rbTXT.UseVisualStyleBackColor = true;
            // 
            // gbSerialType
            // 
            this.gbSerialType.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbSerialType.Controls.Add(this.rbTXT);
            this.gbSerialType.Controls.Add(this.rbJSON);
            this.gbSerialType.Controls.Add(this.rbXML);
            this.gbSerialType.Controls.Add(this.rbDAT);
            this.gbSerialType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbSerialType.Location = new System.Drawing.Point(12, 12);
            this.gbSerialType.Name = "gbSerialType";
            this.gbSerialType.Size = new System.Drawing.Size(315, 277);
            this.gbSerialType.TabIndex = 19;
            this.gbSerialType.TabStop = false;
            this.gbSerialType.Text = "Выберите расширение файла..";
            // 
            // frmSerialize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(342, 342);
            this.Controls.Add(this.gbSerialType);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bOk);
            this.Name = "frmSerialize";
            this.Load += new System.EventHandler(this.frmSerialize_Load);
            this.gbSerialType.ResumeLayout(false);
            this.gbSerialType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.RadioButton rbDAT;
        private System.Windows.Forms.RadioButton rbXML;
        private System.Windows.Forms.RadioButton rbJSON;
        private System.Windows.Forms.RadioButton rbTXT;
        private System.Windows.Forms.GroupBox gbSerialType;
    }
}