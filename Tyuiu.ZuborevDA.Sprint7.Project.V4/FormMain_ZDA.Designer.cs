
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
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочнаяИнформацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxBaza_ZDA = new System.Windows.Forms.GroupBox();
            this.dataGridViewBaza_ZDA = new System.Windows.Forms.DataGridView();
            this.groupBoxTools_ZDA = new System.Windows.Forms.GroupBox();
            this.buttonSChange_ZDA = new System.Windows.Forms.Button();
            this.buttonRemove_ZDA = new System.Windows.Forms.Button();
            this.buttonChange_ZDA = new System.Windows.Forms.Button();
            this.buttonAdd_ZDA = new System.Windows.Forms.Button();
            this.openFileDialogBaza_ZDA = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogBaza_ZDA = new System.Windows.Forms.SaveFileDialog();
            this.BookYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReaderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TicketNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGive = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.сохранитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.действияToolStripMenuItem.Text = "Действия";
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // справочнаяИнформацияToolStripMenuItem
            // 
            this.справочнаяИнформацияToolStripMenuItem.Name = "справочнаяИнформацияToolStripMenuItem";
            this.справочнаяИнформацияToolStripMenuItem.Size = new System.Drawing.Size(161, 20);
            this.справочнаяИнформацияToolStripMenuItem.Text = "Справочная информация";
            this.справочнаяИнформацияToolStripMenuItem.Click += new System.EventHandler(this.справочнаяИнформацияToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // groupBoxBaza_ZDA
            // 
            this.groupBoxBaza_ZDA.Controls.Add(this.dataGridViewBaza_ZDA);
            this.groupBoxBaza_ZDA.Location = new System.Drawing.Point(28, 156);
            this.groupBoxBaza_ZDA.Name = "groupBoxBaza_ZDA";
            this.groupBoxBaza_ZDA.Size = new System.Drawing.Size(619, 400);
            this.groupBoxBaza_ZDA.TabIndex = 1;
            this.groupBoxBaza_ZDA.TabStop = false;
            this.groupBoxBaza_ZDA.Text = "База данных";
            // 
            // dataGridViewBaza_ZDA
            // 
            this.dataGridViewBaza_ZDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBaza_ZDA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookYear,
            this.Author,
            this.BookName,
            this.Price,
            this.ReaderName,
            this.TicketNumber,
            this.DataGet,
            this.DataGive});
            this.dataGridViewBaza_ZDA.Location = new System.Drawing.Point(18, 53);
            this.dataGridViewBaza_ZDA.Name = "dataGridViewBaza_ZDA";
            this.dataGridViewBaza_ZDA.Size = new System.Drawing.Size(580, 308);
            this.dataGridViewBaza_ZDA.TabIndex = 0;
            // 
            // groupBoxTools_ZDA
            // 
            this.groupBoxTools_ZDA.Controls.Add(this.buttonSChange_ZDA);
            this.groupBoxTools_ZDA.Controls.Add(this.buttonRemove_ZDA);
            this.groupBoxTools_ZDA.Controls.Add(this.buttonChange_ZDA);
            this.groupBoxTools_ZDA.Controls.Add(this.buttonAdd_ZDA);
            this.groupBoxTools_ZDA.Location = new System.Drawing.Point(675, 216);
            this.groupBoxTools_ZDA.Name = "groupBoxTools_ZDA";
            this.groupBoxTools_ZDA.Size = new System.Drawing.Size(323, 458);
            this.groupBoxTools_ZDA.TabIndex = 2;
            this.groupBoxTools_ZDA.TabStop = false;
            this.groupBoxTools_ZDA.Text = "Инструменты";
            // 
            // buttonSChange_ZDA
            // 
            this.buttonSChange_ZDA.Location = new System.Drawing.Point(52, 155);
            this.buttonSChange_ZDA.Name = "buttonSChange_ZDA";
            this.buttonSChange_ZDA.Size = new System.Drawing.Size(161, 23);
            this.buttonSChange_ZDA.TabIndex = 3;
            this.buttonSChange_ZDA.Text = "Сохранить изменения";
            this.buttonSChange_ZDA.UseVisualStyleBackColor = true;
            this.buttonSChange_ZDA.Click += new System.EventHandler(this.buttonSChange_ZDA_Click);
            // 
            // buttonRemove_ZDA
            // 
            this.buttonRemove_ZDA.Location = new System.Drawing.Point(88, 368);
            this.buttonRemove_ZDA.Name = "buttonRemove_ZDA";
            this.buttonRemove_ZDA.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove_ZDA.TabIndex = 2;
            this.buttonRemove_ZDA.Text = "Удалить";
            this.buttonRemove_ZDA.UseVisualStyleBackColor = true;
            this.buttonRemove_ZDA.Click += new System.EventHandler(this.buttonRemove_ZDA_Click);
            // 
            // buttonChange_ZDA
            // 
            this.buttonChange_ZDA.Location = new System.Drawing.Point(52, 117);
            this.buttonChange_ZDA.Name = "buttonChange_ZDA";
            this.buttonChange_ZDA.Size = new System.Drawing.Size(161, 23);
            this.buttonChange_ZDA.TabIndex = 1;
            this.buttonChange_ZDA.Text = "Изменить строку";
            this.buttonChange_ZDA.UseVisualStyleBackColor = true;
            this.buttonChange_ZDA.Click += new System.EventHandler(this.buttonChange_ZDA_Click);
            // 
            // buttonAdd_ZDA
            // 
            this.buttonAdd_ZDA.Location = new System.Drawing.Point(52, 71);
            this.buttonAdd_ZDA.Name = "buttonAdd_ZDA";
            this.buttonAdd_ZDA.Size = new System.Drawing.Size(175, 23);
            this.buttonAdd_ZDA.TabIndex = 0;
            this.buttonAdd_ZDA.Text = "Добавить";
            this.buttonAdd_ZDA.UseVisualStyleBackColor = true;
            this.buttonAdd_ZDA.Click += new System.EventHandler(this.buttonAdd_ZDA_Click);
            // 
            // openFileDialogBaza_ZDA
            // 
            this.openFileDialogBaza_ZDA.Filter = "Exel|*csv";
            // 
            // BookYear
            // 
            this.BookYear.HeaderText = "Год издания";
            this.BookYear.Name = "BookYear";
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
            // Price
            // 
            this.Price.HeaderText = "Цена, р";
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
        private System.Windows.Forms.GroupBox groupBoxTools_ZDA;
        private System.Windows.Forms.Button buttonRemove_ZDA;
        private System.Windows.Forms.Button buttonChange_ZDA;
        private System.Windows.Forms.Button buttonAdd_ZDA;
        private System.Windows.Forms.OpenFileDialog openFileDialogBaza_ZDA;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialogBaza_ZDA;
        private System.Windows.Forms.Button buttonSChange_ZDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReaderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGet;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGive;
    }
}

