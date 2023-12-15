
namespace Tyuiu.ZuborevDA.Sprint7.Project.V4
{
    partial class FormMain_ZDA
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStripUpPanel_ZDA = new System.Windows.Forms.MenuStrip();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочнаяИнформацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxBaza_ZDA = new System.Windows.Forms.GroupBox();
            this.dataGridViewBaza_ZDA = new System.Windows.Forms.DataGridView();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReaderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TicketNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxTools_ZDA = new System.Windows.Forms.GroupBox();
            this.buttonAdd_ZDA = new System.Windows.Forms.Button();
            this.buttonUpdate_ZDA = new System.Windows.Forms.Button();
            this.buttonRemove_ZDA = new System.Windows.Forms.Button();
            this.menuStripUpPanel_ZDA.SuspendLayout();
            this.groupBoxBaza_ZDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBaza_ZDA)).BeginInit();
            this.groupBoxTools_ZDA.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripUpPanel_ZDA
            // 
            this.menuStripUpPanel_ZDA.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.действияToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.справочнаяИнформацияToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStripUpPanel_ZDA.Location = new System.Drawing.Point(0, 0);
            this.menuStripUpPanel_ZDA.Name = "menuStripUpPanel_ZDA";
            this.menuStripUpPanel_ZDA.Size = new System.Drawing.Size(1116, 24);
            this.menuStripUpPanel_ZDA.TabIndex = 0;
            this.menuStripUpPanel_ZDA.Text = "menuStrip1";
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.действияToolStripMenuItem.Text = "Действия";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // справочнаяИнформацияToolStripMenuItem
            // 
            this.справочнаяИнформацияToolStripMenuItem.Name = "справочнаяИнформацияToolStripMenuItem";
            this.справочнаяИнформацияToolStripMenuItem.Size = new System.Drawing.Size(161, 20);
            this.справочнаяИнформацияToolStripMenuItem.Text = "Справочная информация";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // groupBoxBaza_ZDA
            // 
            this.groupBoxBaza_ZDA.Controls.Add(this.dataGridViewBaza_ZDA);
            this.groupBoxBaza_ZDA.Location = new System.Drawing.Point(106, 173);
            this.groupBoxBaza_ZDA.Name = "groupBoxBaza_ZDA";
            this.groupBoxBaza_ZDA.Size = new System.Drawing.Size(337, 400);
            this.groupBoxBaza_ZDA.TabIndex = 1;
            this.groupBoxBaza_ZDA.TabStop = false;
            this.groupBoxBaza_ZDA.Text = "База данных";
            // 
            // dataGridViewBaza_ZDA
            // 
            this.dataGridViewBaza_ZDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBaza_ZDA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Author,
            this.BookName,
            this.BookYear,
            this.Price,
            this.ReaderName,
            this.TicketNumber,
            this.DataGet,
            this.DataGive});
            this.dataGridViewBaza_ZDA.Location = new System.Drawing.Point(66, 53);
            this.dataGridViewBaza_ZDA.Name = "dataGridViewBaza_ZDA";
            this.dataGridViewBaza_ZDA.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewBaza_ZDA.TabIndex = 0;
            // 
            // Author
            // 
            this.Author.HeaderText = "Автор книги";
            this.Author.Name = "Author";
            // 
            // BookName
            // 
            this.BookName.HeaderText = "Название книги";
            this.BookName.Name = "BookName";
            // 
            // BookYear
            // 
            this.BookYear.HeaderText = "Год издания";
            this.BookYear.Name = "BookYear";
            // 
            // Price
            // 
            this.Price.HeaderText = "Цена";
            this.Price.Name = "Price";
            // 
            // ReaderName
            // 
            this.ReaderName.HeaderText = "ФИО";
            this.ReaderName.Name = "ReaderName";
            // 
            // TicketNumber
            // 
            this.TicketNumber.HeaderText = "Номер читательского билета";
            this.TicketNumber.Name = "TicketNumber";
            // 
            // DataGet
            // 
            this.DataGet.HeaderText = "Дата выдачи";
            this.DataGet.Name = "DataGet";
            // 
            // DataGive
            // 
            this.DataGive.HeaderText = "Дата сдачи";
            this.DataGive.Name = "DataGive";
            // 
            // groupBoxTools_ZDA
            // 
            this.groupBoxTools_ZDA.Controls.Add(this.buttonRemove_ZDA);
            this.groupBoxTools_ZDA.Controls.Add(this.buttonUpdate_ZDA);
            this.groupBoxTools_ZDA.Controls.Add(this.buttonAdd_ZDA);
            this.groupBoxTools_ZDA.Location = new System.Drawing.Point(675, 216);
            this.groupBoxTools_ZDA.Name = "groupBoxTools_ZDA";
            this.groupBoxTools_ZDA.Size = new System.Drawing.Size(323, 380);
            this.groupBoxTools_ZDA.TabIndex = 2;
            this.groupBoxTools_ZDA.TabStop = false;
            this.groupBoxTools_ZDA.Text = "Инструменты";
            // 
            // buttonAdd_ZDA
            // 
            this.buttonAdd_ZDA.Location = new System.Drawing.Point(52, 71);
            this.buttonAdd_ZDA.Name = "buttonAdd_ZDA";
            this.buttonAdd_ZDA.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd_ZDA.TabIndex = 0;
            this.buttonAdd_ZDA.Text = "Добавить";
            this.buttonAdd_ZDA.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate_ZDA
            // 
            this.buttonUpdate_ZDA.Location = new System.Drawing.Point(52, 117);
            this.buttonUpdate_ZDA.Name = "buttonUpdate_ZDA";
            this.buttonUpdate_ZDA.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate_ZDA.TabIndex = 1;
            this.buttonUpdate_ZDA.Text = "Обновить";
            this.buttonUpdate_ZDA.UseVisualStyleBackColor = true;
            // 
            // buttonRemove_ZDA
            // 
            this.buttonRemove_ZDA.Location = new System.Drawing.Point(52, 171);
            this.buttonRemove_ZDA.Name = "buttonRemove_ZDA";
            this.buttonRemove_ZDA.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove_ZDA.TabIndex = 2;
            this.buttonRemove_ZDA.Text = "Удалить";
            this.buttonRemove_ZDA.UseVisualStyleBackColor = true;
            // 
            // FormMain_ZDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 713);
            this.Controls.Add(this.groupBoxTools_ZDA);
            this.Controls.Add(this.groupBoxBaza_ZDA);
            this.Controls.Add(this.menuStripUpPanel_ZDA);
            this.MainMenuStrip = this.menuStripUpPanel_ZDA;
            this.Name = "FormMain_ZDA";
            this.Text = "Form1";
            this.menuStripUpPanel_ZDA.ResumeLayout(false);
            this.menuStripUpPanel_ZDA.PerformLayout();
            this.groupBoxBaza_ZDA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBaza_ZDA)).EndInit();
            this.groupBoxTools_ZDA.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripUpPanel_ZDA;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочнаяИнформацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxBaza_ZDA;
        private System.Windows.Forms.DataGridView dataGridViewBaza_ZDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReaderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGet;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGive;
        private System.Windows.Forms.GroupBox groupBoxTools_ZDA;
        private System.Windows.Forms.Button buttonRemove_ZDA;
        private System.Windows.Forms.Button buttonUpdate_ZDA;
        private System.Windows.Forms.Button buttonAdd_ZDA;
    }
}

