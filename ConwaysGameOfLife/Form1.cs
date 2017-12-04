using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConwaysGameOfLife
{
    public partial class Form1 : Form
    {
        int gridScale = 25;
        bool isRunning;
        PictureBox gameOfLifeBox;
        LifeGrid lifeGrid;
        Timer timer;
        Random rnd;

        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            rnd = new Random();
            timer.Tick += new EventHandler(timer_Tick);
            GameOfLifeBoxInit();
            lifeGrid = new LifeGrid(new bool[20, 20]);
            isRunning = false;
        }

        void GameOfLifeBoxInit()
        {
            gameOfLifeBox = new PictureBox();
            gameOfLifeBox.Name = "gameOfLifeBox";
            gameOfLifeBox.Click += gameOfLifeBox_Click;
            gameOfLifeBox.Location = new Point(150, 50);
        }

        void timer_Tick(object sender, EventArgs e)
        {
            lifeGrid.grid = lifeGrid.CalculateNextFrame();
            DrawGrid(lifeGrid.grid);
        }

        private void gameOfLifeBox_Click(object sender, EventArgs e)
        {
            FlipCell(this.PointToClient(Cursor.Position).X, this.PointToClient(Cursor.Position).Y);
        }

        /// <summary>
        /// Takes in the coordinates of the mouse relative to the form and flips the cell that was clicked on
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        void FlipCell(int x, int y)
        {
            x -= gameOfLifeBox.Location.X;
            y -= gameOfLifeBox.Location.Y;
            x = x / gridScale;
            y = y / gridScale;
            lifeGrid.grid[x, y] = !lifeGrid.grid[x, y];
            DrawGrid(lifeGrid.grid);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            if (gridScaleBox.Text != "")
                gridScale = Convert.ToInt32(gridScaleBox.Text);
            lifeGrid = new LifeGrid(new bool[Convert.ToInt32(gridSizeBox.Text), Convert.ToInt32(gridSizeBox.Text)]);
            DrawGrid(lifeGrid.grid);
        }

        void DrawGrid(bool[,] boolArray)
        {
            gameOfLifeBox.Size = new Size(boolArray.GetLength(0) * gridScale, boolArray.GetLength(1) * gridScale);
            this.Controls.Add(gameOfLifeBox);

            Bitmap grid = new Bitmap(boolArray.GetLength(0) * gridScale, boolArray.GetLength(1) * gridScale);
            Graphics gridGraphics = Graphics.FromImage(grid);
            for (int i = 0; i < boolArray.GetLength(0); i++)
            {
                for (int j = 0; j < boolArray.GetLength(1); j++)
                {
                    SolidBrush brush;
                    if (boolArray[j, i] == true)
                    {
                        brush = new SolidBrush(Color.Black);
                    }
                    else
                    {
                        brush = new SolidBrush(Color.White);
                    }
                    gridGraphics.FillRectangle(brush, j * gridScale, i * gridScale, gridScale, gridScale);
                }
            }

            for (int i = 0; i < boolArray.GetLength(0); i++)
            {
                for (int j = 0; j < boolArray.GetLength(1); j++)
                {
                    SolidBrush brush = new SolidBrush(Color.DarkGray);
                    Pen pen = new Pen(brush);
                    pen.Width = 1;
                    gridGraphics.DrawRectangle(pen, j * gridScale, i * gridScale, gridScale, gridScale);
                }
            }
            gameOfLifeBox.Image = grid;
        }

        private void nextFrameButton_Click(object sender, EventArgs e)
        {
            lifeGrid.grid = lifeGrid.CalculateNextFrame();
            DrawGrid(lifeGrid.grid);
        }

        private void gridSizeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void delayBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void startStopButton_Click(object sender, EventArgs e)
        {
            isRunning = !isRunning;
            if (isRunning)
            {
                timer.Interval = Convert.ToInt32(delayBox.Text);
                timer.Start();
            }
            else
            {
                timer.Stop();
            }
        }

        private void gridScaleBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void randomChanceBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void randomiseButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lifeGrid.grid.GetLength(0); i++)
            {
                for (int j = 0; j < lifeGrid.grid.GetLength(1); j++)
                {
                    if (rnd.Next(1000) < Convert.ToInt32(randomChanceBox.Text))
                    {
                        lifeGrid.grid[j, i] = true;
                    }
                    else
                    {
                        lifeGrid.grid[j, i] = false;
                    }
                }
            }
            DrawGrid(lifeGrid.grid);
        }
    }
}
