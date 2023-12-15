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

            openFileDialogTask_ZDA.Filter = "Значения, разделенные запятыми(*.xlsx)|*.xlsx|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_ZDA.Filter = "Значения, разделенные запятыми(*.xlsx)|*.xlsx|Все файлы(*.*)|*.*";
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
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(',').Length;

            string[,] arrayValues = new string[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(',');

                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = line_r[c];
                }
            }
            return arrayValues;
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialogTask_ZDA.ShowDialog();
            openFilePath = openFileDialogTask_ZDA.FileName;

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
    }
}
