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

        private void ControllerForm_Load(object sender, EventArgs e)
        {

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
    }
}
