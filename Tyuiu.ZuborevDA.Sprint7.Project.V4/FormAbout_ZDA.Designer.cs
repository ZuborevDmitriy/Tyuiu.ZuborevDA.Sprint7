
namespace Tyuiu.ZuborevDA.Sprint7.Project.V4
{
    partial class FormAbout_ZDA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_ZDA));
            this.pictureBoxAvatar_ZDA = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCloseAbout_ZDA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_ZDA)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar_ZDA
            // 
            this.pictureBoxAvatar_ZDA.Image = global::Tyuiu.ZuborevDA.Sprint7.Project.V4.Properties.Resources._16883149893820;
            this.pictureBoxAvatar_ZDA.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxAvatar_ZDA.Name = "pictureBoxAvatar_ZDA";
            this.pictureBoxAvatar_ZDA.Size = new System.Drawing.Size(203, 202);
            this.pictureBoxAvatar_ZDA.TabIndex = 0;
            this.pictureBoxAvatar_ZDA.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(222, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 153);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // buttonCloseAbout_ZDA
            // 
            this.buttonCloseAbout_ZDA.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonCloseAbout_ZDA.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.buttonCloseAbout_ZDA.FlatAppearance.BorderSize = 2;
            this.buttonCloseAbout_ZDA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonCloseAbout_ZDA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(219)))), ((int)(((byte)(137)))));
            this.buttonCloseAbout_ZDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseAbout_ZDA.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCloseAbout_ZDA.ForeColor = System.Drawing.Color.White;
            this.buttonCloseAbout_ZDA.Location = new System.Drawing.Point(494, 182);
            this.buttonCloseAbout_ZDA.Name = "buttonCloseAbout_ZDA";
            this.buttonCloseAbout_ZDA.Size = new System.Drawing.Size(100, 33);
            this.buttonCloseAbout_ZDA.TabIndex = 2;
            this.buttonCloseAbout_ZDA.Text = "Ок";
            this.buttonCloseAbout_ZDA.UseVisualStyleBackColor = false;
            this.buttonCloseAbout_ZDA.Click += new System.EventHandler(this.buttonCloseAbout_ZDA_Click);
            // 
            // FormAbout_ZDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 228);
            this.Controls.Add(this.buttonCloseAbout_ZDA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxAvatar_ZDA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout_ZDA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О приложении";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_ZDA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_ZDA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCloseAbout_ZDA;
    }
}