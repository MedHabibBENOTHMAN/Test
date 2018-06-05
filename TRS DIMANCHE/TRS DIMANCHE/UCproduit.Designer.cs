namespace TRS_DIMANCHE
{
    partial class UCproduit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCproduit));
            this.panel_produit = new System.Windows.Forms.Panel();
            this.dataGridView_produit = new System.Windows.Forms.DataGridView();
            this.datagrid_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datagrid_produit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empreinte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datagrid_durée = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroButton_ajouter = new MetroFramework.Controls.MetroButton();
            this.panel_addnew = new System.Windows.Forms.Panel();
            this.metroTextBox_tempsdecycle = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox_reference = new MetroFramework.Controls.MetroTextBox();
            this.metroButton_cancel = new MetroFramework.Controls.MetroButton();
            this.metroTextBox_produit = new MetroFramework.Controls.MetroTextBox();
            this.metroButton_save = new MetroFramework.Controls.MetroButton();
            this.label2 = new System.Windows.Forms.Label();
            this.metroButton_delete = new MetroFramework.Controls.MetroButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroTextBoxOF = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.metroTextBox_produit1 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox_produit2 = new MetroFramework.Controls.MetroTextBox();
            this.checkBox_matiere_1 = new System.Windows.Forms.CheckBox();
            this.checkBox_matiere_2 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.metroTextBoxOF_2 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox_lot = new MetroFramework.Controls.MetroTextBox();
            this.metroButton_set = new MetroFramework.Controls.MetroButton();
            this.metroTextBox_palette = new MetroFramework.Controls.MetroTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel_produit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_produit)).BeginInit();
            this.panel_addnew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_produit
            // 
            this.panel_produit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_produit.BackColor = System.Drawing.Color.Transparent;
            this.panel_produit.Controls.Add(this.dataGridView_produit);
            this.panel_produit.Controls.Add(this.metroButton_ajouter);
            this.panel_produit.Location = new System.Drawing.Point(863, 45);
            this.panel_produit.Name = "panel_produit";
            this.panel_produit.Size = new System.Drawing.Size(634, 300);
            this.panel_produit.TabIndex = 0;
            this.panel_produit.Visible = false;
            // 
            // dataGridView_produit
            // 
            this.dataGridView_produit.AllowUserToDeleteRows = false;
            this.dataGridView_produit.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_produit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_produit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_produit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datagrid_id,
            this.reference,
            this.datagrid_produit,
            this.description,
            this.empreinte,
            this.datagrid_durée});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_produit.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_produit.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView_produit.Location = new System.Drawing.Point(15, 17);
            this.dataGridView_produit.Name = "dataGridView_produit";
            this.dataGridView_produit.ReadOnly = true;
            this.dataGridView_produit.RowTemplate.Height = 24;
            this.dataGridView_produit.Size = new System.Drawing.Size(616, 213);
            this.dataGridView_produit.TabIndex = 0;
            this.dataGridView_produit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_produit_CellClick);
            // 
            // datagrid_id
            // 
            this.datagrid_id.DataPropertyName = "idmoule";
            this.datagrid_id.HeaderText = "ID";
            this.datagrid_id.Name = "datagrid_id";
            this.datagrid_id.ReadOnly = true;
            this.datagrid_id.Visible = false;
            // 
            // reference
            // 
            this.reference.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.reference.DataPropertyName = "reference";
            this.reference.HeaderText = "Reference moule";
            this.reference.Name = "reference";
            this.reference.ReadOnly = true;
            this.reference.Width = 133;
            // 
            // datagrid_produit
            // 
            this.datagrid_produit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.datagrid_produit.DataPropertyName = "produit";
            this.datagrid_produit.FillWeight = 150F;
            this.datagrid_produit.HeaderText = "Produit";
            this.datagrid_produit.Name = "datagrid_produit";
            this.datagrid_produit.ReadOnly = true;
            this.datagrid_produit.Width = 82;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Width = 75;
            // 
            // empreinte
            // 
            this.empreinte.DataPropertyName = "empreinte";
            this.empreinte.HeaderText = "Empreinte";
            this.empreinte.Name = "empreinte";
            this.empreinte.ReadOnly = true;
            this.empreinte.Width = 50;
            // 
            // datagrid_durée
            // 
            this.datagrid_durée.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.datagrid_durée.DataPropertyName = "temps_de_cycle";
            this.datagrid_durée.HeaderText = "Temps de cycle";
            this.datagrid_durée.Name = "datagrid_durée";
            this.datagrid_durée.ReadOnly = true;
            this.datagrid_durée.Width = 96;
            // 
            // metroButton_ajouter
            // 
            this.metroButton_ajouter.BackColor = System.Drawing.Color.Teal;
            this.metroButton_ajouter.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton_ajouter.ForeColor = System.Drawing.Color.White;
            this.metroButton_ajouter.Location = new System.Drawing.Point(15, 249);
            this.metroButton_ajouter.Name = "metroButton_ajouter";
            this.metroButton_ajouter.Size = new System.Drawing.Size(370, 48);
            this.metroButton_ajouter.TabIndex = 5;
            this.metroButton_ajouter.Text = "Ajouter, modifier ou supprimer un produit";
            this.metroButton_ajouter.UseCustomBackColor = true;
            this.metroButton_ajouter.UseCustomForeColor = true;
            this.metroButton_ajouter.UseSelectable = true;
            this.metroButton_ajouter.UseStyleColors = true;
            this.metroButton_ajouter.Click += new System.EventHandler(this.metroButton_ajouter_Click);
            // 
            // panel_addnew
            // 
            this.panel_addnew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_addnew.Controls.Add(this.metroTextBox_tempsdecycle);
            this.panel_addnew.Controls.Add(this.metroTextBox_reference);
            this.panel_addnew.Controls.Add(this.metroButton_cancel);
            this.panel_addnew.Controls.Add(this.metroTextBox_produit);
            this.panel_addnew.Controls.Add(this.metroButton_save);
            this.panel_addnew.Controls.Add(this.label2);
            this.panel_addnew.Controls.Add(this.metroButton_delete);
            this.panel_addnew.Controls.Add(this.label5);
            this.panel_addnew.Controls.Add(this.label1);
            this.panel_addnew.Location = new System.Drawing.Point(863, 409);
            this.panel_addnew.Name = "panel_addnew";
            this.panel_addnew.Size = new System.Drawing.Size(634, 220);
            this.panel_addnew.TabIndex = 1;
            this.panel_addnew.Visible = false;
            // 
            // metroTextBox_tempsdecycle
            // 
            // 
            // 
            // 
            this.metroTextBox_tempsdecycle.CustomButton.Image = null;
            this.metroTextBox_tempsdecycle.CustomButton.Location = new System.Drawing.Point(250, 1);
            this.metroTextBox_tempsdecycle.CustomButton.Name = "";
            this.metroTextBox_tempsdecycle.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox_tempsdecycle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_tempsdecycle.CustomButton.TabIndex = 1;
            this.metroTextBox_tempsdecycle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_tempsdecycle.CustomButton.UseSelectable = true;
            this.metroTextBox_tempsdecycle.CustomButton.Visible = false;
            this.metroTextBox_tempsdecycle.Lines = new string[0];
            this.metroTextBox_tempsdecycle.Location = new System.Drawing.Point(166, 95);
            this.metroTextBox_tempsdecycle.MaxLength = 32767;
            this.metroTextBox_tempsdecycle.Name = "metroTextBox_tempsdecycle";
            this.metroTextBox_tempsdecycle.PasswordChar = '\0';
            this.metroTextBox_tempsdecycle.PromptText = "veuillez saisir le temps de cycle du produit";
            this.metroTextBox_tempsdecycle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_tempsdecycle.SelectedText = "";
            this.metroTextBox_tempsdecycle.SelectionLength = 0;
            this.metroTextBox_tempsdecycle.SelectionStart = 0;
            this.metroTextBox_tempsdecycle.ShortcutsEnabled = true;
            this.metroTextBox_tempsdecycle.Size = new System.Drawing.Size(272, 23);
            this.metroTextBox_tempsdecycle.TabIndex = 4;
            this.metroTextBox_tempsdecycle.UseSelectable = true;
            this.metroTextBox_tempsdecycle.WaterMark = "veuillez saisir le temps de cycle du produit";
            this.metroTextBox_tempsdecycle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_tempsdecycle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox_reference
            // 
            // 
            // 
            // 
            this.metroTextBox_reference.CustomButton.Image = null;
            this.metroTextBox_reference.CustomButton.Location = new System.Drawing.Point(250, 1);
            this.metroTextBox_reference.CustomButton.Name = "";
            this.metroTextBox_reference.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox_reference.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_reference.CustomButton.TabIndex = 1;
            this.metroTextBox_reference.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_reference.CustomButton.UseSelectable = true;
            this.metroTextBox_reference.CustomButton.Visible = false;
            this.metroTextBox_reference.Lines = new string[0];
            this.metroTextBox_reference.Location = new System.Drawing.Point(166, 52);
            this.metroTextBox_reference.MaxLength = 32767;
            this.metroTextBox_reference.Name = "metroTextBox_reference";
            this.metroTextBox_reference.PasswordChar = '\0';
            this.metroTextBox_reference.PromptText = "veuillez saisir la référence du produit";
            this.metroTextBox_reference.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_reference.SelectedText = "";
            this.metroTextBox_reference.SelectionLength = 0;
            this.metroTextBox_reference.SelectionStart = 0;
            this.metroTextBox_reference.ShortcutsEnabled = true;
            this.metroTextBox_reference.Size = new System.Drawing.Size(272, 23);
            this.metroTextBox_reference.TabIndex = 4;
            this.metroTextBox_reference.UseSelectable = true;
            this.metroTextBox_reference.WaterMark = "veuillez saisir la référence du produit";
            this.metroTextBox_reference.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_reference.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton_cancel
            // 
            this.metroButton_cancel.BackColor = System.Drawing.Color.Teal;
            this.metroButton_cancel.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton_cancel.ForeColor = System.Drawing.Color.White;
            this.metroButton_cancel.Location = new System.Drawing.Point(306, 157);
            this.metroButton_cancel.Name = "metroButton_cancel";
            this.metroButton_cancel.Size = new System.Drawing.Size(123, 51);
            this.metroButton_cancel.TabIndex = 4;
            this.metroButton_cancel.Text = "Cancel";
            this.metroButton_cancel.UseCustomBackColor = true;
            this.metroButton_cancel.UseCustomForeColor = true;
            this.metroButton_cancel.UseSelectable = true;
            this.metroButton_cancel.UseStyleColors = true;
            this.metroButton_cancel.Click += new System.EventHandler(this.metroButton_cancel_Click);
            // 
            // metroTextBox_produit
            // 
            // 
            // 
            // 
            this.metroTextBox_produit.CustomButton.Image = null;
            this.metroTextBox_produit.CustomButton.Location = new System.Drawing.Point(250, 1);
            this.metroTextBox_produit.CustomButton.Name = "";
            this.metroTextBox_produit.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox_produit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_produit.CustomButton.TabIndex = 1;
            this.metroTextBox_produit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_produit.CustomButton.UseSelectable = true;
            this.metroTextBox_produit.CustomButton.Visible = false;
            this.metroTextBox_produit.Lines = new string[0];
            this.metroTextBox_produit.Location = new System.Drawing.Point(166, 11);
            this.metroTextBox_produit.MaxLength = 32767;
            this.metroTextBox_produit.Name = "metroTextBox_produit";
            this.metroTextBox_produit.PasswordChar = '\0';
            this.metroTextBox_produit.PromptText = "veuillez saisir le nom du produit";
            this.metroTextBox_produit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_produit.SelectedText = "";
            this.metroTextBox_produit.SelectionLength = 0;
            this.metroTextBox_produit.SelectionStart = 0;
            this.metroTextBox_produit.ShortcutsEnabled = true;
            this.metroTextBox_produit.Size = new System.Drawing.Size(272, 23);
            this.metroTextBox_produit.TabIndex = 4;
            this.metroTextBox_produit.UseSelectable = true;
            this.metroTextBox_produit.WaterMark = "veuillez saisir le nom du produit";
            this.metroTextBox_produit.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_produit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton_save
            // 
            this.metroButton_save.BackColor = System.Drawing.Color.Teal;
            this.metroButton_save.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton_save.ForeColor = System.Drawing.Color.White;
            this.metroButton_save.Location = new System.Drawing.Point(166, 157);
            this.metroButton_save.Name = "metroButton_save";
            this.metroButton_save.Size = new System.Drawing.Size(125, 51);
            this.metroButton_save.TabIndex = 3;
            this.metroButton_save.Text = "Save";
            this.metroButton_save.UseCustomBackColor = true;
            this.metroButton_save.UseCustomForeColor = true;
            this.metroButton_save.UseSelectable = true;
            this.metroButton_save.UseStyleColors = true;
            this.metroButton_save.Click += new System.EventHandler(this.metroButton_save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Temps de cycle";
            // 
            // metroButton_delete
            // 
            this.metroButton_delete.BackColor = System.Drawing.Color.Teal;
            this.metroButton_delete.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton_delete.ForeColor = System.Drawing.Color.White;
            this.metroButton_delete.Location = new System.Drawing.Point(28, 157);
            this.metroButton_delete.Name = "metroButton_delete";
            this.metroButton_delete.Size = new System.Drawing.Size(123, 51);
            this.metroButton_delete.TabIndex = 2;
            this.metroButton_delete.Text = "Delete";
            this.metroButton_delete.UseCustomBackColor = true;
            this.metroButton_delete.UseCustomForeColor = true;
            this.metroButton_delete.UseSelectable = true;
            this.metroButton_delete.UseStyleColors = true;
            this.metroButton_delete.Click += new System.EventHandler(this.metroButton_delete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Reference";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom du produit";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(347, 225);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // metroTextBoxOF
            // 
            // 
            // 
            // 
            this.metroTextBoxOF.CustomButton.Image = null;
            this.metroTextBoxOF.CustomButton.Location = new System.Drawing.Point(237, 1);
            this.metroTextBoxOF.CustomButton.Name = "";
            this.metroTextBoxOF.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxOF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxOF.CustomButton.TabIndex = 1;
            this.metroTextBoxOF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxOF.CustomButton.UseSelectable = true;
            this.metroTextBoxOF.CustomButton.Visible = false;
            this.metroTextBoxOF.Lines = new string[0];
            this.metroTextBoxOF.Location = new System.Drawing.Point(16, 61);
            this.metroTextBoxOF.MaxLength = 32767;
            this.metroTextBoxOF.Name = "metroTextBoxOF";
            this.metroTextBoxOF.PasswordChar = '\0';
            this.metroTextBoxOF.PromptText = "veuillez saisir l\'ordre de fabrication";
            this.metroTextBoxOF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxOF.SelectedText = "";
            this.metroTextBoxOF.SelectionLength = 0;
            this.metroTextBoxOF.SelectionStart = 0;
            this.metroTextBoxOF.ShortcutsEnabled = true;
            this.metroTextBoxOF.Size = new System.Drawing.Size(259, 23);
            this.metroTextBoxOF.TabIndex = 0;
            this.metroTextBoxOF.UseSelectable = true;
            this.metroTextBoxOF.WaterMark = "veuillez saisir l\'ordre de fabrication";
            this.metroTextBoxOF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxOF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ordre de fabrication :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(300, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Produit :";
            // 
            // metroTextBox_produit1
            // 
            // 
            // 
            // 
            this.metroTextBox_produit1.CustomButton.Image = null;
            this.metroTextBox_produit1.CustomButton.Location = new System.Drawing.Point(237, 1);
            this.metroTextBox_produit1.CustomButton.Name = "";
            this.metroTextBox_produit1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox_produit1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_produit1.CustomButton.TabIndex = 1;
            this.metroTextBox_produit1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_produit1.CustomButton.UseSelectable = true;
            this.metroTextBox_produit1.CustomButton.Visible = false;
            this.metroTextBox_produit1.Lines = new string[0];
            this.metroTextBox_produit1.Location = new System.Drawing.Point(300, 61);
            this.metroTextBox_produit1.MaxLength = 32767;
            this.metroTextBox_produit1.Name = "metroTextBox_produit1";
            this.metroTextBox_produit1.PasswordChar = '\0';
            this.metroTextBox_produit1.PromptText = "veuillez saisir la reference du produit";
            this.metroTextBox_produit1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_produit1.SelectedText = "";
            this.metroTextBox_produit1.SelectionLength = 0;
            this.metroTextBox_produit1.SelectionStart = 0;
            this.metroTextBox_produit1.ShortcutsEnabled = true;
            this.metroTextBox_produit1.Size = new System.Drawing.Size(259, 23);
            this.metroTextBox_produit1.TabIndex = 1;
            this.metroTextBox_produit1.UseSelectable = true;
            this.metroTextBox_produit1.WaterMark = "veuillez saisir la reference du produit";
            this.metroTextBox_produit1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_produit1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox_produit2
            // 
            // 
            // 
            // 
            this.metroTextBox_produit2.CustomButton.Image = null;
            this.metroTextBox_produit2.CustomButton.Location = new System.Drawing.Point(237, 1);
            this.metroTextBox_produit2.CustomButton.Name = "";
            this.metroTextBox_produit2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox_produit2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_produit2.CustomButton.TabIndex = 1;
            this.metroTextBox_produit2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_produit2.CustomButton.UseSelectable = true;
            this.metroTextBox_produit2.CustomButton.Visible = false;
            this.metroTextBox_produit2.Enabled = false;
            this.metroTextBox_produit2.Lines = new string[0];
            this.metroTextBox_produit2.Location = new System.Drawing.Point(297, 158);
            this.metroTextBox_produit2.MaxLength = 32767;
            this.metroTextBox_produit2.Name = "metroTextBox_produit2";
            this.metroTextBox_produit2.PasswordChar = '\0';
            this.metroTextBox_produit2.PromptText = "veuillez saisir la reference du produit 2";
            this.metroTextBox_produit2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_produit2.SelectedText = "";
            this.metroTextBox_produit2.SelectionLength = 0;
            this.metroTextBox_produit2.SelectionStart = 0;
            this.metroTextBox_produit2.ShortcutsEnabled = true;
            this.metroTextBox_produit2.Size = new System.Drawing.Size(259, 23);
            this.metroTextBox_produit2.TabIndex = 3;
            this.metroTextBox_produit2.UseSelectable = true;
            this.metroTextBox_produit2.WaterMark = "veuillez saisir la reference du produit 2";
            this.metroTextBox_produit2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_produit2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // checkBox_matiere_1
            // 
            this.checkBox_matiere_1.AutoSize = true;
            this.checkBox_matiere_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_matiere_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_matiere_1.Location = new System.Drawing.Point(17, 239);
            this.checkBox_matiere_1.Name = "checkBox_matiere_1";
            this.checkBox_matiere_1.Size = new System.Drawing.Size(114, 28);
            this.checkBox_matiere_1.TabIndex = 10;
            this.checkBox_matiere_1.Text = "Matière 1";
            this.checkBox_matiere_1.UseVisualStyleBackColor = true;
            this.checkBox_matiere_1.CheckStateChanged += new System.EventHandler(this.checkBox_matiere_1_CheckStateChanged);
            // 
            // checkBox_matiere_2
            // 
            this.checkBox_matiere_2.AutoSize = true;
            this.checkBox_matiere_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_matiere_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_matiere_2.Location = new System.Drawing.Point(161, 239);
            this.checkBox_matiere_2.Name = "checkBox_matiere_2";
            this.checkBox_matiere_2.Size = new System.Drawing.Size(114, 28);
            this.checkBox_matiere_2.TabIndex = 10;
            this.checkBox_matiere_2.Text = "Matière 2";
            this.checkBox_matiere_2.UseVisualStyleBackColor = true;
            this.checkBox_matiere_2.CheckStateChanged += new System.EventHandler(this.checkBox_matiere_2_CheckStateChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.metroTextBoxOF_2);
            this.panel1.Controls.Add(this.metroTextBox_lot);
            this.panel1.Controls.Add(this.metroButton_set);
            this.panel1.Controls.Add(this.metroTextBox_palette);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.checkBox_matiere_1);
            this.panel1.Controls.Add(this.metroTextBoxOF);
            this.panel1.Controls.Add(this.checkBox_matiere_2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.metroTextBox_produit2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.metroTextBox_produit1);
            this.panel1.Location = new System.Drawing.Point(3, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 584);
            this.panel1.TabIndex = 12;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.checkBox1.Location = new System.Drawing.Point(612, 56);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(180, 28);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Ajouter poduit 2";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            // 
            // metroTextBoxOF_2
            // 
            // 
            // 
            // 
            this.metroTextBoxOF_2.CustomButton.Image = null;
            this.metroTextBoxOF_2.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.metroTextBoxOF_2.CustomButton.Name = "";
            this.metroTextBoxOF_2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxOF_2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxOF_2.CustomButton.TabIndex = 1;
            this.metroTextBoxOF_2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxOF_2.CustomButton.UseSelectable = true;
            this.metroTextBoxOF_2.CustomButton.Visible = false;
            this.metroTextBoxOF_2.Lines = new string[0];
            this.metroTextBoxOF_2.Location = new System.Drawing.Point(14, 158);
            this.metroTextBoxOF_2.MaxLength = 32767;
            this.metroTextBoxOF_2.Name = "metroTextBoxOF_2";
            this.metroTextBoxOF_2.PasswordChar = '\0';
            this.metroTextBoxOF_2.PromptText = "veuillez saisir l\'ordre de fabrication 2";
            this.metroTextBoxOF_2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxOF_2.SelectedText = "";
            this.metroTextBoxOF_2.SelectionLength = 0;
            this.metroTextBoxOF_2.SelectionStart = 0;
            this.metroTextBoxOF_2.ShortcutsEnabled = true;
            this.metroTextBoxOF_2.Size = new System.Drawing.Size(258, 23);
            this.metroTextBoxOF_2.TabIndex = 2;
            this.metroTextBoxOF_2.UseSelectable = true;
            this.metroTextBoxOF_2.WaterMark = "veuillez saisir l\'ordre de fabrication 2";
            this.metroTextBoxOF_2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxOF_2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox_lot
            // 
            // 
            // 
            // 
            this.metroTextBox_lot.CustomButton.Image = null;
            this.metroTextBox_lot.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.metroTextBox_lot.CustomButton.Name = "";
            this.metroTextBox_lot.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox_lot.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_lot.CustomButton.TabIndex = 1;
            this.metroTextBox_lot.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_lot.CustomButton.UseSelectable = true;
            this.metroTextBox_lot.CustomButton.Visible = false;
            this.metroTextBox_lot.Lines = new string[0];
            this.metroTextBox_lot.Location = new System.Drawing.Point(17, 316);
            this.metroTextBox_lot.MaxLength = 32767;
            this.metroTextBox_lot.Name = "metroTextBox_lot";
            this.metroTextBox_lot.PasswordChar = '\0';
            this.metroTextBox_lot.PromptText = "veuillez saisir la reference du lot";
            this.metroTextBox_lot.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_lot.SelectedText = "";
            this.metroTextBox_lot.SelectionLength = 0;
            this.metroTextBox_lot.SelectionStart = 0;
            this.metroTextBox_lot.ShortcutsEnabled = true;
            this.metroTextBox_lot.Size = new System.Drawing.Size(258, 23);
            this.metroTextBox_lot.TabIndex = 14;
            this.metroTextBox_lot.UseSelectable = true;
            this.metroTextBox_lot.WaterMark = "veuillez saisir la reference du lot";
            this.metroTextBox_lot.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_lot.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton_set
            // 
            this.metroButton_set.BackColor = System.Drawing.Color.Teal;
            this.metroButton_set.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton_set.ForeColor = System.Drawing.Color.White;
            this.metroButton_set.Location = new System.Drawing.Point(265, 521);
            this.metroButton_set.Name = "metroButton_set";
            this.metroButton_set.Size = new System.Drawing.Size(365, 51);
            this.metroButton_set.TabIndex = 13;
            this.metroButton_set.Text = "Valider";
            this.metroButton_set.UseCustomBackColor = true;
            this.metroButton_set.UseCustomForeColor = true;
            this.metroButton_set.UseSelectable = true;
            this.metroButton_set.UseStyleColors = true;
            this.metroButton_set.Click += new System.EventHandler(this.metroButton_set_Click);
            // 
            // metroTextBox_palette
            // 
            // 
            // 
            // 
            this.metroTextBox_palette.CustomButton.Image = null;
            this.metroTextBox_palette.CustomButton.Location = new System.Drawing.Point(237, 1);
            this.metroTextBox_palette.CustomButton.Name = "";
            this.metroTextBox_palette.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox_palette.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_palette.CustomButton.TabIndex = 1;
            this.metroTextBox_palette.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_palette.CustomButton.UseSelectable = true;
            this.metroTextBox_palette.CustomButton.Visible = false;
            this.metroTextBox_palette.Lines = new string[0];
            this.metroTextBox_palette.Location = new System.Drawing.Point(16, 396);
            this.metroTextBox_palette.MaxLength = 32767;
            this.metroTextBox_palette.Name = "metroTextBox_palette";
            this.metroTextBox_palette.PasswordChar = '\0';
            this.metroTextBox_palette.PromptText = "veuillez saiasir la palette";
            this.metroTextBox_palette.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_palette.SelectedText = "";
            this.metroTextBox_palette.SelectionLength = 0;
            this.metroTextBox_palette.SelectionStart = 0;
            this.metroTextBox_palette.ShortcutsEnabled = true;
            this.metroTextBox_palette.Size = new System.Drawing.Size(259, 23);
            this.metroTextBox_palette.TabIndex = 12;
            this.metroTextBox_palette.UseSelectable = true;
            this.metroTextBox_palette.WaterMark = "veuillez saiasir la palette";
            this.metroTextBox_palette.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_palette.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(231, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Ordre de fabrication 2 :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(297, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Produit 2 :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Lot :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Plalette :";
            // 
            // UCproduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_addnew);
            this.Controls.Add(this.panel_produit);
            this.Name = "UCproduit";
            this.Size = new System.Drawing.Size(1500, 652);
            this.panel_produit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_produit)).EndInit();
            this.panel_addnew.ResumeLayout(false);
            this.panel_addnew.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_produit;
        private System.Windows.Forms.DataGridView dataGridView_produit;
        private System.Windows.Forms.Panel panel_addnew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroTextBox metroTextBox_tempsdecycle;
        private MetroFramework.Controls.MetroTextBox metroTextBox_reference;
        private MetroFramework.Controls.MetroTextBox metroTextBox_produit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxOF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox metroTextBox_produit1;
        private MetroFramework.Controls.MetroTextBox metroTextBox_produit2;
        private System.Windows.Forms.CheckBox checkBox_matiere_1;
        private System.Windows.Forms.CheckBox checkBox_matiere_2;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTextBox metroTextBox_palette;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn datagrid_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn datagrid_produit;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn empreinte;
        private System.Windows.Forms.DataGridViewTextBoxColumn datagrid_durée;
        private MetroFramework.Controls.MetroTextBox metroTextBox_lot;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Controls.MetroTextBox metroTextBoxOF_2;
        private System.Windows.Forms.Label label10;
        public MetroFramework.Controls.MetroButton metroButton_delete;
        public MetroFramework.Controls.MetroButton metroButton_save;
        public MetroFramework.Controls.MetroButton metroButton_cancel;
        public MetroFramework.Controls.MetroButton metroButton_ajouter;
        public MetroFramework.Controls.MetroButton metroButton_set;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
