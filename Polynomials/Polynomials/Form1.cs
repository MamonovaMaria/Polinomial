using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polynomials
{
    public partial class Form1 : Form
    {
        List<List<int>> fPol;
        List<List<int>> sPol;
		List<List<int>> r;
		List<int> N;
		
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonForFirstPolimom_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void buttonForSecomdtPolimom_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }


		private void firstPolinomial_TextChanged(object sender, EventArgs e)
		{
		}

		private void secondPolinomial_TextChanged(object sender, EventArgs e)
		{
		}


		private void buttonForStart_Click(object sender, EventArgs e)
		{
			buttonForSubtraction.Enabled = true;
			buttonForSummation.Enabled = true;
			buttonForSave.Enabled = true;
		}

		private void buttonForSummation_Click(object sender, EventArgs e)
		{
			fPol = new List<List<int>>();
			sPol = new List<List<int>>();
			N = new List<int>();
			r = new List<List<int>>();
			List<int> result = new List<int>();

			createPol(firstPolinomial.Text, fPol);
			createPol(secondPolinomial.Text, sPol);
			balancingPolinomial();
			textBoxForResult.Text = summ(result);
			createPol(textBoxForResult.Text, r);
		}

		private void buttonForSubtraction_Click(object sender, EventArgs e)
		{
			fPol = new List<List<int>>();
			sPol = new List<List<int>>();
			N = new List<int>();
			r = new List<List<int>>();
			List<int> result = new List<int>();

			createPol(firstPolinomial.Text, fPol);
			createPol(secondPolinomial.Text, sPol);
			balancingPolinomial();
			textBoxForResult.Text = sub(result);
			//createPol(textBoxForResult.Text, r);
		}

		private void buttonForSave_Click(object sender, EventArgs e)
		{
			openFileDialog3.ShowDialog();
		}


		private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
		{
			StreamReader openFileForFirstPolonomial = new StreamReader(openFileDialog1.FileName, Encoding.Default);
			firstPolinomial.AppendText(openFileForFirstPolonomial.ReadToEnd());
			openFileForFirstPolonomial.Close();
		}

		private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
		{
			StreamReader openFileForSecondPolonomial = new StreamReader(openFileDialog2.FileName, Encoding.Default);
			secondPolinomial.AppendText(openFileForSecondPolonomial.ReadToEnd());
			openFileForSecondPolonomial.Close();
		}

		private void openFileDialog3_FileOk(object sender, CancelEventArgs e)
		{
			StreamWriter saveFale = new StreamWriter(openFileDialog3.FileName);
			saveFale.WriteLine(textBoxForResult.Text);
			saveFale.Close();
		}


		private void createPol(string text, List<List<int>> list)
		{
			string[] coefficients = text.Split(' ');

			for (int j = 0; j < coefficients.Length; j++)
			{
				List<int> coefficient = new List<int>();
				for (int i = 0; i < coefficients[j].Length; i++)
					coefficient.Add(int.Parse(coefficients[j][i].ToString()));

				list.Add(coefficient);
			}
		}

		private void balancingPolinomial()
		{
			int max = 0;
			if (fPol.Count < sPol.Count) max = sPol.Count;
			else max = fPol.Count;

			N.Add(0);

			if (fPol.Count < max)
				do
				{
					fPol.Insert(0, N);
				} while (fPol.Count < max);
			else if (sPol.Count < max)
				do
				{
					sPol.Insert(0, N);
				} while (sPol.Count < max);
		}

		private void balancingCoefficient(int i)
		{
			int max = 0;
			if (fPol[i].Count < sPol[i].Count) max = sPol[i].Count;
			else max = fPol[i].Count;

			if (fPol[i].Count < max)
				do
				{
					fPol[i].Insert(0, 0);
				} while (fPol[i].Count < max);
			else if (sPol[i].Count < max)
				do
				{
					sPol[i].Insert(0, 0);
				} while (sPol[i].Count < max);
		}

		public void print(List<List<int>> list)
		{
			textBoxForResult.Text = null;
			for (int i = 0; i < list.Count; i++)
			{
				for (int j = 0; j < list[i].Count; j++)
					textBoxForResult.AppendText(list[i][j].ToString());
				textBoxForResult.AppendText(", ");
			}
		}

		public string summ(List<int> result)
		{
			List<TimeSpan> resTime1 = new List<TimeSpan>();
			List<TimeSpan> resTime2 = new List<TimeSpan>();

			string res = "";
			int ch = 0;
			do
			{
				res = "";
				DateTime time1 = DateTime.Now;
				Stopwatch stopWatch = new Stopwatch();
				stopWatch.Start();

				bool flag = false;
				for (int i = 0; i < fPol.Count; i++)
				{
					result = new List<int>();
					balancingCoefficient(i);
					for (int j = fPol[i].Count - 1; j >= 0; j--)
					{
						int sum = fPol[i][j] + sPol[i][j];
						if (sum >= 10)
						{
							result.Insert(0, sum - 10);

							for (int k = 1; ; k++)
							{
								if (j - k < 0)
								{
									flag = true;
									break;
								}

								if (fPol[i][j - k] >= 9)
									fPol[i][j - k] = 0;
								else
								{
									fPol[i][j - k] += 1;
									break;
								}
							}
						}
						else result.Insert(0, sum);
					}
					if (flag)
						res += "1";
					foreach (var el in result)
						res += el;
					for (int t = 0; t < res.Count(); t++)
					{
						if (res[t] == '0')
							res = res.Remove(t, 1);
						else break;
					}

					res += " ";
					flag = false;
				}

				DateTime time2 = DateTime.Now;
				stopWatch.Stop();
				resTime1.Add(stopWatch.Elapsed);
				resTime2.Add(time2-time1);
				ch++;
			} while (ch < 1000);

			long t1 = 0;
			long t2 = 0;

			foreach (var el in resTime1)
				t1 += el.Ticks;
			foreach (var el in resTime2)
				t2 += el.Ticks;

			textBoxForTime1.Text = (t1 / 1000).ToString() + " ticks";
			textBoxForTime2.Text = (t2 / 1000).ToString() + " ticks";
			return res;
		}

		public string sub(List<int> result)
		{
			List<TimeSpan> resTime1 = new List<TimeSpan>();
			List<TimeSpan> resTime2 = new List<TimeSpan>();

			string res = "";
			int ch = 0;
			do
			{
				res = "";
				DateTime time1 = DateTime.Now;
				Stopwatch stopWatch = new Stopwatch();
				stopWatch.Start();

				List<int> a = new List<int>();
				List<int> b = new List<int>();
				res = "";
				bool flag1 = false;
				bool flag2 = false;

				for (int i = 0; i < fPol.Count; i++)
				{
					result = new List<int>();
					balancingCoefficient(i);
					int l;
					for (l = 0; l < fPol[i].Count; l++)
					{
						if (fPol[i][l] > sPol[i][l])
						{
							a = fPol[i];
							b = sPol[i];
							break;
						}
						else if (fPol[i][l] < sPol[i][l])
						{
							a = sPol[i];
							b = fPol[i];
							flag2 = true;
							break;
						}
					}
					if (l == fPol[i].Count)
						res += "0";
					else
					{
						for (int j = a.Count - 1; j >= 0; j--)
						{
							if (a[j] < b[j])
							{
								a[j] += 10;
								for (int k = 1; ; k++)
								{
									if (a[j - k] == 0)
										a[j - k] = 9;
									else
									{
										a[j - k] -= 1;
										break;
									}
								}
							}
							int sub = a[j] - b[j];
							result.Insert(0, sub);
						}
						if (flag2)
							res += "-";
						if (flag1)
							res += "1";
						foreach (var el in result)
							res += el;
						for (int t = 0; t < res.Count(); t++)
						{
							if (res[t] != '-')
							{
								if (res[t] == '0')
									res = res.Remove(t, 1);
								else break;
							}
						}
					}
					res += " ";
					flag1 = false;
					flag2 = false;
				}
				DateTime time2 = DateTime.Now;
				stopWatch.Stop();
				resTime1.Add(stopWatch.Elapsed);
				resTime2.Add(time2 - time1);
				ch++;
			} while (ch < 1000);

			long t1 = 0;
			long t2 = 0;

			foreach (var el in resTime1)
				t1 += el.Ticks;
			foreach (var el in resTime2)
				t2 += el.Ticks;

			textBoxForTime1.Text = (t1 / 1000).ToString() + " ticks";
			textBoxForTime2.Text = (t2 / 1000).ToString() + " ticks";

			return res;
		}
	}
}
