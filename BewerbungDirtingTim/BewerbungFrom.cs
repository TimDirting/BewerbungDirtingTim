using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BewerbungDirtingTim
{
    public partial class BewerbungsForm : Form
    {

        KnightTour knight;
        List<Image> Imagelist = new List<Image>();
        Graphics g,g1,g2;
        Rectangle rect;
        SolidBrush CBrush, ChessBrush;
        Font f = new Font("Arial", 12.0f);
        int sliderlen = 500;
        string RunningPath;
        public BewerbungsForm()
        {
            InitializeComponent();
            ChessBrush = new SolidBrush(Color.Black);
            g = pictureBoxDesign.CreateGraphics();
            g1 = pictureBoxDesign2.CreateGraphics();
            g2 = pictureBoxKnight.CreateGraphics();
            CBrush = new SolidBrush(Color.DodgerBlue);
            buttonPicture.BackgroundImageLayout = ImageLayout.Stretch;
            RunningPath  = Path.GetFullPath(Path.Combine(Application.StartupPath, @"../../"));

            rect = new Rectangle(0, 0, 0, 100);

          
            Imagelist.Add(Properties.Resources.IMG_62);
            Imagelist.Add(Properties.Resources.IMG_61);

            setupInfoBox();
            
        }

        private void buttonLebenslauf_Click(object sender, EventArgs e)
        {
            
            
            System.Diagnostics.Process.Start(RunningPath + "/Properties/Lebenslauf.pdf");
        }

        private void buttonAnlagen_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(RunningPath + "/Properties/Anlagen.pdf");
        }

        private void buttonAnschreiben_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start(RunningPath + "/Properties/Anschreiben.pdf");
        }

        private void buttonBeispielCode_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(RunningPath + "/Properties/SortAlginC.exe");
        }

        private void buttonPicture_Click(object sender, EventArgs e)
        {
            buttonPicture.BackgroundImage = Imagelist[0];
            Imagelist.Reverse();
        }
       
        private void paintingTimer_Tick(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            g1.Clear(Color.White);
            if (rect.X > this.Width +80 ) {
                rect.X = 0;
                rect.Width = 0;
            }

            if (rect.Width < sliderlen)
                rect.Width++;
            else
                rect.X++;

            g1.FillRectangle(CBrush, rect);
            g.FillRectangle(CBrush, rect);
     
        }

        private void pictureBoxKnight_Click(object sender, EventArgs e)
        {
            solveKnightProblem();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            solveKnightProblem();
        }

        private void buttonchessstart_Click(object sender, EventArgs e)
        {
            solveKnightProblem();
        }

        private void setupInfoBox()
        {

            richTextBoxInfo.BackColor = Color.White;
            richTextBoxInfo.SelectionColor = Color.DodgerBlue;
            richTextBoxInfo.SelectionFont = new Font("Georgia", 32, FontStyle.Bold);
            richTextBoxInfo.SelectedText = "Tim Dirting\n ";
            richTextBoxInfo.SelectionFont = new Font("Arial", 14);
            richTextBoxInfo.SelectionColor = Color.LightSlateGray;
            richTextBoxInfo.SelectedText = "Kontaktdaten" + "\n";
            richTextBoxInfo.SelectionFont = new Font("VArial", 12);
            richTextBoxInfo.SelectionColor = Color.Black;
            richTextBoxInfo.SelectedText = "dirtingtim@gmail.com" + "\n" + "015757167400 \n";
            richTextBoxInfo.SelectionFont = new Font("Arial", 14);
            richTextBoxInfo.SelectionColor = Color.LightSlateGray;
            richTextBoxInfo.SelectedText = "Anschrift" + "\n";
            richTextBoxInfo.SelectionFont = new Font("Arial", 12);
            richTextBoxInfo.SelectionColor = Color.Black;
            richTextBoxInfo.SelectedText = "Tim Dirting\n" + "Biekmeresch 15 \n" + "48282 Emsdetten \n" + "Deutschland \n";

        }

        private void solveKnightProblem()
        {
            int dimension = 5;
            Random r = new Random();
            int x = r.Next(0, dimension);
            int y = r.Next(0, dimension);

            knight = new KnightTour(dimension);


            knight.solve(x, y, 0);
            if (knight.isSolved())
            {
                printchessfield();
            }
            else
                solveKnightProblem();
        }


       

        private void printchessfield()
        {
            int dim = knight.N;
            int[,] field = knight.chessfield;
                
            Pen blackPen = new Pen(Color.Black, 3);
            
            g2.Clear(Color.White);
            int width = pictureBoxKnight.Width;
            int height = pictureBoxKnight.Height;
            int w = (width / dim);
            int h = (height / dim);
            Rectangle r = new Rectangle(0, 0, width, height);

            g2.DrawRectangle(blackPen,r);
            
            
            
            for (int i = 0; i < dim; i++)
            {
                r = new Rectangle(0, 0, w, h);
                g2.DrawRectangle(blackPen, r);
                r = new Rectangle(width-w,height-h,width,height);
                g2.DrawRectangle(blackPen, r);
           
                w = w + width / dim ;
                h = h +  height / dim ;
            }
           

            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    g2.DrawString(field[i, j].ToString(), f, ChessBrush, i* width / dim + 18,j* height / dim + 18);
                }
            }

        }

        private void BewerbungsForm_Resize(object sender, EventArgs e)
        {

            int formwidth = this.Width-50;
            buttonAnschreiben.Width = formwidth / 2;
            buttonLebenslauf.Width = formwidth / 2;
            buttonAnlagen.Width = formwidth / 2;
            buttonBeispielCode.Width = formwidth / 2;
         
        }

        
    }
}
