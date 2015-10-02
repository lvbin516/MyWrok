using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CCWin;
using SearchEngin;
using CCWin.SkinControl;
using System.Threading;
using Excel;

namespace WindowsFormsApplication1
{

    public partial class Form1 : CCSkinMain
    {
        private SearchEnginBase mGoogleEngin;
        private SearchEnginBase mYahooEngin;
        private SearchEnginBase mBingEngin;
        private SearchEnginBase mYouTubeEngin;
        private SearchEnginBase mGooglePlayEngin;
        private SearchEnginBase mAmazonEngin;

        private delegate void GCallBackDelegate(Object result);
        private delegate void YCallBackDelegate(Object result);
        private delegate void BCallBackDelegate(Object result);
        private delegate void TCallBackDelegate(Object result);
        private delegate void PCallBackDelegate(Object result);
        private delegate void ACallBackDelegate(Object result);

        private String googleKeyWord;
        private String YahooKeyWord;
        private String BingKeyWord;
        private String YouTubeKeyWord;
        private String PlayKeyWord;
        private String AmazonKeyWord;
        private TYPE mType;
        enum TYPE{
            GOOGLE, YAHOO, BING, YOUTUBE, PLAY, AMAZON
        }

        public Form1()
        {
            InitializeComponent();
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
            this.googleSearch.Enabled = true;
            mType = TYPE.GOOGLE;
            hideProgress();
        }

         private void gExecutorInThread(Object callBack)
        {
            //子线程执行
            List<SearchTerm> result = mGoogleEngin.SearchKeyWordByTerm(googleKeyWord);
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
            this.YahooSearch.Enabled = true;
            mType = TYPE.YAHOO;
            hideProgress();
        }

        private void yExecutorInThread(Object callBack)
        {
            //子线程执行
            List<SearchTerm> result = mYahooEngin.SearchKeyWordByTerm(YahooKeyWord);
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
            showProgress();
            BCallBackDelegate cbd = bCallBack;
            Thread t = new Thread(bExecutorInThread);
            t.Start(cbd);
        }

        private void bCallBack(Object result)
        {
            //主线程报告信息,可以根据这个信息做判断操作,执行不同逻辑.
            showResultOnList((List<SearchTerm>)result);
            this.BingSearch.Enabled = true;
            mType = TYPE.BING;
            hideProgress();
        }

        private void bExecutorInThread(Object callBack)
        {
            //子线程执行
            List<SearchTerm> result = mBingEngin.SearchKeyWordByTerm(BingKeyWord);
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
            this.YouTubeSearch.Enabled = true;
            mType = TYPE.YOUTUBE;
            hideProgress();
        }

        private void tExecutorInThread(Object callBack)
        {
            //子线程执行
            List<SearchTerm> result = mYouTubeEngin.SearchKeyWordByTerm(YouTubeKeyWord);
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
            this.GooglePlaySearch.Enabled = true;
            mType = TYPE.PLAY;
            hideProgress();
        }

        private void pExecutorInThread(Object callBack)
        {
            //子线程执行
            List<SearchTerm> result = this.mGooglePlayEngin.SearchKeyWordByTerm(PlayKeyWord);
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
            this.amazonSearchButton.Enabled = true;
            mType = TYPE.AMAZON;
            hideProgress();
        }

        private void aExecutorInThread(Object callBack)
        {
            //子线程执行
            List<SearchTerm> result = mAmazonEngin.SearchKeyWordByTerm(AmazonKeyWord);
            ACallBackDelegate cbd = callBack as ACallBackDelegate;
            cbd(result);
        }

        private void showMessageTip()
        {
            //MessageBoxEx.Show(this, "key word can not be empty!");
        }


        private void SearchTabIndexChange(object sender, EventArgs e)
        {
            Console.Write("amazonSearchIconClick");
        }

        private List<SearchTerm> mTempResult;
        private void showResultOnList(List<SearchTerm> result)
        {
            if (result == null || result.Count == 0)
            {
                showMessageTip();
            }
            else
            {
                mTempResult = result;
                this.resultListView.BeginUpdate();
                foreach (SearchTerm s in result)
                {
                    string[] s1 = { s.Term, s.Keyword };
                    ListViewItem item = new ListViewItem(s1);
                    this.resultListView.Items.Add(item);
                }
                this.resultListView.EndUpdate();
            }
        }


        private void GenExcelClick(object sender, EventArgs e)
        {
            Console.Write("GenExcelClick");
            String currentKeyWord;
            String currentEngin;
            switch (mType)
            {
                case TYPE.GOOGLE:
                    currentEngin = "google";
                    currentKeyWord = googleKeyWord;
                    break;
                case TYPE.YAHOO:
                    currentKeyWord = YahooKeyWord;
                    currentEngin = "yahoo";
                    break;

                case TYPE.BING:
                    currentEngin = "bing";
                    currentKeyWord = BingKeyWord;
                    break;

                case TYPE.YOUTUBE:
                    currentEngin = "youtube";
                    currentKeyWord = YouTubeKeyWord;
                    break;

                case TYPE.PLAY:
                    currentEngin = "google play";
                    currentKeyWord = PlayKeyWord;
                    break;

                case TYPE.AMAZON:
                    currentEngin = "amazon";
                    currentKeyWord = AmazonKeyWord;
                    break;
                default:
                    currentKeyWord = "";
                    currentEngin = "";
                    break;

            }

            Object[] param = new object[3] { currentEngin, currentKeyWord, mTempResult };
            Thread t = new Thread(genExcel);
            t.Start(param);
        }

        private void genExcel(Object param)
        {
            Object[] obj = (Object[])param;
            //need modify
            ExcelHelper.exportExcel((String)obj[0], (String)obj[1], (List<SearchTerm>)obj[2]);
        }

        private void ClearClick(object sender, EventArgs e)
        {
            Console.Write("ClearClick");
            this.resultListView.Items.Clear();
        }

        private void showProgress()
        {
            this.resultListView.Items.Clear();
            this.ProgressIndicator.Visible = true;
            this.ProgressIndicator.Start();
        }

        private void hideProgress()
        {
            this.ProgressIndicator.Visible = false;
            this.ProgressIndicator.Stop();
        }

    }
}
