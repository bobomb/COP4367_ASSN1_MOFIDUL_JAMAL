using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace COP4367_ASSN1_MOFIDUL_JAMAL
{
    public class ParticleEngine : IDrawable
    {
        IDrawable[] Particles;
        ParticleEmitter emitter;

        public ParticleEngine(int numberOfParticles)
        {
            Particles = new IDrawable[numberOfParticles];
            for(int i = 0; i < numberOfParticles; i++)
            {
                if (Particle.rand.Next(0, 2) % 2 == 0)
                    Particles[i] = new GrowingShrinkingParticle();
                else
                    Particles[i] = new Particle();
            }
        }

        public override void Draw(Graphics graphicsContext)
        {
            foreach(Particle p in Particles)
            {
                p.Draw(graphicsContext);
            }

            if (emitter != null)
            {
                if (emitter.IsAlive)
                    emitter.Draw(graphicsContext);
            }
        }
        public override void Update()
        {
            for (int i = 0; i < Particles.Count(); i++)
            {
                IDrawable p = Particles[i];
                p.Update();
                if(p.IsAlive == false)
                {
                    Particles[i] = new GrowingShrinkingParticle();
                }
            }

            if (emitter != null)
            {
                emitter.Update();
            }
        }

        internal void Explode(Point point)
        {
            emitter = new ParticleEmitter(new PointF(point.X, point.Y), 250);
        }
    }
}
