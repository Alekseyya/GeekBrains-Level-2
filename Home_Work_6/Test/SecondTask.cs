using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public static class SecondTask
    {
        static int[,] myArr2;
        static public int[,] GetArr { get { return myArr2; } }

        public static void FillAndTest()
        {

            do
            {
                FillArray();
            } while (!RepeatElement());


        }
        public static void Start()
        {

            int counter = 0;
            do
            {
                FillAndTest();
                PrintConsole(++counter);
            } while (!Request());

            PrintArray();

            
        }

        static void PrintConsole(int counter)
        {
            //Console.Clear();
            Console.WriteLine(counter);

        }
        static bool RepeatElement()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (ProverkaElementa(i, j))
                    {
                        continue;
                    }
                    else return false;
                }
            }

            return true;
        }

        static bool ProverkaElementa(int i, int j)
        {
            int rowTemp = j + 1;
            int columntemp = i;
            if (rowTemp > 2)
            {
                columntemp++;
                rowTemp = 0;
            }
            if (i == 2 && j == 2) return true;

            //проерка элемента myArr
            for (int row = columntemp; row < 3; row++)
            {
                for (int column = rowTemp; column < 3; column++)
                {
                    if (myArr2[i, j] == myArr2[row, column])
                    {
                        return false;
                    }

                }
                rowTemp = 0;
            }
            return true;
        }

        static void PrintArray()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    Console.Write("{0}\t", myArr2[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void FillArray()
        {
            // Объявляем двумерный массив
            myArr2 = new int[3, 3];

            Random ran = new Random();

            // Инициализируем данный массив
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    myArr2[i, j] = ran.Next(3, 12);

                }

            }

        }
        static bool Request()
        {

            //проверка первой строки
            int summFirstStr = 1;
            for (int firstStr = 0; firstStr < 3; firstStr++)
            {
                summFirstStr *= myArr2[0, firstStr];
            }
            //проверка первого столбца
            int summFirstColumn = 1;
            for (int firstColumn = 0; firstColumn < 3; firstColumn++)
            {
                summFirstColumn *= myArr2[firstColumn, 0];
            }
            //если первая строка равна первому столбцу
            if (summFirstStr == summFirstColumn)
            {
                //проверка второй строки
                int summSecondStr = 1;
                for (int secondStr = 0; secondStr < 3; secondStr++)
                {
                    summSecondStr *= myArr2[1, secondStr];
                }
                //проверка второго столбца
                int summSecondColumn = 1;
                for (int secondColumn = 0; secondColumn < 3; secondColumn++)
                {
                    summSecondColumn *= myArr2[secondColumn, 1];
                }
                //проверка второй строки
                if (summSecondStr == summSecondColumn)
                {
                    //провека третьей строки
                    int summThirdStr = 1;
                    for (int thirdStr = 0; thirdStr < 3; thirdStr++)
                    {
                        summThirdStr *= myArr2[2, thirdStr];
                    }
                    //проверка третьего столбца
                    int sumThirdColumn = 1;
                    for (int thirdColumn = 0; thirdColumn < 3; thirdColumn++)
                    {
                        sumThirdColumn *= myArr2[thirdColumn, 2];
                    }
                    if (summThirdStr == sumThirdColumn) return true;
                }
                else return false;
            }
            else return false;
            return false;


        }
    }
}
