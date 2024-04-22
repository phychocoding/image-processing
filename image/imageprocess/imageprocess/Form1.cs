namespace imageprocess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap B;
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                B = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = B;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap S = new Bitmap(pictureBox1.Image);
                S.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }

        private void endToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap P = new Bitmap(B.Width, B.Height);
            for (int i = 0; i < B.Width; i++)
            {
                for (int j = 0; j < B.Height; j++)
                {
                    Color C = B.GetPixel(i, j);
                    C = Color.FromArgb(C.R, 0, 0);
                    P.SetPixel(i, j, C);
                }
            }
            pictureBox1.Image = P;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap P = new Bitmap(B.Width, B.Height);
            for (int i = 0; i < B.Width; i++)
            {
                for (int j = 0; j < B.Height; j++)
                {
                    Color C = B.GetPixel(i, j);
                    C = Color.FromArgb(0, C.G, 0);
                    P.SetPixel(i, j, C);
                }
            }
            pictureBox1.Image = P;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap P = new Bitmap(B.Width, B.Height);
            for (int i = 0; i < B.Width; i++)
            {
                for (int j = 0; j < B.Height; j++)
                {
                    Color C = B.GetPixel(i, j);
                    C = Color.FromArgb(0, 0, C.B);
                    P.SetPixel(i, j, C);
                }
            }
            pictureBox1.Image = P;
        }

        private void grayscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap P = new Bitmap(B.Width, B.Height);
            for (int i = 0; i < B.Width; i++)
            {
                for (int j = 0; j < B.Height; j++)
                {
                    Color C = B.GetPixel(i, j);
                    Byte K = (byte)(((int)C.R + (int)C.G + (int)C.B) / 3);
                    C = Color.FromArgb(K, K, K);
                    P.SetPixel(i, j, C);
                }
            }
            pictureBox1.Image = P;
        }

        private void blackandwhiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap P = new Bitmap(B.Width, B.Height);
            for (int i = 0; i < B.Width; i++)
            {
                for (int j = 0; j < B.Height; j++)
                {
                    Color C = B.GetPixel(i, j);
                    Byte K = (byte)(((int)C.R + (int)C.G + (int)C.B) / 3);
                    if (K > 127)
                    {
                        C = Color.White;
                    }
                    else
                    {
                        C = Color.Black;
                    }
                    P.SetPixel(i, j, C);
                }
            }
            pictureBox1.Image = P;
        }

        private void negativeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap P = new Bitmap(B.Width, B.Height);
            for (int i = 0; i < B.Width; i++)
            {
                for (int j = 0; j < B.Height; j++)
                {
                    Color C = B.GetPixel(i, j);
                    C = Color.FromArgb(255 - C.R, 255 - C.G, 255 - C.B);
                    P.SetPixel(i, j, C);
                }
            }
            pictureBox1.Image = P;
        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap P = new Bitmap(B.Width, B.Height);
            for (int i = 0; i < B.Width; i++)
            {
                for (int j = 0; j < B.Height; j++)
                {
                    Color C = B.GetPixel(i, j);
                    int R1 = (int)C.R + 50;
                    if (R1 > 255)
                    {
                        R1 = 255;
                    }
                    int G1 = (int)C.G + 50;
                    if (G1 > 255)
                    {
                        G1 = 255;
                    }
                    int B1 = (int)C.B + 50;
                    if (B1 > 255)
                    {
                        B1 = 255;
                    }
                    C = Color.FromArgb((byte)R1, (byte)G1, (byte)B1);
                    P.SetPixel(i, j, C);
                }
            }
            pictureBox1.Image = P;
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap P = new Bitmap(B.Width, B.Height);
            for (int i = 0; i < B.Width; i++)
            {
                for (int j = 0; j < B.Height; j++)
                {
                    Color C = B.GetPixel(i, j);
                    int R1 = (int)C.R - 50;
                    if (R1 < 0)
                    {
                        R1 = 0;
                    }
                    int G1 = (int)C.G - 50;
                    if (G1 < 0)
                    {
                        G1 = 0;
                    }
                    int B1 = (int)C.B - 50;
                    if (B1 < 0)
                    {
                        B1 = 0;
                    }
                    C = Color.FromArgb((byte)R1, (byte)G1, (byte)B1);
                    P.SetPixel(i, j, C);
                }
            }
            pictureBox1.Image = P;
        }

        private void rephrase12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap P = new Bitmap(B.Width / 2, B.Height / 2);
            for (int i = 0; i < B.Width; i += 2)
            {
                for (int j = 0; j < B.Height; j += 2)
                {
                    Color C = B.GetPixel(i, j);
                    int i1 = i / 2;
                    int j1 = j / 2;
                    if (i1 < P.Width && j1 < P.Height)
                    {
                        P.SetPixel(i / 2, j / 2, C);
                    }
                }
            }
            pictureBox1.Image = P;
        }

        private void rephrase2XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap P = new Bitmap(B.Width * 2, B.Height * 2);
            for (int i = 0; i < B.Width; i ++)
            {
                for (int j = 0; j < B.Height; j ++)
                {
                    Color C = B.GetPixel(i, j);
                    for(int k = 0; k <2; k ++)
                    {
                        for(int l = 0; l < 2; l ++)
                        {
                            P.SetPixel(i*2+k, j*2+l, C);
                        }
                    }
                }
            }
            pictureBox1.Image = P;
        }
    }
}
