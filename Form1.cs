using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Picker
{
    struct color
    {
        public byte r { get; set; }
        public byte g { get; set; }
        public byte b { get; set; }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            colorsRising();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colors();
        }

        private void colors()
        {
            Random rng = new Random();
            color start = new color();
            start.r = (byte) rng.Next(256);
            start.g = (byte) rng.Next(256);
            start.b = (byte) rng.Next(256);

            setColor(dom1, start, r1, g1, b1);
            color cl2 = newColor(start, rng);
            setColor(dom2, cl2, r2, g2, b2);
            color cl3 = newColor(cl2, rng);
            setColor(dom3, cl3, r3, g3, b3);
            color cl4 = newColor(cl3, rng);
            setColor(dom4, cl4, r4, g4, b4);
            color cl5 = newColor(cl4, rng);
            setColor(dom5, cl5, r5, g5, b5);
            color cl6 = newColor(cl5, rng);
            setColor(dom6, cl6, r6, g6, b6);
            color cl7 = newColor(cl6, rng);
            setColor(dom7, cl7, r7, g7, b7);
            color cl8 = newColor(cl7, rng);
            setColor(dom8, cl8, r8, g8, b8);
            color cl9 = newColor(cl8, rng);
            setColor(dom9, cl9, r9, g9, b9);
            color cl10 = newColor(cl9, rng);
            setColor(dom10, cl10, r10, g10, b10);
        }

        private void colorsRising()
        {
            Random rng = new Random();
            color start = new color();
            start.r = (byte)rng.Next(196);
            start.g = (byte)rng.Next(196);
            start.b = (byte)rng.Next(196);

            setColor(dom1, start, r1, g1, b1);
            color cl2 = newColorRising(start);
            setColor(dom2, cl2, r2, g2, b2);
            color cl3 = newColorRising(cl2);
            setColor(dom3, cl3, r3, g3, b3);
            color cl4 = newColorRising(cl3);
            setColor(dom4, cl4, r4, g4, b4);
            color cl5 = newColorRising(cl4);
            setColor(dom5, cl5, r5, g5, b5);
            color cl6 = newColorRising(cl5);
            setColor(dom6, cl6, r6, g6, b6);
            color cl7 = newColorRising(cl6);
            setColor(dom7, cl7, r7, g7, b7);
            color cl8 = newColorRising(cl7);
            setColor(dom8, cl8, r8, g8, b8);
            color cl9 = newColorRising(cl8);
            setColor(dom9, cl9, r9, g9, b9);
            color cl10 = newColorRising(cl9);
            setColor(dom10, cl10, r10, g10, b10);
        }

        private color newColor(color cl, Random rng)
        {
            color newCl = new color();
            int r = rng.Next(0, 256);
            int g = rng.Next(0, 256);
            int b = rng.Next(0, 256);

            r = (r + cl.r) / 2;
            g = (g + cl.g) / 2;
            b = (b + cl.b) / 2;

            newCl.r = (byte) r;
            newCl.g = (byte) g;
            newCl.b = (byte) b;

            return newCl;
        }
        private color newColorRising(color cl)
        {
            color newCl = new color();
            int r = (int) (cl.r + 0.15 * cl.r);
            int g = (int)(cl.g + 0.15 * cl.g);
            int b = (int)(cl.b + 0.15 * cl.b);
            if (r > 255)
                r = 255;
            if (g > 255)
                g = 255;
            if (b > 255)
                b = 255;

            newCl.r = (byte)r;
            newCl.g = (byte)g;
            newCl.b = (byte)b;

            return newCl;
        }


        private void setColor(PictureBox pb, color cl, TextBox r, TextBox g, TextBox b)
        {
            pb.BackColor = Color.FromArgb(cl.r, cl.g, cl.b);
            r.Text = cl.r.ToString();
            g.Text = cl.g.ToString();
            b.Text = cl.b.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            colorsRising();
        }
    }
}
