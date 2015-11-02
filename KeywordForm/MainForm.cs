using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SearchEngin;
using CCWin.SkinControl;
using System.Threading;
using Excel;
using KeywordForm;
using CCWin;
using System.IO;
using System.Text.RegularExpressions;
using EncrypterUtils;

namespace SearchApplication
{

    public partial class Form1 : CCSkinMain
    {
        private SearchEnginBase mGoogleEngin;
        private SearchEnginBase mYahooEngin;
        private SearchEnginBase mBingEngin;
        private SearchEnginBase mYouTubeEngin;
        private SearchEnginBase mGooglePlayEngin;
        private SearchEnginBase mAmazonEngin;

        private bool isActivate;

        public bool IsActivate
        {
            get
            {
                return isActivate;
            }
            set
            {
                this.isActivate = value;
            }
        }

        SynchronizationContext _syncContext = null;

        private delegate void GCallBackDelegate(Object result);
        private delegate void YCallBackDelegate(Object result);
        private delegate void BCallBackDelegate(Object result);
        private delegate void TCallBackDelegate(Object result);
        private delegate void PCallBackDelegate(Object result);
        private delegate void ACallBackDelegate(Object result);

        private delegate void GenExcelCallBackDelegate();

        private String googleKeyWord;
        private String YahooKeyWord;
        private String BingKeyWord;
        private String YouTubeKeyWord;
        private String PlayKeyWord;
        private String AmazonKeyWord;

        private String currentKeyWord;

        private TYPE mType;
        enum TYPE{
            GOOGLE, YAHOO, BING, YOUTUBE, PLAY, AMAZON
        }

        public Form1()
        {
            InitializeComponent();
            _syncContext = SynchronizationContext.Current;
            //判断是否已经激活
            this.isActivate = validateIsActivate();
            if (this.isActivate)
            {
                this.trialLable.Visible = false;
            }
        }

        public void updateActivateStatus(bool isActivate)
        {
            this.isActivate = isActivate;
            this.trialLable.Visible = false;
        }

