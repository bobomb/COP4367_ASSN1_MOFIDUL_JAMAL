using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COP4367_ASSN1_MOFIDUL_JAMAL
{
    public partial class ControllerForm : Form
    {
        FlockingEngine flockingEngine;
        public ControllerForm(FlockingEngine engine)
        {
            InitializeComponent();
            flockingEngine = engine;
        }
        private void cohesionRadiusTrack_Scroll(object sender, EventArgs e)
        {
            flockingEngine.CohesionRadius = cohesionRadiusTrack.Value;
        }

        private void alignmentRadiusTrack_Scroll(object sender, EventArgs e)
        {
            flockingEngine.AlignmentRadius = alignmentRadiusTrack.Value;
        }

        private void seperationRadiusTrack_Scroll(object sender, EventArgs e)
        {
            flockingEngine.SeperationRadius = seperationRadiusTrack.Value;
        }

        private void cohesionWeightTrack_Scroll(object sender, EventArgs e)
        {
            flockingEngine.CohesionWeight = cohesionWeightTrack.Value * 0.05f;

        }

        private void alignmentWeightTrack_Scroll(object sender, EventArgs e)
        {
            flockingEngine.AlignmentWeight = alignmentWeightTrack.Value * 0.05f;

        }

        private void seperationWeightTrack_Scroll(object sender, EventArgs e)
        {
            flockingEngine.SeperationWeight = seperationWeightTrack.Value * 0.05f;

        }

        private void trailLengthTrack_Scroll(object sender, EventArgs e)
        {
            Bird.HistorySize = trailLengthTrack.Value;
        }

        private void birdSizeTrack_Scroll(object sender, EventArgs e)
        {
            Bird.Diameter = birdSizeTrack.Value;
        }

        private void randomizeButton_Click(object sender, EventArgs e)
        {
            //sep
            seperationRadiusTrack.Value = Program.Rand.Next(seperationRadiusTrack.Minimum, seperationRadiusTrack.Maximum);
            seperationWeightTrack.Value = Program.Rand.Next(seperationWeightTrack.Minimum, seperationWeightTrack.Maximum);
            //coh
            cohesionRadiusTrack.Value = Program.Rand.Next(cohesionRadiusTrack.Minimum, cohesionRadiusTrack.Maximum);
            cohesionWeightTrack.Value = Program.Rand.Next(cohesionWeightTrack.Minimum, cohesionWeightTrack.Maximum);
            //align
            alignmentRadiusTrack.Value = Program.Rand.Next(alignmentRadiusTrack.Minimum, alignmentRadiusTrack.Maximum);
            alignmentWeightTrack.Value = Program.Rand.Next(alignmentWeightTrack.Minimum, alignmentWeightTrack.Maximum);

            trailLengthTrack.Value = Program.Rand.Next(trailLengthTrack.Minimum, trailLengthTrack.Maximum);

            birdSizeTrack.Value = Program.Rand.Next(birdSizeTrack.Minimum, birdSizeTrack.Maximum);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {

            birdSizeTrack.Value = 30;
            trailLengthTrack.Value = 35;
            seperationWeightTrack.Value = 200;
            alignmentWeightTrack.Value = 4;
            cohesionWeightTrack.Value = 2;
            seperationRadiusTrack.Value = 40;
            cohesionRadiusTrack.Value = 25;
            alignmentRadiusTrack.Value = 155;
        }
    }
}
