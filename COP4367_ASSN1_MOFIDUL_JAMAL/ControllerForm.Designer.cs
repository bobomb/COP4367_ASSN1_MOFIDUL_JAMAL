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
            this.label7 = new System.Windows.Forms.Label();
            this.trailLengthTrack = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.birdSizeTrack = new System.Windows.Forms.TrackBar();
            this.randomizeButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cohesionRadiusTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alignmentRadiusTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seperationRadiusTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cohesionWeightTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alignmentWeightTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seperationWeightTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trailLengthTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birdSizeTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // cohesionRadiusTrack
            // 
            this.cohesionRadiusTrack.Location = new System.Drawing.Point(171, 33);
            this.cohesionRadiusTrack.Margin = new System.Windows.Forms.Padding(4);
            this.cohesionRadiusTrack.Maximum = 500;
            this.cohesionRadiusTrack.Minimum = 5;
            this.cohesionRadiusTrack.Name = "cohesionRadiusTrack";
            this.cohesionRadiusTrack.Size = new System.Drawing.Size(161, 56);
            this.cohesionRadiusTrack.TabIndex = 0;
            this.cohesionRadiusTrack.TickFrequency = 100;
            this.cohesionRadiusTrack.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.cohesionRadiusTrack.Value = 25;
            this.cohesionRadiusTrack.ValueChanged += new System.EventHandler(this.cohesionRadiusTrack_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cohesion Radius";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Alignment Radius";
            // 
            // alignmentRadiusTrack
            // 
            this.alignmentRadiusTrack.Location = new System.Drawing.Point(171, 96);
            this.alignmentRadiusTrack.Margin = new System.Windows.Forms.Padding(4);
            this.alignmentRadiusTrack.Maximum = 500;
            this.alignmentRadiusTrack.Minimum = 5;
            this.alignmentRadiusTrack.Name = "alignmentRadiusTrack";
            this.alignmentRadiusTrack.Size = new System.Drawing.Size(161, 56);
            this.alignmentRadiusTrack.TabIndex = 2;
            this.alignmentRadiusTrack.TickFrequency = 100;
            this.alignmentRadiusTrack.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.alignmentRadiusTrack.Value = 155;
            this.alignmentRadiusTrack.ValueChanged += new System.EventHandler(this.alignmentRadiusTrack_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seperation Radius";
            // 
            // seperationRadiusTrack
            // 
            this.seperationRadiusTrack.Location = new System.Drawing.Point(171, 159);
            this.seperationRadiusTrack.Margin = new System.Windows.Forms.Padding(4);
            this.seperationRadiusTrack.Maximum = 300;
            this.seperationRadiusTrack.Minimum = 5;
            this.seperationRadiusTrack.Name = "seperationRadiusTrack";
            this.seperationRadiusTrack.Size = new System.Drawing.Size(161, 56);
            this.seperationRadiusTrack.TabIndex = 4;
            this.seperationRadiusTrack.TickFrequency = 100;
            this.seperationRadiusTrack.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.seperationRadiusTrack.Value = 40;
            this.seperationRadiusTrack.ValueChanged += new System.EventHandler(this.seperationRadiusTrack_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 222);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cohesion Weight";
            // 
            // cohesionWeightTrack
            // 
            this.cohesionWeightTrack.Location = new System.Drawing.Point(171, 222);
            this.cohesionWeightTrack.Margin = new System.Windows.Forms.Padding(4);
            this.cohesionWeightTrack.Maximum = 50;
            this.cohesionWeightTrack.Minimum = 1;
            this.cohesionWeightTrack.Name = "cohesionWeightTrack";
            this.cohesionWeightTrack.Size = new System.Drawing.Size(161, 56);
            this.cohesionWeightTrack.TabIndex = 6;
            this.cohesionWeightTrack.TickFrequency = 20;
            this.cohesionWeightTrack.Value = 2;
            this.cohesionWeightTrack.ValueChanged += new System.EventHandler(this.cohesionWeightTrack_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 284);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Alignment Weight";
            // 
            // alignmentWeightTrack
            // 
            this.alignmentWeightTrack.Location = new System.Drawing.Point(171, 284);
            this.alignmentWeightTrack.Margin = new System.Windows.Forms.Padding(4);
            this.alignmentWeightTrack.Maximum = 50;
            this.alignmentWeightTrack.Minimum = 1;
            this.alignmentWeightTrack.Name = "alignmentWeightTrack";
            this.alignmentWeightTrack.Size = new System.Drawing.Size(161, 56);
            this.alignmentWeightTrack.TabIndex = 8;
            this.alignmentWeightTrack.TickFrequency = 20;
            this.alignmentWeightTrack.Value = 4;
            this.alignmentWeightTrack.ValueChanged += new System.EventHandler(this.alignmentWeightTrack_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 347);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Seperation Weight";
            // 
            // seperationWeightTrack
            // 
            this.seperationWeightTrack.Location = new System.Drawing.Point(171, 347);
            this.seperationWeightTrack.Margin = new System.Windows.Forms.Padding(4);
            this.seperationWeightTrack.Maximum = 300;
            this.seperationWeightTrack.Minimum = 1;
            this.seperationWeightTrack.Name = "seperationWeightTrack";
            this.seperationWeightTrack.Size = new System.Drawing.Size(161, 56);
            this.seperationWeightTrack.TabIndex = 10;
            this.seperationWeightTrack.TickFrequency = 20;
            this.seperationWeightTrack.Value = 100;
            this.seperationWeightTrack.ValueChanged += new System.EventHandler(this.seperationWeightTrack_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 411);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Trail Length";
            // 
            // trailLengthTrack
            // 
            this.trailLengthTrack.Location = new System.Drawing.Point(171, 411);
            this.trailLengthTrack.Margin = new System.Windows.Forms.Padding(4);
            this.trailLengthTrack.Maximum = 120;
            this.trailLengthTrack.Name = "trailLengthTrack";
            this.trailLengthTrack.Size = new System.Drawing.Size(161, 56);
            this.trailLengthTrack.TabIndex = 12;
            this.trailLengthTrack.TickFrequency = 20;
            this.trailLengthTrack.Value = 20;
            this.trailLengthTrack.ValueChanged += new System.EventHandler(this.trailLengthTrack_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 475);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "Bird Size";
            // 
            // birdSizeTrack
            // 
            this.birdSizeTrack.Location = new System.Drawing.Point(171, 475);
            this.birdSizeTrack.Margin = new System.Windows.Forms.Padding(4);
            this.birdSizeTrack.Maximum = 75;
            this.birdSizeTrack.Minimum = 1;
            this.birdSizeTrack.Name = "birdSizeTrack";
            this.birdSizeTrack.Size = new System.Drawing.Size(161, 56);
            this.birdSizeTrack.TabIndex = 14;
            this.birdSizeTrack.TickFrequency = 20;
            this.birdSizeTrack.Value = 12;
            this.birdSizeTrack.ValueChanged += new System.EventHandler(this.birdSizeTrack_Scroll);
            // 
            // randomizeButton
            // 
            this.randomizeButton.Location = new System.Drawing.Point(12, 553);
            this.randomizeButton.Name = "randomizeButton";
            this.randomizeButton.Size = new System.Drawing.Size(320, 38);
            this.randomizeButton.TabIndex = 16;
            this.randomizeButton.Text = "Randomize Parameters";
            this.randomizeButton.UseVisualStyleBackColor = true;
            this.randomizeButton.Click += new System.EventHandler(this.randomizeButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(12, 598);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(320, 39);
            this.resetButton.TabIndex = 17;
            this.resetButton.Text = "Reset Parameters To Default";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // ControllerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 692);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.randomizeButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.birdSizeTrack);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.trailLengthTrack);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ControllerForm";
            this.Text = "ControllerForm";
            ((System.ComponentModel.ISupportInitialize)(this.cohesionRadiusTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alignmentRadiusTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seperationRadiusTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cohesionWeightTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alignmentWeightTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seperationWeightTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trailLengthTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birdSizeTrack)).EndInit();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trailLengthTrack;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar birdSizeTrack;
        private System.Windows.Forms.Button randomizeButton;
        private System.Windows.Forms.Button resetButton;
    }
}