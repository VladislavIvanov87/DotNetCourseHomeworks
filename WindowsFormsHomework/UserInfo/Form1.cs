namespace UserInfo
{
    using System;
    using System.IO;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("UserInfo.txt"))
            {
                string[] text = new string[3];
                {
                    text[0] = textBox1.Text;
                    text[1] = textBox2.Text;
                    text[2] = textBox3.Text;
                }

                for (int i = 0; i < text.Length; i++)
                {
                    writer.WriteLine(text[i]);
                }
            }
        }
    }
}
