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
        //Bird testParticle = new Bird(); //new random particle
        FlockingEngine engine;
        private static Size windowSize;
        int FLOCK_SIZE = 100;
        public static Point WindowSize
        {
            get { return new Point(windowSize); }
        }
        public Form1()
        {
            InitializeComponent();
            windowSize = this.ClientSize;
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (engine != null)
            {
                Graphics graphicsContext = e.Graphics;
                engine.Draw(graphicsContext);
            }
            //graphicsContext.FillEllipse(testParticle.ColorPen.Brush, testParticle.Position.X, testParticle.Position.Y, testParticle.Size, testParticle.Size);
        }

        private void invalidateTimer_Tick(object sender, EventArgs e)
        {
            if(engine != null)
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

        private void startupTimer_Tick(object sender, EventArgs e)
        {
            startupTimer.Stop();
            engine = new FlockingEngine(FLOCK_SIZE);
        }
    }
}
