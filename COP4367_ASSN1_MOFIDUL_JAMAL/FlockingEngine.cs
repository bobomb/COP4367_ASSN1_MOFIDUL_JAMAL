using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace COP4367_ASSN1_MOFIDUL_JAMAL
{
    public class FlockingEngine
    {
        float AlignmentRadius = 50f;
        float CohesionRadius = 50f;
        float SeperationRadius = 50f;
        Bird[] BirdList;
        public FlockingEngine(int numberOfBirds)
        {
            BirdList = new Bird[numberOfBirds];
            for(int i = 0; i < numberOfBirds; i++)
            {
                Bird b = new Bird();
                BirdList[i] = b;
            }
        }

        public void Draw(Graphics graphicsContext)
        {
            foreach(Bird b in BirdList)
            {
                b.Draw(graphicsContext);
            }
        }
        public void Update()
        {
            for(int i = 0; i < BirdList.Length; i++)
            {
                CalculateAlignment(BirdList[i]);
                CalculateCohesion(BirdList[i]);
                CalculateSeperation(BirdList[i]);
            }
        }

        public void CalculateAlignment(Bird b)
        {

        }

        public void CalculateCohesion(Bird b)
        {

        }

        public void CalculateSeperation(Bird b)
        {

        }
    }
}
