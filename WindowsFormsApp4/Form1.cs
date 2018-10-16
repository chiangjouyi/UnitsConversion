using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn公分轉英寸_Click(object sender, EventArgs e)
        {
            if (tb公分.Text != "")
            {
                try
                {
                    float myCM = 0.0f;
                    float myInch = 0.0f;
                    float myft = 0.0f;
                    float myinch = 0.0f;
                    myCM = Convert.ToSingle(tb公分.Text);
                    myInch = myCM * 0.3937f;
                    //1ft=12inch
                    tb英吋.Text = Convert.ToString(myInch);
                    tb英吋.Text = string.Format("{0:F2}", myInch);
                    myft = Convert.ToInt16(Math.Floor(myInch / 12));
                    myinch = Convert.ToInt16(myInch % 12);
                    tb尺.Text = Convert.ToString(myft);
                    tb吋.Text = Convert.ToString(myinch);
                }
                catch (Exception error)//糾錯
                {
                    //MessageBox.Show(Convert.ToString(error));
                    MessageBox.Show("輸入格式有誤");
                }
            }
            else
            {
                MessageBox.Show("請輸入公分數值");
            }

        }

        private void btn坪數轉平方公尺_Click(object sender, EventArgs e)
        {
            if (tb坪數.Text != "")
            {
                double myPing = 0.0;
                double myM2 = 0.0;
                myPing = Convert.ToDouble(tb坪數.Text);
                myM2 = myPing * 3.3058;
                tb平方公尺.Text = Convert.ToString(myM2);
            }
            else
            {
                MessageBox.Show("請輸入坪數數值");
            }
        }

        private void btn公斤轉磅_Click(object sender, EventArgs e)
        {
            if (tb公斤.Text != "")
            {
                double myKG = 0.0;
                double myPound = 0.0;
                myKG = Convert.ToDouble(tb公斤.Text);
                myPound = myKG * 2.2;
                tb磅.Text = Convert.ToString(myPound);
            }
            else
            {
                MessageBox.Show("請輸入公斤數值");
            }
        }
    }
}
