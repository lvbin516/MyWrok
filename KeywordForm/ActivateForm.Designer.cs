namespace KeywordForm
{
    partial class ActivateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivateForm));
            this.activateInfo1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.mail = new CCWin.SkinControl.SkinLabel();
            this.license = new CCWin.SkinControl.SkinLabel();
            this.mailInput = new CCWin.SkinControl.SkinTextBox();
            this.numberInput = new CCWin.SkinControl.SkinTextBox();
            this.buyNow = new CCWin.SkinControl.SkinButton();
            this.activateBtn = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // activateInfo1
            // 
            this.activateInfo1.BackColor = System.Drawing.Color.Transparent;
            this.activateInfo1.BorderColor = System.Drawing.Color.White;
            this.activateInfo1.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.activateInfo1.Location = new System.Drawing.Point(21, 37);
            this.activateInfo1.Name = "activateInfo1";
            this.activateInfo1.Size = new System.Drawing.Size(435, 23);
            this.activateInfo1.TabIndex = 0;
            this.activateInfo1.Text = "You\'re using the trial version, please activate it using your license";
            // 
            // skinLabel2
            // 
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(23, 62);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(435, 26);
            this.skinLabel2.TabIndex = 0;
            this.skinLabel2.Text = "mail and serial number to get full keywords.";
            // 
            // mail
            // 
            this.mail.AutoSize = true;
            this.mail.BackColor = System.Drawing.Color.Transparent;
            this.mail.BorderColor = System.Drawing.Color.White;
            this.mail.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mail.Location = new System.Drawing.Point(26, 114);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(102, 20);
            this.mail.TabIndex = 1;
            this.mail.Text = "License mail : ";
            // 
            // license
            // 
            this.license.AutoSize = true;
            this.license.BackColor = System.Drawing.Color.Transparent;
            this.license.BorderColor = System.Drawing.Color.White;
            this.license.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.license.Location = new System.Drawing.Point(26, 155);
            this.license.Name = "license";
            this.license.Size = new System.Drawing.Size(114, 20);
            this.license.TabIndex = 2;
            this.license.Text = "Serial number : ";
            // 
            // mailInput
            // 
            this.mailInput.BackColor = System.Drawing.Color.Transparent;
            this.mailInput.DownBack = null;
            this.mailInput.Icon = null;
            this.mailInput.IconIsButton = false;
            this.mailInput.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.mailInput.IsPasswordChat = '\0';
            this.mailInput.IsSystemPasswordChar = false;
            this.mailInput.Lines = new string[0];
            this.mailInput.Location = new System.Drawing.Point(152, 107);
            this.mailInput.Margin = new System.Windows.Forms.Padding(0);
            this.mailInput.MaxLength = 32767;
            this.mailInput.MinimumSize = new System.Drawing.Size(28, 28);
            this.mailInput.MouseBack = null;
            this.mailInput.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.mailInput.Multiline = false;
            this.mailInput.Name = "mailInput";
            this.mailInput.NormlBack = null;
            this.mailInput.Padding = new System.Windows.Forms.Padding(5);
            this.mailInput.ReadOnly = false;
            this.mailInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mailInput.Size = new System.Drawing.Size(304, 28);
            // 
            // 
            // 
            this.mailInput.SkinTxt.Location = new System.Drawing.Point(0, 0);
            this.mailInput.SkinTxt.Name = "BaseText";
            this.mailInput.SkinTxt.TabIndex = 0;
            this.mailInput.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.mailInput.SkinTxt.WaterText = "";
            this.mailInput.TabIndex = 1;
            this.mailInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mailInput.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.mailInput.WaterText = "";
            this.mailInput.WordWrap = true;
            // 
            // numberInput
            // 
            this.numberInput.BackColor = System.Drawing.Color.Transparent;
            this.numberInput.DownBack = null;
            this.numberInput.Icon = null;
            this.numberInput.IconIsButton = false;
            this.numberInput.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.numberInput.IsPasswordChat = '\0';
            this.numberInput.IsSystemPasswordChar = false;
            this.numberInput.Lines = new string[0];
            this.numberInput.Location = new System.Drawing.Point(152, 153);
            this.numberInput.Margin = new System.Windows.Forms.Padding(0);
            this.numberInput.MaxLength = 32767;
            this.numberInput.MinimumSize = new System.Drawing.Size(28, 28);
            this.numberInput.MouseBack = null;
            this.numberInput.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.numberInput.Multiline = false;
            this.numberInput.Name = "numberInput";
            this.numberInput.NormlBack = null;
            this.numberInput.Padding = new System.Windows.Forms.Padding(5);
            this.numberInput.ReadOnly = false;
            this.numberInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.numberInput.Size = new System.Drawing.Size(306, 28);
            // 
            // 
            // 
            this.numberInput.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numberInput.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberInput.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.numberInput.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.numberInput.SkinTxt.Name = "BaseText";
            this.numberInput.SkinTxt.Size = new System.Drawing.Size(296, 18);
            this.numberInput.SkinTxt.TabIndex = 0;
            this.numberInput.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.numberInput.SkinTxt.WaterText = "";
            this.numberInput.TabIndex = 2;
            this.numberInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.numberInput.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.numberInput.WaterText = "";
            this.numberInput.WordWrap = true;
            // 
            // buyNow
            // 
            this.buyNow.BackColor = System.Drawing.Color.Transparent;
            this.buyNow.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.buyNow.DownBack = null;
            this.buyNow.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buyNow.Location = new System.Drawing.Point(110, 216);
            this.buyNow.MouseBack = null;
            this.buyNow.Name = "buyNow";
            this.buyNow.NormlBack = null;
            this.buyNow.Size = new System.Drawing.Size(107, 30);
            this.buyNow.TabIndex = 3;
            this.buyNow.Text = "Buy Now";
            this.buyNow.UseVisualStyleBackColor = false;
            this.buyNow.Click += new System.EventHandler(this.buyNow_Click);
            // 
            // activateBtn
            // 
            this.activateBtn.BackColor = System.Drawing.Color.Transparent;
            this.activateBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.activateBtn.DownBack = null;
            this.activateBtn.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.activateBtn.Location = new System.Drawing.Point(271, 216);
            this.activateBtn.MouseBack = null;
            this.activateBtn.Name = "activateBtn";
            this.activateBtn.NormlBack = null;
            this.activateBtn.Size = new System.Drawing.Size(107, 30);
            this.activateBtn.TabIndex = 4;
            this.activateBtn.Text = "Activate";
            this.activateBtn.UseVisualStyleBackColor = false;
            this.activateBtn.Click += new System.EventHandler(this.activateBtn_Click);
            // 
            // ActivateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(498, 274);
            this.Controls.Add(this.activateBtn);
            this.Controls.Add(this.buyNow);
            this.Controls.Add(this.numberInput);
            this.Controls.Add(this.mailInput);
            this.Controls.Add(this.license);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.activateInfo1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ActivateForm";
            this.Text = "";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel activateInfo1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel mail;
        private CCWin.SkinControl.SkinLabel license;
        private CCWin.SkinControl.SkinTextBox mailInput;
        private CCWin.SkinControl.SkinTextBox numberInput;
        private CCWin.SkinControl.SkinButton buyNow;
        private CCWin.SkinControl.SkinButton activateBtn;
    }
}