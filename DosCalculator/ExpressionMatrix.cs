using System;
using MathNet.Symbolics;

namespace DosCalculator
{
    public class ExpressionMatrix
    {
        private readonly Expression[,] _data;

        public int M { get; }

        public int N { get; }

        public bool IsSquare => M == N;

        public Expression this[int x, int y]
        {
            get => _data[x, y];
            set => _data[x, y] = value;
        }

        public ExpressionMatrix(int m, int n)
        {
            M = m;
            N = n;
            _data = new Expression[m, n];
            ProcessFunctionOverData((i, j) => _data[i, j] = 0);
        }


        public ExpressionMatrix Set(int x, int y, string expression)
        {
            _data[x, y] = Infix.ParseOrThrow(expression);
            return this;
        }

        public void ProcessFunctionOverData(Action<int, int> func)
        {
            for (var i = 0; i < M; i++)
            {
                for (var j = 0; j < N; j++)
                {
                    func(i, j);
                }
            }
        }

        public static ExpressionMatrix CreateIdentityMatrix(int m, int n)
        {
            var result = new ExpressionMatrix(m, n);
            for (var i = 0; i < n; i++)
            {
                result[i, i] = 1;
            }

            return result;
        }

        public ExpressionMatrix CreateTransposeMatrix()
        {
            var result = new ExpressionMatrix(M, N);
            result.ProcessFunctionOverData((i, j) => result[i, j] = this[j, i]);
            return result;
        }

        public Expression CalculateDeterminant()
        {
            if (!IsSquare)
                throw new InvalidOperationException("determinant can be calculated only for square matrix");

            if (N == 2)
                return this[0, 0] * this[1, 1] - this[0, 1] * this[1, 0];

            Expression result = 0;
            for (var j = 0; j < N; j++)
            {
                result += (j % 2 == 1 ? 1 : -1) * this[1, j] *
                          CreateMatrixWithoutColumn(j).CreateMatrixWithoutRow(1).CalculateDeterminant();
            }

            return result;
        }

        public Expression CalculateSubmatrixDeterminant(int numbers)
        {
            var result = CreateMatrixWithoutRow(numbers);
            result = result.CreateMatrixWithoutColumn(numbers);

            return result.CalculateDeterminant();
        }

        private ExpressionMatrix CreateMatrixWithoutRow(int row)
        {
            if (row < 0 || row >= M)
                throw new ArgumentException("invalid row index");

            var result = new ExpressionMatrix(M - 1, N);
            result.ProcessFunctionOverData((i, j) => result[i, j] = i < row ? this[i, j] : this[i + 1, j]);
            return result;
        }

        private ExpressionMatrix CreateMatrixWithoutColumn(int column)
        {
            if (column < 0 || column >= N)
                throw new ArgumentException("invalid column index");

            var result = new ExpressionMatrix(M, N - 1);
            result.ProcessFunctionOverData((i, j) => result[i, j] = j < column ? this[i, j] : this[i, j + 1]);

            return result;
        }

        #region Operators

        public static ExpressionMatrix operator *(ExpressionMatrix expressionMatrix, double value)
        {
            var result = new ExpressionMatrix(expressionMatrix.M, expressionMatrix.N);
            result.ProcessFunctionOverData((i, j) => result[i, j] = expressionMatrix[i, j] * value);
            return result;
        }

        public static ExpressionMatrix operator *(ExpressionMatrix expressionMatrix, ExpressionMatrix matrix2)
        {
            if (expressionMatrix.N != matrix2.M)
                throw new ArgumentException("matrixes can not be multiplied");

            var result = new ExpressionMatrix(expressionMatrix.M, matrix2.N);
            result.ProcessFunctionOverData((i, j) =>
            {
                for (var k = 0; k < expressionMatrix.N; k++)
                {
                    result[i, j] += expressionMatrix[i, k] * matrix2[k, j];
                }
            });

            return result;
        }

        public static ExpressionMatrix operator +(ExpressionMatrix expressionMatrix, ExpressionMatrix matrix2)
        {
            if (expressionMatrix.M != matrix2.M || expressionMatrix.N != matrix2.N)
                throw new ArgumentException("matrixes dimensions should be equal");

            var result = new ExpressionMatrix(expressionMatrix.M, expressionMatrix.N);
            result.ProcessFunctionOverData((i, j) => result[i, j] = expressionMatrix[i, j] + matrix2[i, j]);
            return result;
        }

        public static ExpressionMatrix operator -(ExpressionMatrix expressionMatrix, ExpressionMatrix matrix2)
        {
            return expressionMatrix + matrix2 * -1;
        }

        #endregion
    }
}