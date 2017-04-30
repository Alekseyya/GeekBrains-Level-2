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
        static public int[,] GetArr { get { return myArr; } }

        static public List<int[,]> tmpArr = new List<int[,]>();
        
        static object threadLock = new object();

        
        static void swap(int[] a, int i, int j)
        {
            int s = a[i];
            a[i] = a[j];
            a[j] = s;
        }
        static bool NextSet(int[] a, int n)
        {
            int j = n - 2;
            while (j != -1 && a[j] >= a[j + 1]) j--;
            if (j == -1)
                return false; // больше перестановок нет
            int k = n - 1;
            while (a[j] >= a[k]) k--;
            swap(a, j, k);
            int l = j + 1, r = n - 1; // сортируем оставшуюся часть последовательности
            while (l < r)
                swap(a, l++, r--);
            return true;
        }
        static void Print(int[] a, int n)  // вывод перестановки
        {
            int num = 1; // номер перестановки
            for (int i = 0; i < n; i++)
                Console.Write(a[i] + " ");

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            
            
            int n = 9;
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = 2 + i+ 1;
            Print(a, n);
            while (NextSet(a, n))
            {
                int[,] arr = new int[3, 3];
                int iteratorMassive = 0;
                for (int row = 0; row < arr.GetLength(0); row++)
                {
                    for (int coulumn = 0; coulumn <arr.GetLength(1); coulumn++)
                    {
                        arr[row, coulumn] = a[iteratorMassive];
                        iteratorMassive++;
                    }
                }
                tmpArr.Add(arr);
                //Print(a, n);
            }
                
            ParallelLoopResult result = Parallel.ForEach<int[,]>(tmpArr,
                Request);

            if (result.IsCompleted)
            {
                Console.WriteLine("результат");
            } 
            Console.ReadKey();
            

        }

        static void PrintArray(int[,] myArr)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    Console.Write("{0}\t", myArr[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void Request(int[,] myArr, ParallelLoopState pls)
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
                    if (summThirdStr == sumThirdColumn)
                    {
                        lock(threadLock)
                            PrintArray(myArr);

                    };
                }
                //else return false;
            }
            //else return false;
            //return false;


        }

        static int FactNaive(int n)
        {
            int r = 1;
            for (int i = 2; i <= n; ++i)
                r *= i;
            return r;
        }

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
                //PrintConsole(++counter);
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
