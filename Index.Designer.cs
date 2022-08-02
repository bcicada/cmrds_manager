
namespace cmrds_manager
{
    partial class Index
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.Btn_Select_File = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numUD_Group_Size = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_Launch_Treatment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_Group_Size)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Select_File
            // 
            this.Btn_Select_File.Location = new System.Drawing.Point(147, 82);
            this.Btn_Select_File.Name = "Btn_Select_File";
            this.Btn_Select_File.Size = new System.Drawing.Size(177, 33);
            this.Btn_Select_File.TabIndex = 0;
            this.Btn_Select_File.Text = "Sélectionner un fichier excel";
            this.Btn_Select_File.UseVisualStyleBackColor = true;
            this.Btn_Select_File.Click += new System.EventHandler(this.Btn_Select_File_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::cmrds_manager.Properties.Resources.CMRDS;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Action  française\r\nCMRDS Manager\r\n------------------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "-------------------------------------------------------------";
            // 
            // numUD_Group_Size
            // 
            this.numUD_Group_Size.Location = new System.Drawing.Point(204, 210);
            this.numUD_Group_Size.Name = "numUD_Group_Size";
            this.numUD_Group_Size.Size = new System.Drawing.Size(120, 23);
            this.numUD_Group_Size.TabIndex = 4;
            this.numUD_Group_Size.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUD_Group_Size.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Taille maximum des groupes :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Règles métiers :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(312, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "-------------------------------------------------------------";
            // 
            // Btn_Launch_Treatment
            // 
            this.Btn_Launch_Treatment.Location = new System.Drawing.Point(84, 253);
            this.Btn_Launch_Treatment.Name = "Btn_Launch_Treatment";
            this.Btn_Launch_Treatment.Size = new System.Drawing.Size(177, 33);
            this.Btn_Launch_Treatment.TabIndex = 8;
            this.Btn_Launch_Treatment.Text = "Lancer le traitement";
            this.Btn_Launch_Treatment.UseVisualStyleBackColor = true;
            this.Btn_Launch_Treatment.Click += new System.EventHandler(this.Btn_Launch_Treatment_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 300);
            this.Controls.Add(this.Btn_Launch_Treatment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numUD_Group_Size);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn_Select_File);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Index";
            this.Text = "CMRDS Manager";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_Group_Size)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Select_File;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numUD_Group_Size;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_Launch_Treatment;
    }
}

