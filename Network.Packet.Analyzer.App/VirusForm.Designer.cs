
namespace Network.Packet.Analyzer.App
{
    partial class VirusForm
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
            this.timer1_Tick_1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1_Tick_1
            // 
            this.timer1_Tick_1.Location = new System.Drawing.Point(220, 21);
            this.timer1_Tick_1.Name = "timer1_Tick_1";
            this.timer1_Tick_1.Size = new System.Drawing.Size(75, 23);
            this.timer1_Tick_1.TabIndex = 0;
            this.timer1_Tick_1.Text = "Detect Virus";
            this.timer1_Tick_1.UseVisualStyleBackColor = true;
            this.timer1_Tick_1.Click += new System.EventHandler(this.timer1_Tick_1_Click);
            // 
            // VirusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 349);
            this.Controls.Add(this.timer1_Tick_1);
            this.Name = "VirusForm";
            this.Text = "VirusForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button timer1_Tick_1;
    }
}