using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Test
{
    
    class Program
    {
        
        static int[,] myArr;
        
        static void Main(string[] args)
        {


            Start();

        }
        
              
        public static void Start()
        {

            int counter = 0;
            do
            {
                do
                {
                    FillArray();
                } while (!RepeatElement());
                PrintConsole(++counter);
            } while (!Request());

            PrintArray();

            Console.ReadKey();
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
            if(rowTemp>2)
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
                    if (myArr[i, j] == myArr[row, column])
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
                    
                    Console.Write("{0}\t", myArr[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void FillArray()
        {
            // Объявляем двумерный массив
            myArr = new int[3, 3];

            Random ran = new Random();

            // Инициализируем данный массив
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    myArr[i, j] = ran.Next(3, 12);
                    
                }
                
            }
            
        }
        static bool Request()
        {

            //проверка первой строки
            int summFirstStr = 1;
            for (int firstStr = 0; firstStr < 3; firstStr++)
            {
                summFirstStr *= myArr[0, firstStr];
            }
            //проверка первого столбца
            int summFirstColumn = 1;
            for (int firstColumn = 0; firstColumn < 3; firstColumn++)
            {
                summFirstColumn *= myArr[firstColumn, 0];
            }
            //если первая строка равна первому столбцу
            if (summFirstStr == summFirstColumn)
            {
                //проверка второй строки
                int summSecondStr = 1;
                for (int secondStr = 0; secondStr < 3; secondStr++)
                {
                    summSecondStr *= myArr[1, secondStr];
                }
                //проверка второго столбца
                int summSecondColumn = 1;
                for (int secondColumn = 0; secondColumn < 3; secondColumn++)
                {
                    summSecondColumn *= myArr[secondColumn, 1];
                }
                //проверка второй строки
                if (summSecondStr == summSecondColumn)
                {
                    //провека третьей строки
                    int summThirdStr = 1;
                    for (int thirdStr = 0; thirdStr < 3; thirdStr++)
                    {
                        summThirdStr *= myArr[2, thirdStr];
                    }
                    //проверка третьего столбца
                    int sumThirdColumn = 1;
                    for (int thirdColumn = 0; thirdColumn < 3; thirdColumn++)
                    {
                        sumThirdColumn *= myArr[thirdColumn, 2];
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
