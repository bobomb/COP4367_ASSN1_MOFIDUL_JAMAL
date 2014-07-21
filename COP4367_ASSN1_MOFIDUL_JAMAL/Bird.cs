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
        public static float MaxVelocity = 15f;
        Pen[] FadeBrushes = new Pen[MAX_HISTORY];
        public bool IsAlive = true;
        public Pen ColorPen;
        public Color ColorARGB = new Color();
        public static float Diameter = 30f;
        public Dictionary<Bird, float> distanceTable = new Dictionary<Bird, float>();
        public List<Vector3> PositionHistory = new List<Vector3>();
        public const int MAX_HISTORY = 254;
        public static int HistorySize = 35;
        public Bird()
        {
            ColorARGB = Color.FromArgb(Program.Rand.Next(255), Program.Rand.Next(255), Program.Rand.Next(255));
            //ColorARGB = Color.Black;
            ColorPen = new Pen(ColorARGB);
            ColorPen.Brush = new SolidBrush(ColorARGB);
            int k = 0;
            for(int i = 0; i < 255; i++)
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
            //draw me and my 25% bigger circle
            //really shoulda just used radius instead of diamter to simplify the maths
            graphicsContext.FillEllipse(ColorPen.Brush, Position.X- (Diameter / 2f), Position.Y - (Diameter / 2f), Diameter, Diameter);
            graphicsContext.DrawEllipse(ColorPen, Position.X - (.625f * Diameter )  , Position.Y - (.625f * Diameter) , 1.25f * Diameter , 1.25f * Diameter);
            //draw direction arrow?
            graphicsContext.DrawLine(ColorPen, Position.X , Position.Y , (Position.X ) + 2f*Velocity.X, (Position.Y ) + 2f*Velocity.Y);
            if (HistorySize > 0)
            {
                lock (PositionHistory)
                {
                    int k = PositionHistory.Count;
                    for (int i = MAX_HISTORY - 1; i > 0; i -= MAX_HISTORY / HistorySize)
                    {
                        k--;
                        graphicsContext.FillEllipse(FadeBrushes[i].Brush, PositionHistory[k].X - (Diameter / 2f), PositionHistory[k].Y - (Diameter / 2f), Diameter, Diameter);
                    }
                }
            }
        }
    }
}
