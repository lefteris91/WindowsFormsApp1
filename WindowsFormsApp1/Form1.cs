using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
  public partial class Form1 : Form
  {
    int index = 0;
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      switch (index)
      {
        case 0:
          textBox1.Text = Roll().ToString();
          break;
        case 1:
          textBox2.Text = Roll().ToString();
          break;
        case 2:
          textBox3.Text = Roll().ToString();
          break;
        case 3:
          textBox4.Text = Roll().ToString();
          break;
        case 4:
          textBox5.Text = Roll().ToString();
          break;
        case 5:
          textBox6.Text = Roll().ToString();
          break;
      }
      index++;
    }

    int Roll()
    {
      int sum = 0;
      int dice = 0;
      Random rand = new Random();//constructor
      label7.Text = "";
      if (label7.Visible == false)
      {
        label7.Visible = true;
      }
      for (int i = 0; i < 3; i++)
      {
        dice = rand.Next(1, 6);
        label7.Text += dice + " ";
        sum += dice;

      }
      return sum;
    }

    private void button2_Click(object sender, EventArgs e)
    {
      index = 0;
      textBox1.Text = "";
      textBox2.Text = "";
      textBox3.Text = "";
      textBox4.Text = "";
      textBox5.Text = "";
      textBox6.Text = "";
      label7.Visible = false;
    }

    private void button3_Click(object sender, EventArgs e)
    {

    }
  }
}
