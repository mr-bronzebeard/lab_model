using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Mathematics
{	
	class RegressionAnalisys
	{
		private Func<double, double>[] converters;
		private List<double[]> rawData;
		private List<double[]> linData;
		private double[] y;
		private double[] a;
		private int N;	// Размер выборки
		private int m;  // Число переменных
		private int M;	// Число коэффициентов

		//Создает объект, задавая функции преобразования
		public RegressionAnalisys(Func<double, double>[] converters)
		{
			this.converters = converters;
			m = converters.Length-1;
			M = m + 1;
		}

		/// <summary>
		/// Провести метод регрессионного анализа
		/// </summary>
		/// <param name="data">Экспериментальные данные</param>
		/// <returns>Массив коэффициентов</returns>
		public double[] Analysis(List<double[]> data)
		{
			N = data.Count;
			linData = linearise(data, converters);
            // w = ln(y/(1-y));
            //a = convertOriginal(SLAUSolver.Solve(calcSLAUMatrix(linData)), converters);
            a = SLAUSolver.Solve(calcSLAUMatrix(linData));
			y = calcY(a, linData);

            //double tmp = -a[0];

            

            //tmp = Math.Round(tmp, 1)-0.1;
            //tmp = Math.Log(tmp);

            //tmp = -tmp;
            //a[0] = tmp;

            return a;
		}

		// Остаточная дисперсия		
		public double CalcDispersion()
		{
			double d = 0;
			for(int i = 0; i<N; i++)
			{
				var v = Math.Pow(linData[i][M] - y[i], 2);
				d += v;
			}
			return d / (N - m - 1);
		}

		// Средняя относительная ошибка		
		public double CalcAverageError()
		{
			double err = 0;
			for(int i = 0; i<N; i++)
				err += Math.Abs((linData[i][M] - y[i]) / linData[i][M]);
            return err * 100 / N;
		}

		//F-критерий Фищера
		public double CalcFCriterion()
		{
			double avY;		//среднее
			double avD;     //Дисперсия  среднего
			double ostD;	//Остаточная дисперсия

			// Вычисляем среднее значение Y экспериментального
			avY = 0;
			foreach (var row in linData)
				avY += row[M];
			avY /= N;

			// Дисперсия среднего
			avD = 0;
			foreach (var yc in y)
				avD += Math.Pow(yc - avY, 2);
			avD /= (N - 1);

			// Остаточная дисперсия
			ostD = CalcDispersion();

			return avD / ostD;
		}

		// Провести линеаризацию значений		
		List<double[]> linearise(List<double[]> data, Func<double, double>[] convertors)
		{
			List<double[]> converted = new List<double[]>();
			foreach (var row in data)
			{
				//Проверка на верное число столбцов
				if (row.Length != M) throw new WrongNumberOfVariablesException();

				converted.Add(new double[row.Length + 1]);
				converted[converted.Count - 1][0] = 1;
				for (int i = 0; i < row.Length; i++)
					converted[converted.Count - 1][i + 1] = convertors[i](row[i]);

			}

			return converted;
		}

		//Вычисление матрицы коэффициентов и свободных членов для СЛАУ
		double[][] calcSLAUMatrix(List<double[]> data)
		{
			//Создаем матрицу коээфициентов
			double[][] A = new double[M][];
			for (int i = 0; i < M; i++)
				A[i] = new double[M + 1];

			//Расчитываем
			for (int k = 1; k <= M; k++)
			{
				// k-номер строки
				for (int i = 1; i <= M; i++)
				{
					// i - номер элемента в строке (номер столбца)					
					A[k - 1][i - 1] = 0;
					for (int j = 0; j < N; j++)
					{
						// j - номер эксперимента
						A[k - 1][i - 1] += data[j][i - 1] * data[j][k - 1];
					}
				}

				//Расчет свободных членов
				A[k - 1][M] = 0;
				for (int j = 0; j < N; j++)
				{
					A[k - 1][M] += data[j][M] * data[j][k - 1];
				}
			}
			return A;
		}

        // Преобразовать полученные коэффициенты обратно
		double[] convertOriginal(double[] a, Func<double, double>[] convertors)
		{
			if (a.Length != convertors.Length) throw new WrongNumberOfVariablesException();

			var newA = new double[a.Length];
			for (int i = 0; i < a.Length; i++)
			{
				newA[i] = convertors[i](a[i]);
			}
			return newA;
		}
        		
        // Рассчитать значения y на основе вычисленных коэффициентов
		double[] calcY(double[] a, List<double[]> data)
		{
			var newY = new double[data.Count];

			for (int j = 0; j < data.Count; j++)
			{
				newY[j] = 0;
				for (int i = 0; i < a.Length; i++)
					newY[j] += data[j][i] * a[i];
			}

			return newY;
		}
	}
}
