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
        ParticleEngine engine;
        private static Size windowSize;
        private string instructions = "press any key or click the mouse anywhere";
        Color backgroundColor = Color.White;
        Font font1 = new Font(FontFamily.Families[0], 70.0f);
        public static Point WindowSize
        {
            get { return new Point(windowSize); }
        }

        public Form1()
        {
            InitializeComponent();
            windowSize = this.ClientSize;
            engine =  new ParticleEngine(250);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphicsContext = e.Graphics;
            graphicsContext.Clear(backgroundColor);
            engine.Draw(graphicsContext);
            graphicsContext.DrawString(instructions, font1, Brushes.Black, 50, 50);
            //graphicsContext.FillEllipse(testParticle.ColorPen.Brush, testParticle.Position.X, testParticle.Position.Y, testParticle.Size, testParticle.Size);
        }

        private void invalidateTimer_Tick(object sender, EventArgs e)
        {
            engine.Update();
            Invalidate();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            engine.Explode(e.Location);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            windowSize = this.ClientSize;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //pick random BG color
            backgroundColor = Color.FromArgb(255, Particle.rand.Next(0, 255), Particle.rand.Next(0, 255), Particle.rand.Next(0, 255));
        }
    }
}
