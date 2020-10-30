using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Mathematics;

namespace RegressionAnalysis
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Открыть входные данные и рассчитать
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnOpen_Click(object sender, EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();
			if (dlg.ShowDialog() != DialogResult.OK)
				return;
            // Создать инструмент для проведения регрессионного анализа
			var regrAnCounter = new RegressionAnalisys(new Func<double, double>[] { x1Lin, x2Lin, yLin });

            // Считать входные данные
			var rawData = readData(dlg.FileName, 2);

            // Провести регрессионный анализ и построить матрицу коэффициентов
			var a = regrAnCounter.Analysis(rawData);

			// Рассчитать и вывести характеристики
			double dispersion = regrAnCounter.CalcDispersion();
			double avError = regrAnCounter.CalcAverageError();
			double fCrit = regrAnCounter.CalcFCriterion();

            //txtDispertion.Text = dispersion.ToString("0.###E+000");
            //txtAvErr.Text = avError.ToString("0.###E+000");
            //txtFCrit.Text = fCrit.ToString("0.###E+000");

            txtDispertion.Text = dispersion.ToString();
            txtAvErr.Text = Math.Round(avError,5).ToString();
            txtFCrit.Text = fCrit.ToString();

            //Вывод коэффициентов
            gridA.Columns.Clear();
			gridA.Columns.Add("name", "Коэффициент");
			gridA.Columns.Add("value", "Значение");
            // Построчный вывод коэффициентов с точностью до 3х знаков после запятой
			for(int i = 0; i<a.Length; i++)
				gridA.Rows.Add("a" + i, a[i].ToString("N3"));
		}

		double yLin(double y)
		{
			if (y == 0)
				throw new LogException(y);
            // Преобразование (замена) функции
            //return Math.Log(y/(1-y));
            return 1/y;
        }
        double x1Lin(double x1)
        {
            
            return x1;
        }
        double x2Lin(double x2)
        {

            return x2;
        }


        //Читает данные из файла
        List<double[]> readData(string filename, int numberOfX)
		{
			//Создаем список, куда будем складывать значения
			var list = new List<double[]>();

			using (var reader = new StreamReader(filename))
			{
				//По заголовоку определяем число переменных
				string line = reader.ReadLine();
				if (line == null) throw new IOException("Файл пуст");

				//Парсим остальные строки
				while ((line = reader.ReadLine()) != null)
					list.Add(parseString(line, numberOfX));
			}

			return list;
		}

		// Распарсить строку данных
		double[] parseString(string str, int numberOfX)
		{
			var strs = str.Split(';');
			if (strs.Length != numberOfX+1) throw new WrongNumberOfVariablesException();
			double[] values = new double[strs.Length];

            for (int i = 0; i < strs.Length; i++)
            {
                values[i] = double.Parse(strs[i]);
            }
           // values[0] = 1 / values[0];
            //values[1] = 1 / values[1];

            return values;
		}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gridA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
