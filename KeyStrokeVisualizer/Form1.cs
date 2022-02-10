using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyStrokeVisualizer
{
    public partial class Form1 : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int GetAsyncKeyState(int vKey);
        public Form1()=>InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {
            //--------------------------------------
            int radius = 20;
            int diameter = radius * 2;
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddPie(0, 0, diameter, diameter, 180, 90);
            gp.AddPie(this.Width - diameter, 0, diameter, diameter, 270, 90);
            gp.AddPie(0, this.Height - diameter, diameter, diameter, 90, 90);
            gp.AddPie(this.Width - diameter, this.Height - diameter, diameter, diameter, 0, 90);
            gp.AddRectangle(new Rectangle(radius, 0, this.Width - diameter, this.Height));
            gp.AddRectangle(new Rectangle(0, radius, radius, this.Height - diameter));
            gp.AddRectangle(new Rectangle(this.Width - radius, radius, radius, this.Height - diameter));
            this.Region = new Region(gp);
            //--------------------------------------
            btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btn_exit.Visible = false;
            //label1.BackColor = Color.Transparent;
            ricktxt_log.Enabled = false;
            ricktxt_log.Enabled = true;
            ricktxt_log.Parent = this;
            ricktxt_log.BackColor =this.BackColor;
            label_key_per_sec.ForeColor = ricktxt_log.ForeColor;
        }
        private void btn_exit_Click(object sender, EventArgs e)=> this.Close();

        private void ricktxt_log_TextChanged(object sender, EventArgs e)
        {

        }
        public void AddKeyLog(String s)
        {
            ricktxt_log.SelectionLength = 0;
            ricktxt_log.SelectionStart = ricktxt_log.TextLength;
            ricktxt_log.SelectionColor = Color.White;
            Font baseFont = ricktxt_log.SelectionFont;
            Font fnt = new Font(baseFont.FontFamily,
                baseFont.Size,
                baseFont.Style | FontStyle.Bold);
            ricktxt_log.SelectionFont = fnt;
            ricktxt_log.SelectedText = s;
            ricktxt_log.SelectionAlignment = HorizontalAlignment.Center;
            label1.Text = s + " " + label1.Text;
            baseFont.Dispose();
            fnt.Dispose();
        }
        public void SetKeyLog(String s)
        {
            ricktxt_log.Text = "";
            AddKeyLog(s);
        }
        int tickc = 0;
        int tick_kb = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            tickc++;
            bool[] gKeys = new bool[257];
            for (int i = 0; i <= 256; i++) gKeys[i] = false;
            for (int i = 1; i <= 256; i++)
            {
                int rtn = GetAsyncKeyState(i);
                if ((rtn & 1) != 0)
                {
                    Keys k = (Keys)i;
                    gKeys[i] = true;
                    tick_kb++;
                }
            }
            string r = String.Empty;
            for(int i = 1; i <= 256; i++)
            {
                if (gKeys[i])
                {
                    string kk = "";
                    Keys k = (Keys)i;

                    String[] blockKs ={ "ControlKey","LButton","RButton" ,"Menu"};//表示しない　キー
                    kk = k.ToString();
                    bool b = false;
                    for(int j = 0;j < blockKs.Length;j++)
                        if (k.ToString() == blockKs[j]) b = true;
                    if (!b)
                    {
                        if (kk == "LWin"||kk=="RWin")
                            kk = "Win";
                        else if (kk == "LControlKey"||kk== "RControlKey")
                            kk = "Ctrl";
                        else if (kk == "LMenu"||kk== "RMenu")
                            kk = "Alt";
                        r += kk + "+";
                    }

                }   
            }
            if (r != String.Empty)
            {
                r = r.Substring(0, r.Length - 1);
                SetKeyLog(r);
            }
            if (tickc == 10)
            {
                tickc = 0;
                label_key_per_sec.Text =(tick_kb * timer1.Interval*0.001*10).ToString()+" KPS";
                tick_kb = 0;
            }
        }

        private Point mousePoint;
        private void Form1_MouseDown(object sender,MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
                mousePoint = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender,
            System.Windows.Forms.MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                this.Left += e.X - mousePoint.X;
                this.Top += e.Y - mousePoint.Y;
            }
        }

        private void ricktxt_log_Enter(object sender, EventArgs e)=>label1.Focus();
    }
}
