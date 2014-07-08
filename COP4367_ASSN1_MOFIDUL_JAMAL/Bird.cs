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
        public float MaxVelocity = 12f;
        Pen[] FadeBrushes = new Pen[MAX_HISTORY];
        public bool IsAlive = true;
        public Pen ColorPen;
        public Color ColorARGB = new Color();
        public float Diameter = 25f;
        public Dictionary<Bird, float> distanceTable = new Dictionary<Bird, float>();
        public List<Vector3> PositionHistory = new List<Vector3>();
        public const int MAX_HISTORY = 100;

        public Bird()
        {
            ColorARGB = Color.FromArgb(Program.Rand.Next(255), Program.Rand.Next(255), Program.Rand.Next(255));
            ColorPen = new Pen(ColorARGB);
            ColorPen.Brush = new SolidBrush(ColorARGB);
            int k = 0;
            for(int i = 0; i < 254; i+=255/(MAX_HISTORY))
            {
                if (k == MAX_HISTORY)
                    break;
                FadeBrushes[k] = new Pen(Color.FromArgb(i, ColorARGB));
                FadeBrushes[k].Brush = new SolidBrush(Color.FromArgb(i, ColorARGB));
                k++;
            }

            Position.X = Program.Rand.Next(Form1.WindowSize.X);
            Position.Y = Program.Rand.Next(Form1.WindowSize.Y);
            Velocity.X = Program.Rand.Next(-(int)MaxVelocity, (int)MaxVelocity);
            Velocity.Y = Program.Rand.Next(-(int)MaxVelocity, (int)MaxVelocity);
            for(int i = 0; i < MAX_HISTORY; i++)
            {
                PositionHistory.Add(Position);
            }
            
        }
        public Bird(Color color)
        {
            ColorARGB = color;
            ColorPen = new Pen(ColorARGB);
            ColorPen.Brush = new SolidBrush(ColorARGB);
        }

        public void Update()
        {
            if(Velocity.Magnitude > MaxVelocity)
            {
                Velocity.Normalize();
                Velocity.X *= MaxVelocity;
                Velocity.Y *= MaxVelocity;
            }
            lock (PositionHistory)
            {
                PositionHistory.Add(Position);
                PositionHistory.RemoveAt(0);
            }
            Position.X += Velocity.X;
            Position.Y += Velocity.Y;
        }

        public  void Draw(System.Drawing.Graphics graphicsContext)
        {
            //draw me
            graphicsContext.FillEllipse(ColorPen.Brush, Position.X- (Diameter / 2f), Position.Y - (Diameter / 2f), Diameter, Diameter);
            lock (PositionHistory)
            {
                for (int i = 0; i < PositionHistory.Count; i++)
                {
                    graphicsContext.FillEllipse(FadeBrushes[i].Brush, PositionHistory[i].X - (Diameter / 2f), PositionHistory[i].Y - (Diameter / 2f), Diameter, Diameter);
                }
            }
        }
    }
}
