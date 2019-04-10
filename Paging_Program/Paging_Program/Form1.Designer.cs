namespace Paging_Program
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AccessSequanceButton = new System.Windows.Forms.Button();
            this.AccessSequanceListBox = new System.Windows.Forms.ListBox();
            this.ASLLB = new System.Windows.Forms.Label();
            this.ASDUD = new System.Windows.Forms.DomainUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.SetSizeButton = new System.Windows.Forms.Button();
            this.SetValButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLOCK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Access Sequance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(342, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Buffer with 12 Frames";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(710, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "HDD";
            // 
            // AccessSequanceButton
            // 
            this.AccessSequanceButton.Location = new System.Drawing.Point(39, 427);
            this.AccessSequanceButton.Name = "AccessSequanceButton";
            this.AccessSequanceButton.Size = new System.Drawing.Size(165, 59);
            this.AccessSequanceButton.TabIndex = 4;
            this.AccessSequanceButton.Text = "Create random access Squance";
            this.AccessSequanceButton.UseVisualStyleBackColor = true;
            // 
            // AccessSequanceListBox
            // 
            this.AccessSequanceListBox.FormattingEnabled = true;
            this.AccessSequanceListBox.ItemHeight = 16;
            this.AccessSequanceListBox.Location = new System.Drawing.Point(39, 191);
            this.AccessSequanceListBox.Name = "AccessSequanceListBox";
            this.AccessSequanceListBox.Size = new System.Drawing.Size(79, 228);
            this.AccessSequanceListBox.TabIndex = 5;
            // 
            // ASLLB
            // 
            this.ASLLB.AutoSize = true;
            this.ASLLB.Location = new System.Drawing.Point(36, 98);
            this.ASLLB.Name = "ASLLB";
            this.ASLLB.Size = new System.Drawing.Size(169, 17);
            this.ASLLB.TabIndex = 7;
            this.ASLLB.Text = "Access Sequance Length";
            // 
            // ASDUD
            // 
            this.ASDUD.Location = new System.Drawing.Point(124, 190);
            this.ASDUD.Name = "ASDUD";
            this.ASDUD.Size = new System.Drawing.Size(80, 22);
            this.ASDUD.TabIndex = 8;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(39, 119);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(165, 22);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SetSizeButton
            // 
            this.SetSizeButton.Location = new System.Drawing.Point(39, 147);
            this.SetSizeButton.Name = "SetSizeButton";
            this.SetSizeButton.Size = new System.Drawing.Size(165, 37);
            this.SetSizeButton.TabIndex = 10;
            this.SetSizeButton.Text = "Set Size";
            this.SetSizeButton.UseVisualStyleBackColor = true;
            // 
            // SetValButton
            // 
            this.SetValButton.Location = new System.Drawing.Point(124, 218);
            this.SetValButton.Name = "SetValButton";
            this.SetValButton.Size = new System.Drawing.Size(81, 67);
            this.SetValButton.TabIndex = 11;
            this.SetValButton.Text = "Set Val";
            this.SetValButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 498);
            this.Controls.Add(this.SetValButton);
            this.Controls.Add(this.SetSizeButton);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.ASDUD);
            this.Controls.Add(this.ASLLB);
            this.Controls.Add(this.AccessSequanceListBox);
            this.Controls.Add(this.AccessSequanceButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AccessSequanceButton;
        private System.Windows.Forms.ListBox AccessSequanceListBox;
        private System.Windows.Forms.Label ASLLB;
        private System.Windows.Forms.DomainUpDown ASDUD;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button SetSizeButton;
        private System.Windows.Forms.Button SetValButton;
    }
}

