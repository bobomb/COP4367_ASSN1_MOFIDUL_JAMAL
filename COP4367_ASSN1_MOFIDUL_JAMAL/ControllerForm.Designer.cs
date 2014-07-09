namespace COP4367_ASSN1_MOFIDUL_JAMAL
{
    partial class ControllerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cohesionRadiusTrack = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.alignmentRadiusTrack = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.seperationRadiusTrack = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.cohesionWeightTrack = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.alignmentWeightTrack = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.seperationWeightTrack = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.cohesionRadiusTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alignmentRadiusTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seperationRadiusTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cohesionWeightTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alignmentWeightTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seperationWeightTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // cohesionRadiusTrack
            // 
            this.cohesionRadiusTrack.Location = new System.Drawing.Point(128, 27);
            this.cohesionRadiusTrack.Maximum = 500;
            this.cohesionRadiusTrack.Minimum = 5;
            this.cohesionRadiusTrack.Name = "cohesionRadiusTrack";
            this.cohesionRadiusTrack.Size = new System.Drawing.Size(121, 45);
            this.cohesionRadiusTrack.TabIndex = 0;
            this.cohesionRadiusTrack.TickFrequency = 100;
            this.cohesionRadiusTrack.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.cohesionRadiusTrack.Value = 25;
            this.cohesionRadiusTrack.Scroll += new System.EventHandler(this.cohesionRadiusTrack_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cohesion Radius";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Alignment Radius";
            // 
            // alignmentRadiusTrack
            // 
            this.alignmentRadiusTrack.Location = new System.Drawing.Point(128, 78);
            this.alignmentRadiusTrack.Maximum = 500;
            this.alignmentRadiusTrack.Minimum = 5;
            this.alignmentRadiusTrack.Name = "alignmentRadiusTrack";
            this.alignmentRadiusTrack.Size = new System.Drawing.Size(121, 45);
            this.alignmentRadiusTrack.TabIndex = 2;
            this.alignmentRadiusTrack.TickFrequency = 100;
            this.alignmentRadiusTrack.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.alignmentRadiusTrack.Value = 155;
            this.alignmentRadiusTrack.Scroll += new System.EventHandler(this.alignmentRadiusTrack_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seperation Radius";
            // 
            // seperationRadiusTrack
            // 
            this.seperationRadiusTrack.Location = new System.Drawing.Point(128, 129);
            this.seperationRadiusTrack.Maximum = 300;
            this.seperationRadiusTrack.Minimum = 5;
            this.seperationRadiusTrack.Name = "seperationRadiusTrack";
            this.seperationRadiusTrack.Size = new System.Drawing.Size(121, 45);
            this.seperationRadiusTrack.TabIndex = 4;
            this.seperationRadiusTrack.TickFrequency = 100;
            this.seperationRadiusTrack.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.seperationRadiusTrack.Value = 40;
            this.seperationRadiusTrack.Scroll += new System.EventHandler(this.seperationRadiusTrack_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cohesion Weight";
            // 
            // cohesionWeightTrack
            // 
            this.cohesionWeightTrack.Location = new System.Drawing.Point(128, 180);
            this.cohesionWeightTrack.Maximum = 50;
            this.cohesionWeightTrack.Minimum = 1;
            this.cohesionWeightTrack.Name = "cohesionWeightTrack";
            this.cohesionWeightTrack.Size = new System.Drawing.Size(121, 45);
            this.cohesionWeightTrack.TabIndex = 6;
            this.cohesionWeightTrack.TickFrequency = 20;
            this.cohesionWeightTrack.Value = 2;
            this.cohesionWeightTrack.Scroll += new System.EventHandler(this.cohesionWeightTrack_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Alignment Weight";
            // 
            // alignmentWeightTrack
            // 
            this.alignmentWeightTrack.Location = new System.Drawing.Point(128, 231);
            this.alignmentWeightTrack.Maximum = 50;
            this.alignmentWeightTrack.Minimum = 1;
            this.alignmentWeightTrack.Name = "alignmentWeightTrack";
            this.alignmentWeightTrack.Size = new System.Drawing.Size(121, 45);
            this.alignmentWeightTrack.TabIndex = 8;
            this.alignmentWeightTrack.TickFrequency = 20;
            this.alignmentWeightTrack.Value = 4;
            this.alignmentWeightTrack.Scroll += new System.EventHandler(this.alignmentWeightTrack_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Seperation Weight";
            // 
            // seperationWeightTrack
            // 
            this.seperationWeightTrack.Location = new System.Drawing.Point(128, 282);
            this.seperationWeightTrack.Maximum = 300;
            this.seperationWeightTrack.Minimum = 1;
            this.seperationWeightTrack.Name = "seperationWeightTrack";
            this.seperationWeightTrack.Size = new System.Drawing.Size(121, 45);
            this.seperationWeightTrack.TabIndex = 10;
            this.seperationWeightTrack.TickFrequency = 20;
            this.seperationWeightTrack.Value = 100;
            this.seperationWeightTrack.Scroll += new System.EventHandler(this.seperationWeightTrack_Scroll);
            // 
            // ControllerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 562);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.seperationWeightTrack);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.alignmentWeightTrack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cohesionWeightTrack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.seperationRadiusTrack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.alignmentRadiusTrack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cohesionRadiusTrack);
            this.Name = "ControllerForm";
            this.Text = "ControllerForm";
            this.Load += new System.EventHandler(this.ControllerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cohesionRadiusTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alignmentRadiusTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seperationRadiusTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cohesionWeightTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alignmentWeightTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seperationWeightTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar cohesionRadiusTrack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar alignmentRadiusTrack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar seperationRadiusTrack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar cohesionWeightTrack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar alignmentWeightTrack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar seperationWeightTrack;
    }
}