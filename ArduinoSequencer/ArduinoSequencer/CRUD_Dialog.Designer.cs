namespace ArduinoSequencer
{
    partial class CRUD_Dialog
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
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.BTN_Ok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_Pin = new System.Windows.Forms.ComboBox();
            this.CB_Output = new System.Windows.Forms.ComboBox();
            this.NUD_Duration = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Duration)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Cancel.Location = new System.Drawing.Point(30, 126);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(75, 23);
            this.BTN_Cancel.TabIndex = 0;
            this.BTN_Cancel.Text = "Cancel";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            // 
            // BTN_Ok
            // 
            this.BTN_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Ok.Location = new System.Drawing.Point(111, 126);
            this.BTN_Ok.Name = "BTN_Ok";
            this.BTN_Ok.Size = new System.Drawing.Size(75, 23);
            this.BTN_Ok.TabIndex = 1;
            this.BTN_Ok.Text = "Ok";
            this.BTN_Ok.UseVisualStyleBackColor = true;
            this.BTN_Ok.Click += new System.EventHandler(this.BTN_Ok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Duration";
            // 
            // CB_Pin
            // 
            this.CB_Pin.FormattingEnabled = true;
            this.CB_Pin.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13"});
            this.CB_Pin.Location = new System.Drawing.Point(65, 13);
            this.CB_Pin.Name = "CB_Pin";
            this.CB_Pin.Size = new System.Drawing.Size(121, 21);
            this.CB_Pin.TabIndex = 5;
            // 
            // CB_Output
            // 
            this.CB_Output.FormattingEnabled = true;
            this.CB_Output.Items.AddRange(new object[] {
            "HIGH",
            "LOW"});
            this.CB_Output.Location = new System.Drawing.Point(65, 40);
            this.CB_Output.Name = "CB_Output";
            this.CB_Output.Size = new System.Drawing.Size(121, 21);
            this.CB_Output.TabIndex = 6;
            // 
            // NUD_Duration
            // 
            this.NUD_Duration.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NUD_Duration.Location = new System.Drawing.Point(65, 67);
            this.NUD_Duration.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NUD_Duration.Name = "NUD_Duration";
            this.NUD_Duration.Size = new System.Drawing.Size(120, 20);
            this.NUD_Duration.TabIndex = 7;
            this.NUD_Duration.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // CRUD_Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 161);
            this.Controls.Add(this.NUD_Duration);
            this.Controls.Add(this.CB_Output);
            this.Controls.Add(this.CB_Pin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Ok);
            this.Controls.Add(this.BTN_Cancel);
            this.Name = "CRUD_Dialog";
            this.Text = "Pulse Editor";
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Duration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.Button BTN_Ok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CB_Pin;
        private System.Windows.Forms.ComboBox CB_Output;
        private System.Windows.Forms.NumericUpDown NUD_Duration;
    }
}