namespace TRS_DIMANCHE
{
    partial class Formmain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formmain));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.bouttonback = new MetroFramework.Controls.MetroLink();
            this.timertime = new System.Windows.Forms.Timer(this.components);
            this.serialPortDAQ = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelstate = new System.Windows.Forms.Label();
            this.nommachine = new System.Windows.Forms.Label();
            this.labeldatetime = new System.Windows.Forms.Label();
            this.label_ = new System.Windows.Forms.Label();
            this.label_X = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 69);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1500, 652);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // bouttonback
            // 
            this.bouttonback.BackColor = System.Drawing.Color.Transparent;
            this.bouttonback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bouttonback.Image = ((System.Drawing.Image)(resources.GetObject("bouttonback.Image")));
            this.bouttonback.ImageSize = 35;
            this.bouttonback.Location = new System.Drawing.Point(23, 11);
            this.bouttonback.Name = "bouttonback";
            this.bouttonback.Size = new System.Drawing.Size(50, 40);
            this.bouttonback.TabIndex = 1;
            this.bouttonback.UseCustomBackColor = true;
            this.bouttonback.UseSelectable = true;
            this.bouttonback.Click += new System.EventHandler(this.bouttonback_Click);
            // 
            // timertime
            // 
            this.timertime.Interval = 1000;
            this.timertime.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // serialPortDAQ
            // 
            this.serialPortDAQ.PortName = "COM7";
            this.serialPortDAQ.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortDAQ_DataReceived);
            // 
            // labelstate
            // 
            this.labelstate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelstate.AutoSize = true;
            this.labelstate.BackColor = System.Drawing.Color.Transparent;
            this.labelstate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelstate.Font = new System.Drawing.Font("Verdana", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelstate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelstate.Location = new System.Drawing.Point(526, 11);
            this.labelstate.Name = "labelstate";
            this.labelstate.Size = new System.Drawing.Size(0, 46);
            this.labelstate.TabIndex = 4;
            this.labelstate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nommachine
            // 
            this.nommachine.AutoSize = true;
            this.nommachine.BackColor = System.Drawing.Color.Transparent;
            this.nommachine.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nommachine.ForeColor = System.Drawing.Color.White;
            this.nommachine.Location = new System.Drawing.Point(68, 15);
            this.nommachine.Name = "nommachine";
            this.nommachine.Size = new System.Drawing.Size(266, 36);
            this.nommachine.TabIndex = 4;
            this.nommachine.Text = "Machine-1-TRS";
            // 
            // labeldatetime
            // 
            this.labeldatetime.AutoSize = true;
            this.labeldatetime.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldatetime.ForeColor = System.Drawing.Color.White;
            this.labeldatetime.Location = new System.Drawing.Point(319, 26);
            this.labeldatetime.Name = "labeldatetime";
            this.labeldatetime.Size = new System.Drawing.Size(61, 25);
            this.labeldatetime.TabIndex = 5;
            this.labeldatetime.Text = "Time";
            // 
            // label_
            // 
            this.label_.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_.AutoSize = true;
            this.label_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_.Location = new System.Drawing.Point(1449, 11);
            this.label_.Name = "label_";
            this.label_.Size = new System.Drawing.Size(16, 20);
            this.label_.TabIndex = 6;
            this.label_.Text = "-";
            this.label_.Click += new System.EventHandler(this.label__Click);
            // 
            // label_X
            // 
            this.label_X.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_X.AutoSize = true;
            this.label_X.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_X.Location = new System.Drawing.Point(1471, 9);
            this.label_X.Name = "label_X";
            this.label_X.Size = new System.Drawing.Size(21, 20);
            this.label_X.TabIndex = 6;
            this.label_X.Text = "X";
            this.label_X.Click += new System.EventHandler(this.label_X_Click);
            // 
            // Formmain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1500, 720);
            this.Controls.Add(this.label_X);
            this.Controls.Add(this.label_);
            this.Controls.Add(this.labeldatetime);
            this.Controls.Add(this.bouttonback);
            this.Controls.Add(this.labelstate);
            this.Controls.Add(this.nommachine);
            this.Controls.Add(this.metroPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Formmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Formmain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLink bouttonback;
        public System.IO.Ports.SerialPort serialPortDAQ;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelstate;
        private System.Windows.Forms.Label nommachine;
        private System.Windows.Forms.Label labeldatetime;
        private System.Windows.Forms.Label label_;
        private System.Windows.Forms.Label label_X;
        public System.Windows.Forms.Timer timertime;
    }
}

