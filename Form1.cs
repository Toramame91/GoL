﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_of_Life
{
    public partial class Form1 : Form
    {

        Random rnd = new Random();
        // The universe array
        bool[,] universe = new bool[100, 100];
        //scratchpad array
        bool[,] scratchpad = new bool[100, 100];
        // Drawing colors      
        Color gridColor = Color.Black;
        Color cellColor = Color.PaleVioletRed;

        // The Timer class
        Timer timer = new Timer();

        // Generation count
        int generations = 0;

        public Form1()
        {
            InitializeComponent();
            // Setup the timer
            timer.Interval = 100; // milliseconds
            timer.Tick += Timer_Tick;
            //generate first new random universe
            InitRandomUniverse();
            //count living cells
            toolStripStatusLivingCells.Text = "Living Cells = " + CountLivingCells();
            //initialize scratchpad array
            ScratchpadInitialize();
        }


        // The event called by the timer every Interval milliseconds.
        private void Timer_Tick(object sender, EventArgs e)
        {
            NextGeneration();
        }
        //init scratchpad function
        private void ScratchpadInitialize()
        {
            // Iterate through the universe in the y, top to bottom
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    scratchpad[x, y] = universe[x, y];
                }
            }
        }

        private void replaceUniverse()
        {
            // Iterate through the universe in the y, top to bottom
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    universe[x, y] = scratchpad[x, y];
                }
            }
            graphicsPanel1.Invalidate();
        }
        //function to hold all the rules for the next generation of cells
        private void NextGenRules()
        {
            // Iterate through the universe in the y, top to bottom
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < universe.GetLength(0); x++)
                {                    
                    if (universe[x, y] == true)
                    {
                        //rule 1
                        if (CountNeighbors(x, y) < 2)
                        {

                            scratchpad[x, y] = false;
                        }
                        //rule 2
                        if (CountNeighbors(x, y) > 3)
                        {

                            scratchpad[x, y] = false;
                        }
                        //rule 3
                        if (CountNeighbors(x, y) <= 3 && CountNeighbors(x, y) >= 2)
                        {
                            scratchpad[x, y] = true;
                        }
                    }
                    else
                    {
                        //rule 4
                        if (CountNeighbors(x, y) == 3)
                        {
                            scratchpad[x, y] = true;
                        }
                    }

                }
            }
            graphicsPanel1.Invalidate();
        }
        //create a randon universe
        private void InitRandomUniverse()
        {
            graphicsPanel1.Invalidate();
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < universe.GetLength(0); x++)
                {                    
                    int number = rnd.Next(3);
                    if (number == 0)
                    {
                        universe[x, y] = true;
                    }
                    else
                    {
                        universe[x, y] = false;
                    }
                }
            }            
        }


        // Calculate the next generation of cells
        private void NextGeneration()
        {
            
            //implement rules of conway's game of life for next generation on scratchpad
            NextGenRules();
            // swap scratchpad to universe
            replaceUniverse();
            // Increment generation count
            generations++;            
            // Update status strips
            toolStripStatusLabelGenerations.Text = "Generations = " + generations.ToString();
            toolStripStatusLivingCells.Text = "Living Cells = " + CountLivingCells();
        }


        private void graphicsPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Calculate the width and height of each cell in pixels
            // CELL WIDTH = WINDOW WIDTH / NUMBER OF CELLS IN X
            float cellWidth = (float)graphicsPanel1.ClientSize.Width / universe.GetLength(0);
            // CELL HEIGHT = WINDOW HEIGHT / NUMBER OF CELLS IN Y
            float cellHeight = (float)graphicsPanel1.ClientSize.Height / universe.GetLength(1);

            // A Pen for drawing the grid lines (color, width)
            Pen gridPen = new Pen(gridColor, 1);

            // A Brush for filling living cells interiors (color)
            Brush cellBrush = new SolidBrush(cellColor);

            // Iterate through the universe in the y, top to bottom
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    // A rectangle to represent each cell in pixels
                    RectangleF cellRect = RectangleF.Empty;
                    cellRect.X = x * cellWidth;
                    cellRect.Y = y * cellHeight;
                    cellRect.Width = cellWidth;
                    cellRect.Height = cellHeight;

                    // Fill the cell with a brush if alive
                    if (universe[x, y] == true)
                    {
                        e.Graphics.FillRectangle(cellBrush, cellRect);
                    }

                    // Outline the cell with a pen
                    e.Graphics.DrawRectangle(gridPen, cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height);
                }
            }

            // Cleaning up pens and brushes
            gridPen.Dispose();
            cellBrush.Dispose();
        }

        private void graphicsPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            // If the left mouse button was clicked
            if (e.Button == MouseButtons.Left)
            {
                // Calculate the width and height of each cell in pixels
                float cellWidth = (float)graphicsPanel1.ClientSize.Width / (float)universe.GetLength(0);
                float cellHeight = (float)graphicsPanel1.ClientSize.Height / (float)universe.GetLength(1);

                // Calculate the cell that was clicked in
                // CELL X = MOUSE X / CELL WIDTH
                int x = e.X / (int)cellWidth;
                // CELL Y = MOUSE Y / CELL HEIGHT
                int y = e.Y / (int)cellHeight;

                // Toggle the cell's state
                universe[x, y] = !universe[x, y];

                // Tell Windows you need to repaint
                graphicsPanel1.Invalidate();
            }
        }
        //resets the board and generates a new universe
        private void resetUniverse()
        {
            clearUniverse();
            InitRandomUniverse();
            //count living cells
            toolStripStatusLivingCells.Text = "Living Cells = " + CountLivingCells();
        }        
        //function to clear the universe and scratchpad board 
        private void clearUniverse()
        {            
            // Iterate through the universe in the y, top to bottom
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    universe[x, y] = false;
                    scratchpad[x, y] = false;
                }
            }
            generations = 0;
            //count living cells
            toolStripStatusLivingCells.Text = "Living Cells = " + CountLivingCells();
            // Tell Windows you need to repaint
            graphicsPanel1.Invalidate();
        }
        
        //logic for counting tiles around a cell
        private int CountNeighbors(int _x, int _y)
        {
            bool checkRight = _x < universe.GetLength(0) - 1;
            bool checkLeft = _x > 0;
            bool checkTop = _y > 0;
            bool checkBottom = _y < universe.GetLength(1) - 1;
            int livingNeighborCount = 0;
            //making sure right value doesn't throw.
            if (checkRight)
            {
                //checking to the right
                if (universe[_x + 1, _y] == true)
                {
                    livingNeighborCount += 1;
                }
                //checking top right
                if (checkTop)
                {
                    if (universe[_x + 1, _y - 1] == true)
                    {
                        livingNeighborCount += 1;
                    }
                }
                //checking bottom right
                if (checkBottom)
                {
                    if (universe[_x + 1, _y + 1] == true)
                    {
                        livingNeighborCount += 1;
                    }
                }
            }
            //making sure Left value doesn't throw.
            if (checkLeft)
            {
                //checking left
                if (universe[_x - 1, _y] == true)
                {
                    livingNeighborCount += 1;
                }
                //checking top left
                if (checkTop)
                {
                    if (universe[_x - 1, _y - 1] == true)
                    {
                        livingNeighborCount += 1;
                    }
                }
                //checking bottom left
                if (checkBottom)
                {

                    if (universe[_x - 1, _y + 1] == true)
                    {
                        livingNeighborCount += 1;
                    }
                }
            }
            //checking bottom
            if (checkBottom)
            {
                if (universe[_x, _y + 1] == true)
                {
                    livingNeighborCount += 1;
                }
            }
            //checking top
            if (checkTop)
            {
                if (universe[_x, _y - 1] == true)
                {
                    livingNeighborCount += 1;
                }
            }
            return livingNeighborCount;
        }

        //logic for counting living cells
        private int CountLivingCells()
        {
            int count = 0;
            // Iterate through the universe in the y, top to bottom
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    if (universe[x,y] == true)
                    {
                        count += 1;
                    }
                }
            }
            return count;
        }

        //toolstrip and menu functions
        private void menuFileNew_Click(object sender, EventArgs e)
        {
            resetUniverse();
        }
        private void toolstripNewButton_Click(object sender, EventArgs e)
        {
            resetUniverse();
        }
        private void menuFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolstripPlayButton_Click(object sender, EventArgs e)
        {
            timer.Enabled = true; // start timer running 
        }
        private void toolstripPauseButton_Click(object sender, EventArgs e)
        {
            timer.Stop();//pause timer
        }

        private void toolstripNextButton_Click(object sender, EventArgs e)
        {
            NextGeneration();
        }

        private void menuFileClear_Click(object sender, EventArgs e)
        {
            clearUniverse();
        }

        private void toolstripClearButton_Click(object sender, EventArgs e)
        {
            clearUniverse();
        }
               
    }

    struct Cell
    {
        public bool cellLiving;
        public int lifeCounter;
        public Cell(bool cell)
        {
            this.lifeCounter = 0;
            this.cellLiving = cell;
            if (this.cellLiving == true)
            {
                this.lifeCounter += 1;
            }
        }
    }
}
