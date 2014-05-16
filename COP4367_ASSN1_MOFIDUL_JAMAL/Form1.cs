using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COP4367_ASSN1_MOFIDUL_JAMAL
{
    public partial class Form1 : Form
    {
        Particle testParticle = new Particle(); //new random particle
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphicsContext = e.Graphics;
            graphicsContext.FillEllipse(testParticle.ColorPen.Brush, testParticle.Position.X, testParticle.Position.Y, testParticle.Size, testParticle.Size);
        }

        private void invalidateTimer_Tick(object sender, EventArgs e)
        {
            testParticle.DoFrame();
            Invalidate();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            testParticle = new Particle();
            testParticle.Position.X = e.X;
            testParticle.Position.Y = e.Y;
        }
    }
}
