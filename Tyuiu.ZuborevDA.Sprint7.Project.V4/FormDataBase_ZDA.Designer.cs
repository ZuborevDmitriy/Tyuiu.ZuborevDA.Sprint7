
namespace Tyuiu.ZuborevDA.Sprint7.Project.V4
{
    partial class FormDataBase_ZDA
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
            this.panelDBUp_ZDA = new System.Windows.Forms.Panel();
            this.groupBoxFile_ZDA = new System.Windows.Forms.GroupBox();
            this.groupBoxTools_ZDA = new System.Windows.Forms.GroupBox();
            this.groupBoxSorting_ZDA = new System.Windows.Forms.GroupBox();
            this.panelDBUp_ZDA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDBUp_ZDA
            // 
            this.panelDBUp_ZDA.Controls.Add(this.groupBoxSorting_ZDA);
            this.panelDBUp_ZDA.Controls.Add(this.groupBoxTools_ZDA);
            this.panelDBUp_ZDA.Controls.Add(this.groupBoxFile_ZDA);
            this.panelDBUp_ZDA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDBUp_ZDA.Location = new System.Drawing.Point(0, 0);
            this.panelDBUp_ZDA.Name = "panelDBUp_ZDA";
            this.panelDBUp_ZDA.Size = new System.Drawing.Size(1159, 292);
            this.panelDBUp_ZDA.TabIndex = 0;
            // 
            // groupBoxFile_ZDA
            // 
            this.groupBoxFile_ZDA.Location = new System.Drawing.Point(67, 54);
            this.groupBoxFile_ZDA.Name = "groupBoxFile_ZDA";
            this.groupBoxFile_ZDA.Size = new System.Drawing.Size(200, 100);
            this.groupBoxFile_ZDA.TabIndex = 0;
            this.groupBoxFile_ZDA.TabStop = false;
            this.groupBoxFile_ZDA.Text = "groupBox1";
            // 
            // groupBoxTools_ZDA
            // 
            this.groupBoxTools_ZDA.Location = new System.Drawing.Point(398, 107);
            this.groupBoxTools_ZDA.Name = "groupBoxTools_ZDA";
            this.groupBoxTools_ZDA.Size = new System.Drawing.Size(200, 100);
            this.groupBoxTools_ZDA.TabIndex = 1;
            this.groupBoxTools_ZDA.TabStop = false;
            this.groupBoxTools_ZDA.Text = "groupBox1";
            // 
            // groupBoxSorting_ZDA
            // 
            this.groupBoxSorting_ZDA.Location = new System.Drawing.Point(722, 128);
            this.groupBoxSorting_ZDA.Name = "groupBoxSorting_ZDA";
            this.groupBoxSorting_ZDA.Size = new System.Drawing.Size(200, 100);
            this.groupBoxSorting_ZDA.TabIndex = 2;
            this.groupBoxSorting_ZDA.TabStop = false;
            this.groupBoxSorting_ZDA.Text = "groupBox1";
            // 
            // FormDataBase_ZDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 684);
            this.Controls.Add(this.panelDBUp_ZDA);
            this.Name = "FormDataBase_ZDA";
            this.Text = "FormDataBase_ZDA";
            this.panelDBUp_ZDA.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDBUp_ZDA;
        private System.Windows.Forms.GroupBox groupBoxSorting_ZDA;
        private System.Windows.Forms.GroupBox groupBoxTools_ZDA;
        private System.Windows.Forms.GroupBox groupBoxFile_ZDA;
    }
}