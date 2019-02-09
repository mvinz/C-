using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleMazeGame
{
    public partial class Form1 : Form
    {
        public static double life = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap cur = new Bitmap(new Bitmap("C:\\Users\\Marc\\source\\repos\\SimpleMazeGame\\SimpleMazeGame\\mazeCursor.png"));
            this.Cursor = new Cursor(cur.GetHicon());
            Cursor.Position = PointToScreen(new Point(lblStart.Location.X, lblStart.Location.Y));    
        }

        private void lblFinish_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Smooth Moves!");
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Position = PointToScreen(new Point(lblStart.Location.X, lblStart.Location.Y));
        }
    }
}
