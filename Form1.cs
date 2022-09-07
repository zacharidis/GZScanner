using System.Net.NetworkInformation;

namespace GZScanner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by GZ" +
                "\n Hello my name is Georgios Z and i am willing to work as a full time C# dev " , "About", MessageBoxButtons.OK);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
            //check the entered IP for non numeral values and values larger than 255
        {
            int ipFirstPart = int.Parse(textBox3.Text);

           
            
            if ((textBox3.Text.Length > 3) | (ipFirstPart > 255) )
            {
                textBox3.Text="127";
                textBox7.Text="127";
                
            } else
            {
                textBox7.Text = textBox3.Text;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            list.Add(textBox3.Text + "." +  textBox4.Text + "." + textBox5.Text + "." +textBox6.Text);
            listBox1.Items.Add(list[0]);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            int ipFirstPart = int.Parse(textBox4.Text);



            if ((textBox4.Text.Length > 3) | (ipFirstPart > 255))
            {
                textBox4.Text="0";
                textBox8.Text="0";
            } else
            {
                textBox8.Text = textBox4.Text; 
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            int ipFirstPart = int.Parse(textBox5.Text);



            if ((textBox3.Text.Length > 3) | (ipFirstPart > 255))
            {
                textBox5.Text="0";
                textBox9.Text="0";

            }
            else
            {
                textBox9.Text = textBox5.Text;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            int ipFirstPart = int.Parse(textBox6.Text);



            if ((textBox6.Text.Length > 3) | (ipFirstPart > 255))
            {
                textBox6.Text="1";

            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            int ipFirstPart = int.Parse(textBox7.Text);



            if ((textBox7.Text.Length > 3) | (ipFirstPart > 255))
            {
                textBox7.Text="127";

            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            int ipFirstPart = int.Parse(textBox8.Text);



            if ((textBox8.Text.Length > 3) | (ipFirstPart > 255))
            {
                textBox8.Text="0";

            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            int ipFirstPart = int.Parse(textBox9.Text);



            if ((textBox9.Text.Length > 3) | (ipFirstPart > 255))
            {
                textBox9.Text="0";

            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            int ipFirstPart = int.Parse(textBox10.Text);



            if ((textBox10.Text.Length > 3) | (ipFirstPart > 255))
            {
                textBox10.Text="255";

            }
        }

        private void button1_Click(object sender, EventArgs e)


        {

            int range = int.Parse(textBox10.Text) - int.Parse(textBox6.Text);


            List<string> list = new List<string>();

            for (int i = 1; i <= range; i++)
            {
                list.Add(textBox3.Text+"."+textBox4.Text+"."+textBox5.Text+"."+i);
            }
            






            foreach (string str in list)
            {
                string result = "";
                Ping p = new Ping();
                PingReply r;
                string s = str;

                r = p.Send(s);

                if (r.Status == IPStatus.Success)
                {
                    result = "Ping to " + s.ToString() + "[" + r.Address.ToString() + "]" + " Successful"
                      + " Response delay = " + r.RoundtripTime.ToString() + " ms" + "\n";
                    listBox1.Items.Add(result);
                }
                else
                {
                    listBox1.Items.Add(s + " is not reachable");
                }

            }

            



        }
    }
}