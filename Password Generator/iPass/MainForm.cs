
using System;
using System.Linq;
using System.Windows.Forms;

namespace iPass
{
    public partial class MainForm : Form
    {
        int passLength = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        //Shuffle method that returns a string parameter with all the characters' position changed.
        static string Shuffle(string input)
        {
            var q = from c in input.ToCharArray()
                    orderby Guid.NewGuid()
                    select c;
            string s = string.Empty;
            foreach (var r in q)
                s += r;
            return s;
        }
        private void btn_generatepass_Click(object sender, EventArgs e)
        {
            txb_password.Text = "";
            string text = "aAbBcCdDeEfFgGhHiIjJhHkKlLmMnNoOpPqQrRsStTuUvVwWxXyYzZ01234567890123456789,;:!*$@-_=,;:!*$@-_=";
            text = Shuffle(text); //shuffle the above symbols using shuffle() method.
            text = text.Remove(passLength); //cut the string size according to the chosen trackbar value.
            txb_password.Text = text;
        }

        private void trckbar_length_ValueChanged(object sender, EventArgs e)
        {
            passLength = trckbar_length.Value + 1; //trackbar value starts from 0, so I add +1 to make it understandable;
            lbl_passlength.Text = passLength.ToString();
        }
    }
}
