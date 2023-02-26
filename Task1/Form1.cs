using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        int[][] matrix;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            string[] lines = this.inputField.Text.Split(
                 new string[] { "\r\n", "\r", "\n" },
                             StringSplitOptions.None);
            int[][] ints= createMatrix(lines);

            int maxRow = getMaxRowСompos(ints);
            int maxCol = getMaxColСompos(ints);

            int[] arrSum = calcLineSum(getRow(ints, maxRow), getColumn(ints, maxCol));
            int[] arrDef = calcLineDef(getRow(ints, maxRow), getColumn(ints, maxCol));

            this.maxRowField.Text = $"{getMaxRowСompos(ints)}";
            this.maxColField.Text = $"{getMaxColСompos(ints)}";

            Console.WriteLine(arrToSrt(getRow(ints, maxRow)));
            Console.WriteLine(arrToSrt(getColumn(ints, maxCol)));

            this.sumField.Text = $"{arrToSrt(arrSum)}";
            this.defField.Text = $"{arrToSrt(arrDef)}";

        }

        public string arrToSrt(int[] arr)
        {
            string line = "";
            for (int i = 0; i < arr.Length; i++)
            {
                line += arr[i].ToString() + " ";
            }
            return line;
        }

        public int[] getColumn(int[][] matrix, int columnNumber)
        {
            int[] column = new int[matrix.Length];
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (j == columnNumber)
                    {
                        column[i] = matrix[i][j];
                    }
                }
            }
            return column;
        }

        public int[] getRow(int[][] matrix, int rowNumber)
        {
            
            return matrix[rowNumber];
        }

        private int[] calcLineDef(int[] rowArr, int[] colArr)
        {
            int[] defArr = new int[rowArr.Length];
            for (int i = 0; i < rowArr.Length; i++)
            {
                defArr[i] = colArr[i] - rowArr[i];
            }
            return defArr;
        }

        private int[] calcLineSum(int[] rowArr, int[] colArr)
        {
            int[] sumArr = new int[rowArr.Length];
            for (int i = 0; i < rowArr.Length; i++)
            {
                sumArr[i] = rowArr[i] + colArr[i];
            }
            return sumArr;
        }

        private int getMaxRowСompos(int[][] matrix)
        {
            int maxCom = -1;
            int maxRow = -1;

            for (int i = 0; i < matrix.Length; i++)
            {
                int curCom = 1;
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    curCom *= matrix[i][j];
                }

                if (curCom > maxCom)
                {
                    maxCom = curCom;
                    maxRow = i;
                }
            }

            return maxRow;
        }

        private int getMaxColСompos(int[][] matrix)
        {
            int maxCom = -1;
            int maxCol = -1;

            for (int i = 0; i < matrix.Length; i++)
            {
                int curCom = 1;
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    curCom *= matrix[j][i];
                }

                if (curCom > maxCom)
                {
                    maxCom = curCom;
                    maxCol = i;
                }
            }


            return maxCol;
        }

        private int[][] createMatrix(string[] arr)
        {
            int[][] matrix = new int[arr.Length][];

            for (int i = 0; i < arr.Length; i++)
            {
                string[] curStr = arr[i].Split();
                int[] curInt = new int[curStr.Length];
                for (int j = 0; j < curStr.Length; j++)
                {
                    curInt[j] = int.Parse(curStr[j]);
                }
                matrix[i] = curInt;
            }
            return matrix;
        }
    }
}
