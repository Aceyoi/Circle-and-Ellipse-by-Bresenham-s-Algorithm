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
            int x = 0;
            int y = B;

            int d = (int)(B * B - A * A * B + 0.25 * A * A);
            int u = 2 * B * B * x;
            int v = 2 * A * A * y;


            Graphicsbriz.DrawRectangle(Pens.Blue, 190 + x, 159 + y, 1, 1);
                Graphicsbriz.DrawRectangle(Pens.Blue, 190 - x, 159 + y, 1, 1);
                Graphicsbriz.DrawRectangle(Pens.Blue, 190 + x, 159 - y, 1, 1);
                Graphicsbriz.DrawRectangle(Pens.Blue, 190 - x, 159 - y, 1, 1);

            // Область 1
            while (u < v)
            {
                x++;
                u += 2 * B * B;

                if (d < 0)
                {
                    d += B * B * (2 * x + 1);
                }
                else
                {
                    y--;
                    v -= 2 * A * A;
                    d += B * B * (2 * x + 1) + A * A * (1 - 2 * y);
                }

                Graphicsbriz.DrawRectangle(Pens.Blue, 190 + x, 159 + y, 1, 1);
                Graphicsbriz.DrawRectangle(Pens.Blue, 190 - x, 159 + y, 1, 1);
                Graphicsbriz.DrawRectangle(Pens.Blue, 190 + x, 159 - y, 1, 1);
                Graphicsbriz.DrawRectangle(Pens.Blue, 190 - x, 159 - y, 1, 1);
            }

            // Область 2
            d = (int)(B * B * (x + 0.5) * (x + 0.5) + A * A * (y - 1) * (y - 1) - A * A * B * B);

            while (y >= 0)
            {
                y--;
                v -= 2 * A * A;

                if (d > 0)
                {
                    d += A * A * (1 - 2 * y);
                }
                else
                {
                    x++;
                    u += 2 * B * B;
                    d += B * B * (2 * x + 1) + A * A * (1 - 2 * y);
                }

                Graphicsbriz.DrawRectangle(Pens.Blue, 190 + x, 159 + y, 1, 1);
                Graphicsbriz.DrawRectangle(Pens.Blue, 190 - x, 159 + y, 1, 1);
                Graphicsbriz.DrawRectangle(Pens.Blue, 190 + x, 159 - y, 1, 1);
                Graphicsbriz.DrawRectangle(Pens.Blue, 190 - x, 159 - y, 1, 1);
            }


        }
    }
}