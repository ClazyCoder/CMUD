using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapEditor
{
    public partial class Form1 : Form
    {
        int[,] arr;
        int cursor = 1;
        int scale = 100;
        public Form1()
        {
            arr = new int[100, 100];
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Brush brush = Brushes.White;
            float width = (float)(ClientRectangle.Width-20) / 100;
            float height = (float)(ClientRectangle.Height-40) / 100;
            for(int i = 0; i< 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    switch (arr[i, j])
                    {
                        case 0:
                            brush = Brushes.White;
                            break;
                        case 1:
                            brush = Brushes.Blue;
                            break;
                        case 2:
                            brush = Brushes.Green;
                            break;
                    }
                    e.Graphics.FillRectangle(brush, 10 + j * width, 30 + i * height, width, height);
                    e.Graphics.DrawRectangle(Pens.Black, 10 + j * width, 30 + i * height, width, height);
                }
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void 물ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            산ToolStripMenuItem.Checked = false;
            물ToolStripMenuItem.Checked = true;
            평지ToolStripMenuItem.Checked = false;
        }

        private void 산ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            산ToolStripMenuItem.Checked = true;
            물ToolStripMenuItem.Checked = false;
            평지ToolStripMenuItem.Checked = false;
        }

        private void 평지ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            산ToolStripMenuItem.Checked = false;
            물ToolStripMenuItem.Checked = false;
            평지ToolStripMenuItem.Checked = true;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (산ToolStripMenuItem.Checked)
                cursor = 2;
            else if (물ToolStripMenuItem.Checked)
                cursor = 1;
            else if (평지ToolStripMenuItem.Checked)
                cursor = 0;
            int y = e.Y;
            int x = e.X;
            float width = (float)(ClientRectangle.Width - 20) / 100;
            float height = (float)(ClientRectangle.Height - 40) / 100;
            int xindex = (int)((x-20) / width);
            int yindex = (int)((y-40) / height);
            if (xindex < 0) xindex = 0;
            if (xindex > 99) xindex = 99;
            if (yindex < 0) yindex = 0;
            if (yindex > 99) yindex = 99;
            arr[yindex, xindex] = cursor;
            Invalidate();
        }
    }
}
