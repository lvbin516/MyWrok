using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CCWin;

namespace KeywordForm
{
    public partial class MyMessageBoxForm : CCSkinMain
    {
        public MyMessageBoxForm()
        {
            InitializeComponent();
        }

        public void setText(string text)
        {
            this.messageLabel.Text = text;
        }

    }
}
