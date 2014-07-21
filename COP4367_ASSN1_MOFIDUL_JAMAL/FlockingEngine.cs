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
        public float AlignmentRadius = 155f;
        public float CohesionRadius = 25f;
        public float SeperationRadius = 40f;
        public float AlignmentWeight = .2f;
        public float CohesionWeight = .1f;
        public float SeperationWeight = 10f;
        public float WallAvoidanceForce = 20f;

        Bird[] BirdList;
        public FlockingEngine(int numberOfBirds)
        {
            BirdList = new Bird[numberOfBirds];
            for(int i = 0; i < numberOfBirds; i++)
            {
                Bird b = new Bird();
                BirdList[i] = b;
            }
            //distance table
            for (int i = 0; i < numberOfBirds; i++)
            {
                for(int j = 0; j < numberOfBirds; j++)
                {
                    if(i != j)
                    {
                        BirdList[i].distanceTable.Add(BirdList[j], BirdList[i].Position.Distance(BirdList[j].Position));
                    }
                }
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
            Vector3 alignmentVec = new Vector3();
            Vector3 cohesionVec = new Vector3();
            Vector3 seperationVec = new Vector3();
            int neighborCountAlignment = 0;
            int neighborCountSeperation = 0;
            int neighborCountCohesion = 0;
            for(int bi = 0; bi < BirdList.Length; bi++)
            {
                alignmentVec.X = 0;
                alignmentVec.Y = 0;
                cohesionVec.X = 0;
                cohesionVec.Y = 0;
                seperationVec.X = 0;
                seperationVec.Y = 0;
                neighborCountAlignment = 0;
                neighborCountCohesion = 0;
                neighborCountSeperation = 0;
                //precalculate distance tables ONCE
                CalculateDistanceTable(BirdList[bi]);
                //Iterating through the birdlist for every bird  three times over is slow as hell so do it once here
                for (int i = 0; i < BirdList.Length; i++)
                {
                    if (BirdList[bi] != BirdList[i])
                    {
                        //alignment
                        if (BirdList[bi].distanceTable[BirdList[i]] < AlignmentRadius)
                        {
                            neighborCountAlignment++;
                            alignmentVec.X += BirdList[i].Velocity.X;
                            alignmentVec.Y += BirdList[i].Velocity.Y;
                        }
                        //cohesion
                        if (BirdList[bi].distanceTable[BirdList[i]] < CohesionRadius)
                        {
                            neighborCountCohesion++;
                            cohesionVec.X += BirdList[i].Position.X;
                            cohesionVec.Y += BirdList[i].Position.Y;
                        }
                        //seperation
                        if (BirdList[bi].distanceTable[BirdList[i]] < SeperationRadius)
                        {
                            neighborCountSeperation++;
                            seperationVec.X += BirdList[i].Position.X - BirdList[bi].Position.X;
                            seperationVec.Y += BirdList[i].Position.Y - BirdList[bi].Position.Y;
                        }
                    }
                }

                if (neighborCountAlignment > 0)
                {
                    alignmentVec.X /= neighborCountAlignment;
                    alignmentVec.Y /= neighborCountAlignment;
                }

                if (neighborCountCohesion > 0)
                {
                    cohesionVec.X /= neighborCountCohesion;
                    cohesionVec.Y /= neighborCountCohesion;
                    cohesionVec.X = cohesionVec.X - BirdList[bi].Position.X;
                    cohesionVec.Y = cohesionVec.Y - BirdList[bi].Position.Y;
                }

                if (neighborCountSeperation > 0)
                {
                    seperationVec.X /= neighborCountSeperation;
                    seperationVec.Y /= neighborCountSeperation;
                    seperationVec.X *= -1f;
                    seperationVec.Y *= -1f;
                }
                try
                {
                    /*
                    alignmentVec.Normalize();
                    cohesionVec.Normalize();
                    seperationVec.Normalize();
                     * */
                }
                catch (Exception E) { }
                BirdList[bi].Velocity.X += alignmentVec.X * AlignmentWeight + cohesionVec.X * CohesionWeight + seperationVec.X * SeperationWeight;
                BirdList[bi].Velocity.Y += alignmentVec.Y * AlignmentWeight + cohesionVec.Y * CohesionWeight + seperationVec.Y * SeperationWeight;
                //BirdList[bi].Velocity += alignmentVec + cohesionVec + seperationVec;
                //avoid walls and shit

                if(BirdList[bi].Position.X < 0)
                    BirdList[bi].Velocity.X += WallAvoidanceForce;

                if (BirdList[bi].Position.X > Form1.WindowSize.X)
                    BirdList[bi].Velocity.X -= WallAvoidanceForce;

                if (BirdList[bi].Position.Y < 0)
                    BirdList[bi].Velocity.Y += WallAvoidanceForce;

                if (BirdList[bi].Position.Y > Form1.WindowSize.Y)
                    BirdList[bi].Velocity.Y -= WallAvoidanceForce;
                

                BirdList[bi].Update();
            }

        }

        private void CalculateDistanceTable(Bird bird)
        {
            for (int i = 0; i < BirdList.Length; i++)
            {
                for (int j = 0; j < BirdList.Length; j++)
                {
                    if (i != j)
                    {
                        BirdList[i].distanceTable[BirdList[j]] =  BirdList[i].Position.Distance(BirdList[j].Position);
                    }
                }
            }
        }
    }
}
