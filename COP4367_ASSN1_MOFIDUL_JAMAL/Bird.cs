using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace COP4367_ASSN1_MOFIDUL_JAMAL
{
    //yes i know i am violating OOP principals of encapsulating data by making it all public. bite me
    public class Bird 
    {
        public Vector3 Position;
        public Vector3 Acceleration;
        public Vector3 Velocity;
        public bool IsAlive = true;
        public Pen ColorPen;
        public Color ColorARGB = new Color();
        public float Diameter = 5f;

        public Bird()
        {
            ColorARGB = Color.FromArgb(Program.Rand.Next(255), Program.Rand.Next(255), Program.Rand.Next(255));
            ColorPen = new Pen(ColorARGB);
            ColorPen.Brush = new SolidBrush(ColorARGB);
            Position.X = Program.Rand.Next(Form1.WindowSize.X);
            Position.Y = Program.Rand.Next(Form1.WindowSize.Y);
        }
        public Bird(Color color)
        {
            ColorARGB = color;
            ColorPen = new Pen(ColorARGB);
            ColorPen.Brush = new SolidBrush(ColorARGB);
        }
        public  void Draw(System.Drawing.Graphics graphicsContext)
        {
            graphicsContext.FillEllipse(ColorPen.Brush, Position.X- (Diameter / 2f), Position.Y - (Diameter / 2f), Diameter, Diameter);
        }
        
   
    }
}
