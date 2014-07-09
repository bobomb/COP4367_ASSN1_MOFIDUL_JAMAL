using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COP4367_ASSN1_MOFIDUL_JAMAL
{
    public partial class Form1 : Form
    {
        //Bird testParticle = new Bird(); //new random particle
        FlockingEngine engine;
        private static Size windowSize;
        int FLOCK_SIZE = 75;
        private Bitmap myBitmap;
        Graphics bitmapGraphicsContext;
        ControllerForm controller;

        public static Point WindowSize
        {
            get { return new Point(windowSize); }
        }
        public Form1()
        {
            InitializeComponent();
            windowSize = this.ClientSize;
            myBitmap = new Bitmap(this.ClientRectangle.Width,
                                    this.ClientRectangle.Height,
                                    System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            bitmapGraphicsContext = Graphics.FromImage(myBitmap);

            Thread bgThread = new Thread((ThreadStart)delegate()
            {
                while (true)
                {
                    if (engine != null)
                    {
                        engine.Update();
                        //engine.Draw(bitmapGraphicsContext);
                    }
                }
            });

            bgThread.IsBackground = true;
            bgThread.Priority = ThreadPriority.AboveNormal;
            bgThread.Start();

            

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (engine != null)
            {
                Graphics graphicsContext = e.Graphics;
                //graphicsContext.DrawImage(myBitmap, 0, 0);
                engine.Draw(graphicsContext);
            }
            //graphicsContext.FillEllipse(testParticle.ColorPen.Brush, testParticle.Position.X, testParticle.Position.Y, testParticle.Size, testParticle.Size);
        }

        private void invalidateTimer_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            windowSize = this.ClientSize;
            myBitmap = new Bitmap(this.ClientRectangle.Width,
                        this.ClientRectangle.Height,
                        System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            bitmapGraphicsContext = Graphics.FromImage(myBitmap);
        }

        private void startupTimer_Tick(object sender, EventArgs e)
        {
            startupTimer.Stop();
            engine = new FlockingEngine(FLOCK_SIZE);
            controller = new ControllerForm(engine);
            controller.Show();
        }
    }
}
