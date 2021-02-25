using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_of_Life
{
    public partial class Form1 : Form
    {
        #region initializers
        //initializers for random seed
        Random rnd = new Random();
        int currentSeed = 0;
        // The universe array
        bool[,] universe = new bool[50, 50];
        //scratchpad array
        bool[,] scratchpad = new bool[50, 50];
        // Drawing colors      
        Color gridColor = Color.Black;
        Color gridColor2 = Color.Black;
        Color cellColor = Color.PaleVioletRed;
        //booleans for toggling
        bool gridDisplay = true;
        bool textDisplay = true;
        bool finiteMode = false;
        bool HUDdisplay = true;
        //text display initialization for neighbor counting
        Font font = new Font("Verdana", 6f);
        Font fontHUD = new Font("Arial", 14f, FontStyle.Bold);
        StringFormat stringFormat = new StringFormat();
        // The Timer class
        Timer timer = new Timer();
        // Generation count
        int generations = 0;
        #endregion


        public Form1()
        {
            InitializeComponent();
            // Setup the timer
            timer.Interval = 100; // milliseconds
            timer.Tick += Timer_Tick;            
            //initial living cells count
            toolStripStatusLivingCells.Text = "Living Cells = " + CountLivingCells();
            //initialize scratchpad array
            ScratchpadInitialize();
        }
        #region functions
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
        //torodial universe function rules
        private void NextGenRulesTorodial()
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
                        if (CountNeighborsTorodial(x, y) < 2)
                        {

                            scratchpad[x, y] = false;
                        }
                        //rule 2
                        if (CountNeighborsTorodial(x, y) > 3)
                        {

                            scratchpad[x, y] = false;
                        }
                        //rule 3
                        if (CountNeighborsTorodial(x, y) <= 3 && CountNeighborsTorodial(x, y) >= 2)
                        {
                            scratchpad[x, y] = true;
                        }
                    }
                    else
                    {
                        //rule 4
                        if (CountNeighborsTorodial(x, y) == 3)
                        {
                            scratchpad[x, y] = true;
                        }
                    }

                }
            }
            graphicsPanel1.Invalidate();
        }
        //create a random universe
        private void InitRandomUniverse()
        {
            Random newRand = new Random(currentSeed);
            graphicsPanel1.Invalidate();
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    int randNum = newRand.Next(3);
                    if (randNum == 0)
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
            NextGenType();
            // swap scratchpad to universe
            replaceUniverse();
            // Increment generation count
            generations++;
            // Update status strips
            toolStripStatusLabelGenerations.Text = "Generations = " + generations.ToString();
            toolStripStatusLivingCells.Text = "Living Cells = " + CountLivingCells();
        }

        //toggle between finite and torodial
        private void NextGenType()
        {            
            if (finiteMode == true)
            {
                NextGenRules();
            }
            else
            {
                NextGenRulesTorodial();
            }
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
            Pen gridPen2 = new Pen(gridColor2, 2);
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
                    //text alignment for cell neighbor count
                    stringFormat.Alignment = StringAlignment.Center;
                    stringFormat.LineAlignment = StringAlignment.Center;

                    // Fill the cell with a brush if alive
                    if (universe[x, y] == true)
                    {
                        e.Graphics.FillRectangle(cellBrush, cellRect);
                    }
                    if (gridDisplay == true)
                    {
                        // Outline the cell with a pen
                        e.Graphics.DrawRectangle(gridPen, cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height);
                        e.Graphics.DrawRectangle(gridPen2, cellRect.X * 10, cellRect.Y * 10, cellRect.Width * 10, cellRect.Height * 10);
                    }
                    //display text for living neighbors   
                    if (textDisplay == true)
                    {
                        e.Graphics.DrawString(displayNeighbors(x, y).ToString(), font, Brushes.Black, cellRect, stringFormat);
                    }
                }
            }
            //display HUD
            if (HUDdisplay == true)
            {
                e.Graphics.DrawString(DisplayHUD(), fontHUD, Brushes.Red, 0, 0);
            }

            // Cleaning up pens and brushes
            gridPen.Dispose();
            cellBrush.Dispose();
        }
        //display HUD

        private string DisplayHUD()
        {
            string type;
            if (finiteMode == true)
            {
                type = "Finite";
            }
            else
            {
                type = "Torodial";
            }
            string HUD = "Generations = " + generations + "\nCell Count = " + CountLivingCells() + "\nBoundary Type = " + type + "\nUniverse Size = (" + universe.GetLength(0) + "," +
                universe.GetLength(1) + ")";
            return HUD;
        }
        //display neighbors
        private int displayNeighbors(int x, int y)
        {
            int neighbors;
            if (finiteMode == true)
            {
                neighbors = CountNeighbors(x, y);
            }
            else
            {
                neighbors = CountNeighborsTorodial(x, y);
            }
            return neighbors;
        }
        //draw grahpics
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
            // Update status strips
            toolStripStatusLabelGenerations.Text = "Generations = " + generations.ToString();
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
            // Update status strips
            toolStripStatusLabelGenerations.Text = "Generations = " + generations.ToString();
            //count living cells
            toolStripStatusLivingCells.Text = "Living Cells = " + CountLivingCells();
            // Tell Windows you need to repaint
            graphicsPanel1.Invalidate();
        }

        //logic for counting tiles around a cell (for a finite universe)
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
        //function for a torodial universe
        private int CountNeighborsTorodial(int _x, int _y)
        {
            int count = 0;
            int xLen = universe.GetLength(0);
            int yLen = universe.GetLength(1);
            for (int yOffset = -1; yOffset <= 1; yOffset++)
            {
                for (int xOffset = -1; xOffset <= 1; xOffset++)
                {
                    int xCheck = _x + xOffset;
                    int yCheck = _y + yOffset;
                    // if xOffset and yOffset are both equal to 0 then continue
                    if (xOffset == 0 && yOffset == 0)
                    {
                        continue;
                    }
                    // if xCheck is less than 0 then set to xLen - 1
                    // if yCheck is less than 0 then set to yLen - 1
                    if (xCheck < 0)
                    {
                        xCheck = xLen - 1;
                    }
                    if (yCheck < 0)
                    {
                        yCheck = yLen - 1;
                    }
                    // if xCheck is greater than or equal too xLen then set to 0
                    if (xCheck >= xLen)
                    {
                        xCheck = 0;
                    }
                    // if yCheck is greater than or equal too yLen then set to 0
                    if (yCheck >= yLen)
                    {
                        yCheck = 0;
                    }
                    if (universe[xCheck, yCheck] == true) count++;
                }
            }
            return count;
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
                    if (universe[x, y] == true)
                    {
                        count += 1;
                    }
                }
            }
            return count;
        }
        //function to save the current universe to txt
        private void SaveUniverse()
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "All Files|*.*|Cells|*.cells";
            saveFile.FilterIndex = 2; saveFile.DefaultExt = "cells";

            if (DialogResult.OK == saveFile.ShowDialog())
            {
                StreamWriter writer = new StreamWriter(saveFile.FileName);

                // Write any comments you want to include first.
                // Prefix all comment strings with an exclamation point.
                // Use WriteLine to write the strings to the file. 
                // It appends a CRLF for you.
                writer.WriteLine("!This is my comment.");

                // Iterate through the universe one row at a time.
                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    String currentRow = string.Empty;

                    // Iterate through the current row one cell at a time.
                    for (int x = 0; x < universe.GetLength(0); x++)
                    {
                        if (universe[x, y] == true)
                        {
                            currentRow += "O";
                        }
                        else
                        {
                            currentRow += ".";
                        }
                    }
                    // Once the current row has been read through and the 
                    // string constructed then write it to the file using WriteLine.
                    writer.WriteLine(currentRow);
                }
                // After all rows and columns have been written then close the file.
                writer.Close();
            }
        }
        //function to open a saved universe file
        private void OpenUniverse()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "All Files|*.*|Cells|*.cells";
            openFile.FilterIndex = 2;

            if (DialogResult.OK == openFile.ShowDialog())
            {
                StreamReader reader = new StreamReader(openFile.FileName);
                int maxWidth = 0;
                int maxHeight = 0;

                // Iterate through the file once to get its size.
                while (!reader.EndOfStream)
                {
                    // Read one row at a time.
                    // If the row begins with '!' then it is a comment
                    // and should be ignored.
                    string row = reader.ReadLine();
                    if (row.StartsWith("!"))
                    {
                        continue;
                    }
                    else
                    {
                        maxHeight += 1;
                        maxWidth = row.Length;
                        continue;
                    }

                }
                universe = new bool[maxWidth, maxHeight];
                scratchpad = new bool[maxWidth, maxHeight];
                // Reset the file pointer back to the beginning of the file.
                reader.BaseStream.Seek(0, SeekOrigin.Begin);
                int yPos = 0;
                // Iterate through the file again, this time reading in the cells.
                while (!reader.EndOfStream)
                {
                    // Read one row at a time.
                    string row = reader.ReadLine();
                    if (row.StartsWith("!"))
                    {
                        continue;
                    }
                    else
                    {
                        for (int xPos = 0; xPos < row.Length; xPos++)
                        {
                            if (row[xPos] == 'O')
                            {
                                universe[xPos, yPos] = true;
                            }
                            if (row[xPos] == '.')
                            {
                                universe[xPos, yPos] = false;
                            }
                        }
                        yPos += 1;
                        continue;
                    }
                }
                // Close the file.
                reader.Close();
            }
        }
        //function for seed dialog box
        private void setSeedDialog()
        {
            RandomizerDialog seedSetting = new RandomizerDialog();

            seedSetting.Seed = currentSeed;

            if (seedSetting.ShowDialog() == DialogResult.OK)
            {
                currentSeed = (int)seedSetting.Seed;
            }
            graphicsPanel1.Invalidate();
        }
        //function for toggling gridlines
        private void gridDisplayToggle()
        {
            if (gridDisplay == true)
            {
                gridDisplay = false;
            }
            else
            {
                gridDisplay = true;
            }
            graphicsPanel1.Invalidate();
        }
        //toggle neighbortext
        private void textDisplayToggle()
        {
            if (textDisplay == true)
            {
                textDisplay = false;
            }
            else
            {
                textDisplay = true;
            }
            graphicsPanel1.Invalidate();
        }
        //toggle HUD
        private void HUDDisplayToggle()
        {
            if (HUDdisplay == true)
            {
                HUDdisplay = false;
            }
            else
            {
                HUDdisplay = true;
            }
            graphicsPanel1.Invalidate();
        }
        //toggle universe
        private void universeTypeToggle()
        {
            if (finiteMode == true)
            {
                finiteMode = false;
            }
            else
            {
                finiteMode = true;
            }
            graphicsPanel1.Invalidate();
        }
        //set universe size dialog
        private void universeSetSize()
        {
            UniverseSettingsDialog settings = new UniverseSettingsDialog();

            settings.UniverseLength = universe.GetLength(0);
            settings.UniverseHeight = universe.GetLength(1);
            settings.TimeInterval = timer.Interval;

            if (settings.ShowDialog() == DialogResult.OK)
            {
                universe = new bool[(int)settings.UniverseLength, (int)settings.UniverseHeight];
                scratchpad = new bool[(int)settings.UniverseLength, (int)settings.UniverseHeight];
                timer.Interval = (int)settings.TimeInterval;
            }
            graphicsPanel1.Invalidate();
        }


        #endregion

        #region toolstrip and menu
        //clears and redraws universe based on current seed
        private void menuFileNew_Click(object sender, EventArgs e)
        {
            resetUniverse();
        }
        private void toolstripNewButton_Click(object sender, EventArgs e)
        {
            resetUniverse();
        }
        //exit application button
        private void menuFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //start generations
        private void toolstripPlayButton_Click(object sender, EventArgs e)
        {
            timer.Enabled = true; // start timer running 
        }
        //pause generations
        private void toolstripPauseButton_Click(object sender, EventArgs e)
        {
            timer.Stop();//pause timer
        }
        //moves to next generation
        private void toolstripNextButton_Click(object sender, EventArgs e)
        {
            NextGeneration();
        }
        //clear universe to blank slate
        private void menuFileClear_Click(object sender, EventArgs e)
        {
            clearUniverse();
        }
        //clear universe to blank slate
        private void toolstripClearButton_Click(object sender, EventArgs e)
        {
            clearUniverse();
        }
        //menu button for toggling grid lines on or off
        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridDisplayToggle();
        }
        //menu button to toggle neighbor count in cells
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textDisplayToggle();
        }
        //dialog to edit the size and time interval for universe
        private void editWindowSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            universeSetSize();
        }
        //dialog to set the seed for universe
        private void setSeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setSeedDialog();
        }
        //creates new universe from random time seed
        private void randomizeUniverseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentSeed = rnd.Next(DateTime.Now.Day);
            clearUniverse();
            InitRandomUniverse();
            graphicsPanel1.Invalidate();
        }
        //dialog to save current universe
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveUniverse();
        }
        //dialog to open a file to read and load universe
        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenUniverse();
            // Update status strips
            toolStripStatusLabelGenerations.Text = "Generations = " + generations.ToString();
            //count living cells
            toolStripStatusLivingCells.Text = "Living Cells = " + CountLivingCells();
            graphicsPanel1.Invalidate();
        }
        //color dialog for changing gridline color
        private void editBackgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog backgroundColor = new ColorDialog();
            backgroundColor.Color = graphicsPanel1.BackColor;

            if (backgroundColor.ShowDialog() == DialogResult.OK)
            {
                graphicsPanel1.BackColor = backgroundColor.Color;
            }
        }
        //color dialog for changing gridline color
        private void editGridLineColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog gridColorDialog = new ColorDialog();
            gridColorDialog.Color = gridColor;

            if (gridColorDialog.ShowDialog() == DialogResult.OK)
            {
                gridColor = gridColorDialog.Color;
            }
            graphicsPanel1.Invalidate();
        }
        //color dialog for changing 10*10 gidline color
        private void edit1010GridLineColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog gridColorDialog = new ColorDialog();
            gridColorDialog.Color = gridColor2;

            if (gridColorDialog.ShowDialog() == DialogResult.OK)
            {
                gridColor2 = gridColorDialog.Color;
            }
            graphicsPanel1.Invalidate();
        }
        //color dialog for changing living cell color
        private void editLivingCellColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cellColorDialog = new ColorDialog();
            cellColorDialog.Color = cellColor;

            if (cellColorDialog.ShowDialog() == DialogResult.OK)
            {
                cellColor = cellColorDialog.Color;
            }
            graphicsPanel1.Invalidate();
        }
        //toggle universe type between torodial and finite
        private void changeUniverseTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            universeTypeToggle();
        }
        //toggle HUD display
        private void toggleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HUDDisplayToggle();
        }
        //context sensitive
        //toggle grid    
        private void toggleGridToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            gridDisplayToggle();
        }
        //toggle neighborcount
        private void toggleNeighborCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textDisplayToggle();
        }
        //toggle HUD
        private void toggleHUDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HUDDisplayToggle();
        }
        private void setSeedToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            setSeedDialog();
        }

        private void setUniverseSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            universeSetSize();
        }

        private void toggleUniverseTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            universeTypeToggle();
        }
        #endregion

    }
    
}
