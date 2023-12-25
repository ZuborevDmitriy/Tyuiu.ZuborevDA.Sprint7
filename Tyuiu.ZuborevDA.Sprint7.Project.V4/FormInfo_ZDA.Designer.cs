
namespace Tyuiu.ZuborevDA.Sprint7.Project.V4
{
    partial class FormInfo_ZDA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfo_ZDA));
            this.textBoxInfo_ZDA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxInfo_ZDA
            // 
            this.textBoxInfo_ZDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInfo_ZDA.Location = new System.Drawing.Point(0, 0);
            this.textBoxInfo_ZDA.Multiline = true;
            this.textBoxInfo_ZDA.Name = "textBoxInfo_ZDA";
            this.textBoxInfo_ZDA.ReadOnly = true;
            this.textBoxInfo_ZDA.Size = new System.Drawing.Size(406, 152);
            this.textBoxInfo_ZDA.TabIndex = 0;
            this.textBoxInfo_ZDA.Text = resources.GetString("textBoxInfo_ZDA.Text");
            // 
            // FormInfo_ZDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 152);
            this.Controls.Add(this.textBoxInfo_ZDA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInfo_ZDA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочная информация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInfo_ZDA;
    }
}