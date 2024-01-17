using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace КУРСАЧ
{
    public partial class App : Form
    {
        public Database myDB;
        public App()
        {
            InitializeComponent();
        }

        private void App_Load(object sender, EventArgs e)
        {
            string currentDirectoryPath = Path.GetDirectoryName(Application.ExecutablePath);
            if (!File.Exists($"{currentDirectoryPath}\\dataBase.DB"))
            {
                myDB = new Database("Data Source=dataBase.DB; Version = 3;");
                myDB.InitializeDatabase();
            }
            else
            {
                myDB = new Database("Data Source=dataBase.DB; Version = 3;");
            }
             var dialogResultAuth = new Auth().ShowDialog();
            if (dialogResultAuth == DialogResult.Cancel)
            {
                Close();
            } 
        }
        private void button1_Click(object sender, EventArgs e)
        {


            if (String.IsNullOrWhiteSpace(EnterRand.Text))
            {
                MessageBox.Show("Введите количество чисел для генерации.", "Некорректные данные", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (
                String.IsNullOrWhiteSpace(BoxFrom.Text) ||
                String.IsNullOrWhiteSpace(BoxTo.Text))
            {
                MessageBox.Show("Введите диапазон значений для генерации.", "Некорректные данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int countgen = Convert.ToInt32(EnterRand.Text);
                int to = Convert.ToInt32(BoxFrom.Text);
                int from = Convert.ToInt32(BoxTo.Text);

                
                    RandGeneration RG = new RandGeneration();
                    int[] nosortarr = RG.RandGen(countgen, to, from);
                    string snosortarr = Convert.ToString(nosortarr[0]);
                    for (int i = 1; i < nosortarr.Length; i++)
                    {
                        snosortarr = snosortarr + " " + nosortarr[i];
                    }
                    EnterData.Text = snosortarr;
                }
                catch (Exception e1)
                {
                    MessageBox.Show($"{e1.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

          private async void ButtonSort_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(EnterData.Text))
            {
                MessageBox.Show("Заполните поле с числами для сортировки.", "Некорректные данные", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    int x = 0;
                    string ssortarr = "";
                    string numdata = EnterData.Text;
                    int[] nosortarr = Array.ConvertAll(numdata.Split(' '), int.Parse);
                    HeapSort ob = new HeapSort();
                    int[,] sortarr = ob.sort(nosortarr);
                    for (int i = 0; i < sortarr.GetLength(0); i++)
                    {
                        ssortarr = ssortarr + " " + sortarr[sortarr.GetLength(1) - 1, i] ;
                    }
                    Testb.Text = ssortarr;
                    for (int i = 0; i < sortarr.GetLength(1); i++)
                    {
                        await ClearAs();
                        for (int j = 0; j < sortarr.GetLength(1); j++)
                        {
                            await CreateChart(sortarr, i, j);
                        }
                        async Task ClearAs()
                        {
                            this.chart1.Series[0].Points.Clear();
                            await Task.Delay(1);
                        }
                        async Task CreateChart(int[,] array, int z, int y)
                        {
                            x = 0;
                            for (int j = 0; j < sortarr.GetLength(1); j++)
                            {
                                x = x + 1;
                                this.chart1.Series[0].Points.AddXY(x, sortarr[i, j]);
                            }


                            await Task.Delay(1);
                        }

                        
                    }
                }
                catch (Exception e1)
                {
                    MessageBox.Show($"{e1.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButAuthExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG Image|*.png";
            saveFileDialog.Title = "Сохранение";
            saveFileDialog.FileName = "Chart.png";

            DialogResult result = saveFileDialog.ShowDialog();
            saveFileDialog.RestoreDirectory = true;

            if (result == DialogResult.OK && saveFileDialog.FileName != "")
            {
                try
                {
                    if (saveFileDialog.CheckPathExists)
                    {
                    chart1.SaveImage(saveFileDialog.FileName, ChartImageFormat.Png);
                    }
                    else
                    {
                        MessageBox.Show($"Н", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }

}