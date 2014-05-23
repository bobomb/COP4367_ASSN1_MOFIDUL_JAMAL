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
        ParticleEngine engine;
        private static Size windowSize;
        public static Point WindowSize
        {
            get { return new Point(windowSize); }
        }
        public Form1()
        {
            InitializeComponent();
            windowSize = this.ClientSize;
            engine =  new ParticleEngine(500);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphicsContext = e.Graphics;
            engine.Draw(graphicsContext);
            //graphicsContext.FillEllipse(testParticle.ColorPen.Brush, testParticle.Position.X, testParticle.Position.Y, testParticle.Size, testParticle.Size);
        }

        private void invalidateTimer_Tick(object sender, EventArgs e)
        {
            engine.Update();
            Invalidate();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            windowSize = this.ClientSize;
        }
    }
}
