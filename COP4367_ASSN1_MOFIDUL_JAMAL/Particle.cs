using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace COP4367_ASSN1_MOFIDUL_JAMAL
{
    //yes i know i am violating OOP principals of encapsulating data by making it all public. bite me
    public class Particle
    {
        public PointF Position = new PointF();
        public Color ColorARGB = new Color();
        public Pen ColorPen;
        public int LifeTimeInTicks = 1000; //defaults to 1/10th second
        public bool IsAlive = true;
        public PointF Velocity = new PointF();
        private float ColorDecayFactor = 1f;
        public float Size;
        public static Random rand = new Random();
        public Particle()
        {
            
            //random pos
            Position.X = rand.Next(0, 800);
            Position.Y = rand.Next(0, 600);
            //random motions
            Velocity.X = rand.Next(-10, 10);
            Velocity.Y = rand.Next(-10, 10);
            //random color
            ColorARGB = Color.FromArgb(255, rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
            ColorPen = new Pen(ColorARGB);
            LifeTimeInTicks = rand.Next(5, 500);
            ColorDecayFactor = 255f /(float) LifeTimeInTicks;
            //random size
            Size = rand.Next(50, 255);
            ColorPen.Brush = new SolidBrush(ColorARGB);

        }
        public Particle(PointF position, Color color, int lifeTimeTicks, PointF velocity, float size)
        {
            Position = position;
            ColorARGB = color;
            ColorPen = new Pen(ColorARGB);
            ColorPen.Brush = new SolidBrush(ColorARGB);
            LifeTimeInTicks = lifeTimeTicks;
            Velocity = velocity;
            ColorDecayFactor = 255 / lifeTimeTicks;
            Size = size;
        }

        public void Draw(Graphics graphicsContext)
        {
            graphicsContext.FillEllipse(ColorPen.Brush, Position.X, Position.Y, Size, Size);
        }
        public void Update()
        {
            LifeTimeInTicks--;
            if (LifeTimeInTicks == 0)
                IsAlive = false;

            if (IsAlive)
            {
                Position = Position.AddPointF(Velocity); //i like to move it move it
                ColorARGB = Color.FromArgb((int)((float)LifeTimeInTicks * ColorDecayFactor), ColorARGB); //fugly, but sets the alpha as it dies
                ColorPen.Color = ColorARGB;
            } 
        }
    }
}

public static class MyExtensions
{
    public static PointF AddPointF(this PointF me, PointF add)
    {
        me.X += add.X;
        me.Y += add.Y;

        return me;
    }

    public static void MultiplyScalar(this PointF me, float scalar)
    {
        me.X *= scalar;
        me.Y *= scalar;
    }
}
