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
        Particle[] Particles;

        public ParticleEngine(int numberOfParticles)
        {
            Particles = new Particle[numberOfParticles];
            for(int i = 0; i < numberOfParticles; i++)
            {
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
                Particle p = Particles[i];
                p.Update();
                if(p.IsAlive == false)
                {
                    Particles[i] = new Particle();
                }
            }
        }
    }
}
