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
            MessageBox.Show("Created by GZ", "About", MessageBoxButtons.OK);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
            //check the entered IP for non numeral values and values larger than 255
        {
            int ipFirstPart = int.Parse(textBox3.Text);

           
            
            if ((textBox3.Text.Length > 3) | (ipFirstPart > 255) )
            {
                textBox3.Text="127";
                
            }
        }
    }
}