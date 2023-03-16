using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ChatGPT
{
public partial class Form1 : Form
{

//GPT _GPT = new GPT();
GPT3 _GPT = new GPT3();
public Form1()
    {
    InitializeComponent();

    }



private async void btn_Ask_Click(object sender, EventArgs e)
    {

    if (string.IsNullOrEmpty (txt_Prompt.Text))
        return;

    string input = string.Format("\n\nQ: {0}\nA:", txt_Prompt.Text);

    txt_Answer.AppendText(txt_Prompt.Text);
    txt_Answer.AppendText (Environment.NewLine);
    string x = await _GPT.GetAnswer(input);

    txt_Answer.AppendText(x);
    txt_Answer.AppendText (Environment.NewLine);
    txt_Prompt.Text = "";
    }
}
}
