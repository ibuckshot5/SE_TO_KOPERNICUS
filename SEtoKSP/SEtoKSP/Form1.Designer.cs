namespace SEtoKSP
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
            this.se = new System.Windows.Forms.TextBox();
            this.Convert = new System.Windows.Forms.Button();
            this.ksp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.scaledSpaceTexturePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.scaledSpaceNormalPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.heightmapPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.colormapPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // se
            // 
            this.se.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.se.Location = new System.Drawing.Point(13, 13);
            this.se.MaxLength = 16777216;
            this.se.Multiline = true;
            this.se.Name = "se";
            this.se.Size = new System.Drawing.Size(290, 280);
            this.se.TabIndex = 0;
            this.se.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Convert
            // 
            this.Convert.Location = new System.Drawing.Point(309, 144);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(66, 23);
            this.Convert.TabIndex = 1;
            this.Convert.Text = "→";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // ksp
            // 
            this.ksp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ksp.Location = new System.Drawing.Point(381, 13);
            this.ksp.MaxLength = 16777216;
            this.ksp.Multiline = true;
            this.ksp.Name = "ksp";
            this.ksp.Size = new System.Drawing.Size(290, 280);
            this.ksp.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(677, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ScaledSpace Texture Path:";
            // 
            // scaledSpaceTexturePath
            // 
            this.scaledSpaceTexturePath.Location = new System.Drawing.Point(680, 33);
            this.scaledSpaceTexturePath.Name = "scaledSpaceTexturePath";
            this.scaledSpaceTexturePath.Size = new System.Drawing.Size(165, 20);
            this.scaledSpaceTexturePath.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(677, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ScaledSpace Normal Path:";
            // 
            // scaledSpaceNormalPath
            // 
            this.scaledSpaceNormalPath.Location = new System.Drawing.Point(680, 72);
            this.scaledSpaceNormalPath.Name = "scaledSpaceNormalPath";
            this.scaledSpaceNormalPath.Size = new System.Drawing.Size(165, 20);
            this.scaledSpaceNormalPath.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(677, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Heightmap Path:";
            // 
            // heightmapPath
            // 
            this.heightmapPath.Location = new System.Drawing.Point(680, 111);
            this.heightmapPath.Name = "heightmapPath";
            this.heightmapPath.Size = new System.Drawing.Size(165, 20);
            this.heightmapPath.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(677, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Colormap Path:";
            // 
            // colormapPath
            // 
            this.colormapPath.Location = new System.Drawing.Point(680, 150);
            this.colormapPath.Name = "colormapPath";
            this.colormapPath.Size = new System.Drawing.Size(165, 20);
            this.colormapPath.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 306);
            this.Controls.Add(this.colormapPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.heightmapPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.scaledSpaceNormalPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scaledSpaceTexturePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ksp);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.se);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox se;
        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.TextBox ksp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox scaledSpaceTexturePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox scaledSpaceNormalPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox heightmapPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox colormapPath;
    }
}

