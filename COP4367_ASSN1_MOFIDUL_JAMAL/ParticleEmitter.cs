using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace COP4367_ASSN1_MOFIDUL_JAMAL
{
    public class ParticleEmitter : IDrawable
    {
        List<Particle> particles;

        public ParticleEmitter(PointF origins, int numParticles)
        {
            particles = new List<Particle>();
            Color particleColor = Color.FromArgb(255, Particle.rand.Next(0, 255), Particle.rand.Next(0, 255), Particle.rand.Next(0, 255));
            for (int i = 0; i < numParticles; i++)
            {
                Particle p = new Particle(Particle.rand.Next(1,100)); //new random particle
                //p.ColorARGB = particleColor;
                p.Diameter = Particle.rand.Next(25, 101);
                //p.Position = origins.RadiallyFromCenter(Particle.rand.Next(5, 50), (360 / numParticles) * i);
                p.Position = origins.RadiallyFromCenter(50, (360.0 / numParticles) * i);
                p.Velocity = origins.RadiallyFromZero(1, (360.0 / numParticles) * i);
                int velocityMult = Particle.rand.Next(1, 25);
                p.Velocity.X *= velocityMult;
                p.Velocity.Y *= velocityMult;
                particles.Add(p);
            }
        }

        public override void Draw(Graphics graphicsContext)
        {
            foreach (Particle p in particles)
            {
                p.Draw(graphicsContext);
            }
        }

        public override void Update()
        {
            if (particles.Count == 0)
                IsAlive = false;

            for (int i = 0; i < particles.Count(); i++)
            {
                IDrawable p = particles[i];
                p.Update();
            }
            //remove all dead particles
            particles.RemoveAll(p => p.IsAlive == false);
        }
    }
}
