namespace imageTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string extensiy = System.IO.Path.GetExtension(saveFileDialog1.FileName);
            switch (extensiy.ToUpper())
            {
                case ".JPEG":
                    pictureBox1.Image.Save (saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    break;
                case ".PNG":
                    pictureBox1.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
                    break;
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PNG`®|*.png|JPEG`®|*.jpeg";
            openFileDialog1.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PNG`®|*.png|JPEG`®|*.jpeg";
            saveFileDialog1.ShowDialog();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            //AvÌI¹
            Application.Exit();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            //æí
            pictureBox1.Image = null;
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            //ãº½]
            pictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pictureBox1.Refresh();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            //¶E½]
            pictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pictureBox1.Refresh();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            //90xñ]
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Refresh();
        }
    }
}