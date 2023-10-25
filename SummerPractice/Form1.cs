namespace SummerPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(textBoxA.Text);
            int b = Int32.Parse(textBoxB.Text);
            int c = Int32.Parse(textBoxC.Text);
            int d = Int32.Parse(textBoxD.Text);

            int l = Int32.Parse(textBoxL.Text);
            int m = Int32.Parse(textBoxM.Text);
            int n = Int32.Parse(textBoxN.Text);

            Plane plane = new Plane(a, b, c, d);

            textBoxAngle.Text = plane.angle(l, m, n).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(textBoxA.Text);
            int b = Int32.Parse(textBoxB.Text);
            int c = Int32.Parse(textBoxC.Text);
            int d = Int32.Parse(textBoxD.Text);

            int a2 = Int32.Parse(textboxA2.Text);
            int b2 = Int32.Parse(textBoxB2.Text);
            int c2 = Int32.Parse(textBoxC2.Text);
            int d2 = Int32.Parse(textBoxD2.Text);

            Plane plane = new Plane(a, b, c, d);
            Plane plane2 = new Plane(a2, b2, c2, d2);
            textBoxRelationships.Text = plane.relationships(plane2);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
                panel1.Visible = true;
                panel2.Visible = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                panel2.Visible = true;
                panel1.Visible = false;
            }
        }
    }
}