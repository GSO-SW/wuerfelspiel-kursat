using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wuerfelspiel
{
    public partial class FrmWuerfelspiel : Form
    {
        public FrmWuerfelspiel()
        {
            InitializeComponent();
        }

        private void FrmWuerfelspiel_Load(object sender, EventArgs e)
        {

        }

        private void FrmWuerfelspiel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen Black = new Pen(Color.Black, 2);


            int Rechteckgrose = 100;
            int Rechteckstart = 50;
            Rectangle außen = new Rectangle(Rechteckstart, Rechteckstart, Rechteckgrose, Rechteckgrose);

            int abstand = Rechteckgrose + 10;  // Abstand zwischen den großen Quadraten

            for (int o = 0; o < 5; o++)
            {
                int aktuellerStartX = Rechteckstart + o * abstand;
                int aktuellerStartY = Rechteckstart; 


                g.DrawRectangle(Black, aktuellerStartX, aktuellerStartY, Rechteckgrose, Rechteckgrose);


                int size = Rechteckgrose / 3;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        int x = aktuellerStartX + i * size;
                        int y = aktuellerStartY + j * size;
                        g.DrawRectangle(Black, x, y, size, size);
                    }
                }
            }









        }
    }
}
