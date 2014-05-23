using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace COP4367_ASSN1_MOFIDUL_JAMAL
{
    public class ParticleEngine
    {
        IParticle[] Particles;

        public ParticleEngine(int numberOfParticles)
        {
            Particles = new IParticle[numberOfParticles];
            for(int i = 0; i < numberOfParticles; i++)
            {
                if (Particle.rand.Next(0, 1) % 1 == 0)
                    Particles[i] = new GrowingShrinkingParticle();
                else
                    Particles[i] = new Particle();
            }
        }

        public void Draw(Graphics graphicsContext)
        {
            foreach(Particle p in Particles)
            {
                p.Draw(graphicsContext);
            }
        }
        public void Update()
        {
            for (int i = 0; i < Particles.Count(); i++)
            {
                IParticle p = Particles[i];
                p.Update();
                if(p.IsAlive == false)
                {
                    Particles[i] = new GrowingShrinkingParticle();
                }
            }
        }
    }
}
