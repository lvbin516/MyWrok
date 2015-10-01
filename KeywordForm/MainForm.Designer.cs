namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.googleSearchInput = new System.Windows.Forms.TextBox();
            this.SearchTabSwitch = new System.Windows.Forms.TabControl();
            this.GoogleTab = new System.Windows.Forms.TabPage();
            this.googleSearchClick = new System.Windows.Forms.PictureBox();
            this.googleCombobox = new System.Windows.Forms.ComboBox();
            this.YahooTab = new System.Windows.Forms.TabPage();
            this.YahooSearchImage = new System.Windows.Forms.PictureBox();
            this.YahooComboBox = new System.Windows.Forms.ComboBox();
            this.YahooSearchInput = new System.Windows.Forms.TextBox();
            this.BingTab = new System.Windows.Forms.TabPage();
            this.BingComboBox = new System.Windows.Forms.ComboBox();
            this.BingSearchIcon = new System.Windows.Forms.PictureBox();
            this.BingSearchInput = new System.Windows.Forms.TextBox();
            this.YouTubeTab = new System.Windows.Forms.TabPage();
            this.YouTubeSearchIcon = new System.Windows.Forms.PictureBox();
            this.YouTuComboBox = new System.Windows.Forms.ComboBox();
            this.YouTubeSearchInput = new System.Windows.Forms.TextBox();
            this.PlayTab = new System.Windows.Forms.TabPage();
            this.playSearchIcon = new System.Windows.Forms.PictureBox();
            this.playComboBox = new System.Windows.Forms.ComboBox();
            this.playSearchInput = new System.Windows.Forms.TextBox();
            this.AmazonTab = new System.Windows.Forms.TabPage();
            this.amazonSearchIcon = new System.Windows.Forms.PictureBox();
            this.amazonComboBox = new System.Windows.Forms.ComboBox();
            this.amazonSearchInput = new System.Windows.Forms.TextBox();
            this.SearchTabSwitch.SuspendLayout();
            this.GoogleTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.googleSearchClick)).BeginInit();
            this.YahooTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YahooSearchImage)).BeginInit();
            this.BingTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BingSearchIcon)).BeginInit();
            this.YouTubeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YouTubeSearchIcon)).BeginInit();
            this.PlayTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playSearchIcon)).BeginInit();
            this.AmazonTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amazonSearchIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // googleSearchInput
            // 
            this.googleSearchInput.Location = new System.Drawing.Point(6, 15);
            this.googleSearchInput.Name = "googleSearchInput";
            this.googleSearchInput.Size = new System.Drawing.Size(362, 21);
            this.googleSearchInput.TabIndex = 0;
            this.googleSearchInput.TextChanged += new System.EventHandler(this.googleTextChange);
            // 
            // SearchTabSwitch
            // 
            this.SearchTabSwitch.Controls.Add(this.GoogleTab);
            this.SearchTabSwitch.Controls.Add(this.YahooTab);
            this.SearchTabSwitch.Controls.Add(this.BingTab);
            this.SearchTabSwitch.Controls.Add(this.YouTubeTab);
            this.SearchTabSwitch.Controls.Add(this.PlayTab);
            this.SearchTabSwitch.Controls.Add(this.AmazonTab);
            this.SearchTabSwitch.Location = new System.Drawing.Point(12, 38);
            this.SearchTabSwitch.Name = "SearchTabSwitch";
            this.SearchTabSwitch.SelectedIndex = 0;
            this.SearchTabSwitch.Size = new System.Drawing.Size(641, 81);
            this.SearchTabSwitch.TabIndex = 3;
            this.SearchTabSwitch.SelectedIndexChanged += new System.EventHandler(this.SearchTabIndexChange);
            this.SearchTabSwitch.Click += new System.EventHandler(this.Google_Click);
            // 
            // GoogleTab
            // 
            this.GoogleTab.Controls.Add(this.googleSearchClick);
            this.GoogleTab.Controls.Add(this.googleCombobox);
            this.GoogleTab.Controls.Add(this.googleSearchInput);
            this.GoogleTab.Location = new System.Drawing.Point(4, 22);
            this.GoogleTab.Name = "GoogleTab";
            this.GoogleTab.Padding = new System.Windows.Forms.Padding(3);
            this.GoogleTab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GoogleTab.Size = new System.Drawing.Size(633, 55);
            this.GoogleTab.TabIndex = 0;
            this.GoogleTab.Text = "Google";
            this.GoogleTab.UseVisualStyleBackColor = true;
            // 
            // googleSearchClick
            // 
            this.googleSearchClick.Image = ((System.Drawing.Image)(resources.GetObject("googleSearchClick.Image")));
            this.googleSearchClick.Location = new System.Drawing.Point(577, 15);
            this.googleSearchClick.Name = "googleSearchClick";
            this.googleSearchClick.Size = new System.Drawing.Size(28, 20);
            this.googleSearchClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.googleSearchClick.TabIndex = 6;
            this.googleSearchClick.TabStop = false;
            this.googleSearchClick.Click += new System.EventHandler(this.googleSearchClick_Click);
            // 
            // googleCombobox
            // 
            this.googleCombobox.FormattingEnabled = true;
            this.googleCombobox.Location = new System.Drawing.Point(402, 16);
            this.googleCombobox.Name = "googleCombobox";
            this.googleCombobox.Size = new System.Drawing.Size(121, 20);
            this.googleCombobox.TabIndex = 5;
            this.googleCombobox.SelectedIndexChanged += new System.EventHandler(this.googleCombobox_SelectedIndexChanged);
            // 
            // YahooTab
            // 
            this.YahooTab.Controls.Add(this.YahooSearchImage);
            this.YahooTab.Controls.Add(this.YahooComboBox);
            this.YahooTab.Controls.Add(this.YahooSearchInput);
            this.YahooTab.Location = new System.Drawing.Point(4, 22);
            this.YahooTab.Name = "YahooTab";
            this.YahooTab.Padding = new System.Windows.Forms.Padding(3);
            this.YahooTab.Size = new System.Drawing.Size(633, 55);
            this.YahooTab.TabIndex = 1;
            this.YahooTab.Text = "Yahoo";
            this.YahooTab.UseVisualStyleBackColor = true;
            this.YahooTab.Click += new System.EventHandler(this.YahooTabClick);
            // 
            // YahooSearchImage
            // 
            this.YahooSearchImage.Image = ((System.Drawing.Image)(resources.GetObject("YahooSearchImage.Image")));
            this.YahooSearchImage.Location = new System.Drawing.Point(579, 18);
            this.YahooSearchImage.Name = "YahooSearchImage";
            this.YahooSearchImage.Size = new System.Drawing.Size(28, 20);
            this.YahooSearchImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.YahooSearchImage.TabIndex = 6;
            this.YahooSearchImage.TabStop = false;
            this.YahooSearchImage.Click += new System.EventHandler(this.YahooSearchClick);
            // 
            // YahooComboBox
            // 
            this.YahooComboBox.DisplayMember = "4";
            this.YahooComboBox.FormattingEnabled = true;
            this.YahooComboBox.Location = new System.Drawing.Point(410, 18);
            this.YahooComboBox.Name = "YahooComboBox";
            this.YahooComboBox.Size = new System.Drawing.Size(121, 20);
            this.YahooComboBox.TabIndex = 5;
            this.YahooComboBox.ValueMember = "1";
            this.YahooComboBox.SelectedIndexChanged += new System.EventHandler(this.YahooComboBoxChange);
            // 
            // YahooSearchInput
            // 
            this.YahooSearchInput.Location = new System.Drawing.Point(6, 18);
            this.YahooSearchInput.Name = "YahooSearchInput";
            this.YahooSearchInput.Size = new System.Drawing.Size(362, 21);
            this.YahooSearchInput.TabIndex = 1;
            this.YahooSearchInput.TextChanged += new System.EventHandler(this.YahooTextChange);
            // 
            // BingTab
            // 
            this.BingTab.Controls.Add(this.BingComboBox);
            this.BingTab.Controls.Add(this.BingSearchIcon);
            this.BingTab.Controls.Add(this.BingSearchInput);
            this.BingTab.Location = new System.Drawing.Point(4, 22);
            this.BingTab.Name = "BingTab";
            this.BingTab.Padding = new System.Windows.Forms.Padding(3);
            this.BingTab.Size = new System.Drawing.Size(633, 55);
            this.BingTab.TabIndex = 2;
            this.BingTab.Text = "Bing";
            this.BingTab.UseVisualStyleBackColor = true;
            this.BingTab.Click += new System.EventHandler(this.BingTabClick);
            // 
            // BingComboBox
            // 
            this.BingComboBox.FormattingEnabled = true;
            this.BingComboBox.Location = new System.Drawing.Point(423, 17);
            this.BingComboBox.Name = "BingComboBox";
            this.BingComboBox.Size = new System.Drawing.Size(121, 20);
            this.BingComboBox.TabIndex = 4;
            this.BingComboBox.SelectedIndexChanged += new System.EventHandler(this.BingComboBoxChange);
            // 
            // BingSearchIcon
            // 
            this.BingSearchIcon.Image = ((System.Drawing.Image)(resources.GetObject("BingSearchIcon.Image")));
            this.BingSearchIcon.Location = new System.Drawing.Point(582, 18);
            this.BingSearchIcon.Name = "BingSearchIcon";
            this.BingSearchIcon.Size = new System.Drawing.Size(28, 20);
            this.BingSearchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BingSearchIcon.TabIndex = 3;
            this.BingSearchIcon.TabStop = false;
            this.BingSearchIcon.Click += new System.EventHandler(this.BingSearchIconClick);
            // 
            // BingSearchInput
            // 
            this.BingSearchInput.Location = new System.Drawing.Point(6, 17);
            this.BingSearchInput.Name = "BingSearchInput";
            this.BingSearchInput.Size = new System.Drawing.Size(363, 21);
            this.BingSearchInput.TabIndex = 2;
            this.BingSearchInput.TextChanged += new System.EventHandler(this.BingTextChange);
            // 
            // YouTubeTab
            // 
            this.YouTubeTab.Controls.Add(this.YouTubeSearchIcon);
            this.YouTubeTab.Controls.Add(this.YouTuComboBox);
            this.YouTubeTab.Controls.Add(this.YouTubeSearchInput);
            this.YouTubeTab.Location = new System.Drawing.Point(4, 22);
            this.YouTubeTab.Name = "YouTubeTab";
            this.YouTubeTab.Padding = new System.Windows.Forms.Padding(3);
            this.YouTubeTab.Size = new System.Drawing.Size(633, 55);
            this.YouTubeTab.TabIndex = 3;
            this.YouTubeTab.Text = "YouTube";
            this.YouTubeTab.UseVisualStyleBackColor = true;
            this.YouTubeTab.Click += new System.EventHandler(this.YouTubeTabClick);
            // 
            // YouTubeSearchIcon
            // 
            this.YouTubeSearchIcon.Image = ((System.Drawing.Image)(resources.GetObject("YouTubeSearchIcon.Image")));
            this.YouTubeSearchIcon.Location = new System.Drawing.Point(588, 16);
            this.YouTubeSearchIcon.Name = "YouTubeSearchIcon";
            this.YouTubeSearchIcon.Size = new System.Drawing.Size(28, 20);
            this.YouTubeSearchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.YouTubeSearchIcon.TabIndex = 6;
            this.YouTubeSearchIcon.TabStop = false;
            this.YouTubeSearchIcon.Click += new System.EventHandler(this.YouTubeSearchIconClick);
            // 
            // YouTuComboBox
            // 
            this.YouTuComboBox.FormattingEnabled = true;
            this.YouTuComboBox.Location = new System.Drawing.Point(388, 17);
            this.YouTuComboBox.Name = "YouTuComboBox";
            this.YouTuComboBox.Size = new System.Drawing.Size(121, 20);
            this.YouTuComboBox.TabIndex = 5;
            this.YouTuComboBox.SelectedIndexChanged += new System.EventHandler(this.YouTubeComboBoxChange);
            // 
            // YouTubeSearchInput
            // 
            this.YouTubeSearchInput.Location = new System.Drawing.Point(6, 16);
            this.YouTubeSearchInput.Name = "YouTubeSearchInput";
            this.YouTubeSearchInput.Size = new System.Drawing.Size(362, 21);
            this.YouTubeSearchInput.TabIndex = 2;
            this.YouTubeSearchInput.TextChanged += new System.EventHandler(this.YouTubeSearchTextChange);
            // 
            // PlayTab
            // 
            this.PlayTab.Controls.Add(this.playSearchIcon);
            this.PlayTab.Controls.Add(this.playComboBox);
            this.PlayTab.Controls.Add(this.playSearchInput);
            this.PlayTab.Location = new System.Drawing.Point(4, 22);
            this.PlayTab.Name = "PlayTab";
            this.PlayTab.Padding = new System.Windows.Forms.Padding(3);
            this.PlayTab.Size = new System.Drawing.Size(633, 55);
            this.PlayTab.TabIndex = 4;
            this.PlayTab.Text = "Google Play";
            this.PlayTab.UseVisualStyleBackColor = true;
            this.PlayTab.Click += new System.EventHandler(this.PlayTabClick);
            // 
            // playSearchIcon
            // 
            this.playSearchIcon.Image = ((System.Drawing.Image)(resources.GetObject("playSearchIcon.Image")));
            this.playSearchIcon.Location = new System.Drawing.Point(584, 17);
            this.playSearchIcon.Name = "playSearchIcon";
            this.playSearchIcon.Size = new System.Drawing.Size(28, 20);
            this.playSearchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playSearchIcon.TabIndex = 6;
            this.playSearchIcon.TabStop = false;
            this.playSearchIcon.Click += new System.EventHandler(this.PlaySearchIconClick);
            // 
            // playComboBox
            // 
            this.playComboBox.FormattingEnabled = true;
            this.playComboBox.Location = new System.Drawing.Point(394, 17);
            this.playComboBox.Name = "playComboBox";
            this.playComboBox.Size = new System.Drawing.Size(121, 20);
            this.playComboBox.TabIndex = 5;
            this.playComboBox.SelectedIndexChanged += new System.EventHandler(this.PlayComboBoxChange);
            // 
            // playSearchInput
            // 
            this.playSearchInput.Location = new System.Drawing.Point(6, 16);
            this.playSearchInput.Name = "playSearchInput";
            this.playSearchInput.Size = new System.Drawing.Size(362, 21);
            this.playSearchInput.TabIndex = 2;
            this.playSearchInput.TextChanged += new System.EventHandler(this.PlaySearchTextChange);
            // 
            // AmazonTab
            // 
            this.AmazonTab.Controls.Add(this.amazonSearchIcon);
            this.AmazonTab.Controls.Add(this.amazonComboBox);
            this.AmazonTab.Controls.Add(this.amazonSearchInput);
            this.AmazonTab.Location = new System.Drawing.Point(4, 22);
            this.AmazonTab.Name = "AmazonTab";
            this.AmazonTab.Padding = new System.Windows.Forms.Padding(3);
            this.AmazonTab.Size = new System.Drawing.Size(633, 55);
            this.AmazonTab.TabIndex = 5;
            this.AmazonTab.Text = "Amazon";
            this.AmazonTab.UseVisualStyleBackColor = true;
            this.AmazonTab.Click += new System.EventHandler(this.AmazonTabClick);
            // 
            // amazonSearchIcon
            // 
            this.amazonSearchIcon.Image = ((System.Drawing.Image)(resources.GetObject("amazonSearchIcon.Image")));
            this.amazonSearchIcon.Location = new System.Drawing.Point(587, 17);
            this.amazonSearchIcon.Name = "amazonSearchIcon";
            this.amazonSearchIcon.Size = new System.Drawing.Size(28, 20);
            this.amazonSearchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.amazonSearchIcon.TabIndex = 7;
            this.amazonSearchIcon.TabStop = false;
            this.amazonSearchIcon.Click += new System.EventHandler(this.amazonSearchIconClick);
            // 
            // amazonComboBox
            // 
            this.amazonComboBox.FormattingEnabled = true;
            this.amazonComboBox.Items.AddRange(new object[] {
            "美国",
            "中国",
            "日本"});
            this.amazonComboBox.Location = new System.Drawing.Point(383, 16);
            this.amazonComboBox.Name = "amazonComboBox";
            this.amazonComboBox.Size = new System.Drawing.Size(121, 20);
            this.amazonComboBox.TabIndex = 6;
            this.amazonComboBox.SelectedIndexChanged += new System.EventHandler(this.amazonComboBoxChange);
            // 
            // amazonSearchInput
            // 
            this.amazonSearchInput.Location = new System.Drawing.Point(6, 16);
            this.amazonSearchInput.Name = "amazonSearchInput";
            this.amazonSearchInput.Size = new System.Drawing.Size(362, 21);
            this.amazonSearchInput.TabIndex = 3;
            this.amazonSearchInput.TextChanged += new System.EventHandler(this.amazonSearchTextChange);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 430);
            this.Controls.Add(this.SearchTabSwitch);
            this.Name = "Form1";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SearchTabSwitch.ResumeLayout(false);
            this.GoogleTab.ResumeLayout(false);
            this.GoogleTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.googleSearchClick)).EndInit();
            this.YahooTab.ResumeLayout(false);
            this.YahooTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YahooSearchImage)).EndInit();
            this.BingTab.ResumeLayout(false);
            this.BingTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BingSearchIcon)).EndInit();
            this.YouTubeTab.ResumeLayout(false);
            this.YouTubeTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YouTubeSearchIcon)).EndInit();
            this.PlayTab.ResumeLayout(false);
            this.PlayTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playSearchIcon)).EndInit();
            this.AmazonTab.ResumeLayout(false);
            this.AmazonTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amazonSearchIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox googleSearchInput;
        private System.Windows.Forms.TabControl SearchTabSwitch;
        private System.Windows.Forms.TabPage GoogleTab;
        private System.Windows.Forms.TabPage YahooTab;
        private System.Windows.Forms.TextBox YahooSearchInput;
        private System.Windows.Forms.TabPage BingTab;
        private System.Windows.Forms.TextBox BingSearchInput;
        private System.Windows.Forms.TabPage YouTubeTab;
        private System.Windows.Forms.TextBox YouTubeSearchInput;
        private System.Windows.Forms.TabPage PlayTab;
        private System.Windows.Forms.TextBox playSearchInput;
        private System.Windows.Forms.ComboBox BingComboBox;
        private System.Windows.Forms.PictureBox BingSearchIcon;
        private System.Windows.Forms.PictureBox googleSearchClick;
        private System.Windows.Forms.ComboBox googleCombobox;
        private System.Windows.Forms.PictureBox YahooSearchImage;
        private System.Windows.Forms.ComboBox YahooComboBox;
        private System.Windows.Forms.PictureBox YouTubeSearchIcon;
        private System.Windows.Forms.ComboBox YouTuComboBox;
        private System.Windows.Forms.PictureBox playSearchIcon;
        private System.Windows.Forms.ComboBox playComboBox;
        private System.Windows.Forms.TabPage AmazonTab;
        private System.Windows.Forms.PictureBox amazonSearchIcon;
        private System.Windows.Forms.ComboBox amazonComboBox;
        private System.Windows.Forms.TextBox amazonSearchInput;
    }
}

