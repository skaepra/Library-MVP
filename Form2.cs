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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        List<Button> buttons;
        Random rand = new Random();
        int lop;
        int draw = 0;
        int xo = 0;
        int player1=0;
        int player2=0;
        void loadbuttons()
        {
            buttons = new List<Button> { b1, b2, b3, b4, b5, b6, b7, b8, b9 };
        }
        void wineffect(Button bm1, Button bm2, Button bm3)
          {
            bm1.ForeColor = Color.Red;
            bm2.ForeColor = Color.Red;
            bm3.ForeColor = Color.Red;
            if (bm1.Text == "X")
            {

                player1++;
                labl1.Text = player1.ToString();

               
            }
            else
            {
               player2++;
               labl2.Text = player2.ToString();
            }
           
        }
        bool win = false;
        void getwin()
        {
            if (b1.Text != "" && b1.Text == b2.Text && b1.Text == b3.Text)
            {
                wineffect(b1, b2, b3);
                win = true;
            }
            else if (b4.Text != "" && b4.Text == b5.Text && b4.Text == b6.Text)
            {
                wineffect(b4, b5, b6);
                win = true;

            }
            else if (b7.Text != "" && b7.Text == b8.Text && b7.Text == b9.Text)
            {
                wineffect(b7, b8, b9);
                win = true;

            }
            else if (b1.Text != "" && b1.Text == b5.Text && b1.Text == b9.Text)
            {
                wineffect(b1, b5, b9);
                win = true;
            }
            else if (b3.Text != "" && b3.Text == b5.Text && b3.Text == b7.Text)
            {
                wineffect(b3, b5, b7);
                win = true;
            }
            else if (b1.Text != "" && b1.Text == b4.Text && b1.Text == b7.Text)
            {
                wineffect(b1, b4, b7);
                win = true;
            }
            else if (b2.Text != "" && b2.Text == b5.Text && b2.Text == b8.Text)
            {
                wineffect(b2, b5, b8);
                win = true;
            }
            else if (b3.Text != "" && b3.Text == b6.Text && b3.Text == b9.Text)
            {
                wineffect(b3, b6, b9);
                win = true;
            }
            else if (xo == 8)
            {
                draw++;
                lab6.Text = draw.ToString();

            }
            xo++;
        }
        private void Form2_Load(object sender, EventArgs e)
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
           
            if (b.Text.Equals("") && win == false)
            {               
                    b.Text = "X";
                    getwin();
                    timer1.Start();                              
            }           
        }
        private void timer1_Tick(object sender, EventArgs e)
        {                     
                if (buttons.Count > 0 && win == false)
                {
                    int index =rand.Next(buttons.Count);
                    if (buttons[index].Text == "")
                    {
                        buttons[index].Text = "O";
                        buttons.RemoveAt(index);
                        getwin();
                        timer1.Stop();
                    }        
                }            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            lop++;
            if (lop % 2 == 1)
            { timer1.Start(); }
            if (lop % 2 == 0)
            { timer1.Stop(); }
            xo = 0;
            loadbuttons();
            win = false;
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

    }
}
