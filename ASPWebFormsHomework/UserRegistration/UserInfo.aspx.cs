namespace UserRegistration
{
    using System;
    using System.IO;
    using System.Web.UI;

    public partial class UserInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != textBox3.Text)
            {
                label4.Text = "Wrong password!";
                label4.Visible = true;
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(Server.MapPath("~/UserInformation.txt"), false))
                {
                    string[] text = new string[5];
                    {
                        text[0] = textBox1.Text;
                        text[1] = textBox2.Text;
                        text[2] = textBox3.Text;
                        text[3] = textBox4.Text;
                        text[4] = textBox5.Text;
                    }

                    for (int i = 0; i < text.Length; i++)
                    {
                        writer.WriteLine(text[i]);
                    }
                }
            }
        }
    }
}