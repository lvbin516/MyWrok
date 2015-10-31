using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KeywordForm
{
    public class MyMessageBoxEx
    {
        public static void show(string text)
        {
            MyMessageBoxForm form = new MyMessageBoxForm();
            form.StartPosition = FormStartPosition.CenterParent;
            form.setText(text);
            form.ShowDialog();
        }
    }
}
