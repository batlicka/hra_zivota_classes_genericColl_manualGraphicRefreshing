using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vagunda_hra_zivota_classes_genericColl;

namespace GraphicalGameOfLifeForm
{
    public partial class Form1 : Form
    {
        private int sideofField;
        private int sideOfCell= 40; //výška strany buňky při čtvercovém hracím poli

        private int HsideOfCell; //výška strany buňky, při nečtvercovém hracím poli
        private int WsideOfCell; //šířka strany buňky, při nečtvercovém hracím poli
        private bool DoPaint = false;

        private Grid FieldOfLife;
        public int Gen { get; set; }
        private OpenFileDialog openFile = new OpenFileDialog();
        private SaveFileDialog saveFileDialog = new SaveFileDialog();

        public Form1()
        {
            InitializeComponent();
            Gen = 0;

            openFile.Filter = "Text files (*.txt)|*.txt";
            //openFile.InitialDirectory = @ "D:\"; 

            saveFileDialog.Filter = "Text files (*.txt)|*.txt";
            saveFileDialog.RestoreDirectory = true;//If RestoreDirectory property is set to true that means the open file dialog box restores the current directory before closing.

            if (this.Width < this.Height)
                sideofField = this.Width;
            else
                sideofField = this.Height;            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DrawAnotherGeneration_Click(object sender, EventArgs e)
        {
            //aktualizuj + připrav další generaci
            //aktualizuj paint
            this.Invalidate();
            FieldOfLife.PrepareAnotherGen();
        }

        private void LoadFromTxt_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath = openFile.FileName;
                    FieldOfLife = new Grid(filePath);
                    DoPaint = true;
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }

            }
        }

        private void SaveToTxt_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //OpenFile()) != null
                var filePath = saveFileDialog.FileName;
                FieldOfLife.WriteToTXT(filePath);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if(DoPaint != false)
            {
                

                HsideOfCell = sideOfCell;//sideofField / (FieldOfLife.GetHeigh() - 2);
                WsideOfCell = sideOfCell;//sideofField / (FieldOfLife.GetWidth() - 2);
                // Create a local version of the graphics object    
                Graphics g = e.Graphics;
                //Graphics g = this.CreateGraphics();
                Brush backGround = new SolidBrush(Color.Black);
                Brush liveBrush = new SolidBrush(Color.Green);
                Brush deadBrush = new SolidBrush(Color.Black);
                Pen whitePen = new Pen(Color.White, 1);

                g.FillRectangle(backGround, new Rectangle(0, 0, (FieldOfLife.GetWidth()-2)*sideOfCell, (FieldOfLife.GetWidth()*sideOfCell)-2));//širka, vyška


                for (int i = 1; i < (FieldOfLife.GetHeigh() - 1); i++) //array.GetLength(0)=rows
                {
                    for (int j = 1; j < (FieldOfLife.GetWidth()- 1); j++)            //array.GetLength(1)= colums
                    {
                        if (FieldOfLife.currArray[i, j].IsAlive == true)
                        {
                            g.FillRectangle(liveBrush, new Rectangle((j - 1) * HsideOfCell, (i - 1) * WsideOfCell, HsideOfCell, WsideOfCell));
                            g.DrawRectangle(whitePen, new Rectangle((j - 1) * HsideOfCell, (i - 1) * WsideOfCell, HsideOfCell, WsideOfCell));
                        }
                        else
                        {
                            //g.FillRectangle(deadBrush, new Rectangle((i - 1) * sideOfCell, (j - 1) * sideOfCell, sideOfCell, sideOfCell));
                            g.DrawRectangle(whitePen, new Rectangle((j - 1) * HsideOfCell, (i - 1) * WsideOfCell, HsideOfCell, WsideOfCell));
                        }
                    }
                }
            }
        }
    }
}
