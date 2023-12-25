
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
            this.pictureBoxAbout_ZDA = new System.Windows.Forms.PictureBox();
            this.textBoxAbout_ZDA = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbout_ZDA)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAbout_ZDA
            // 
            this.pictureBoxAbout_ZDA.Image = global::Tyuiu.ZuborevDA.Sprint7.Project.V4.Properties.Resources._16883149893820;
            this.pictureBoxAbout_ZDA.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAbout_ZDA.Name = "pictureBoxAbout_ZDA";
            this.pictureBoxAbout_ZDA.Size = new System.Drawing.Size(206, 206);
            this.pictureBoxAbout_ZDA.TabIndex = 0;
            this.pictureBoxAbout_ZDA.TabStop = false;
            // 
            // textBoxAbout_ZDA
            // 
            this.textBoxAbout_ZDA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAbout_ZDA.Location = new System.Drawing.Point(224, 12);
            this.textBoxAbout_ZDA.Multiline = true;
            this.textBoxAbout_ZDA.Name = "textBoxAbout_ZDA";
            this.textBoxAbout_ZDA.ReadOnly = true;
            this.textBoxAbout_ZDA.Size = new System.Drawing.Size(294, 206);
            this.textBoxAbout_ZDA.TabIndex = 0;
            this.textBoxAbout_ZDA.TabStop = false;
            this.textBoxAbout_ZDA.Text = resources.GetString("textBoxAbout_ZDA.Text");
            // 
            // FormAbout_ZDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 227);
            this.Controls.Add(this.textBoxAbout_ZDA);
            this.Controls.Add(this.pictureBoxAbout_ZDA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout_ZDA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbout_ZDA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAbout_ZDA;
        private System.Windows.Forms.TextBox textBoxAbout_ZDA;
    }
}