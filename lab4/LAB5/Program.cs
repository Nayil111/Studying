
using System;
using System.Collections.Generic;
using System.Text;

namespace AllLabs.Lab5
{
    class programm
    {
        /// <summary>
        /// Метод демонстрации всех заданий лабораторной работы
        /// </summary>    
        public void Demo()
        {
            // Console.WriteLine("Демо");
            // ход лабы

            Matrix exemp1 = new Matrix(5, 5);

            exemp1.Random();
            exemp1.Print();

            Console.WriteLine("Сумма:" + exemp1.Sum());

            Console.WriteLine();
            exemp1.GlavDiag();

            Console.WriteLine();
            exemp1.PassivDiag();

            Console.ReadKey();
        }

        /// <summary>
        /// Метод возвращает описание заданий лабораторной работы
        /// </summary>
        /// <returns></returns>
        /// <returns>Описание лабы</returns>
        public string Description()
        {
            return "Задание 5";
        }
        /// <summary>
        /// Метод возвращает номер лабораторной работы
        /// </summary>
        /// <returns>Номер лабы</returns>
        public int Id()
        {
            return 5;
        }

        /// <summary>
        /// Метод возвращает заголовок лабораторной работы
        /// </summary>
        /// <returns></returns>
        public string Name()
        {
            return "Лабораторная №5. OOП";
        }

        private class Matrix
        {
            public Matrix(int v1, int v2)
            {
                V1 = v1;
                V2 = v2;
            }

            public int V1 { get; }
            public int V2 { get; }

            internal void GlavDiag()
            {
                throw new NotImplementedException();
            }

            internal void PassivDiag()
            {
                throw new NotImplementedException();
            }

            internal void Print()
            {
                throw new NotImplementedException();
            }

            internal void Random()
            {
                throw new NotImplementedException();
            }

            internal string Sum()
            {
                throw new NotImplementedException();
            }
        }
    }
}