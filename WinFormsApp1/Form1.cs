namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics Graphicsbriz = pictureBox1.CreateGraphics();
            int R = int.Parse(textBox1.Text);
            int d = 12 - 2 * R; // ошибка
            int u = 6;
            int v = 10 - 4 * R;
            int x = 0;
            int y = R;

            while (v < 10){
                Graphicsbriz.DrawRectangle(Pens.Blue, 190 + x, 159 - 2*R + y, 1, 1);
                Graphicsbriz.DrawRectangle(Pens.Blue, 190 - x, 159 - 2*R + y, 1, 1);
                Graphicsbriz.DrawRectangle(Pens.Blue, 190 + x, 159 + 2*R - y, 1, 1);
                Graphicsbriz.DrawRectangle(Pens.Blue, 190 - x, 159 + 2*R - y, 1, 1);
                Graphicsbriz.DrawRectangle(Pens.Blue, 190 - 2*R + y, 159 + x, 1, 1);
                Graphicsbriz.DrawRectangle(Pens.Blue, 190 - 2*R + y, 159 - x, 1, 1);
                Graphicsbriz.DrawRectangle(Pens.Blue, 190 + 2*R - y, 159 + x, 1, 1);
                Graphicsbriz.DrawRectangle(Pens.Blue, 190 + 2*R - y, 159 - x, 1, 1);

                if (d > 0) {
                    d = d + v;
                    x = x + 1;
                    y = y + 1;
                    u = u + 4;
                    v = v + 8;
                }
                else if (d <= 0) {
                    d = d + u;
                    x =x + 1;
                    u = u + 4;
                    v = v + 4;
                }
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics Graphicsbriz = pictureBox1.CreateGraphics();
            Graphics Graphicsbriz1 = pictureBox3.CreateGraphics();
            Graphicsbriz.DrawLine(Pens.Red, 90, 159, 290, 159);
            Graphicsbriz.DrawLine(Pens.Red, 190, 59, 190, 259);
            Graphicsbriz1.DrawLine(Pens.Red, 90, 159, 290, 159);
            Graphicsbriz1.DrawLine(Pens.Red, 190, 59, 190, 259);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics Graphicsbriz = pictureBox3.CreateGraphics();
            int A = int.Parse(textBox3.Text);
            int B = int.Parse(textBox2.Text);
            int d = 0; // ошибка
            int u = 12 * B;
            int v = 12 * B + 8 * A;
            int l = A * B;
            int x = 0;
            int y = B;

            while (l > 0)
            {
                Graphicsbriz.DrawRectangle(Pens.Blue, 190 + x, 159 + y, 1, 1);
                Graphicsbriz.DrawRectangle(Pens.Blue, 190 - x, 159 + y, 1, 1);
                Graphicsbriz.DrawRectangle(Pens.Blue, 190 + x, 159 - y, 1, 1);
                Graphicsbriz.DrawRectangle(Pens.Blue, 190 - x, 159 - y, 1, 1);

                if (d < 0)
                {
                    d = d + u;
                    u = u + 8 * B;
                    v = v + 8 * A;
                    l = l - B;

                }
                else if (d >= 0)
                {
                    d = d + v;
                    u = u + 8 * B;
                    v = v + B * (B + A);
                    l = l - (B + A);
                    x = x + 1;

                }
                y = y + 1;
            }
        }
    }
}