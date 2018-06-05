namespace TRS_DIMANCHE
{
    partial class UCidentifieerarret
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
            this.components = new System.ComponentModel.Container();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.dataGridViewnonidentifie = new System.Windows.Forms.DataGridView();
            this.Columnheure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_non_identifié = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naturearret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnduree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabelarret = new MetroFramework.Controls.MetroLabel();
            this.metroTilepause = new MetroFramework.Controls.MetroTile();
            this.metroLabelduree = new MetroFramework.Controls.MetroLabel();
            this.metroTilearret = new MetroFramework.Controls.MetroTile();
            this.metroPanelarret = new MetroFramework.Controls.MetroPanel();
            this.dataGridViewlistearret_prevu = new System.Windows.Forms.DataGridView();
            this.id_arret_prevu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arret_arret_prevu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewlistearret = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTile_SELECT = new MetroFramework.Controls.MetroTile();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroTile_refresh = new MetroFramework.Controls.MetroTile();
            this.timer1_refresh = new System.Windows.Forms.Timer(this.components);
            this.metroTile_arret = new MetroFramework.Controls.MetroTile();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewnonidentifie)).BeginInit();
            this.metroPanelarret.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewlistearret_prevu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewlistearret)).BeginInit();
            this.metroPanel2.SuspendLayout();
            this.metroTile_arret.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.dataGridViewnonidentifie);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 235);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(791, 388);
            this.metroPanel1.TabIndex = 18;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // dataGridViewnonidentifie
            // 
            this.dataGridViewnonidentifie.AllowUserToDeleteRows = false;
            this.dataGridViewnonidentifie.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewnonidentifie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewnonidentifie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Columnheure,
            this.fin,
            this.id_non_identifié,
            this.ColumnOF,
            this.naturearret,
            this.Columnduree});
            this.dataGridViewnonidentifie.Location = new System.Drawing.Point(15, 13);
            this.dataGridViewnonidentifie.Name = "dataGridViewnonidentifie";
            this.dataGridViewnonidentifie.ReadOnly = true;
            this.dataGridViewnonidentifie.RowTemplate.Height = 24;
            this.dataGridViewnonidentifie.Size = new System.Drawing.Size(751, 350);
            this.dataGridViewnonidentifie.TabIndex = 2;
            this.dataGridViewnonidentifie.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewnonidentifie_CellContentClick_1);
            // 
            // Columnheure
            // 
            this.Columnheure.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Columnheure.DataPropertyName = "debut";
            this.Columnheure.HeaderText = "Début";
            this.Columnheure.Name = "Columnheure";
            this.Columnheure.ReadOnly = true;
            // 
            // fin
            // 
            this.fin.DataPropertyName = "fin";
            this.fin.HeaderText = "Fin";
            this.fin.Name = "fin";
            this.fin.ReadOnly = true;
            this.fin.Width = 200;
            // 
            // id_non_identifié
            // 
            this.id_non_identifié.DataPropertyName = "id";
            this.id_non_identifié.HeaderText = "id";
            this.id_non_identifié.Name = "id_non_identifié";
            this.id_non_identifié.ReadOnly = true;
            this.id_non_identifié.Visible = false;
            // 
            // ColumnOF
            // 
            this.ColumnOF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnOF.DataPropertyName = "of";
            this.ColumnOF.HeaderText = "OF";
            this.ColumnOF.Name = "ColumnOF";
            this.ColumnOF.ReadOnly = true;
            this.ColumnOF.Visible = false;
            // 
            // naturearret
            // 
            this.naturearret.DataPropertyName = "arret";
            this.naturearret.HeaderText = "Arret";
            this.naturearret.Name = "naturearret";
            this.naturearret.ReadOnly = true;
            this.naturearret.Width = 200;
            // 
            // Columnduree
            // 
            this.Columnduree.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Columnduree.DataPropertyName = "duree";
            this.Columnduree.HeaderText = "Durée (en secondes)";
            this.Columnduree.Name = "Columnduree";
            this.Columnduree.ReadOnly = true;
            // 
            // metroLabelarret
            // 
            this.metroLabelarret.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabelarret.AutoSize = true;
            this.metroLabelarret.BackColor = System.Drawing.Color.Transparent;
            this.metroLabelarret.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelarret.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelarret.Location = new System.Drawing.Point(16, 9);
            this.metroLabelarret.Name = "metroLabelarret";
            this.metroLabelarret.Size = new System.Drawing.Size(192, 25);
            this.metroLabelarret.TabIndex = 11;
            this.metroLabelarret.Text = "Arret non identifié : ";
            this.metroLabelarret.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabelarret.UseCustomBackColor = true;
            this.metroLabelarret.Visible = false;
            // 
            // metroTilepause
            // 
            this.metroTilepause.ActiveControl = null;
            this.metroTilepause.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTilepause.BackColor = System.Drawing.Color.Transparent;
            this.metroTilepause.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroTilepause.Location = new System.Drawing.Point(800, 408);
            this.metroTilepause.Name = "metroTilepause";
            this.metroTilepause.Size = new System.Drawing.Size(261, 51);
            this.metroTilepause.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTilepause.TabIndex = 7;
            this.metroTilepause.Text = "Arret plannifié";
            this.metroTilepause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTilepause.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTilepause.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTilepause.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTilepause.UseSelectable = true;
            this.metroTilepause.UseStyleColors = true;
            this.metroTilepause.Click += new System.EventHandler(this.metroTilepause_Click);
            // 
            // metroLabelduree
            // 
            this.metroLabelduree.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabelduree.AutoSize = true;
            this.metroLabelduree.BackColor = System.Drawing.Color.Transparent;
            this.metroLabelduree.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelduree.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelduree.Location = new System.Drawing.Point(262, 9);
            this.metroLabelduree.Name = "metroLabelduree";
            this.metroLabelduree.Size = new System.Drawing.Size(88, 25);
            this.metroLabelduree.TabIndex = 11;
            this.metroLabelduree.Text = "00:00:00";
            this.metroLabelduree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabelduree.UseCustomBackColor = true;
            this.metroLabelduree.Visible = false;
            // 
            // metroTilearret
            // 
            this.metroTilearret.ActiveControl = null;
            this.metroTilearret.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTilearret.AutoSize = true;
            this.metroTilearret.BackColor = System.Drawing.Color.Transparent;
            this.metroTilearret.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroTilearret.Location = new System.Drawing.Point(800, 319);
            this.metroTilearret.Name = "metroTilearret";
            this.metroTilearret.Size = new System.Drawing.Size(261, 51);
            this.metroTilearret.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTilearret.TabIndex = 12;
            this.metroTilearret.Text = "Arret non plannifié";
            this.metroTilearret.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTilearret.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTilearret.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTilearret.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTilearret.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTilearret.UseSelectable = true;
            this.metroTilearret.UseStyleColors = true;
            this.metroTilearret.Click += new System.EventHandler(this.metroTilearret_Click);
            // 
            // metroPanelarret
            // 
            this.metroPanelarret.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroPanelarret.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanelarret.Controls.Add(this.dataGridViewlistearret_prevu);
            this.metroPanelarret.Controls.Add(this.dataGridViewlistearret);
            this.metroPanelarret.HorizontalScrollbarBarColor = true;
            this.metroPanelarret.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelarret.HorizontalScrollbarSize = 10;
            this.metroPanelarret.Location = new System.Drawing.Point(1067, 235);
            this.metroPanelarret.Name = "metroPanelarret";
            this.metroPanelarret.Size = new System.Drawing.Size(430, 388);
            this.metroPanelarret.TabIndex = 16;
            this.metroPanelarret.VerticalScrollbarBarColor = true;
            this.metroPanelarret.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelarret.VerticalScrollbarSize = 10;
            // 
            // dataGridViewlistearret_prevu
            // 
            this.dataGridViewlistearret_prevu.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewlistearret_prevu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewlistearret_prevu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_arret_prevu,
            this.arret_arret_prevu});
            this.dataGridViewlistearret_prevu.Location = new System.Drawing.Point(14, 23);
            this.dataGridViewlistearret_prevu.Name = "dataGridViewlistearret_prevu";
            this.dataGridViewlistearret_prevu.RowTemplate.Height = 24;
            this.dataGridViewlistearret_prevu.Size = new System.Drawing.Size(420, 352);
            this.dataGridViewlistearret_prevu.TabIndex = 0;
            this.dataGridViewlistearret_prevu.Visible = false;
            this.dataGridViewlistearret_prevu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewlistearret_prevu_CellClick);
            // 
            // id_arret_prevu
            // 
            this.id_arret_prevu.DataPropertyName = "id";
            this.id_arret_prevu.HeaderText = "id";
            this.id_arret_prevu.Name = "id_arret_prevu";
            this.id_arret_prevu.Visible = false;
            // 
            // arret_arret_prevu
            // 
            this.arret_arret_prevu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.arret_arret_prevu.DataPropertyName = "arret";
            this.arret_arret_prevu.HeaderText = "arret_prevu";
            this.arret_arret_prevu.Name = "arret_arret_prevu";
            // 
            // dataGridViewlistearret
            // 
            this.dataGridViewlistearret.AllowUserToDeleteRows = false;
            this.dataGridViewlistearret.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewlistearret.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewlistearret.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.arret});
            this.dataGridViewlistearret.Location = new System.Drawing.Point(14, 23);
            this.dataGridViewlistearret.Name = "dataGridViewlistearret";
            this.dataGridViewlistearret.ReadOnly = true;
            this.dataGridViewlistearret.RowTemplate.Height = 24;
            this.dataGridViewlistearret.Size = new System.Drawing.Size(420, 352);
            this.dataGridViewlistearret.TabIndex = 15;
            this.dataGridViewlistearret.Visible = false;
            this.dataGridViewlistearret.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewlistearret_CellClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // arret
            // 
            this.arret.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.arret.DataPropertyName = "arret";
            this.arret.HeaderText = "arret";
            this.arret.Name = "arret";
            this.arret.ReadOnly = true;
            // 
            // metroTile_SELECT
            // 
            this.metroTile_SELECT.ActiveControl = null;
            this.metroTile_SELECT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTile_SELECT.BackColor = System.Drawing.Color.Transparent;
            this.metroTile_SELECT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroTile_SELECT.Location = new System.Drawing.Point(800, 560);
            this.metroTile_SELECT.Name = "metroTile_SELECT";
            this.metroTile_SELECT.Size = new System.Drawing.Size(261, 51);
            this.metroTile_SELECT.TabIndex = 16;
            this.metroTile_SELECT.Text = "SELECT";
            this.metroTile_SELECT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile_SELECT.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile_SELECT.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile_SELECT.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile_SELECT.UseSelectable = true;
            this.metroTile_SELECT.UseStyleColors = true;
            this.metroTile_SELECT.UseTileImage = true;
            this.metroTile_SELECT.Visible = false;
            this.metroTile_SELECT.Click += new System.EventHandler(this.metroTile_SELECT_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.metroTile_arret);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 0);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(1500, 83);
            this.metroPanel2.TabIndex = 17;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroTile_refresh
            // 
            this.metroTile_refresh.ActiveControl = null;
            this.metroTile_refresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTile_refresh.Location = new System.Drawing.Point(19, 102);
            this.metroTile_refresh.Name = "metroTile_refresh";
            this.metroTile_refresh.Size = new System.Drawing.Size(237, 51);
            this.metroTile_refresh.TabIndex = 0;
            this.metroTile_refresh.Text = "Refresh";
            this.metroTile_refresh.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile_refresh.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile_refresh.UseSelectable = true;
            this.metroTile_refresh.Click += new System.EventHandler(this.metroTile_refresh_Click);
            // 
            // timer1_refresh
            // 
            this.timer1_refresh.Enabled = true;
            this.timer1_refresh.Interval = 1000;
            this.timer1_refresh.Tick += new System.EventHandler(this.timer1_refresh_Tick);
            // 
            // metroTile_arret
            // 
            this.metroTile_arret.ActiveControl = null;
            this.metroTile_arret.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTile_arret.Controls.Add(this.metroLabelduree);
            this.metroTile_arret.Controls.Add(this.metroLabelarret);
            this.metroTile_arret.Location = new System.Drawing.Point(19, 21);
            this.metroTile_arret.Name = "metroTile_arret";
            this.metroTile_arret.Size = new System.Drawing.Size(791, 44);
            this.metroTile_arret.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTile_arret.TabIndex = 12;
            this.metroTile_arret.UseSelectable = true;
            this.metroTile_arret.UseStyleColors = true;
            this.metroTile_arret.Visible = false;
            // 
            // UCidentifieerarret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTilearret);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroTile_SELECT);
            this.Controls.Add(this.metroTilepause);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanelarret);
            this.Controls.Add(this.metroTile_refresh);
            this.Name = "UCidentifieerarret";
            this.Size = new System.Drawing.Size(1500, 640);
            this.Load += new System.EventHandler(this.UCidentifieerarret_Load);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewnonidentifie)).EndInit();
            this.metroPanelarret.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewlistearret_prevu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewlistearret)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.metroTile_arret.ResumeLayout(false);
            this.metroTile_arret.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabelarret;
        private MetroFramework.Controls.MetroTile metroTilepause;
        private MetroFramework.Controls.MetroLabel metroLabelduree;
        private MetroFramework.Controls.MetroTile metroTilearret;
        private MetroFramework.Controls.MetroPanel metroPanelarret;
        private System.Windows.Forms.DataGridView dataGridViewlistearret;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn arret;
        private MetroFramework.Controls.MetroTile metroTile_SELECT;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTile metroTile_refresh;
        public System.Windows.Forms.Timer timer1_refresh;
        private MetroFramework.Controls.MetroTile metroTile_arret;
        private System.Windows.Forms.DataGridView dataGridViewlistearret_prevu;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_arret_prevu;
        private System.Windows.Forms.DataGridViewTextBoxColumn arret_arret_prevu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnheure;
        private System.Windows.Forms.DataGridViewTextBoxColumn fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_non_identifié;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOF;
        private System.Windows.Forms.DataGridViewTextBoxColumn naturearret;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnduree;
        public System.Windows.Forms.DataGridView dataGridViewnonidentifie;
    }
}
