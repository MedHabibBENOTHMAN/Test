namespace TRS_DIMANCHE
{
    partial class UCrebus
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCrebus));
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroLabelqte = new MetroFramework.Controls.MetroLabel();
            this.panel_selection_anomalie = new System.Windows.Forms.Panel();
            this.dataGridView_liste_rebut = new System.Windows.Forms.DataGridView();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox_produit_2 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_produit_1 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.idrebut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rebut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_selection_anomalie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_liste_rebut)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(392, 6);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(33, 35);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "+";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(312, 6);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(33, 34);
            this.metroButton2.TabIndex = 2;
            this.metroButton2.Text = "-";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroLabelqte
            // 
            this.metroLabelqte.AutoSize = true;
            this.metroLabelqte.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelqte.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelqte.Location = new System.Drawing.Point(244, 6);
            this.metroLabelqte.Name = "metroLabelqte";
            this.metroLabelqte.Size = new System.Drawing.Size(23, 25);
            this.metroLabelqte.TabIndex = 3;
            this.metroLabelqte.Text = "0";
            // 
            // panel_selection_anomalie
            // 
            this.panel_selection_anomalie.BackColor = System.Drawing.Color.Transparent;
            this.panel_selection_anomalie.Controls.Add(this.dataGridView_liste_rebut);
            this.panel_selection_anomalie.Controls.Add(this.metroTile1);
            this.panel_selection_anomalie.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_selection_anomalie.Location = new System.Drawing.Point(656, 0);
            this.panel_selection_anomalie.Name = "panel_selection_anomalie";
            this.panel_selection_anomalie.Size = new System.Drawing.Size(616, 514);
            this.panel_selection_anomalie.TabIndex = 5;
            this.panel_selection_anomalie.Visible = false;
            // 
            // dataGridView_liste_rebut
            // 
            this.dataGridView_liste_rebut.AllowUserToDeleteRows = false;
            this.dataGridView_liste_rebut.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_liste_rebut.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_liste_rebut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_liste_rebut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idrebut,
            this.rebut});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_liste_rebut.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_liste_rebut.Location = new System.Drawing.Point(14, 6);
            this.dataGridView_liste_rebut.Name = "dataGridView_liste_rebut";
            this.dataGridView_liste_rebut.ReadOnly = true;
            this.dataGridView_liste_rebut.RowTemplate.Height = 24;
            this.dataGridView_liste_rebut.Size = new System.Drawing.Size(580, 360);
            this.dataGridView_liste_rebut.TabIndex = 2;
            this.dataGridView_liste_rebut.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_liste_rebut_CellClick);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(14, 381);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(580, 67);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTile1.TabIndex = 7;
            this.metroTile1.Text = "Valider";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseStyleColors = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.checkBox_produit_2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.checkBox_produit_1);
            this.panel2.Controls.Add(this.metroButton1);
            this.panel2.Controls.Add(this.metroLabelqte);
            this.panel2.Controls.Add(this.metroButton2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(543, 514);
            this.panel2.TabIndex = 6;
            // 
            // checkBox_produit_2
            // 
            this.checkBox_produit_2.AutoSize = true;
            this.checkBox_produit_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_produit_2.Location = new System.Drawing.Point(285, 76);
            this.checkBox_produit_2.Name = "checkBox_produit_2";
            this.checkBox_produit_2.Size = new System.Drawing.Size(120, 28);
            this.checkBox_produit_2.TabIndex = 7;
            this.checkBox_produit_2.Text = "Produit_2";
            this.checkBox_produit_2.UseVisualStyleBackColor = true;
            this.checkBox_produit_2.CheckStateChanged += new System.EventHandler(this.checkBox_produit_2_CheckStateChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(409, 276);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quantité rebutée = ";
            // 
            // checkBox_produit_1
            // 
            this.checkBox_produit_1.AutoSize = true;
            this.checkBox_produit_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_produit_1.Location = new System.Drawing.Point(36, 76);
            this.checkBox_produit_1.Name = "checkBox_produit_1";
            this.checkBox_produit_1.Size = new System.Drawing.Size(120, 28);
            this.checkBox_produit_1.TabIndex = 7;
            this.checkBox_produit_1.Text = "Produit_1";
            this.checkBox_produit_1.UseVisualStyleBackColor = true;
            this.checkBox_produit_1.CheckStateChanged += new System.EventHandler(this.checkBox_produit_1_CheckStateChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel_selection_anomalie);
            this.panel1.Location = new System.Drawing.Point(125, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1272, 514);
            this.panel1.TabIndex = 8;
            // 
            // idrebut
            // 
            this.idrebut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idrebut.DataPropertyName = "idrebut";
            this.idrebut.HeaderText = "id";
            this.idrebut.Name = "idrebut";
            this.idrebut.ReadOnly = true;
            this.idrebut.Visible = false;
            // 
            // rebut
            // 
            this.rebut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rebut.DataPropertyName = "rebut";
            this.rebut.HeaderText = "Anomalie";
            this.rebut.Name = "rebut";
            this.rebut.ReadOnly = true;
            // 
            // UCrebus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UCrebus";
            this.Size = new System.Drawing.Size(1500, 640);
            this.Load += new System.EventHandler(this.UCrebus_Load);
            this.panel_selection_anomalie.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_liste_rebut)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLabel metroLabelqte;
        private System.Windows.Forms.Panel panel_selection_anomalie;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView_liste_rebut;
        private System.Windows.Forms.CheckBox checkBox_produit_1;
        private System.Windows.Forms.CheckBox checkBox_produit_2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrebut;
        private System.Windows.Forms.DataGridViewTextBoxColumn rebut;
    }
}