        private bool validateIsActivate()
        {
            try
            {
                //获取安装目录
                String installDir = Application.StartupPath;
                //读取key文件
                FileStream fs = new FileStream(installDir + "\\data.bin", FileMode.Open, FileAccess.Read, FileShare.None);
                StreamReader sr = new StreamReader(fs, Encoding.UTF8);
                string serialNumber = sr.ReadLine();
                sr.Close();
                return Encrypter.ValidateSerialNumber(serialNumber);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.Write("Form1_Load");
            mGoogleEngin = new GoogleEngin();
            mYahooEngin = new YahooEngin();
            mBingEngin = new BingEngin();
            mYouTubeEngin = new YoutubeEngin();
            mGooglePlayEngin = new GooglePlayEngin();
            mAmazonEngin = new AmazonEngin();
        }

        //google
        private void Google_Click(object sender, EventArgs e)
        {
            //DO NOTHING
        }

        private void googleSearchClick_Click(object sender, EventArgs e)
        {
            Console.Write("googleSearchClick_Click");
            googleKeyWord = this.googleInput.Text;
            if (googleKeyWord == "" || googleKeyWord == null)
            {
                showMessageTip();
                return;
            }
            currentKeyWord = googleKeyWord;

            showProgress();
            this.googleSearch.Enabled = false;
            GCallBackDelegate cbd = gCallBack;
            Thread t = new Thread(gExecutorInThread);
            t.Start(cbd);
        }
        private void gCallBack(Object result)
        {
            //主线程报告信息,可以根据这个信息做判断操作,执行不同逻辑.
            showResultOnList((List < SearchTerm >)result);
            mType = TYPE.GOOGLE;
        }

         private void gExecutorInThread(Object callBack)
        {
            //子线程执行
            List<SearchTerm> result = mGoogleEngin.SearchKeyWordByTerm(googleKeyWord, this.isActivate);
            GCallBackDelegate cbd = callBack as GCallBackDelegate;
            cbd(result);
        }

        //Yahoo
        private void YahooTabClick(object sender, EventArgs e)
        {
            //DO NOTHING
        }

        private void YahooSearchClick(object sender, EventArgs e)
        {
            Console.Write("YahooSearchClick");
            YahooKeyWord = this.YahooInput.Text;
            if (YahooKeyWord == "" || YahooKeyWord == null)
            {
                showMessageTip();
                return;
            }
            currentKeyWord = YahooKeyWord;

            showProgress();
            this.YahooSearch.Enabled = false;
            YCallBackDelegate cbd = yCallBack;
            Thread t = new Thread(yExecutorInThread);
            t.Start(cbd);
        }

        private void yCallBack(Object result)
        {
            //主线程报告信息,可以根据这个信息做判断操作,执行不同逻辑.
            showResultOnList((List<SearchTerm>)result);
            mType = TYPE.YAHOO;
        }

        private void yExecutorInThread(Object callBack)
        {
            //子线程执行
            List<SearchTerm> result = mYahooEngin.SearchKeyWordByTerm(YahooKeyWord, this.isActivate);
            YCallBackDelegate cbd = callBack as YCallBackDelegate;
            cbd(result);
        }

        //Bing
        private void BingTabClick(object sender, EventArgs e)
        {
            //DO NOTHING
        }

        private void BingSearchIconClick(object sender, EventArgs e)
        {
            Console.Write("BingSearchIconClick");
            BingKeyWord = this.BingInput.Text;
            if (BingKeyWord == "" || BingKeyWord == null)
            {
                showMessageTip();
                return;
            }
            this.BingSearch.Enabled = false;

            currentKeyWord = BingKeyWord;
            showProgress();
            BCallBackDelegate cbd = bCallBack;
            Thread t = new Thread(bExecutorInThread);
            t.IsBackground = true;
            t.Start(cbd);
        }

        private void bCallBack(Object result)
        {
            //主线程报告信息,可以根据这个信息做判断操作,执行不同逻辑.
            showResultOnList((List<SearchTerm>)result);
            mType = TYPE.BING;
        }

        private void bExecutorInThread(Object callBack)
        {
            //子线程执行
            List<SearchTerm> result = mBingEngin.SearchKeyWordByTerm(BingKeyWord, this.isActivate);
            BCallBackDelegate cbd = callBack as BCallBackDelegate;
            cbd(result);
        }

        //YouTube
        private void YouTubeTabClick(object sender, EventArgs e)
        {
            //DO NOTHING
        }

        private void YouTubeSearchIconClick(object sender, EventArgs e)
        {
            Console.Write("YouTubeSearchIconClick");
            YouTubeKeyWord = this.YouTubeInput.Text;
            if (YouTubeKeyWord == "" || YouTubeKeyWord == null)
            {
                showMessageTip();
                return;
            }
            currentKeyWord = YouTubeKeyWord;

            showProgress();
            this.YouTubeSearch.Enabled = false;
            TCallBackDelegate cbd = tCallBack;
            Thread t = new Thread(tExecutorInThread);
            t.Start(cbd);
        }

        private void tCallBack(Object result)
        {
            //主线程报告信息,可以根据这个信息做判断操作,执行不同逻辑.
            showResultOnList((List<SearchTerm>)result);
            mType = TYPE.YOUTUBE;
        }

        private void tExecutorInThread(Object callBack)
        {
            //子线程执行
            List<SearchTerm> result = mYouTubeEngin.SearchKeyWordByTerm(YouTubeKeyWord, this.isActivate);
            TCallBackDelegate cbd = callBack as TCallBackDelegate;
            cbd(result);
        }

        //google Play
        private void PlayTabClick(object sender, EventArgs e)
        {
            //DO NOTHING
        }

        private void PlaySearchIconClick(object sender, EventArgs e)
        {
            Console.Write("PlaySearchIconClick");
            PlayKeyWord = this.GooglePlayInput.Text;
            if (PlayKeyWord == "" || PlayKeyWord == null)
            {
                showMessageTip();
                return;
            }
            currentKeyWord = PlayKeyWord;

            showProgress();
            this.GooglePlaySearch.Enabled = false;
            PCallBackDelegate cbd = pCallBack;
            Thread t = new Thread(pExecutorInThread);
            t.Start(cbd);
        }


        private void pCallBack(Object result)
        {
            //主线程报告信息,可以根据这个信息做判断操作,执行不同逻辑.
            showResultOnList((List<SearchTerm>)result);
            mType = TYPE.PLAY;
        }

        private void pExecutorInThread(Object callBack)
        {
            //子线程执行
            List<SearchTerm> result = this.mGooglePlayEngin.SearchKeyWordByTerm(PlayKeyWord, this.isActivate);
            PCallBackDelegate cbd = callBack as PCallBackDelegate;
            cbd(result);
        }

        //amazon
        private void AmazonTabClick(object sender, EventArgs e)
        {
            //DO NOTHING
        }

        private void amazonSearchIconClick(object sender, EventArgs e)
        {
            Console.Write("amazonSearchIconClick");
            AmazonKeyWord = this.amazonInput.Text;
            if (AmazonKeyWord == "" || AmazonKeyWord == null)
            {
                showMessageTip();
                return;
            }
            currentKeyWord = AmazonKeyWord;

            showProgress();
            this.amazonSearchButton.Enabled = false;
            ACallBackDelegate cbd = aCallBack;
            Thread t = new Thread(aExecutorInThread);
            t.Start(cbd);
        }

        private void aCallBack(Object result)
        {
            //主线程报告信息,可以根据这个信息做判断操作,执行不同逻辑.
            showResultOnList((List<SearchTerm>)result);
            mType = TYPE.AMAZON;
        }

        private void aExecutorInThread(Object callBack)
        {
            //子线程执行
            List<SearchTerm> result = mAmazonEngin.SearchKeyWordByTerm(AmazonKeyWord, this.isActivate);
            ACallBackDelegate cbd = callBack as ACallBackDelegate;
            cbd(result);
        }

        private void showMessageTip()
        {
            //MyMessageBoxEx.show("key word can not be empty!");
        }


        private void SearchTabIndexChange(object sender, EventArgs e)
        {
            Console.Write("amazonSearchIconClick");
            this.EmptyTipLab.Visible = false;
            SkinTabControl skinTab = (SkinTabControl)sender;
            int index = skinTab.SelectedIndex;
            if (currentKeyWord == null || "".Equals(currentKeyWord))
            {
                return;
            }
            switch (index)
            {
                case 0:
                    this.googleInput.Text = currentKeyWord;
                    break;

                case 1:
                    this.YahooInput.Text = currentKeyWord;
                    break;

                case 2:
                    this.BingInput.Text = currentKeyWord;
                    break;

                case 3:
                    this.YouTubeInput.Text = currentKeyWord;
                    break;

                case 4:
                    this.GooglePlayInput.Text = currentKeyWord;
                    break;

                case 5:
                    this.amazonInput.Text = currentKeyWord;
                    break;
            }
        }

        private List<SearchTerm> mTempResult;
        private void showResultOnList(List<SearchTerm> result)
        {
            _syncContext.Post(showResult, result);
        }

        private void showResult(Object result) {
            hideProgress();
            List<SearchTerm> temp = (List<SearchTerm>)result;
            if (temp == null || temp.Count == 0)
            {
                //showMessageTip();
                this.EmptyTipLab.Visible = true;
            }
            else
            {

                mTempResult = removeTheSame(temp);
                this.resultListView.BeginUpdate();
                foreach (SearchTerm s in mTempResult)
                {
                    string[] s1 = { s.Term, s.Keyword };
                    ListViewItem item = new ListViewItem(s1);
                    this.resultListView.Items.Add(item);
                }
                this.resultListView.EndUpdate();
            }
        }

        private List<SearchTerm> removeTheSame(List<SearchTerm> temp)
        {
            List<SearchTerm> nonDuplicateList = new List<SearchTerm>();
            List<String> keywords = new List<String>();

            foreach (SearchTerm term in temp)
            {
                if (!keywords.Contains(term.Keyword.Trim()))
                {
                    keywords.Add(term.Keyword.Trim());
                    nonDuplicateList.Add(term);
                }
                   
            }
            return nonDuplicateList;
        }


        private void GenExcelClick(object sender, EventArgs e)
        {
            if (!this.isActivate)
            {
                trialLable_Click(null, null);
                return;
            }
            Console.Write("GenExcelClick");
            String currentKeyWordTemp;
            String currentEngin;
            switch (mType)
            {
                case TYPE.GOOGLE:
                    currentEngin = "google";
                    currentKeyWordTemp = googleKeyWord;
                    break;
                case TYPE.YAHOO:
                    currentKeyWordTemp = YahooKeyWord;
                    currentEngin = "yahoo";
                    break;

                case TYPE.BING:
                    currentEngin = "bing";
                    currentKeyWordTemp = BingKeyWord;
                    break;

                case TYPE.YOUTUBE:
                    currentEngin = "youtube";
                    currentKeyWordTemp = YouTubeKeyWord;
                    break;

                case TYPE.PLAY:
                    currentEngin = "google play";
                    currentKeyWordTemp = PlayKeyWord;
                    break;

                case TYPE.AMAZON:
                    currentEngin = "amazon";
                    currentKeyWordTemp = AmazonKeyWord;
                    break;
                default:
                    currentKeyWordTemp = "";
                    currentEngin = "";
                    break;

            }
            if (!checkExcel())
            {
                MyMessageBoxEx.show("can not creat excel. make sure you have install excel!");
                return;
            }

            if (mTempResult == null || mTempResult.Count == 0)
            {
                MyMessageBoxEx.show("result is empty");
                return;
            }

            String fileName = showFileSelectDialog(mTempResult, currentEngin, currentKeyWordTemp);
            GenExcelCallBackDelegate callback = excelCallBack;
            Object[] param = new object[5] { currentEngin, currentKeyWordTemp, fileName, mTempResult, callback };
            
            this.export.Enabled = false;
            Thread t = new Thread(genExcel);
            t.Start(param);
        }

        private void genExcel(Object param)
        {
            Object[] obj = (Object[])param;
            ExcelHelper.exportExcel((string)obj[0], (string)obj[1], (string)obj[2], (List<SearchTerm>)obj[3]);

            GenExcelCallBackDelegate callback = obj[4] as GenExcelCallBackDelegate;
            callback();
        }

        private void excelCallBack()
        {
            _syncContext.Post(showTip, new Object());
        }

        private void showTip(Object obj)
        {
            this.export.Enabled = true;
            MyMessageBoxEx.show("Export successfully!");
        }

        private String showFileSelectDialog(List<SearchTerm> result, String enginName, String keyword)
        {
            string title = enginName + " - " + keyword;
            //选择框
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = "xls";
            saveDialog.AddExtension = true;
            saveDialog.Filter = "Excel 文件|*.xls";
            saveDialog.FileName = title + ".xls";
            //保存对话框是否记忆上次打开的目录
            saveDialog.RestoreDirectory = true;
            DialogResult saveResult = saveDialog.ShowDialog();
            if (saveResult == DialogResult.Cancel)
            {
                return null;
            }
            string saveFileName = saveDialog.FileName;
            return saveFileName;
            //MessageBox.Show("选择的文件为：\r\n" + saveFileName);
        }

        private bool checkExcel()
        {
           
            Type type = Type.GetTypeFromProgID("Excel.Application");
            if(type == null) {
                return false;
            }

            Microsoft.Office.Interop.Excel.Application  xls = new Microsoft.Office.Interop.Excel.Application();
            if (xls == null)
            {
                MyMessageBoxEx.show("Can't create excel file, please make sure you have installed Excel correctly!");
                return false;
            }
            else
            {
                xls = null;
                return true;
            }
        }

        private void ClearClick(object sender, EventArgs e)
        {
            Console.Write("ClearClick");
            this.resultListView.Items.Clear();
        }

        private void showProgress()
        {
            this.EmptyTipLab.Visible = false;
            this.resultListView.Items.Clear();
            this.ProgressIndicator.Visible = true;
            this.ProgressIndicator.Start();
        }

        private void hideProgress()
        {
            this.YahooSearch.Enabled = true;
            this.googleSearch.Enabled = true;
            this.amazonSearchButton.Enabled = true;
            this.GooglePlaySearch.Enabled = true;
            this.BingSearch.Enabled = true;
            this.YouTubeSearch.Enabled = true;

            this.ProgressIndicator.Visible = false;
            this.ProgressIndicator.Stop();
        }

        private void googleInputEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13 && this.googleSearch.Enabled == true)
            {
                googleSearchClick_Click(null, null);
            }
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void yahooInputEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13 && this.YahooSearch.Enabled == true)
            {
                YahooSearchClick(null, null);
            }
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void bingInputEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13 && this.BingSearch.Enabled == true)
            {
                BingSearchIconClick(null, null);
            }
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void youtubeInputEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13 && this.YouTubeSearch.Enabled == true)
            {
                YouTubeSearchIconClick(null, null);
            }
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void playInputEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13 && this.GooglePlaySearch.Enabled == true)
            {
                PlaySearchIconClick(null, null);
            }
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void amazonInputEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13 && this.amazonSearchButton.Enabled == true)
            {
                amazonSearchIconClick(null, null);
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void trialLable_Click(object sender, EventArgs e)
        {
            ActivateForm frm = new ActivateForm(this);
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

    }
}
