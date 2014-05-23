using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace COP4367_ASSN1_MOFIDUL_JAMAL
{
    public class GrowingShrinkingParticle : Particle
    {
        private int maxParticleRadius = 10;
        private int minParticleRadius = 1;
        private int millisecondOffset = 10;
        private float timeScale = 1f;
        private float tickCounter = 0;
        public GrowingShrinkingParticle() : base()
        {
            maxParticleRadius = rand.Next(50, 250);
            minParticleRadius = rand.Next(maxParticleRadius / 2, maxParticleRadius-1);
            millisecondOffset = rand.Next(1, 500);
            tickCounter = (float)(rand.NextDouble() * 6.28);
           // Radius = maxParticleRadius;
        }

        public override void Draw(Graphics graphicsContext)
        {
            //graphicsContext.TranslateTransform(-Radius, -Radius);
            graphicsContext.FillEllipse(ColorPen.Brush, Position.X - (Diameter / 2f), Position.Y - (Diameter / 2f), Diameter, Diameter);
        }

        public override void Update()
        {
            base.Update();
            if (IsAlive)
            {
                Diameter = 25 + (100 * (.5f + Math.Abs(((float)Math.Sin(tickCounter)))));
                tickCounter+=(6.28f/100f);
            }            
        }
    }
}
