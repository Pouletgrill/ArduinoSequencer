namespace ArduinoSequencer
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGV_CollectionViewer = new System.Windows.Forms.DataGridView();
            this.BTN_Create = new System.Windows.Forms.Button();
            this.BTN_Update = new System.Windows.Forms.Button();
            this.Pin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CollectionViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_CollectionViewer
            // 
            this.DGV_CollectionViewer.AllowUserToAddRows = false;
            this.DGV_CollectionViewer.AllowUserToDeleteRows = false;
            this.DGV_CollectionViewer.AllowUserToOrderColumns = true;
            this.DGV_CollectionViewer.AllowUserToResizeColumns = false;
            this.DGV_CollectionViewer.AllowUserToResizeRows = false;
            this.DGV_CollectionViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_CollectionViewer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pin,
            this.Column2,
            this.Column3});
            this.DGV_CollectionViewer.Location = new System.Drawing.Point(128, 105);
            this.DGV_CollectionViewer.MultiSelect = false;
            this.DGV_CollectionViewer.Name = "DGV_CollectionViewer";
            this.DGV_CollectionViewer.ReadOnly = true;
            this.DGV_CollectionViewer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_CollectionViewer.Size = new System.Drawing.Size(351, 380);
            this.DGV_CollectionViewer.TabIndex = 0;
            // 
            // BTN_Create
            // 
            this.BTN_Create.Location = new System.Drawing.Point(12, 105);
            this.BTN_Create.Name = "BTN_Create";
            this.BTN_Create.Size = new System.Drawing.Size(110, 23);
            this.BTN_Create.TabIndex = 1;
            this.BTN_Create.Text = "Add";
            this.BTN_Create.UseVisualStyleBackColor = true;
            this.BTN_Create.Click += new System.EventHandler(this.BTN_Create_Click);
            // 
            // BTN_Update
            // 
            this.BTN_Update.Location = new System.Drawing.Point(12, 134);
            this.BTN_Update.Name = "BTN_Update";
            this.BTN_Update.Size = new System.Drawing.Size(110, 23);
            this.BTN_Update.TabIndex = 2;
            this.BTN_Update.Text = "Modify";
            this.BTN_Update.UseVisualStyleBackColor = true;
            this.BTN_Update.Click += new System.EventHandler(this.BTN_Update_Click);
            // 
            // Pin
            // 
            this.Pin.HeaderText = "Pin";
            this.Pin.Name = "Pin";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Output";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Duration";
            this.Column3.Name = "Column3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 497);
            this.Controls.Add(this.BTN_Update);
            this.Controls.Add(this.BTN_Create);
            this.Controls.Add(this.DGV_CollectionViewer);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CollectionViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_CollectionViewer;
        private System.Windows.Forms.Button BTN_Create;
        private System.Windows.Forms.Button BTN_Update;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

