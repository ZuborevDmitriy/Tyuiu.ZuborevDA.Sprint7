using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.ZuborevDA.Sprint7.Project.V4.Lib;

using System.IO;

namespace Tyuiu.ZuborevDA.Sprint7.Project.V4
{
    public partial class FormMain_ZDA : Form
    {
        public FormMain_ZDA()
        {
            InitializeComponent();

            openFileDialogBaza_ZDA.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogBaza_ZDA.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int columns;
        static string openFilePath;

        DataService ds = new DataService();

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout_ZDA formAbout = new FormAbout_ZDA();
            formAbout.ShowDialog();
        }

        private void справочнаяИнформацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInfo_ZDA formInfo = new FormInfo_ZDA();
            formInfo.ShowDialog();  
        }

        public static string[,] LoadFromFileData(string filePath)
        {
            string fileData = System.IO.File.ReadAllText(filePath, Encoding.Default);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split('\t').Length;

            string[,] arrayValues = new string[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split('\t');

                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = line_r[c];
                }
            }
            return arrayValues;
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogBaza_ZDA.ShowDialog();
                openFilePath = openFileDialogBaza_ZDA.FileName;

                string[,] arrayValues = new string[rows, columns];
                arrayValues = LoadFromFileData(openFilePath);

                dataGridViewBaza_ZDA.ColumnCount = columns;
                dataGridViewBaza_ZDA.RowCount = rows;

                for (int i = 0; i < columns; i++)
                {
                    dataGridViewBaza_ZDA.Columns[i].Width = 100;
                }

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridViewBaza_ZDA.Rows[r].Cells[c].Value = arrayValues[r, c];
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка", "Что-то пошло не так", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_ZDA_Click(object sender, EventArgs e)
        {
            if (dataGridViewBaza_ZDA.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            int index = dataGridViewBaza_ZDA.SelectedRows[0].Index;

            if (dataGridViewBaza_ZDA.Rows[index].Cells[0].Value == null ||
                dataGridViewBaza_ZDA.Rows[index].Cells[1].Value == null ||
                dataGridViewBaza_ZDA.Rows[index].Cells[2].Value == null ||
                dataGridViewBaza_ZDA.Rows[index].Cells[3].Value == null ||
                dataGridViewBaza_ZDA.Rows[index].Cells[4].Value == null ||
                dataGridViewBaza_ZDA.Rows[index].Cells[5].Value == null ||
                dataGridViewBaza_ZDA.Rows[index].Cells[6].Value == null ||
                dataGridViewBaza_ZDA.Rows[index].Cells[7].Value == null)
            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
                return;
            }
            else
            {
                MessageBox.Show("Данные добавлены!", "Внимание!");
            }

            dataGridViewBaza_ZDA.Rows[index].ReadOnly = true;
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialogBaza_ZDA.FileName = "OutPutBaza.csv";
            saveFileDialogBaza_ZDA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogBaza_ZDA.ShowDialog();

            string path = saveFileDialogBaza_ZDA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewBaza_ZDA.RowCount;
            int columns = dataGridViewBaza_ZDA.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewBaza_ZDA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewBaza_ZDA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
            MessageBox.Show("Данные сохранены", "Внимание!");
        }

        private void buttonRemove_ZDA_Click(object sender, EventArgs e)
        {
            int index = dataGridViewBaza_ZDA.SelectedRows[0].Index;
            dataGridViewBaza_ZDA.Rows.RemoveAt(index);
        }

        private void buttonChange_ZDA_Click(object sender, EventArgs e)
        {
            int index = dataGridViewBaza_ZDA.SelectedRows[0].Index;
            dataGridViewBaza_ZDA.Rows[index].ReadOnly = false;
        }

        private void buttonSChange_ZDA_Click(object sender, EventArgs e)
        {
            if (dataGridViewBaza_ZDA.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            int index = dataGridViewBaza_ZDA.SelectedRows[0].Index;

            if (dataGridViewBaza_ZDA.Rows[index].Cells[0].Value == null ||
                dataGridViewBaza_ZDA.Rows[index].Cells[1].Value == null ||
                dataGridViewBaza_ZDA.Rows[index].Cells[2].Value == null ||
                dataGridViewBaza_ZDA.Rows[index].Cells[3].Value == null ||
                dataGridViewBaza_ZDA.Rows[index].Cells[4].Value == null ||
                dataGridViewBaza_ZDA.Rows[index].Cells[5].Value == null ||
                dataGridViewBaza_ZDA.Rows[index].Cells[6].Value == null ||
                dataGridViewBaza_ZDA.Rows[index].Cells[7].Value == null)
            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
                return;
            }
            else
            {
                MessageBox.Show("Данные обновлены!", "Внимание!");
            }

            dataGridViewBaza_ZDA.Rows[index].ReadOnly = true;
        }
    }
}
