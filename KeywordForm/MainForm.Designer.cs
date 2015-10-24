namespace SearchApplication
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
            CCWin.SkinControl.Animation animation1 = new CCWin.SkinControl.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.skinTabControl = new CCWin.SkinControl.SkinTabControl();
            this.google = new System.Windows.Forms.TabPage();
            this.googleSearch = new CCWin.SkinControl.SkinButton();
            this.googleInput = new CCWin.SkinControl.SkinTextBox();
            this.Yahoo = new System.Windows.Forms.TabPage();
            this.YahooSearch = new CCWin.SkinControl.SkinButton();
            this.YahooInput = new CCWin.SkinControl.SkinTextBox();
            this.Bing = new System.Windows.Forms.TabPage();
            this.BingSearch = new CCWin.SkinControl.SkinButton();
            this.BingInput = new CCWin.SkinControl.SkinTextBox();
            this.YouTube = new System.Windows.Forms.TabPage();
            this.YouTubeSearch = new CCWin.SkinControl.SkinButton();
            this.YouTubeInput = new CCWin.SkinControl.SkinTextBox();
            this.googlePlay = new System.Windows.Forms.TabPage();
            this.GooglePlaySearch = new CCWin.SkinControl.SkinButton();
            this.GooglePlayInput = new CCWin.SkinControl.SkinTextBox();
            this.amazon = new System.Windows.Forms.TabPage();
            this.amazonSearchButton = new CCWin.SkinControl.SkinButton();
            this.amazonInput = new CCWin.SkinControl.SkinTextBox();
            this.export = new CCWin.SkinControl.SkinButton();
            this.clear = new CCWin.SkinControl.SkinButton();
            this.resultListView = new CCWin.SkinControl.SkinListView();
            this.Term = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KeyWord = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProgressIndicator = new CCWin.SkinControl.SkinProgressIndicator();
            this.skinTabControl.SuspendLayout();
            this.google.SuspendLayout();
            this.Yahoo.SuspendLayout();
            this.Bing.SuspendLayout();
            this.YouTube.SuspendLayout();
            this.googlePlay.SuspendLayout();
            this.amazon.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinTabControl
            // 
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 1F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.skinTabControl.Animation = animation1;
            this.skinTabControl.AnimatorType = CCWin.SkinControl.AnimationType.Leaf;
            this.skinTabControl.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.skinTabControl.Controls.Add(this.google);
            this.skinTabControl.Controls.Add(this.Yahoo);
            this.skinTabControl.Controls.Add(this.Bing);
            this.skinTabControl.Controls.Add(this.YouTube);
            this.skinTabControl.Controls.Add(this.googlePlay);
            this.skinTabControl.Controls.Add(this.amazon);
            this.skinTabControl.HeadBack = null;
            this.skinTabControl.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.skinTabControl.ItemSize = new System.Drawing.Size(70, 36);
            this.skinTabControl.Location = new System.Drawing.Point(35, 62);
            this.skinTabControl.Name = "skinTabControl";
            this.skinTabControl.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl.PageArrowDown")));
            this.skinTabControl.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl.PageArrowHover")));
            this.skinTabControl.PageBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.skinTabControl.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl.PageCloseHover")));
            this.skinTabControl.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("skinTabControl.PageCloseNormal")));
            this.skinTabControl.PageDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl.PageDown")));
            this.skinTabControl.PageHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl.PageHover")));
            this.skinTabControl.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.skinTabControl.PageNorml = null;
            this.skinTabControl.PagePalace = true;
            this.skinTabControl.SelectedIndex = 0;
            this.skinTabControl.Size = new System.Drawing.Size(637, 76);
            this.skinTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.skinTabControl.TabIndex = 4;
            this.skinTabControl.SelectedIndexChanged += new System.EventHandler(this.SearchTabIndexChange);
            // 
            // google
            // 
            this.google.BackColor = System.Drawing.Color.White;
            this.google.Controls.Add(this.googleSearch);
            this.google.Controls.Add(this.googleInput);
            this.google.Location = new System.Drawing.Point(0, 36);
            this.google.Name = "google";
            this.google.Padding = new System.Windows.Forms.Padding(3);
            this.google.Size = new System.Drawing.Size(637, 40);
            this.google.TabIndex = 0;
            this.google.Text = "Google";
            this.google.Click += new System.EventHandler(this.Google_Click);
            // 
            // googleSearch
            // 
            this.googleSearch.BackColor = System.Drawing.Color.Transparent;
            this.googleSearch.BaseColor = System.Drawing.Color.DodgerBlue;
            this.googleSearch.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.googleSearch.DownBack = null;
            this.googleSearch.Location = new System.Drawing.Point(545, 3);
            this.googleSearch.MouseBack = null;
            this.googleSearch.Name = "googleSearch";
            this.googleSearch.NormlBack = null;
            this.googleSearch.Size = new System.Drawing.Size(89, 34);
            this.googleSearch.TabIndex = 1;
            this.googleSearch.Text = "Search";
            this.googleSearch.UseVisualStyleBackColor = false;
            this.googleSearch.Click += new System.EventHandler(this.googleSearchClick_Click);
            // 
            // googleInput
            // 
            this.googleInput.BackColor = System.Drawing.Color.Transparent;
            this.googleInput.DownBack = null;
            this.googleInput.Icon = null;
            this.googleInput.IconIsButton = false;
            this.googleInput.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.googleInput.IsPasswordChat = '\0';
            this.googleInput.IsSystemPasswordChar = false;
            this.googleInput.Lines = new string[0];
            this.googleInput.Location = new System.Drawing.Point(3, 3);
            this.googleInput.Margin = new System.Windows.Forms.Padding(0);
            this.googleInput.MaxLength = 32767;
            this.googleInput.MinimumSize = new System.Drawing.Size(28, 28);
            this.googleInput.MouseBack = null;
            this.googleInput.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.googleInput.Multiline = false;
            this.googleInput.Name = "googleInput";
            this.googleInput.NormlBack = null;
            this.googleInput.Padding = new System.Windows.Forms.Padding(5);
            this.googleInput.ReadOnly = false;
            this.googleInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.googleInput.Size = new System.Drawing.Size(539, 34);
            // 
            // 
            // 
            this.googleInput.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.googleInput.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.googleInput.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.googleInput.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.googleInput.SkinTxt.Name = "BaseText";
            this.googleInput.SkinTxt.Size = new System.Drawing.Size(529, 18);
            this.googleInput.SkinTxt.TabIndex = 0;
            this.googleInput.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.googleInput.SkinTxt.WaterText = "Enter a keyword or phrase here";
            this.googleInput.SkinTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.googleInputEnter);
            this.googleInput.TabIndex = 0;
            this.googleInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.googleInput.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.googleInput.WaterText = "Enter a keyword or phrase here";
            this.googleInput.WordWrap = true;
            // 
            // Yahoo
            // 
            this.Yahoo.BackColor = System.Drawing.Color.White;
            this.Yahoo.Controls.Add(this.YahooSearch);
            this.Yahoo.Controls.Add(this.YahooInput);
            this.Yahoo.Location = new System.Drawing.Point(0, 36);
            this.Yahoo.Name = "Yahoo";
            this.Yahoo.Padding = new System.Windows.Forms.Padding(3);
            this.Yahoo.Size = new System.Drawing.Size(637, 40);
            this.Yahoo.TabIndex = 1;
            this.Yahoo.Text = "Yahoo";
            this.Yahoo.Click += new System.EventHandler(this.YahooTabClick);
            // 
            // YahooSearch
            // 
            this.YahooSearch.BackColor = System.Drawing.Color.Transparent;
            this.YahooSearch.BaseColor = System.Drawing.Color.DodgerBlue;
            this.YahooSearch.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.YahooSearch.DownBack = null;
            this.YahooSearch.Location = new System.Drawing.Point(545, 3);
            this.YahooSearch.MouseBack = null;
            this.YahooSearch.Name = "YahooSearch";
            this.YahooSearch.NormlBack = null;
            this.YahooSearch.Size = new System.Drawing.Size(89, 34);
            this.YahooSearch.TabIndex = 2;
            this.YahooSearch.Text = "Search";
            this.YahooSearch.UseVisualStyleBackColor = false;
            this.YahooSearch.Click += new System.EventHandler(this.YahooSearchClick);
            // 
            // YahooInput
            // 
            this.YahooInput.BackColor = System.Drawing.Color.Transparent;
            this.YahooInput.DownBack = null;
            this.YahooInput.Icon = null;
            this.YahooInput.IconIsButton = false;
            this.YahooInput.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.YahooInput.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.YahooInput.IsPasswordChat = '\0';
            this.YahooInput.IsSystemPasswordChar = false;
            this.YahooInput.Lines = new string[0];
            this.YahooInput.Location = new System.Drawing.Point(3, 3);
            this.YahooInput.Margin = new System.Windows.Forms.Padding(0);
            this.YahooInput.MaxLength = 32767;
            this.YahooInput.MinimumSize = new System.Drawing.Size(28, 28);
            this.YahooInput.MouseBack = null;
            this.YahooInput.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.YahooInput.Multiline = false;
            this.YahooInput.Name = "YahooInput";
            this.YahooInput.NormlBack = null;
            this.YahooInput.Padding = new System.Windows.Forms.Padding(5);
            this.YahooInput.ReadOnly = false;
            this.YahooInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.YahooInput.Size = new System.Drawing.Size(537, 34);
            // 
            // 
            // 
            this.YahooInput.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.YahooInput.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.YahooInput.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.YahooInput.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.YahooInput.SkinTxt.Name = "BaseText";
            this.YahooInput.SkinTxt.Size = new System.Drawing.Size(527, 18);
            this.YahooInput.SkinTxt.TabIndex = 0;
            this.YahooInput.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.YahooInput.SkinTxt.WaterText = "Enter a keyword or phrase here";
            this.YahooInput.SkinTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yahooInputEnter);
            this.YahooInput.TabIndex = 1;
            this.YahooInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.YahooInput.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.YahooInput.WaterText = "Enter a keyword or phrase here";
            this.YahooInput.WordWrap = true;
            // 
            // Bing
            // 
            this.Bing.BackColor = System.Drawing.Color.White;
            this.Bing.Controls.Add(this.BingSearch);
            this.Bing.Controls.Add(this.BingInput);
            this.Bing.Location = new System.Drawing.Point(0, 36);
            this.Bing.Name = "Bing";
            this.Bing.Padding = new System.Windows.Forms.Padding(3);
            this.Bing.Size = new System.Drawing.Size(637, 40);
            this.Bing.TabIndex = 2;
            this.Bing.Text = "Bing";
            this.Bing.Click += new System.EventHandler(this.BingTabClick);
            // 
            // BingSearch
            // 
            this.BingSearch.BackColor = System.Drawing.Color.Transparent;
            this.BingSearch.BaseColor = System.Drawing.Color.DodgerBlue;
            this.BingSearch.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BingSearch.DownBack = null;
            this.BingSearch.Location = new System.Drawing.Point(545, 3);
            this.BingSearch.MouseBack = null;
            this.BingSearch.Name = "BingSearch";
            this.BingSearch.NormlBack = null;
            this.BingSearch.Size = new System.Drawing.Size(89, 34);
            this.BingSearch.TabIndex = 2;
            this.BingSearch.Text = "Search";
            this.BingSearch.UseVisualStyleBackColor = false;
            this.BingSearch.Click += new System.EventHandler(this.BingSearchIconClick);
            // 
            // BingInput
            // 
            this.BingInput.BackColor = System.Drawing.Color.Transparent;
            this.BingInput.DownBack = null;
            this.BingInput.Icon = null;
            this.BingInput.IconIsButton = false;
            this.BingInput.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.BingInput.IsPasswordChat = '\0';
            this.BingInput.IsSystemPasswordChar = false;
            this.BingInput.Lines = new string[0];
            this.BingInput.Location = new System.Drawing.Point(3, 3);
            this.BingInput.Margin = new System.Windows.Forms.Padding(0);
            this.BingInput.MaxLength = 32767;
            this.BingInput.MinimumSize = new System.Drawing.Size(28, 28);
            this.BingInput.MouseBack = null;
            this.BingInput.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.BingInput.Multiline = false;
            this.BingInput.Name = "BingInput";
            this.BingInput.NormlBack = null;
            this.BingInput.Padding = new System.Windows.Forms.Padding(5);
            this.BingInput.ReadOnly = false;
            this.BingInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BingInput.Size = new System.Drawing.Size(537, 34);
            // 
            // 
            // 
            this.BingInput.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BingInput.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BingInput.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.BingInput.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.BingInput.SkinTxt.Name = "BaseText";
            this.BingInput.SkinTxt.Size = new System.Drawing.Size(527, 18);
            this.BingInput.SkinTxt.TabIndex = 0;
            this.BingInput.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BingInput.SkinTxt.WaterText = "Enter a keyword or phrase here";
            this.BingInput.SkinTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bingInputEnter);
            this.BingInput.TabIndex = 1;
            this.BingInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BingInput.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BingInput.WaterText = "Enter a keyword or phrase here";
            this.BingInput.WordWrap = true;
            // 
            // YouTube
            // 
            this.YouTube.BackColor = System.Drawing.Color.White;
            this.YouTube.Controls.Add(this.YouTubeSearch);
            this.YouTube.Controls.Add(this.YouTubeInput);
            this.YouTube.Location = new System.Drawing.Point(0, 36);
            this.YouTube.Name = "YouTube";
            this.YouTube.Padding = new System.Windows.Forms.Padding(3);
            this.YouTube.Size = new System.Drawing.Size(637, 40);
            this.YouTube.TabIndex = 3;
            this.YouTube.Text = "YouTube";
            this.YouTube.Click += new System.EventHandler(this.YouTubeTabClick);
            // 
            // YouTubeSearch
            // 
            this.YouTubeSearch.BackColor = System.Drawing.Color.Transparent;
            this.YouTubeSearch.BaseColor = System.Drawing.Color.DodgerBlue;
            this.YouTubeSearch.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.YouTubeSearch.DownBack = null;
            this.YouTubeSearch.Location = new System.Drawing.Point(545, 3);
            this.YouTubeSearch.MouseBack = null;
            this.YouTubeSearch.Name = "YouTubeSearch";
            this.YouTubeSearch.NormlBack = null;
            this.YouTubeSearch.Size = new System.Drawing.Size(89, 34);
            this.YouTubeSearch.TabIndex = 2;
            this.YouTubeSearch.Text = "Search";
            this.YouTubeSearch.UseVisualStyleBackColor = false;
            this.YouTubeSearch.Click += new System.EventHandler(this.YouTubeSearchIconClick);
            // 
            // YouTubeInput
            // 
            this.YouTubeInput.BackColor = System.Drawing.Color.Transparent;
            this.YouTubeInput.DownBack = null;
            this.YouTubeInput.Icon = null;
            this.YouTubeInput.IconIsButton = false;
            this.YouTubeInput.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.YouTubeInput.IsPasswordChat = '\0';
            this.YouTubeInput.IsSystemPasswordChar = false;
            this.YouTubeInput.Lines = new string[0];
            this.YouTubeInput.Location = new System.Drawing.Point(3, 3);
            this.YouTubeInput.Margin = new System.Windows.Forms.Padding(0);
            this.YouTubeInput.MaxLength = 32767;
            this.YouTubeInput.MinimumSize = new System.Drawing.Size(28, 28);
            this.YouTubeInput.MouseBack = null;
            this.YouTubeInput.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.YouTubeInput.Multiline = false;
            this.YouTubeInput.Name = "YouTubeInput";
            this.YouTubeInput.NormlBack = null;
            this.YouTubeInput.Padding = new System.Windows.Forms.Padding(5);
            this.YouTubeInput.ReadOnly = false;
            this.YouTubeInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.YouTubeInput.Size = new System.Drawing.Size(537, 34);
            // 
            // 
            // 
            this.YouTubeInput.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.YouTubeInput.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.YouTubeInput.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.YouTubeInput.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.YouTubeInput.SkinTxt.Name = "BaseText";
            this.YouTubeInput.SkinTxt.Size = new System.Drawing.Size(527, 18);
            this.YouTubeInput.SkinTxt.TabIndex = 0;
            this.YouTubeInput.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.YouTubeInput.SkinTxt.WaterText = "Enter a keyword or phrase here";
            this.YouTubeInput.SkinTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.youtubeInputEnter);
            this.YouTubeInput.TabIndex = 1;
            this.YouTubeInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.YouTubeInput.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.YouTubeInput.WaterText = "Enter a keyword or phrase here";
            this.YouTubeInput.WordWrap = true;
            // 
            // googlePlay
            // 
            this.googlePlay.BackColor = System.Drawing.Color.White;
            this.googlePlay.Controls.Add(this.GooglePlaySearch);
            this.googlePlay.Controls.Add(this.GooglePlayInput);
            this.googlePlay.Location = new System.Drawing.Point(0, 36);
            this.googlePlay.Name = "googlePlay";
            this.googlePlay.Padding = new System.Windows.Forms.Padding(3);
            this.googlePlay.Size = new System.Drawing.Size(637, 40);
            this.googlePlay.TabIndex = 4;
            this.googlePlay.Text = "Google Play";
            this.googlePlay.Click += new System.EventHandler(this.PlayTabClick);
            // 
            // GooglePlaySearch
            // 
            this.GooglePlaySearch.BackColor = System.Drawing.Color.Transparent;
            this.GooglePlaySearch.BaseColor = System.Drawing.Color.DodgerBlue;
            this.GooglePlaySearch.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.GooglePlaySearch.DownBack = null;
            this.GooglePlaySearch.Location = new System.Drawing.Point(545, 3);
            this.GooglePlaySearch.MouseBack = null;
            this.GooglePlaySearch.Name = "GooglePlaySearch";
            this.GooglePlaySearch.NormlBack = null;
            this.GooglePlaySearch.Size = new System.Drawing.Size(89, 34);
            this.GooglePlaySearch.TabIndex = 2;
            this.GooglePlaySearch.Text = "Search";
            this.GooglePlaySearch.UseVisualStyleBackColor = false;
            this.GooglePlaySearch.Click += new System.EventHandler(this.PlaySearchIconClick);
            // 
            // GooglePlayInput
            // 
            this.GooglePlayInput.BackColor = System.Drawing.Color.Transparent;
            this.GooglePlayInput.DownBack = null;
            this.GooglePlayInput.Icon = null;
            this.GooglePlayInput.IconIsButton = false;
            this.GooglePlayInput.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.GooglePlayInput.IsPasswordChat = '\0';
            this.GooglePlayInput.IsSystemPasswordChar = false;
            this.GooglePlayInput.Lines = new string[0];
            this.GooglePlayInput.Location = new System.Drawing.Point(3, 3);
            this.GooglePlayInput.Margin = new System.Windows.Forms.Padding(0);
            this.GooglePlayInput.MaxLength = 32767;
            this.GooglePlayInput.MinimumSize = new System.Drawing.Size(28, 28);
            this.GooglePlayInput.MouseBack = null;
            this.GooglePlayInput.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.GooglePlayInput.Multiline = false;
            this.GooglePlayInput.Name = "GooglePlayInput";
            this.GooglePlayInput.NormlBack = null;
            this.GooglePlayInput.Padding = new System.Windows.Forms.Padding(5);
            this.GooglePlayInput.ReadOnly = false;
            this.GooglePlayInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.GooglePlayInput.Size = new System.Drawing.Size(537, 34);
            // 
            // 
            // 
            this.GooglePlayInput.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GooglePlayInput.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GooglePlayInput.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.GooglePlayInput.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.GooglePlayInput.SkinTxt.Name = "BaseText";
            this.GooglePlayInput.SkinTxt.Size = new System.Drawing.Size(527, 18);
            this.GooglePlayInput.SkinTxt.TabIndex = 0;
            this.GooglePlayInput.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GooglePlayInput.SkinTxt.WaterText = "Enter a keyword or phrase here";
            this.GooglePlayInput.SkinTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.playInputEnter);
            this.GooglePlayInput.TabIndex = 1;
            this.GooglePlayInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GooglePlayInput.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GooglePlayInput.WaterText = "Enter a keyword or phrase here";
            this.GooglePlayInput.WordWrap = true;
            // 
            // amazon
            // 
            this.amazon.BackColor = System.Drawing.Color.White;
            this.amazon.Controls.Add(this.amazonSearchButton);
            this.amazon.Controls.Add(this.amazonInput);
            this.amazon.Location = new System.Drawing.Point(0, 36);
            this.amazon.Name = "amazon";
            this.amazon.Padding = new System.Windows.Forms.Padding(3);
            this.amazon.Size = new System.Drawing.Size(637, 40);
            this.amazon.TabIndex = 5;
            this.amazon.Text = "Amazon";
            this.amazon.Click += new System.EventHandler(this.AmazonTabClick);
            // 
            // amazonSearchButton
            // 
            this.amazonSearchButton.BackColor = System.Drawing.Color.Transparent;
            this.amazonSearchButton.BaseColor = System.Drawing.Color.DodgerBlue;
            this.amazonSearchButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.amazonSearchButton.DownBack = null;
            this.amazonSearchButton.Location = new System.Drawing.Point(545, 3);
            this.amazonSearchButton.MouseBack = null;
            this.amazonSearchButton.Name = "amazonSearchButton";
            this.amazonSearchButton.NormlBack = null;
            this.amazonSearchButton.Size = new System.Drawing.Size(89, 34);
            this.amazonSearchButton.TabIndex = 2;
            this.amazonSearchButton.Text = "Search";
            this.amazonSearchButton.UseVisualStyleBackColor = false;
            this.amazonSearchButton.Click += new System.EventHandler(this.amazonSearchIconClick);
            // 
            // amazonInput
            // 
            this.amazonInput.BackColor = System.Drawing.Color.Transparent;
            this.amazonInput.DownBack = null;
            this.amazonInput.Icon = null;
            this.amazonInput.IconIsButton = false;
            this.amazonInput.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.amazonInput.IsPasswordChat = '\0';
            this.amazonInput.IsSystemPasswordChar = false;
            this.amazonInput.Lines = new string[0];
            this.amazonInput.Location = new System.Drawing.Point(3, 3);
            this.amazonInput.Margin = new System.Windows.Forms.Padding(0);
            this.amazonInput.MaxLength = 32767;
            this.amazonInput.MinimumSize = new System.Drawing.Size(28, 28);
            this.amazonInput.MouseBack = null;
            this.amazonInput.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.amazonInput.Multiline = false;
            this.amazonInput.Name = "amazonInput";
            this.amazonInput.NormlBack = null;
            this.amazonInput.Padding = new System.Windows.Forms.Padding(5);
            this.amazonInput.ReadOnly = false;
            this.amazonInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.amazonInput.Size = new System.Drawing.Size(537, 34);
            // 
            // 
            // 
            this.amazonInput.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.amazonInput.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.amazonInput.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.amazonInput.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.amazonInput.SkinTxt.Name = "BaseText";
            this.amazonInput.SkinTxt.Size = new System.Drawing.Size(527, 18);
            this.amazonInput.SkinTxt.TabIndex = 0;
            this.amazonInput.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.amazonInput.SkinTxt.WaterText = "Enter a keyword or phrase here";
            this.amazonInput.SkinTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amazonInputEnter);
            this.amazonInput.TabIndex = 1;
            this.amazonInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.amazonInput.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.amazonInput.WaterText = "Enter a keyword or phrase here";
            this.amazonInput.WordWrap = true;
            // 
            // export
            // 
            this.export.BackColor = System.Drawing.Color.Transparent;
            this.export.BaseColor = System.Drawing.Color.DodgerBlue;
            this.export.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.export.DownBack = null;
            this.export.Location = new System.Drawing.Point(553, 394);
            this.export.MouseBack = null;
            this.export.Name = "export";
            this.export.NormlBack = null;
            this.export.Size = new System.Drawing.Size(119, 29);
            this.export.TabIndex = 6;
            this.export.Text = "Export";
            this.export.UseVisualStyleBackColor = false;
            this.export.Click += new System.EventHandler(this.GenExcelClick);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Transparent;
            this.clear.BaseColor = System.Drawing.Color.DodgerBlue;
            this.clear.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.clear.DownBack = null;
            this.clear.Location = new System.Drawing.Point(431, 394);
            this.clear.MouseBack = null;
            this.clear.Name = "clear";
            this.clear.NormlBack = null;
            this.clear.Size = new System.Drawing.Size(116, 29);
            this.clear.TabIndex = 7;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.ClearClick);
            // 
            // resultListView
            // 
            this.resultListView.BorderColor = System.Drawing.Color.LightBlue;
            this.resultListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Term,
            this.KeyWord});
            this.resultListView.HeadColor = System.Drawing.Color.AliceBlue;
            this.resultListView.HideSelection = false;
            this.resultListView.Location = new System.Drawing.Point(35, 178);
            this.resultListView.Name = "resultListView";
            this.resultListView.OwnerDraw = true;
            this.resultListView.RowBackColor2 = System.Drawing.Color.White;
            this.resultListView.SelectedColor = System.Drawing.Color.White;
            this.resultListView.Size = new System.Drawing.Size(637, 210);
            this.resultListView.TabIndex = 8;
            this.resultListView.UseCompatibleStateImageBehavior = false;
            this.resultListView.View = System.Windows.Forms.View.Details;
            // 
            // Term
            // 
            this.Term.Text = "Search Terms";
            this.Term.Width = 317;
            // 
            // KeyWord
            // 
            this.KeyWord.Text = "Keywords";
            this.KeyWord.Width = 319;
            // 
            // ProgressIndicator
            // 
            this.ProgressIndicator.BackColor = System.Drawing.Color.White;
            this.ProgressIndicator.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ProgressIndicator.Location = new System.Drawing.Point(337, 268);
            this.ProgressIndicator.Name = "ProgressIndicator";
            this.ProgressIndicator.Percentage = 0F;
            this.ProgressIndicator.Size = new System.Drawing.Size(45, 45);
            this.ProgressIndicator.TabIndex = 9;
            this.ProgressIndicator.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(712, 430);
            this.Controls.Add(this.ProgressIndicator);
            this.Controls.Add(this.resultListView);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.export);
            this.Controls.Add(this.skinTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.skinTabControl.ResumeLayout(false);
            this.google.ResumeLayout(false);
            this.Yahoo.ResumeLayout(false);
            this.Bing.ResumeLayout(false);
            this.YouTube.ResumeLayout(false);
            this.googlePlay.ResumeLayout(false);
            this.amazon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinTabControl skinTabControl;
        private System.Windows.Forms.TabPage google;
        private System.Windows.Forms.TabPage Yahoo;
        private CCWin.SkinControl.SkinButton googleSearch;
        private CCWin.SkinControl.SkinTextBox googleInput;
        private System.Windows.Forms.TabPage Bing;
        private System.Windows.Forms.TabPage YouTube;
        private System.Windows.Forms.TabPage googlePlay;
        private System.Windows.Forms.TabPage amazon;
        private CCWin.SkinControl.SkinButton export;
        private CCWin.SkinControl.SkinButton clear;
        private CCWin.SkinControl.SkinButton YahooSearch;
        private CCWin.SkinControl.SkinTextBox YahooInput;
        private CCWin.SkinControl.SkinButton BingSearch;
        private CCWin.SkinControl.SkinTextBox BingInput;
        private CCWin.SkinControl.SkinButton YouTubeSearch;
        private CCWin.SkinControl.SkinTextBox YouTubeInput;
        private CCWin.SkinControl.SkinButton GooglePlaySearch;
        private CCWin.SkinControl.SkinTextBox GooglePlayInput;
        private CCWin.SkinControl.SkinButton amazonSearchButton;
        private CCWin.SkinControl.SkinTextBox amazonInput;
        private CCWin.SkinControl.SkinListView resultListView;
        private System.Windows.Forms.ColumnHeader Term;
        private System.Windows.Forms.ColumnHeader KeyWord;
        private CCWin.SkinControl.SkinProgressIndicator ProgressIndicator;
    }
}

