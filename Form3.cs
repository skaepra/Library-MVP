using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int lop;
        int draw = 0;
        int xo = 0;
        int me = 0;
        int you = 0;

        List<Button> buttons;
        void loadbuttons()
        {
            buttons = new List<Button> { b1, b2, b3, b4, b5, b6, b7, b8, b9 };
        }
        void winer(Button bm1, Button bm2, Button bm3)
        {
            bm1.ForeColor = Color.Red;
            bm2.ForeColor = Color.Red;
            bm3.ForeColor = Color.Red;
            if (bm1.Text == "X")
            {

                me++;
                labl1.Text = me.ToString();


            }
            else
            {
                you++;
                labl2.Text = you.ToString();
            }

        }
        bool GG = false;
        void win()
        {
            if (b1.Text != "" && b1.Text == b2.Text && b1.Text == b3.Text)
            {
                winer(b1, b2, b3);
                GG = true;
            }
            else if (b4.Text != "" && b4.Text == b5.Text && b4.Text == b6.Text)
            {
                winer(b4, b5, b6);
                GG = true;

            }
            else if (b7.Text != "" && b7.Text == b8.Text && b7.Text == b9.Text)
            {
                winer(b7, b8, b9);
                GG = true;

            }
            else if (b1.Text != "" && b1.Text == b5.Text && b1.Text == b9.Text)
            {
                winer(b1, b5, b9);
                GG = true;
            }
            else if (b3.Text != "" && b3.Text == b5.Text && b3.Text == b7.Text)
            {
                winer(b3, b5, b7);
                GG = true;
            }
            else if (b1.Text != "" && b1.Text == b4.Text && b1.Text == b7.Text)
            {
                winer(b1, b4, b7);
                GG = true;
            }
            else if (b2.Text != "" && b2.Text == b5.Text && b2.Text == b8.Text)
            {
                winer(b2, b5, b8);
                GG = true;
            }
            else if (b3.Text != "" && b3.Text == b6.Text && b3.Text == b9.Text)
            {
                winer(b3, b6, b9);
                GG = true;
            }
            else if (xo == 8)
            {
                draw++;
                lab6.Text = draw.ToString();

            }
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            foreach (Control c in panel2.Controls)
            {
                if (c is Button)
                {
                    c.Click += new System.EventHandler(b_click);
                }
            }
            loadbuttons();
        }
        public void b_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (lop == 0)
                lop++;

            if (lop % 2 == 0)
            {
               
                if (b.Text.Equals("") && GG == false)
                {
                    if (xo % 2 == 0)
                    {
                        lab9.Text = "O";
                        b.Text = "X";
                        win();

                    }
                    else
                    {
                        lab9.Text = "X";
                        b.Text = "O";
                        win();
                    }
                    xo++;
                }
            }
            if (lop % 2 == 1)
            {
               
                if (b.Text.Equals("") && GG == false)
                {
                    if (xo % 2 == 0)
                    {
                        lab9.Text = "X";
                        b.Text = "O";
                        win();

                    }
                    else
                    {
                        lab9.Text = "O";
                        b.Text = "X";
                        win();
                    }
                    xo++;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lop++;
            xo = 0;

            GG = false;
            foreach (Control c in panel2.Controls)
            {
                if (c is Button)
                {
                    c.Text = "";
                }
            }
            b1.ForeColor = Color.Black;
            b2.ForeColor = Color.Black;
            b3.ForeColor = Color.Black;
            b4.ForeColor = Color.Black;
            b5.ForeColor = Color.Black;
            b6.ForeColor = Color.Black;
            b7.ForeColor = Color.Black;
            b8.ForeColor = Color.Black;
            b9.ForeColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void lab9_Click(object sender, EventArgs e)
        {

        } 
    }
}
