using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{

    public partial class Form1 : Form
    {


        private string mSearchKeyWord;


        public Form1()
        {
            InitializeComponent();
        }

        //google
        private void Google_Click(object sender, EventArgs e)
        {
            Console.Write("Google_Click");
        }


        private void googleTextChange(object sender, EventArgs e)
        {
            Console.Write("googleTextChange");
            setKeyWord(sender);
        }

        private void googleCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.Write("googleCombobox_SelectedIndexChanged");
        }

        private void googleSearchClick_Click(object sender, EventArgs e)
        {
            Console.Write("googleSearchClick_Click");
        }

        //Yahoo
        private void YahooTabClick(object sender, EventArgs e)
        {
            Console.Write("YahooTabClick");
        }

        private void YahooTextChange(object sender, EventArgs e)
        {
            Console.Write("YahooTextChange");
            setKeyWord(sender);
        }

        private void YahooComboBoxChange(object sender, EventArgs e)
        {
            Console.Write("YahooComboBoxChange");
        }

        private void YahooSearchClick(object sender, EventArgs e)
        {
            Console.Write("YahooSearchClick");
        }

        //Bing
        private void BingTabClick(object sender, EventArgs e)
        {
            Console.Write("BingTabClick");
        }

        private void BingTextChange(object sender, EventArgs e)
        {
            Console.Write("BingTextChange");
            setKeyWord(sender);
        }

        private void BingComboBoxChange(object sender, EventArgs e)
        {
            Console.Write("BingComboBoxChange");
        }

        private void BingSearchIconClick(object sender, EventArgs e)
        {
            Console.Write("BingSearchIconClick");
        }

        //YouTube
        private void YouTubeTabClick(object sender, EventArgs e)
        {
            Console.Write("YouTubeTabClick");
        }

        private void YouTubeSearchTextChange(object sender, EventArgs e)
        {
            Console.Write("YouTubeSearchTextChange");
            setKeyWord(sender);
        }

        private void YouTubeComboBoxChange(object sender, EventArgs e)
        {
            Console.Write("YouTubeComboBoxChange");
        }

        private void YouTubeSearchIconClick(object sender, EventArgs e)
        {
            Console.Write("YouTubeSearchIconClick");
        }

        //google Play
        private void PlayTabClick(object sender, EventArgs e)
        {
            Console.Write("PlayTabClick");
        }

        private void PlaySearchTextChange(object sender, EventArgs e)
        {
            Console.Write("PlaySearchTextChange");
            setKeyWord(sender);
        }

        private void PlayComboBoxChange(object sender, EventArgs e)
        {
            Console.Write("PlayComboBoxChange");
        }

        private void PlaySearchIconClick(object sender, EventArgs e)
        {
            Console.Write("PlaySearchIconClick");
        }

        //amazon
        private void AmazonTabClick(object sender, EventArgs e)
        {
            Console.Write("AmazonTabClick");
        }

        private void amazonSearchTextChange(object sender, EventArgs e)
        {
            Console.Write("amazonSearchTextChange");
            setKeyWord(sender);
        }

        private void amazonComboBoxChange(object sender, EventArgs e)
        {
            Console.Write("amazonComboBoxChange");
        }

        private void amazonSearchIconClick(object sender, EventArgs e)
        {
            Console.Write("amazonSearchIconClick");
        }

        private void SearchTabIndexChange(object sender, EventArgs e)
        {
            Console.Write("amazonSearchIconClick");
        }

        private void setKeyWord(Object sender)
        {
            mSearchKeyWord = ((TextBoxBase)sender).Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
