using System;
using System.Collections.Generic;

//namespace Level1Space
//{
//    public static class Level1
//    {
//        public static int squirrel(int N)
//        {
//            int factorial = 1;
//            if (N != 0)
//            {
//                for (int i = 2; i <= N; i++)
//                {
//                    factorial *= i;
//                }
//            }
//            while (factorial >= 10)
//            {
//                factorial /= 10;
//            }
//            return factorial;
//        }
//    }
//}


//Олег катает Оксану на мотоцикле. Счётчик километража на мотоцикле не работает, но Оксана следит за временем в поездке, и за текущей скоростью. Олег хочет установить рекорд дальности совместной поездки, и просит Оксану выяснить километраж.
//Функция
//int odometer(int [] oksana) 
//получает параметром массив N целых чисел (N >= 2) с индексацией с нуля, в котором каждый чётный (с чётным индексом) элемент содержит скорость в километрах в час, а каждый нечётный (с нечётным индексом) элемент содержит время, прошедшее с начала поездки, в часах.
//Возвращает функция общее пройденное расстояние.
//Например, на входе массив [10,1,20,2], на выходе расстояние 30.
//namespace Level1Space
//{
//    public static class Level1
//    {
//        public static int odometer(int[] oksana)
//        {
//            int distance = 0;
//            for (int i = 0; i < oksana.Length - 1; i++)
//            {
//                if (i % 2 == 0)
//                {
//                    if (i > 1)
//                    {
//                        int b = oksana[i + 1] - oksana[i - 1];
//                        distance += oksana[i] *b;
//                    }
//                    else 
//                        distance += oksana[i] * oksana[i + 1];
//                    i++;
//                }
//            }
//            return distance;
//        }
//        static void Main()
//        {      
//            Console.Write("Введите размерность массива");
//            int N = Convert.ToInt32(Console.ReadLine());        
//            int[] oksana = new int[N];
//            Random rand = new Random();
//            for (int i = 0; i < N; i++) //заполнение массива
//            {
//                oksana[i] = rand.Next(1,50);
//                Console.WriteLine(i+"номер "+ oksana[i]);
//            }
//            int distance = odometer(oksana);
//            Console.WriteLine(distance);
//            Console.ReadLine();
//        }
//    }
//}


/*
 подготовительное задание №3
Освобождение Государства Квадратов

Государство Кругов подготовило группу элитных десантников, которые должны в кратчайший срок спасти соседнюю братскую страну -- Государство Квадратов, где внезапно начались гражданские бунты против интернета. Территория Государства Квадратов представляет собой прямоугольник из NxM квадратных областей, где каждая область имеет координаты 1 .. N , 1 .. M.

Десантники в день 1 высаживаются в L областей, заданных их координатами (x1, y1), (x2,y2), ... , (xl, yl) и защищают их от бунтовщиков. На следующий день (день 2) они захватывают все соседние области, прилегающие к этим областям с четырёх сторон (по вертикали и горизонтали), и далее каждый следующий день этот процесс повторяется, пока не будут взяты под контроль все бунтующие области без исключения.

Генштаб Государства Кругов требует точный план освобождения Государства Квадратов -- на какой день оно будет полностью контролироваться десантниками.

Например:

В первый день под контроль взяты две области (заштрихованы); во второй -- 8 областей (две с первого дня, сплошные синие, и шесть в текущий день, заштрихованы).
В третий день (результирующее значение -- 3) вся территория Государства Квадратов оказывается под контролем десантников.

Функция

int ConquestCampaign(int N, int M, int L, int [] battalion) 

получает первыми двумя параметрами размер Государства Квадратов NxM, а battalion содержит массив из L*2 целых чисел (L >= 1) с индексацией с нуля, в котором каждый чётный (с чётным индексом) элемент содержит очередную координату области высадки по первому измерению N, а каждый нечётный (с нечётным индексом) элемент содержит очередную координату области высадки по второму измерению M.
Не исключено, что в связи с неразберихой в командовании координаты областей высадки могут дублироваться.

На примере с картинки параметры будут такими: N = 3, M = 4, L = 2, battalion = [2,2, 3,4]

Возвращает функция день, начиная с 1, когда все области будут взяты под контроль. 
 */
//namespace Level1Space
//{
//    public static class Level1
//    {
//        public static int ConquestCampaign(int N, int M, int L, int[] battalion)
//        {
//            int k = 0;
//            int day;
//            L *= 2;
//            int[,] dynarr = new int[N*M];
//            //for (day=1; )
//            for (int i = 0; i < battalion.Length; i++)
//            {
//                if (i % 2 == 0)
//                {
//                    if ((battalion[i] > 1) && (battalion[i + 1] == 1))
//                    {
//                        dynarr[k] = battalion[i];
//                        k++;
//                        dynarr[k] = battalion[i + 1];
//                        k++;
//                    }
//                    else if (battalion[i] > 1)
//                    {
//                        dynarr[k] = battalion[i];
//                        k++;
//                        dynarr[k] = battalion[i + 1] - 1;
//                        k++;
//                    }
//                    if (battalion[i]<N)
//                    {
//                        dynarr[k] = battalion[i];
//                        k++;
//                        dynarr[k] = battalion[i + 1] + 1;
//                        k++;
//                    }
//                }
//                else
//                {
//                    if ((battalion[i] > 1) && (battalion[i - 1] == 1))
//                    {
//                        dynarr[k] = battalion[i-1];
//                        k++;
//                        dynarr[k] = battalion[i];
//                        k++;
//                    }
//                    else if (battalion[i] > 1)
//                    {
//                        dynarr[k] = battalion[i - 1] - 1;
//                        k++;
//                        dynarr[k] = battalion[i];
//                        k++;
//                    }
//                    if (battalion[i] < M)
//                    {
//                        dynarr[k] = battalion[i-1]+1;
//                        k++;
//                        dynarr[k] = battalion[i];
//                    }
//                } 
//            }
//            day++;
//            for (int i=0; i < dynarr.Length; i++)
//            {
//                Console.WriteLine(i+"й индекс равен числу "+dynarr[i] + " i ");
//            }
//            return day;
//        }
//        static void Main()
//        {
//            Console.Write("Введите размерность массива N");
//            int N = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Введите размерность массива M");
//            int M = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Введите L >= 1");
//            int L = Convert.ToInt32(Console.ReadLine());
//            L *= 2;
//            int[] battalion = new int[L];
//            Random rand = new Random();
//            for (int i = 0; i < L; i++) //заполнение массива
//            {
//                battalion[i] = rand.Next(1, L);
//                Console.WriteLine(i + " номер " + battalion[i]);
//                Console.ReadKey();
//            }
//            int day2 = ConquestCampaign(N, M, L, battalion);
//            day2++;
//            Console.WriteLine(day2);
//            Console.ReadKey();
//        }
//    }
//}
/*
 * 
Денис 0:10

    Здравствуйте, Сергей Игоревич!
    Застрял на задаче "Освобождение Государства Квадратов". Подскажите пожалуйста каким путем идти?
    Поиск соседей я вроде сделал, у меня выходит вот такое (x-1,y), (x+1,y),(x,y-1),(x,y+1)
    Как теперь это обернуть: как заполнитьновый массив чтобы на каждый день в массиве были новые значения. 

Сергей
Сергей 9:48

    Добрый день, Денис!
    Алгоритм такой:
    Заводите массив NxM, исходно все нули.
    В каждой клетке где высадились десантники прописываете 1, во всех остальных 0. Потом в цикле (так как массив двумерный, нужны два цикла конечно), на каждой итерации сперва увеличиваете на +1 все ненулевые клетки ,

    потом во все те пустые клетки у которых соседи больше или равны +2, ставите +1,

    и потом проверяете, остались ли ещё пустые клетки. Если не осталось, значит закончилось.

    И считаете кол-во таких циклов, это и будет кол-во дней.

    Для этого делаете ещё один внешний цикл, уже while, в который вкладываете эту итерацию по двумерному массиву (лучше её отдельной функцией оформить),
    он выполняется "пока" просто по какому-то флажку, который принимает true если пустых клеток больше не осталось.
*/
#region Попытка 1
//namespace Level1Space
//{
//    public static class Level1
//    {
//        public static int ConquestCampaign(int N, int M, int L, int[] battalion)
//        {
//            int[,] dynarr = new int[N,M];
//            #region заполняем массив нулями
//            for (int i = 0; i < N; i++)
//            {
//                for (int j = 0; j < M; j++)
//                {
//                    dynarr[i, j] = 0;
//                }
//                Console.WriteLine("");
//            }
//            #endregion
//            #region заполняем +1 
//            for (int i = 0; i < battalion.Length-1;  i++)
//            {
//                if (i % 2 == 0)
//                {
//                    int a = battalion[i];
//                    int b = battalion[i + 1];
//                    dynarr[a, b] = 1;
//                }
//                else
//                    continue;
//            }
//            int day = 1;
//            #endregion
//            #region увеличиваем на +1 ненулевые клетки
//            for (int i = 0; i < N; i++)
//            {
//                for (int j = 0; j < M; j++)
//                {
//                    if (dynarr[i, j] != 0)
//                        dynarr[i, j]++;
//                }
//                Console.WriteLine("");
//            }
//            #endregion
//            bool prizn = false;
//            while (prizn == false)
//            {
//                int k = 0;
//                #region +1 соседи
//                for (int i = 0; i < N; i++)
//                {
//                    for (int j = 0; j < M; j++)
//                    {
//                        //if (dynarr[i, j] != 0)
//                        //    dynarr[i, j]++;
//                        if (dynarr[i, j] >= 2)
//                        {
//                            if (i > 0)
//                                dynarr[i - 1, j] ++;
//                            if (i < N - 1)
//                                dynarr[i + 1, j] ++;
//                            if (j > 0)
//                                dynarr[i, j - 1] ++;
//                            if (j < M - 1)
//                                dynarr[i, j + 1] ++;
//                        }
//                    }
//                }
//                for (int i = 0; i < N; i++)
//                {
//                    for (int j = 0; j < M; j++)
//                    {
//                        if (dynarr[i, j] == 0)
//                            k++;
//                        else
//                            continue;
//                    }
//                }
//                if (k == 0)
//                {
//                    prizn = true;
//                    if (prizn == true)
//                        break;
//                }
//                day++;
//            }
//            #endregion
//            return day;
//        }
//        static void Main()
//        {
//            Console.Write("Введите размерность массива N");
//            int N = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Введите размерность массива M");
//            int M = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Введите L >= 1");
//            int L = Convert.ToInt32(Console.ReadLine());
//            L *= 2;
//            int[] battalion = new int[L];
//            Random rand = new Random();
//            for (int i = 0; i < L; i++) //заполнение массива
//            {
//                if (N<M)
//                    battalion[i] = rand.Next(1, N);
//                else
//                    battalion[i] = rand.Next(1, M);
//                Console.WriteLine(i + " номер " + battalion[i]);
//                Console.ReadKey();
//            }
//            int day2 = ConquestCampaign(N, M, L, battalion);
//            Console.WriteLine("колв-о дней " + day2);
//            Console.ReadKey();
//        }
//    }
//}
#endregion
#region Попытка 2
//namespace Level1Space
//{
//    public static class Level1
//    {
//        public static int ConquestCampaign(int N, int M, int L, int[] battalion)
//        {
//            int[,] dynarr = new int[N, M];
//            for (int i = 0; i < N; i++)
//            {
//                for (int j = 0; j < M; j++)
//                {
//                    dynarr[i, j] = 0;
//                }
//            }
//            for (int i = 0; i < battalion.Length - 1; i++)
//            {
//                if (i % 2 == 0)
//                {
//                    int a = battalion[i];
//                    int b = battalion[i + 1];
//                    dynarr[a, b] = 1;
//                }
//                else
//                    continue;
//            }
//            int day = 1;
//            bool prizn = false;
//            while (prizn == false)
//            {
//                int k = 0;
//                for (int i = 0; i < N; i++)
//                {
//                    for (int j = 0; j < M; j++)
//                    {
//                        if (dynarr[i, j] != 0)
//                            dynarr[i, j]++;
//                        if (dynarr[i, j] >= 2)
//                        {
//                            if (i > 0)
//                                dynarr[i - 1, j]++;
//                            if (i < N - 1)
//                                dynarr[i + 1, j]++;
//                            if (j > 0)
//                                dynarr[i, j - 1]++;
//                            if (j < M - 1)
//                                dynarr[i, j + 1]++;
//                        }
//                    }
//                }
//                day++;
//                for (int i = 0; i < N; i++)
//                {
//                    for (int j = 0; j < M; j++)
//                    {
//                        if (dynarr[i, j] == 0)
//                            k++;
//                    }
//                }
//                if (k == 0)
//                {
//                    prizn = true;
//                    break;
//                }
//            }
//            return day;
//        }

//        static void Main()
//        {
//            Console.Write("Введите размерность массива N");
//            int N = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Введите размерность массива M");
//            int M = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Введите L >= 1");
//            int L = Convert.ToInt32(Console.ReadLine());
//            L *= 2;
//            int[] battalion = new int[L];
//            Random rand = new Random();
//            for (int i = 0; i < L; i++) //заполнение массива
//            {
//                if (N <= M)
//                    battalion[i] = rand.Next(1, M);
//                else
//                    battalion[i] = rand.Next(1, N);
//                Console.WriteLine(i + " номер " + battalion[i]);
//                Console.ReadKey();
//            }

//            int day = ConquestCampaign(N, M, L, battalion);
//            Console.WriteLine("колв-о дней " + day);
//            Console.ReadKey();
//        }
//    }
//}
#endregion
#region Попытка 3_c выводом на экран
//namespace Level1Space
//{
//    public static class Level1
//    {
//        public static int ConquestCampaign(int N, int M, int L, int[] battalion)
//        {
//            int[,] dynarr = new int[N+1, M+1];
//            for (int i = 1; i <= N; i++)
//            {
//                for (int j = 1; j <= M; j++)
//                {
//                    dynarr[Level1.S(i), Level1.S(j)] = 0;
//                }
//            }
//            for (int i = 1; i <= N; i++)
//            {
//                for (int j = 1; j <= M; j++)
//                {
//                    Console.Write("i " + Level1.S(i) + " j" + Level1.S(j) + "i " + i + " j" + j + " число "+dynarr[Level1.S(i), Level1.S(j)]);
//                    Console.WriteLine(" ");
//                }
//            }
//            for (int i = 0; i < battalion.Length; i++)
//            {
//                if (i % 2 == 0)
//                {
//                    int a = battalion[i];
//                    int b = battalion[i + 1];
//                    Console.Write(a+" "+b+" "+" "+ dynarr[a, b]);
//                    Console.WriteLine(" ");
//                    dynarr[a, b] = 1;
//                }
//                else
//                    continue;
//            }
//            int day = 1;
//            day = WhileDo(N, M, day, dynarr);
//            return day;
//        }
//        public static int S(int indexE)
//        {
//            return indexE - 1;
//        }
//        public static int WhileDo(int N, int M, int day, int[,] dynarr)
//        {
//            bool prizn = false;
//            while (prizn == false)

//            {
//                int k = 0;
//                for (int i = 0; i < N; i++)
//                {
//                    for (int j = 0; j < M; j++)
//                    {
//                        if (dynarr[i, j] != 0)
//                            dynarr[i, j]++;
//                        if (dynarr[i, j] >= 2)
//                        {
//                            if (i > 0)
//                                dynarr[i - 1, j]++;
//                            if (i < N - 1)
//                                dynarr[i + 1, j]++;
//                            if (j > 0)
//                                dynarr[i, j - 1]++;
//                            if (j < M - 1)
//                                dynarr[i, j + 1]++;
//                        }
//                    }
//                }
//                day++;
//                for (int i = 0; i < N; i++)
//                {
//                    for (int j = 0; j < M; j++)
//                    {
//                        if (dynarr[i, j] == 0)
//                            k++;
//                    }
//                }
//                if (k == 0)
//                {
//                    prizn = true;
//                    break;
//                }
//            }
//            return day;
//        } 
//        static void Main()
//        {
//            Console.Write("Введите размерность массива N");
//            int N = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Введите размерность массива M");
//            int M = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Введите L >= 1");
//            int L = Convert.ToInt32(Console.ReadLine());
//            L *= 2;
//            int[] battalion = new int[L];
//            Random rand = new Random();
//            for (int i = 0; i < L; i++) //заполнение массива
//            {
//                if (i % 2 == 0)
//                    battalion[i] = rand.Next(1, N);
//                else
//                    battalion[i] = rand.Next(1, M);
//                Console.WriteLine(i + " номер " + battalion[i]);
//                Console.ReadKey();
//            }

//            int day = ConquestCampaign(N, M, L, battalion);
//            Console.WriteLine("колв-о дней " + day);
//            Console.ReadKey();
//        }
//    }
//}
#endregion
#region Попытка 4_ Тест закончился ошибкой:
//ConquestCampaign(3, 4, 3, [2, 2, 2, 2, 3, 4]) = 3
//namespace Level1Space
//{
//    public static class Level1
//    {
//        public static int ConquestCampaign(int N, int M, int L, int[] battalion)
//        {
//            int[,] dynarr = new int[N + 1, M + 1];
//            for (int i = 1; i <= N; i++)
//            {
//                for (int j = 1; j <= M; j++)
//                {
//                    dynarr[Level1.S(i), Level1.S(j)] = 0;
//                }
//            }
//            for (int i = 0; i < battalion.Length; i++) 
//            {
//                Console.Write(i + " - "  + battalion[i]);
//                Console.WriteLine(" ");
//            }
//            for (int i = 0; i < battalion.Length; i++)
//            {
//                if (i % 2 == 0)
//                {
//                    int a = battalion[i];
//                    int b = battalion[i + 1];

//                    dynarr[a-1, b-1] = 1;
//                }
//                else
//                    continue;
//            }
//            for (int i = 1; i <= N; i++)
//            {
//                for (int j = 1; j <= M; j++)
//                {
//                    Console.Write(Level1.S(i)+" " + 
//                        Level1.S(j) + " число " + dynarr[Level1.S(i), Level1.S(j)]);
//                    Console.WriteLine(" ");
//                }
//            }
//            int day = 1;
//            day = WhileDo(N, M, day, dynarr);
//            return day;
//        }
//        public static int S(int indexE)
//        {
//            return indexE - 1;
//        }
//        public static int WhileDo(int N, int M, int day, int[,] dynarr)
//        {
//            bool prizn = false;
//            while (prizn == false)
//            {
//                int k = 0;
//                for (int i = 1; i <= N; i++)
//                {
//                    for (int j = 1; j <= M; j++)
//                    {
//                        if (dynarr[Level1.S(i), Level1.S(j)] != 0)
//                            dynarr[Level1.S(i), Level1.S(j)]++;
//                        if (dynarr[Level1.S(i), Level1.S(j)] >= 2)
//                        {
//                            if (Level1.S(i) > 0)
//                                dynarr[Level1.S(i) - 1, Level1.S(j)]++;
//                            if (Level1.S(i) < N - 1)
//                                dynarr[Level1.S(i) + 1, Level1.S(j)]++;
//                            if (Level1.S(j) > 0)
//                                dynarr[i, Level1.S(j) - 1]++;
//                            if (Level1.S(j) < M - 1)
//                                dynarr[Level1.S(i), Level1.S(j) + 1]++;
//                        }
//                    }
//                }
//                day++;
//                for (int i = 1; i <= N; i++)
//                {
//                    for (int j = 1; j <= M; j++)
//                    {
//                        if (dynarr[Level1.S(i), Level1.S(j)] == 0)
//                            k++;
//                    }
//                }
//                if (k == 0)
//                {
//                    prizn = true;
//                    break;
//                }
//            }
//            return day;
//        }
//        static void Main()
//        {
//            Console.Write("Введите размерность массива N");
//            int N = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Введите размерность массива M");
//            int M = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Введите L >= 1");
//            int L = Convert.ToInt32(Console.ReadLine());
//            L *= 2;
//            //int[] battalion = new int[L];
//            int[] battalion = new int[6] { 2, 2, 2, 2, 3, 4 };
//            //Random rand = new Random();
//            //for (int i = 0; i < L; i++) //заполнение массива
//            //{
//            //    if (i % 2 == 0)
//            //        battalion[i] = rand.Next(1, N);
//            //    else
//            //        battalion[i] = rand.Next(1, M);
//            //Console.WriteLine(i + " номер " + battalion[i]);
//            //Console.ReadKey();
//            //int day = ConquestCampaign(N, M, L, battalion);
//            int day = ConquestCampaign(3, 4, 3, battalion);
//            Console.WriteLine("колв-о дней " + day);
//            Console.ReadKey();
//        }
//    }
//}
#endregion
#region Попытка 5 с выводом
//namespace Level1Space
//{
//    public static class Level1
//    {
//        public static int ConquestCampaign(int N, int M, int L, int[] battalion)
//        {
//            int[,] dynarr = new int[N, M];
//            for (int i = 1; i <= N; i++)
//            {
//                for (int j = 1; j <= M; j++)
//                {
//                    dynarr[Level1.S(i), Level1.S(j)] = 0;
//                }
//            }
//            for (int i = 0; i < battalion.Length; i++)
//            {
//                Console.Write(i + " - " + battalion[i]);
//                Console.WriteLine(" ");
//            }
//            for (int i = 0; i < battalion.Length; i++)
//            {
//                if (i % 2 == 0)
//                {
//                    int a = battalion[i];
//                    int b = battalion[i + 1];

//                    dynarr[a - 1, b - 1] = 1;
//                }
//                else
//                    continue;
//            }
//            for (int i = 1; i <= N; i++)
//            {
//                for (int j = 1; j <= M; j++)
//                {
//                    Console.Write(Level1.S(i) + " " + Level1.S(j) + " число " + dynarr[Level1.S(i), Level1.S(j)]);
//                    Console.WriteLine(" ");
//                }
//            }
//            int day = 1;
//            day = WhileDo(N, M, day, dynarr);
//            return day;
//        }
//        public static int S(int indexE)
//        {
//            return indexE - 1;
//        }
//        public static int WhileDo(int N, int M, int day, int[,] dynarr)
//        {
//            bool prizn = false;
//            for (int i = 1; i <= N; i++)
//            {
//                for (int j = 1; j <= M; j++)
//                {
//                    Console.Write(dynarr[Level1.S(i), Level1.S(j)] + " ");
//                }
//                Console.WriteLine(" ");
//            }
//            while (prizn == false)
//            {
//                int k = 0;
//                for (int i = 1; i <= N; i++)
//                {
//                    for (int j = 1; j <= M; j++)
//                    {
//                        if (dynarr[Level1.S(i), Level1.S(j)] == 0)
//                            k++;
//                    }
//                }
//                if (k == 0)
//                {
//                    prizn = true;
//                    break;
//                }
//                for (int i = 1; i <= N; i++)
//                {
//                    for (int j = 1; j <= M; j++)
//                    {
//                        if (dynarr[Level1.S(i), Level1.S(j)] != 0)
//                            dynarr[Level1.S(i), Level1.S(j)]++;
//                    }
//                }
//                for (int t = 1; t <= N; t++)
//                {
//                    for (int r = 1; r <= M; r++)
//                    {
//                        Console.Write(dynarr[Level1.S(t), Level1.S(r)] + " ");
//                    }
//                    Console.WriteLine(" ");
//                }
//                for (int i = 1; i <= N; i++)
//                {
//                    for (int j = 1; j <= M; j++)
//                    {
//                        if (dynarr[Level1.S(i), Level1.S(j)] >= 2)
//                        {
//                            if (Level1.S(i) > 0)
//                                dynarr[Level1.S(i) - 1, Level1.S(j)]++;
//                            if (Level1.S(i) < N - 1)
//                                dynarr[Level1.S(i) + 1, Level1.S(j)]++;
//                            if (Level1.S(j) > 0)
//                                dynarr[Level1.S(i), Level1.S(j) - 1]++;
//                            if (Level1.S(j) < M - 1)
//                                dynarr[Level1.S(i), Level1.S(j) + 1]++;
//                        }
//                    }
//                }
//                for (int i = 1; i <= N; i++)
//                {
//                    for (int j = 1; j <= M; j++)
//                    {
//                        Console.Write(dynarr[Level1.S(i), Level1.S(j)] + " ");
//                    }
//                    Console.WriteLine(" ");
//                }
//                day++;
//                Console.WriteLine(" день " + day);
//            }
//            return day;
//        }
//        static void Main()
//        {
//            Console.Write("Введите размерность массива N");
//            int N = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Введите размерность массива M");
//            int M = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Введите L >= 1");
//            int L = Convert.ToInt32(Console.ReadLine());
//            L *= 2;
//            //int[] battalion = new int[L];
//            int[] battalion = new int[12] { 1, 1, 1, 2, 1, 3, 2, 1, 2, 2, 2, 3 };
//            //Random rand = new Random();
//            //for (int i = 0; i < L; i++) //заполнение массива
//            //{
//            //    if (i % 2 == 0)
//            //        battalion[i] = rand.Next(1, N);
//            //    else
//            //        battalion[i] = rand.Next(1, M);
//            //    Console.WriteLine(i + " номер " + battalion[i]);
//            //    Console.ReadKey();
//            //}
//            //int day = ConquestCampaign(N, M, L, battalion);
//            int day = ConquestCampaign(2, 3, 6, battalion);
//            Console.WriteLine("кол-во дней " + day);
//            Console.ReadKey();
//        }
//    }
//}
#endregion
#region Попытка 5 без вывода
//namespace Level1Space
//{
//    public static class Level1
//    {
//        public static int ConquestCampaign(int N, int M, int L, int[] battalion)
//        {
//            int[,] dynarr = new int[N, M];
//            for (int i = 1; i <= N; i++)
//            {
//                for (int j = 1; j <= M; j++)
//                {
//                    dynarr[Level1.S(i), Level1.S(j)] = 0;
//                }
//            }
//            for (int i = 0; i < battalion.Length; i++)
//            {
//                if (i % 2 == 0)
//                {
//                    int a = battalion[i];
//                    int b = battalion[i + 1];
//                    dynarr[a - 1, b - 1] = 1;
//                }
//                else
//                    continue;
//            }
//            int day = 1;
//            day = WhileDo(N, M, day, dynarr);
//            return day;
//        }
//        public static int S(int indexE)
//        {
//            return indexE - 1;
//        }
//        public static int WhileDo(int N, int M, int day, int[,] dynarr)
//        {
//            bool prizn = false;
//            while (prizn == false)
//            {
//                int k = 0;
//                for (int i = 1; i <= N; i++)
//                {
//                    for (int j = 1; j <= M; j++)
//                    {
//                        if (dynarr[Level1.S(i), Level1.S(j)] == 0)
//                            k++;
//                    }
//                }
//                if (k == 0)
//                {
//                    prizn = true;
//                    break;
//                }
//                for (int i = 1; i <= N; i++)
//                {
//                    for (int j = 1; j <= M; j++)
//                    {
//                        if (dynarr[Level1.S(i), Level1.S(j)] != 0)
//                            dynarr[Level1.S(i), Level1.S(j)]++;
//                    }
//                }
//                for (int i = 1; i <= N; i++)
//                {
//                    for (int j = 1; j <= M; j++)
//                    {
//                        if (dynarr[Level1.S(i), Level1.S(j)] >= 2)
//                        {
//                            if (Level1.S(i) > 0)
//                                dynarr[Level1.S(i) - 1, Level1.S(j)]++;
//                            if (Level1.S(i) < N - 1)
//                                dynarr[Level1.S(i) + 1, Level1.S(j)]++;
//                            if (Level1.S(j) > 0)
//                                dynarr[Level1.S(i), Level1.S(j) - 1]++;
//                            if (Level1.S(j) < M - 1)
//                                dynarr[Level1.S(i), Level1.S(j) + 1]++;
//                        }
//                    }
//                }
//                day++;
//            }
//            return day;
//        }
//        static void Main()
//        {
//            Console.Write("Введите размерность массива N");
//            int N = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Введите размерность массива M");
//            int M = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Введите L >= 1");
//            int L = Convert.ToInt32(Console.ReadLine());
//            L *= 2;
//            //int[] battalion = new int[L];
//            int[] battalion = new int[12] { 1, 1, 1, 2, 1, 3, 2, 1, 2, 2, 2, 3 };
//            //Random rand = new Random();
//            //for (int i = 0; i < L; i++) //заполнение массива
//            //{
//            //    if (i % 2 == 0)
//            //        battalion[i] = rand.Next(1, N);
//            //    else
//            //        battalion[i] = rand.Next(1, M);
//            //    Console.WriteLine(i + " номер " + battalion[i]);
//            //    Console.ReadKey();

//            //}
//            //int day = ConquestCampaign(N, M, L, battalion);
//            int day = ConquestCampaign(2, 3, 6, battalion);
//            Console.WriteLine("кол-во дней " + day);
//            Console.ReadKey();
//        }
//    }
//}
#endregion

/*-------------------------------------------------------------------------------------------------------------------------------------------------*/
//Задача №4 "Безумный Макс"
/*
Безумный Макс Рокатански, офицер Главного Силового Патруля, ремонтирует свой восьмицилиндровый Перехватчик, чтобы продолжить погоню за Ночным Ездоком. Не дайте Ездоку добраться до банды Потрошителей, помогите Максу правильно настроить машину патруля.
Бортовой софт Перехватчика генерирует телеметрический массив -- неповторяющиеся целые числа в диапазоне от 0 до 255, общим количеством N (длина массива), которое всегда нечётно. В общем случае эти значения в массиве будут случайно перемешаны.
1 <= N <= 127
Для достижения максимального количества оборотов двигателю требуется корректный стартовый импульс. Он представляет собой массив, центральным элементом которого будет максимальное его значение, все левые элементы упорядочены по возрастанию (причём первый левый элемент -- самый минимальный в массиве), а все правые -- по убыванию.
Например, на входе массив из семи элементов, N=7:

1 2 3 4 5 6 7 
Эти элементы могут быть случайно перемешаны.

На выходе должно быть:
1 2 3 7 6 5 4

Функция
int [] MadMax(int N, int [] Tele)
получает на вход массив Tele из N чисел, и возвращает результирующий массив-импульс. 
 */
//#region попытка №1 с выводом
//namespace Level1Space
//{
//    public static class Level1
//    {
//        public static int[] MadMax(int N, int[] Tele)
//        {
//            //по возрастанию
//            for (int i = 0; i < N - 1; i++)
//            {
//                for (int j = i + 1; j < N; j++)
//                {
//                    if (Tele[i] > Tele[j])
//                    {
//                        int b = Tele[i];
//                        Tele[i] = Tele[j];
//                        Tele[j] = b;
//                    }
//                }
//            }
//            for (int i = 0; i < N; i++)
//            {
//                Console.WriteLine(i + " номер " + Tele[i]);
//                Console.ReadKey();
//            }
//            decimal P = (decimal)N / 2; ;
//            int M = (int)Math.Round(P);
//            // Сортируем по убыванию
//            for (int i = M-1; i < N; i++)
//            {
//                for (int j = i; j < N-1; j++)
//                {
//                    if (Tele[i] < Tele[j+1])
//                    {
//                        int b = Tele[i];
//                        Tele[i] = Tele[j+1];
//                        Tele[j+1] = b;
//                    }
//                }
//            }
//            for (int i = 0; i < N; i++)
//            {
//                Console.WriteLine(i + " номер " + Tele[i]);
//                Console.ReadKey();
//            }
//            return Tele;
//        }
//        static void Main()
//        {
//            //Console.Write("Введите размерность массива N (1 <= N <= 127). N всегда нечетно");
//            //int N = Convert.ToInt32(Console.ReadLine());
//            //-------
//            //int[] Tele = new int[N];
//            //Random rand = new Random();
//            //for (int i = 0; i < N; i++) //заполнение массива
//            //{
//            //    Tele[i] = rand.Next(1, N);
//            //    Console.WriteLine(i + " номер " + Tele[i]);
//            //    Console.ReadKey();
//            //}
//            //int[] Impuls = MadMax(N, Tele);
//            //------
//            int[] Tele = new int[7] { 2, 1, 0, 0, 4, 6, 7 };
//            int[] Impuls = MadMax(7, Tele);
//            for (int i = 0; i < 7; i++) 
//            {
//                Console.WriteLine(i + "p номер " + Impuls[i]);
//                Console.ReadKey();
//            }
//        }
//    }
//}

//#endregion
#region попытка №1 без вывода
//namespace Level1Space
//{
//    public static class Level1
//    {
//        public static int [] MadMax(int N, int [] Tele)
//        {
//            if (N > 1)
//            {
//                for (int i = 0; i < N - 1; i++)
//                {
//                    for (int j = i + 1; j < N; j++)
//                    {
//                        if (Tele[i] > Tele[j])
//                        {
//                            int b = Tele[i];
//                            Tele[i] = Tele[j];
//                            Tele[j] = b;
//                        }
//                    }
//                }
//                decimal P = (decimal)N / 2; ;
//                int M = (int)Math.Round(P);
//                for (int i = M - 1; i < N; i++)
//                {
//                    for (int j = i; j < N - 1; j++)
//                    {
//                        if (Tele[i] < Tele[j + 1])
//                        {
//                            int b = Tele[i];
//                            Tele[i] = Tele[j + 1];
//                            Tele[j + 1] = b;
//                        }
//                    }
//                }
//            }            
//            return Tele;
//        }
//        static void Main()
//        {
//            //Console.Write("Введите размерность массива N (1 <= N <= 127). N всегда нечетно");
//            //int N = Convert.ToInt32(Console.ReadLine());
//            //int[] Tele = new int[N];
//            //Random rand = new Random();
//            //for (int i = 0; i < N; i++) //заполнение массива
//            //{
//            //    Tele[i] = rand.Next(1, N);
//            //    Console.WriteLine(i + " номер " + Tele[i]);
//            //    Console.ReadKey();
//            //}

//            //int[] Impuls = MadMax(N, Tele);
//            //------
//            //int[] Tele = Level1.MadMax(7, new int[] { 1, 2, 3, 4, 5, 6, 7 });
//            int[] Impuls = Level1.MadMax(2, new int[] { 1,1 });
//            for (int i = 0; i < 2; i++)
//            {
//                Console.WriteLine(i + "p номер " + Impuls[i]);
//                Console.ReadKey();
//            }
//        }
//    }
//}

#endregion

/*-------------------------------------------------------------------------------------------------------------------------------------------------*/
//Задача №5 "Восстановление таблицы зарплат"
/*
 Взятый на прошлой неделе на работу джуниор Олег случайно удалил в базе таблицу, в которой хранилась информация о взаимосвязях учётных номеров сотрудников и их зарплат. Только вы помните на память алгоритм этой связи; требуется срочно восстановить таблицу и сформировать ведомость зарплат в точном соответствии зарплаты и номера сотрудника.
Номера сотрудников -- это целые положительные числа. Они некоторым особо упорядоченным способом хранятся в списке сотрудников; номер каждого сотрудника уникален, повторяющихся нету. Пример списка сотрудников: [50, 1, 1024]
Зарплаты -- тоже целые положительные числа. Они хранятся в отдельном списке зарплат, по размеру равном списку сотрудников, но могут повторяться по значениям. Пример списка зарплат: [20000, 100000, 90000]
Известно, что список сотрудников однозначно соответствует списку зарплат, если отсортировать по возрастанию список номеров и список зарплат. То есть номеру 50 соответствует зарплата 90000, номеру 1 - 20000, номеру 1024 -- 100000.
Ваша задача -- перестроить список зарплат, не трогая список номеров, так, чтобы соблюдалось правильное соответствие номер-зарплата. В данном примере список зарплат должен получиться таким: [90000, 20000, 100000]

Функция
int [] SynchronizingTables(int N, int [] ids, int [] salary) 
получает параметром N длину обоих массивов. Параметр ids -- массив, содержащий номера сотрудников, параметр salary -- массив, содержащий зарплаты.
Возвращает функция массив, содержащий переупорядоченные зарплаты.  
 */
//#region Попытка №1 с выводом
//namespace Level1Space
//{
//    public static class Level1
//    {
//        public static int[] SynchronizingTables(int N, int[] ids, int[] salary)
//        {
//            int[] ids2 = new int[N];
//            Array.Copy(ids, ids2, N);
//            //int[] salary = new int[N];
//            int[] ReSalary2 = new int[N];
//            if (N > 1)
//            {
//                for (int i = 0; i < N - 1; i++) // сортировка по возрастанию массива ids2
//                {
//                    for (int j = i + 1; j < N; j++)
//                    {
//                        if (ids2[i] > ids2[j])
//                        {
//                            int b = ids2[i];
//                            ids2[i] = ids2[j];
//                            ids2[j] = b;
//                        }
//                    }
//                }
//                for (int i = 0; i < N; i++)
//                {
//                    Console.Write(ids2[i] + " ");
//                }
//                Console.WriteLine();
//                for (int i = 0; i < N - 1; i++) // сортировка по возрастанию массива salary
//                {
//                    for (int j = i + 1; j < N; j++)
//                    {
//                        if (salary[i] > salary[j])
//                        {
//                            int b = salary[i];
//                            salary[i] = salary[j];
//                            salary[j] = b;
//                        }
//                    }
//                }
//                for (int i = 0; i < N; i++)
//                {
//                    Console.Write(salary[i] + " ");
//                }
//                Console.WriteLine();
//                //объединяем два массива в двумерный
//                int[,] Concantenated = new int[N, 2];
//                for (int i = 0; i < N; i++)
//                    Concantenated[i, 0] = ids2[i];
//                for (int i = 0; i < N; i++)
//                    Concantenated[i, 1] = salary[i];
//                Console.WriteLine();
//                for (int i = 0; i < N; i++)
//                {
//                    for (int j = 0; j < 2; j++)
//                    {
//                        Console.Write(Concantenated[i,j]+" ");
//                    }
//                    Console.WriteLine();
//                }
//                Console.ReadKey();
//                // ищем элементы масива ids в двумерном массиве
//                int k=0;
//                for (int i = 0; i < N; i++) 
//                {
//                    for (int j = 0; j < N; j++)
//                    {
//                        if (ids[i] == Concantenated[j, 0])
//                        {
//                            ReSalary2[k] = Concantenated[j, 1];
//                            k++;
//                            break;
//                        }
//                    }
//                }
//                for (int i = 0; i < N; i++)
//                {
//                    Console.Write(ReSalary2[i]+ " ");
//                    Console.WriteLine();
//                }
//                Console.ReadKey();
//            }
//            return ReSalary2;
//        }
//        static void Main()
//        {
//            //Console.Write("Введите размерность массива N ");
//            //int N = Convert.ToInt32(Console.ReadLine());
//            //int[] ids = new int[N];
//            //int[] salary = new int[N];
//            //Random rand = new Random();
//            //for (int i = 0; i < N; ++i) //заполнение массива ids уникальными целыми числами
//            //{
//            //    bool isUnique;
//            //    do
//            //    {
//            //        ids[i] = rand.Next(1, 1 + N);
//            //        isUnique = true;
//            //        for (int j = 0; j < i; ++j)
//            //            if (ids[i] == ids[j])
//            //            {
//            //                isUnique = false;
//            //                break;
//            //            }
//            //    } while (!isUnique);
//            //    Console.Write(ids[i]+" ");
//            //}
//            //Console.WriteLine();
//            //for (int i = 0; i < N; i++) 
//            //{
//            //    salary[i] = rand.Next(1000, 1000000);
//            //    Console.Write(salary[i]+" ");
//            //}
//            //Console.WriteLine();
//            //Console.ReadKey();
//            //--
//            int[] ids = new int[3] { 50, 1, 1024 };
//            int[] salary = new int[3] { 20000, 100000, 90000 };
//            //--
//            int[] ReSalary2 = SynchronizingTables(3, ids, salary);
//            //------

//            for (int i = 0; i < 3; i++)
//            {
//                Console.Write(ReSalary2[i] + " ");
//            }
//            Console.WriteLine();
//            Console.ReadKey();
//        }
//    }
//}
//#endregion
//#region Попытка №1 без вывода
//namespace Level1Space
//{
//    public static class Level1
//    {
//        public static int [] SynchronizingTables(int N, int [] ids, int [] salary)
//        {
//            int[] ids2 = new int[N];
//            Array.Copy(ids, ids2, N);
//            int[] ReSalary2 = new int[N];
//            if (N > 1)
//            {
//                for (int i = 0; i < N - 1; i++)
//                {
//                    for (int j = i + 1; j < N; j++)
//                    {
//                        if (ids2[i] > ids2[j])
//                        {
//                            int b = ids2[i];
//                            ids2[i] = ids2[j];
//                            ids2[j] = b;
//                        }
//                    }
//                }
//                for (int i = 0; i < N - 1; i++) 
//                {
//                    for (int j = i + 1; j < N; j++)
//                    {
//                        if (salary[i] > salary[j])
//                        {
//                            int b = salary[i];
//                            salary[i] = salary[j];
//                            salary[j] = b;
//                        }
//                    }
//                }
//                int[,] Concantenated = new int[N, 2];
//                for (int i = 0; i < N; i++)
//                    Concantenated[i, 0] = ids2[i];
//                for (int i = 0; i < N; i++)
//                    Concantenated[i, 1] = salary[i];
//                int k = 0;
//                for (int i = 0; i < N; i++)
//                {
//                    for (int j = 0; j < N; j++)
//                    {
//                        if (ids[i] == Concantenated[j, 0])
//                        {
//                            ReSalary2[k] = Concantenated[j, 1];
//                            k++;
//                            break;
//                        }
//                    }
//                }
//            }
//            return ReSalary2;
//        }
//        static void Main()
//        {
//            //Console.Write("Введите размерность массива N ");
//            //int N = Convert.ToInt32(Console.ReadLine());
//            //int[] ids = new int[N];
//            //int[] salary = new int[N];
//            //Random rand = new Random();
//            //for (int i = 0; i < N; ++i) //заполнение массива ids уникальными целыми числами
//            //{
//            //    bool isUnique;
//            //    do
//            //    {
//            //        ids[i] = rand.Next(1, 1 + N);
//            //        isUnique = true;
//            //        for (int j = 0; j < i; ++j)
//            //            if (ids[i] == ids[j])
//            //            {
//            //                isUnique = false;
//            //                break;
//            //            }
//            //    } while (!isUnique);
//            //    Console.Write(ids[i]+" ");
//            //}
//            //Console.WriteLine();
//            //for (int i = 0; i < N; i++) 
//            //{
//            //    salary[i] = rand.Next(1000, 1000000);
//            //    Console.Write(salary[i]+" ");
//            //}
//            //Console.WriteLine();
//            //Console.ReadKey();
//            //--
//            int[] ids = new int[3] { 50, 1, 1024 };
//            int[] salary = new int[3] { 20000, 100000, 90000 };
//            //--
//            int[] ReSalary2 = SynchronizingTables(3, ids, salary);
//            //------

//            for (int i = 0; i < 3; i++)
//            {
//                Console.Write(ReSalary2[i] + " ");
//            }
//            Console.WriteLine();
//            Console.ReadKey();
//        }
//    }
//}
//#endregion
/*-------------------------------------------------------------------------------------------------------------------------------------------------*/
//Задача №6 "Разблокировка мобильных телефонов"
/* Условие задачи
 Код блокировки мобильных телефонов не умеют взламывать даже спецслужбы, однако хакерская группировка Анонимусы-80 добралась до исходников операционной системы, и выяснила способ его почти мгновенного взлома.
Оказывается, достаточно лишь посчитать длину линии, рисуемой в процессе взлома кода, после чего округлить её до пятого знака, и нажать пальцем на соответствующие цифры, пропуская нули, как телефон разблокируется.
Раскладка точек блокировки:
Ломаная линия разблокировки представляет собой последовательность цифр от 1 до 9, соответствующих точкам на этой картинке, причем гарантируется, что от точки переход совершается только к её ближайшим соседям (нету перепрыгиваний, например из точки 8 в точку 5).
Расстояние между точками по вертикали или горизонтали считается единичным.

6  1  9
5  2  8
4  3  7

На рисунке представлена такая последовательность: 1 2 3 4 5 6 2 7 8 9
Её длина приблизительно равняется 1 + 1 + 1 + 1 + 1 + 1.41.. + 1.41.. + 1 + 1 = 9.82843
(точность требуется пять цифр после запятой)
Результат: строка "982843"
Если бы результат получился, например, 10.012, то результирующая строка получилась бы "112" (все нули удаляются).

Функция
string PatternUnlock(int N, int [] hits) 
получает параметром N длину массива с кодами разблокировки, а сам массив hits содержит последовательность кодов разблокировки -- номера точек в диапазоне от 1 до 9.
Последовательность задаётся только шагами между соседними точками, программно искать "длинные" пути не нужно.
Серые линии на рисунке -- просто пример возможной траектории.

Возвращает функция строку, как в примере выше. 
 */
/* Алгоритм
 * 1. заполнить двумерный массив 3,3
 * 2. сформировать одномерный массив случайных чисел
 * 3. сформировать линию: найти все элементы одномерного массива по порядку в двумерном массиве и записать координаты в одномерный новый массив
 * 4. если сумма разницы по модулю двух сосдених четных чисел и двух соседних нечетных числе равна 2 то к счетчику прибавляем 1,414213, 
 * иначе прибавляем 1
 * 5. округляем полученную сумму до 5-го знака
 * 6. преобразуем в строку и удаляем 0
 * 7. учесть ситуацию когда N=1 или полученная сумма равна 1 или целому числу
 * 7 return 
 * */
//#region Попытка №1 с выводом
//namespace Level1Space
//{
//    public static class Level1
//    {
//        public static string PatternUnlock(int N, int[] hits)
//        {
//            if (N > 1)
//            {
//                int[,] block = new int[3, 3] { { 6, 1, 9 }, { 5, 2, 8 }, { 4, 3, 7 } };
//                for (int i = 0; i < 3; i++)
//                {
//                    for (int j = 0; j < 3; j++)
//                    {
//                        Console.Write(block[i, j] + " ");
//                    }
//                    Console.WriteLine();
//                }
//                // ищем элементы масива hits в двумерном массиве block
//                int k1 = 0;
//                int k2 = 0;
//                int k3 = 0;
//                Console.Write("hits ");
//                for (int i = 0; i < N; i++)
//                {
//                    Console.Write(hits[i] + " ");
//                }
//                Console.WriteLine();
//                int M = N * 2;
//                int[] coord = new int[M];
//                for (int i = 0; i < M; i++)
//                {
//                    for (int j = 0; j < 3; j++)
//                    {
//                        if (hits[k3] == block[k2, j])
//                        {
//                            //coord[k1] = block[k2, j];
//                            coord[k1] = k2;
//                            Console.WriteLine("индекс " + k1 + " число " + coord[k1] + " ");
//                            k1++;
//                            coord[k1] = j;
//                            Console.WriteLine("индекс " + k1 + " число " + coord[k1] + " ");
//                            k1++;
//                            k3++;
//                            k2 = 0;
//                            break;
//                        }
//                    }
//                    if (k2 == 2)
//                        k2 = 0;
//                    else
//                        k2++;
//                    if (k3 == N)
//                        break;
//                }
//                Console.Write("coord ");
//                for (int i = 0; i < M; i++)
//                {
//                    Console.Write(coord[i] + " ");
//                }
//                Console.WriteLine();
//                double summ = 0;
//                for (int i = 0; i < M - 2; i++)
//                {
//                    if (i % 2 == 0)
//                    {
//                        if ((Math.Abs(coord[i] - coord[i + 2]) + Math.Abs(coord[i + 1] - coord[i + 3])) == 1)
//                            summ++;
//                        else
//                            summ += 1.414213;
//                    }
//                }
//                Console.WriteLine("summ " + summ + " ");
//                summ = Math.Round(summ, 5);
//                Console.WriteLine("2summ " + summ + " ");
//                //summ = String.Format("{0:0.0}", summ);
//                string summ2 = summ.ToString(format: "0.00000000");
//                Console.WriteLine("summ2 " + summ2 + " ");
//                summ2 = summ2.Replace(@",", "").Replace(@"0", "");
//                return summ2;
//            }
//            else
//                return "1";
//        }
//        static void Main()
//        {
//            int[] hits = new int[12] { 1,2,3,4,5,2,8,2,6,1,8,7};
//            string Unlock = PatternUnlock(12, hits);
//            Console.WriteLine(" " + Unlock);
//            Console.ReadKey();
//        }
//    }
//}
//#endregion
#region Попытка №1 без вывода
//namespace Level1Space
//{
//    public static class Level1
//    {
//        public static string PatternUnlock(int N, int[] hits)
//        {
//            if (N > 1)
//            {
//                int[,] block = new int[3, 3] { { 6, 1, 9 }, { 5, 2, 8 }, { 4, 3, 7 } };
//                int k1 = 0;
//                int k2 = 0;
//                int k3 = 0;
//                int M = N * 2;
//                int[] coord = new int[M];
//                for (int i = 0; i < M; i++)
//                {
//                    for (int j = 0; j < 3; j++)
//                    {
//                        if (hits[k3] == block[k2, j])
//                        {
//                            coord[k1] = k2;
//                            k1++;
//                            coord[k1] = j;
//                            k1++;
//                            k3++;
//                            k2 = 0;
//                            break;
//                        }
//                    }
//                    if (k2 == 2)
//                        k2 = 0;
//                    else
//                        k2++;
//                    if (k3 == N)
//                        break;
//                }
//                double summ = 0;
//                for (int i = 0; i < M - 2; i++)
//                {
//                    if (i % 2 == 0)
//                    {
//                        if ((Math.Abs(coord[i] - coord[i + 2]) + Math.Abs(coord[i + 1] - coord[i + 3])) == 1)
//                            summ++;
//                        else
//                            summ += 1.414213;
//                    }
//                }
//                summ = Math.Round(summ, 5);
//                string summ2 = summ.ToString(format: "0.00000000");
//                summ2 = summ2.Replace(@",", "").Replace(@"0", "");
//                return summ2;
//            }
//            else
//                return "0";
//        }
//        static void Main()
//        {
//            int[] hits = new int[2] { 1, 8};
//            string Unlock = PatternUnlock(2, hits);
//            Console.WriteLine(Unlock);
//            Console.ReadKey();
//        }
//    }
//}
#endregion

/*-------------------------------------------------------------------------------------------------------------------------------------------------*/
//Задача №7 "Конкурент Google" было 5 или 6 попыток. успешно - 08.03.2021

/* Условие задачи
 Ваш стартап получил миллионные инвестиции на создание нового поискового движка.
Требуется срочно реализовать базовый алгоритм поиска, чтобы отчитаться перед инвесторами.
На вход алгоритма поступает текстовая строка достаточно большой длины. Все слова в ней разделены ровно одним пробелом. Алгоритм обрабатывает строку в два шага:


1) строка разбивается на набор строк через выравнивание по заданной ширине.
Разбивать строку разрешается только в местах пробелов, слова надо переносить целиком, если они меньше или равны длине разбивки. Например, имеется строка

1) строка разбивается на набор строк через выравнивание по заданной ширине.

и задана ширина разбивки 12.

Тогда на первом шаге будет получена такая последовательность строк:

1) строка 
разбивается
на набор
строк через
выравнивание
по заданной
ширине.

Пустые строки в такой разбивке полностью исключаются. Если ширина разбивки меньше какого-то слова, то это слово разбивается на несколько (с переносом на следующую строку).

2) Каждая строка проверяется на наличие в ней заданного целого слова (ограниченного либо пробелами, либо началом/концом строки).

Результат работы алгоритма -- последовательность целых чисел 1 или 0, которые показывают, имеется ли в соответствующей строке запрошенное слово.

Например, для слова "строк" результат будет таким: 0 0 0 1 0 0 0

Функция

int [] WordSearch(int len, string s, string subs) 

получает параметром len ширину выравнивания, саму строку в параметре s, и проверяемое слово в параметре subs.

Возвращает функция массив целых чисел, содержащий 1 или 0 (признаки нахождения слова в соответствующей строке). 
 */
/* Алгоритм
 * 1. сформировать двумерный массив N,0
 * 2. поиск подстроки subs в строке s
 * 3. заполнить двумерный массив N,0
 * 4. сформировать одномерный массив целых чисел 1 0
 * 5. учесть ситуацию когда N=1 или полученная сумма равна 1 или целому числу
 * 6 return 
 * */
#region Попытка №1 с выводом
//namespace Level1Space
//{
//    public static class Level1
//    {
//        public static int[] WordSearch(int len, string s, string subs)
//        {
//            char[] s1 = s.ToCharArray();
//            string[,] s3 = new string[len, len];
//            int k = 0;
//            int i;
//            int j = 0;
//            for (i = 0; i < len; i++)
//            {
//                bool twelve = false;
//                for (j = 0; j < len; j++)
//                {
//                    if (k < s.Length) // пока строка не закончилась
//                    {
//                        if (s1[k].ToString() == " ")
//                            twelve = true;
//                        // если первый символ пробел или последний символ пробел и следующий пробел
//                        if (((j == 0) && (s1[k].ToString() == " ")) || ((s1[k].ToString() == " ") && (s1[k + 1].ToString() == " ")))
//                        {
//                            if (k == s.Length - 1) // если это последний символ в строке прерываем
//                                break;
//                            else
//                            {
//                                k++; //переходим к следующей
//                                s3[i, j] = s1[k].ToString();
//                            }
//                            //continue;
//                        }
//                        else
//                            s3[i, j] = s1[k].ToString(); //иначе продолжаем
//                        //Console.Write(s3[i, j]);
//                        if (k == s.Length - 1) // если это последний символ в строке прерываем
//                            break;
//                        else
//                            k++; //иначе переходим к следующей
//                    }
//                }
//                // Console.WriteLine();
//                if (k == s.Length - 1) // если это последний символ в строке прерываем
//                    break;
//                else
//                    if ((s[k].ToString() != " ") && (s[k - 1].ToString() != " ")) //если при переходе последний символ и первый символ не пробелы
//                {
//                    int z = k; //запоминаем к
//                    for (int d = j - 1; d >= 0; d--)
//                    {
//                        if (s3[i, d].ToString() == " ")
//                        {
//                            //k--;
//                            break;
//                        }
//                        else if ((d == 0) && (s3[i, d].ToString() != " ")) //если слово без пробелов значит ширина меньше длины слова, то возвращаем позицию к K
//                            k = z;
//                        else
//                        {
//                            if (twelve == true)
//                                s3[i, d] = "";
//                            k--;
//                        }
//                        //Console.Write(s3[i, d]);
//                    }
//                    //Console.WriteLine();
//                }
//            }
//            //for (int d = 0; d < len; d++)
//            //{
//            //    for (int b = 0; b < len; b++)
//            //    {
//            //        Console.Write(s3[d, b]);
//            //    }
//            //    Console.WriteLine(d + " ");
//            //}
//            //Console.WriteLine();
//            string[] s4 = new string[len];
//            bool w = false;
//            int a, g;
//            for (a = 0; a < len; a++)
//            {
//                for (g = 0; g < len; g++)
//                {
//                    if (s3[a, g] != null)
//                    {
//                        s4[a] += s3[a, g];
//                        Console.WriteLine("index " + a + " " + s4[a] + " ");
//                    }
//                    else
//                    {
//                        w = true;
//                        Array.Resize(ref s4, a + 1);
//                        break;
//                    }
//                }
//                Console.WriteLine();
//                if (w == true)
//                {
//                    a++;
//                    break;
//                }
//            }
//            Console.WriteLine();
//            for (int c = 0; c < a; c++)
//            {
//                Console.Write(s4[c]);
//                Console.WriteLine();
//            }
//            int[] result = new int[a];
//            ///<summary> Поиск слова в массиве </summary>
//            for (int c = 0; c < a; c++)
//            {
//                string values = s4[c].ToString();
//                string subs3 = subs.Substring(0, 1); //c

//                if (values.Contains(subs))
//                {
//                    for (int m = 0; m < a; m++)
//                    {
//                        if (m == 0)
//                        {
//                            if ((m + subs.Length) >= a+1)
//                            {
//                                if (s3[c, m] == subs3)
//                                {
//                                    result[c] = 1;
//                                    break;
//                                }
//                            }
//                            else if ((m + subs.Length) < a+1)
//                            {
//                                if ((s3[c, m] == subs3) && ((s3[c, m + a] == " ") || s3[c, m + a] == null))
//                                {
//                                    result[c] = 1;
//                                    break;
//                                }
//                            }
//                        }
//                        else if (m != 0)
//                        {
//                            if ((s3[c, m] == subs3) && (s3[c, m - 1] == " ") && ((s3[c, m + subs.Length] == " ") || s3[c, m + subs.Length] == null))
//                            {
//                                result[c] = 1;
//                                break;
//                            }
//                        }
//                        else
//                            result[c] = 0;
//                    }
//                }
//                else
//                    result[c] = 0;
//                Console.Write(result[c] + " ");
//                Console.WriteLine();
//            }
//            return result;
//        }
//        static void Main()
//        {
//            string s = "12345";
//            string subs = "123";
//            int len = 3;
//            //string s = "1) строкаппппппп разбивается на набор строк через выравнивание по заданной ширине.";
//            //string subs = "строк";
//            //int len = 12;
//            int[] findword;
//            findword = WordSearch(len, s, subs);
//            for (int i = 0; i < findword.Length; i++)
//            {
//                Console.Write(findword[i] + " ");
//            }
//            Console.ReadKey();
//        }
//    }
//}
#endregion
#region Попытка №1 без вывода
//namespace Level1Space
//{
//    public static class Level1
//    {
//        public static int[] WordSearch(int len, string s, string subs)
//        {
//            char[] s1 = s.ToCharArray();
//            string[,] s3 = new string[len, len];
//            int k = 0;
//            int i;
//            int j = 0;
//            for (i = 0; i < len; i++)
//            {
//                bool twelve = false;
//                for (j = 0; j < len; j++)
//                {
//                    if (k < s.Length)
//                    {
//                        if (s1[k].ToString() == " ")
//                            twelve = true;
//                        if (((j == 0) && (s1[k].ToString() == " ")) || ((s1[k].ToString() == " ") && (s1[k + 1].ToString() == " ")))
//                        {
//                            if (k == s.Length - 1)
//                                break;
//                            else
//                                k++;
//                            continue;
//                        }
//                        else
//                            s3[i, j] = s1[k].ToString();
//                        if (k == s.Length - 1)
//                            break;
//                        else
//                            k++;
//                    }
//                }
//                if (k == s.Length - 1)
//                    break;
//                else
//                    if ((s[k].ToString() != " ") && (s[k - 1].ToString() != " "))
//                {
//                    int z = k;
//                    for (int a = j - 1; a >= 0; a--)
//                    {
//                        if (s3[i, a].ToString() == " ")
//                        {
//                            break;
//                        }
//                        else if ((a == 0) && (s3[i, a].ToString() != " "))
//                            k = z;
//                        else
//                        {
//                            if (twelve == true)
//                                s3[i, a] = "";
//                            k--;
//                        }
//                    }
//                }
//            }
//            string[] s4 = new string[j];
//            for (int a = 0; a < j; a++)
//            {
//                for (int b = 0; b < len; b++)
//                {
//                    s4[a] += s3[a, b];
//                }
//            }
//            int[] result = new int[j];
//            for (int a = 0; a < j; a++)
//            {
//                string values = s4[a].ToString();
//                string subs3 = subs.Substring(0, 1);
//                string subs4 = subs.Substring(subs.Length - 1);
//                if ((values.Contains(subs)) && ((s4[a].ToString().StartsWith(subs3) || (s4[a].ToString().StartsWith(" ")))) && ((s4[a].ToString().EndsWith(subs4) || (s4[a].ToString().EndsWith(" ")))))
//                    result[a] = 1;
//                else
//                    result[a] = 0;
//            }
//            return result;
//        }
//        static void Main()
//        {
//            //Console.WriteLine("Введите строку");
//            //string stroka = Console.ReadLine();
//            //Console.WriteLine("Введите подстроку");
//            //string podstroka = Console.ReadLine();
//            //if (stroka.Length < podstroka.Length)
//            //    Console.WriteLine("строка не может быть меньше подстроки");
//            //else
//            string s = "1) строк разбивается на набор сyuтрокyu через выравнивание по заданной ширине.";
//            string subs = "строк";
//            int len = 12;
//            int[] findword;
//            findword = WordSearch(len, s, subs);
//            for (int i = 0; i < findword.Length; i++)
//            {
//                Console.Write(findword[i] + " ");
//            }
//            Console.ReadKey();
//        }
//    }
//}
#endregion
#region Попытка №2 без вывода
//namespace Level1Space
//{
//    public static class Level1
//    {
//        public static int [] WordSearch(int len, string s, string subs)
//        {
//            char[] s1 = s.ToCharArray();
//            string[,] s3 = new string[len, len];
//            int k = 0;
//            int i;
//            int j = 0;
//            for (i = 0; i < len; i++)
//            {
//                bool twelve = false;
//                for (j = 0; j < len; j++)
//                {
//                    if (k < s.Length)
//                    {
//                        if (s1[k].ToString() == " ")
//                            twelve = true;
//                        if (((j == 0) && (s1[k].ToString() == " ")) || ((s1[k].ToString() == " ") && (s1[k + 1].ToString() == " ")))
//                        {
//                            if (k == s.Length - 1)
//                                break;
//                            else
//                            {
//                                k++; 
//                                s3[i, j] = s1[k].ToString();
//                            }
//                        }
//                        else
//                            s3[i, j] = s1[k].ToString();
//                        if (k == s.Length - 1)
//                            break;
//                        else
//                            k++;
//                    }
//                }
//                if (k == s.Length - 1)
//                    break;
//                else
//                    if ((s[k].ToString() != " ") && (s[k - 1].ToString() != " "))
//                {
//                    int z = k;
//                    for (int d = j - 1; d >= 0; d--)
//                    {
//                        if (s3[i, d].ToString() == " ")
//                        {
//                            break;
//                        }
//                        else if ((d == 0) && (s3[i, d].ToString() != " "))
//                            k = z;
//                        else
//                        {
//                            if (twelve == true)
//                                s3[i, d] = "";
//                            k--;
//                        }
//                    }
//                }
//            }
//            string[] s4 = new string[len];
//            bool w = false;
//            int a, g;
//            for (a = 0; a < len; a++)
//            {
//                for (g = 0; g < len; g++)
//                {
//                    if (s3[a, g] != null)
//                    {
//                        s4[a] += s3[a, g];
//                    }
//                    else
//                    {
//                        w = true;
//                        Array.Resize(ref s4, a + 1);
//                        break;
//                    }
//                }
//                if (w == true)
//                    break;
//            }
//            int[] result = new int[a + 1];
//            for (int c = 0; c < a + 1; c++)
//            {
//                string values = s4[c].ToString();
//                string subs3 = subs.Substring(0, 1);
//                string subs4 = subs[^1..];
//                if (values.Contains(subs)) 
//                {
//                    for (int m = 0; m < a + 1; m++)
//                    {
//                        if (m == 0)
//                        {
//                            if ((s3[c, m] == subs3) && ((s3[c, m + subs.Length] == " ") || s3[c, m + subs.Length] == null))
//                            {
//                                result[c] = 1;
//                                break;
//                            }
//                        }
//                        else if (m != 0)
//                        {
//                            if ((s3[c, m] == subs3) && (s3[c, m - 1] == " ") && ((s3[c, m + subs.Length] == " ") || s3[c, m + subs.Length] == null))
//                            {
//                                result[c] = 1;
//                                break;
//                            }
//                        }
//                        else
//                            result[c] = 0;
//                    }
//                }
//                else
//                    result[c] = 0;
//            }
//            return result;
//        }
//        static void Main()
//        {
//            string s = "1) строка разбивается на набор строк через выравнивание по заданной ширинечапрвапрвапрвапрвап впрвапрвап вапрвапр вапр вапр веапр.";
//            string subs = "строкаааааааа";
//            int len = 12;
//            int[] findword;
//            findword = WordSearch(len, s, subs);
//            for (int i = 0; i < findword.Length; i++)
//            {
//                Console.Write(findword[i] + " ");
//            }
//            Console.ReadKey();
//        }
//    }
//}
#endregion
#region Попытка №3 без вывода 2-я отправка
//namespace Level1Space
//{
//    public static class Level1
//    {
//        public static int[] WordSearch(int len, string s, string subs)
//        {
//            char[] s1 = s.ToCharArray();
//            string[,] s3 = new string[len, len];
//            int k = 0;
//            int i;
//            int j = 0;
//            for (i = 0; i < len; i++)
//            {
//                bool twelve = false;
//                for (j = 0; j < len; j++)
//                {
//                    if (k < s.Length)
//                    {
//                        if (s1[k].ToString() == " ")
//                            twelve = true;
//                        if (((j == 0) && (s1[k].ToString() == " ")) || ((s1[k].ToString() == " ") && (s1[k + 1].ToString() == " ")))
//                        {
//                            if (k == s.Length - 1)
//                                break;
//                            else
//                            {
//                                k++;
//                                s3[i, j] = s1[k].ToString();
//                            }
//                        }
//                        else
//                            s3[i, j] = s1[k].ToString();
//                        if (k == s.Length - 1)
//                            break;
//                        else
//                            k++;
//                    }
//                }
//                if (k == s.Length - 1)
//                    break;
//                else
//                    if ((s[k].ToString() != " ") && (s[k - 1].ToString() != " "))
//                {
//                    int z = k;
//                    for (int d = j - 1; d >= 0; d--)
//                    {
//                        if (s3[i, d].ToString() == " ")
//                        {
//                            break;
//                        }
//                        else if ((d == 0) && (s3[i, d].ToString() != " "))
//                            k = z;
//                        else
//                        {
//                            if (twelve == true)
//                                s3[i, d] = "";
//                            k--;
//                        }
//                    }
//                }
//            }
//            string[] s4 = new string[len];
//            bool w = false;
//            int a, g;
//            for (a = 0; a < len; a++)
//            {
//                for (g = 0; g < len; g++)
//                {
//                    if (s3[a, g] != null)
//                    {
//                        s4[a] += s3[a, g];
//                    }
//                    else
//                    {
//                        w = true;
//                        Array.Resize(ref s4, a + 1);
//                        break;
//                    }
//                }
//                if (w == true)
//                {
//                    a++;
//                    break;
//                }
//            }
//            int[] result = new int[a];
//            for (int c = 0; c < a; c++)
//            {
//                string values = s4[c].ToString();
//                string subs3 = subs.Substring(0, 1);
//                if (values.Contains(subs))
//                {
//                    for (int m = 0; m < a; m++)
//                    {
//                        if (m == 0)
//                        {
//                            if ((s3[c, m] == subs3) && ((s3[c, m + subs.Length] == " ") || s3[c, m + subs.Length] == null))
//                            {
//                                result[c] = 1;
//                                break;
//                            }
//                        }
//                        else if (m != 0)
//                        {
//                            if ((s3[c, m] == subs3) && (s3[c, m - 1] == " ") && ((s3[c, m + subs.Length] == " ") || s3[c, m + subs.Length] == null))
//                            {
//                                result[c] = 1;
//                                break;
//                            }
//                        }
//                        else
//                            result[c] = 0;
//                    }
//                }
//                else
//                    result[c] = 0;
//            }
//            return result;
//        }
//        static void Main()
//        {
//            string s = "1) стрвапвапва вапзбивается на набор строк через вапвапвапвапвпавапвыравнивание по заданной ширине.";
//            string subs = "строк";
//            int len = 12;
//            int[] findword;
//            findword = WordSearch(len, s, subs);
//            for (int i = 0; i < findword.Length; i++)
//            {
//                Console.Write(findword[i] + " ");
//            }
//            Console.ReadKey();
//        }
//    }
//}
#endregion
#region Попытка №4 без вывода 3-я отправка
//namespace Level1Space
//{
//    public static class Level1
//    {
//        public static int[] WordSearch(int len, string s, string subs)
//        {
//            char[] s1 = s.ToCharArray();
//            string[,] s3 = new string[len, len];
//            int k = 0;
//            int i;
//            int j;
//            for (i = 0; i < len; i++)
//            {
//                bool twelve = false;
//                for (j = 0; j < len; j++)
//                {
//                    if (k < s.Length)
//                    {
//                        if (s1[k].ToString() == " ")
//                            twelve = true;
//                        if (((j == 0) && (s1[k].ToString() == " ")) || ((s1[k].ToString() == " ") && (s1[k + 1].ToString() == " ")))
//                        {
//                            if (k == s.Length - 1)
//                                break;
//                            else
//                            {
//                                k++;
//                                s3[i, j] = s1[k].ToString();
//                            }
//                        }
//                        else
//                        {
//                            s3[i, j] = s1[k].ToString();
//                            k++; ;
//                        }
//                        if (k == s.Length)
//                            break;
//                    }
//                }
//                if (k == s.Length)
//                    break;
//                else
//                    if ((s[k].ToString() != " ") && (s[k - 1].ToString() != " "))
//                {
//                    int z = k;
//                    for (int d = j - 1; d >= 0; d--)
//                    {
//                        if (s3[i, d].ToString() == " ")
//                        {
//                            break;
//                        }
//                        else if ((d == 0) && (s3[i, d].ToString() != " "))
//                            k = z;
//                        else
//                        {
//                            if (twelve == true)
//                                s3[i, d] = "";
//                            k--;
//                        }
//                    }
//                }
//            }
//            string[] s4 = new string[len];
//            bool w = false;
//            int a, g;
//            for (a = 0; a < len; a++)
//            {
//                for (g = 0; g < len; g++)
//                {
//                    if (s3[a, g] != null)
//                    {
//                        s4[a] += s3[a, g];
//                    }
//                    else
//                    {
//                        w = true;
//                        Array.Resize(ref s4, a + 1);
//                        break;
//                    }
//                }
//                if (w == true)
//                {
//                    a++;
//                    break;
//                }
//            }
//            int[] result = new int[a];
//            for (int c = 0; c < a; c++)
//            {
//                string values = s4[c].ToString();
//                string subs3 = subs.Substring(0, 1);
//                if (values.Contains(subs))
//                {
//                    for (int m = 0; m < a; m++)
//                    {
//                        if (m == 0)
//                        {
//                            if ((m + subs.Length) >= a)
//                            {
//                                if (s3[c, m] == subs3)
//                                {
//                                    result[c] = 1;
//                                    break;
//                                }
//                            }
//                            else if ((m + subs.Length) < a )
//                            {
//                                if ((s3[c, m] == subs3) && ((s3[c, m + subs.Length] == " ") || s3[c, m + subs.Length] == null))
//                                {
//                                    result[c] = 1;
//                                    break;
//                                }
//                            }
//                        }
//                        else if (m != 0)
//                        {
//                            if ((s3[c, m] == subs3) && (s3[c, m - 1] == " ") && ((s3[c, m + subs.Length] == " ") || s3[c, m + subs.Length] == null))
//                            {
//                                result[c] = 1;
//                                break;
//                            }
//                        }
//                        else
//                            result[c] = 0;
//                    }
//                }
//                else
//                    result[c] = 0;
//            }
//            return result;
//        }
//        static void Main()
//        {
//            string s = "12";
//            string subs = "1";
//            int len = 1;
//            //string s = "1) строка разбивается на набор строквапвааааааааааааааааааааааа через выравнивание по заданной ширине.";
//            //string subs = "строк";
//            //int len = 12;
//            int[] findword;
//            findword = WordSearch(len, s, subs);
//            for (int i = 0; i < findword.Length; i++)
//            {
//                Console.Write(findword[i] + " ");
//            }
//            Console.ReadKey();
//        }
//    }
//}
#endregion
#region Попытка №5 с выводом
//namespace Level1Space
//{
//    public static class Level1
//    {
//        public static int[] WordSearch(int len, string s, string subs)
//        {
//            char[] s1 = s.ToCharArray();
//            string[,] s3 = new string[s.Length, s.Length];
//            int k = 0;
//            int i;
//            int j;
//            for (i = 0; i < s.Length; i++)
//            {
//                bool twelve = false;
//                for (j = 0; j < len; j++)
//                {
//                    if (k < s.Length)
//                    {
//                        if (s1[k].ToString() == " ")
//                            twelve = true;
//                        if (((j == 0) && (s1[k].ToString() == " ")) || ((s1[k].ToString() == " ") && (s1[k + 1].ToString() == " ")))
//                        {
//                            if (k == s.Length - 1)
//                            {
//                                k++;
//                                break;
//                            }
//                            else
//                            {
//                                k++;
//                                s3[i, j] = s1[k].ToString();
//                                k++;
//                            }
//                        }
//                        else
//                        {
//                            s3[i, j] = s1[k].ToString();
//                            if (k < s.Length)
//                                k++;
//                        }
//                        if ((k == s.Length) || (s.Length <= 1))
//                            break;
//                    }
//                }
//                if ((k == s.Length) || (s.Length <= 1))
//                    break;
//                else
//                    if ( (s[k].ToString() != " ") && (s[k - 1].ToString() != " "))
//                {
//                    int z = k;
//                    for (int d = j - 1; d >= 0; d--)
//                    {
//                        if (s3[i, d].ToString() == " ")
//                        {
//                            break;
//                        }
//                        else if ((d == 0) && (s3[i, d].ToString() != " "))
//                            k = z;
//                        else
//                        {
//                            if (twelve == true)
//                                s3[i, d] = "";
//                            k--;
//                        }
//                       // Console.Write(s3[i, d] + " ");
//                    }
//                }
//            }
//            for (int d = 0; d < s.Length; d++)
//            {
//                for (int b = 0; b < len; b++)
//                {
//                    Console.Write(s3[d, b]+ " ");
//                }
//                Console.WriteLine();
//            }
//            Console.WriteLine();
//            string[] s4 = new string[s.Length];
//            bool w = false;
//            int a, g;
//            for (a = 0; a < s.Length; a++)
//            {
//                for (g = 0; g < len; g++)
//                {
//                    if (s3[a, g] != null)
//                    {
//                        s4[a] += s3[a, g];
//                    }
//                    else
//                    {
//                        if (g != 0)
//                            a++;
//                        w = true;
//                        Array.Resize(ref s4, a); //для массива 12345678 со словом 1234 ----   a+1 -> a
//                        break;
//                    }
//                }
//                if (w == true)
//                {
//                    //a++; //для массива 12345678 со словом 1234 ----   a+1 -> a
//                    break;
//                }
//            }
//            for (int d = 0; d < a; d++)
//            {
//                Console.Write(s4[d] + " ");
//            }
//            Console.WriteLine();
//            int[] result = new int[a];
//            for (int c = 0; c < a; c++)
//            {
//                string values = s4[c].ToString();
//                string subs3 = subs.Substring(0, 1);
//                if (values.Contains(subs))
//                {
//                    for (int m = 0; m < a; m++)
//                    {
//                        if (m == 0)
//                        {
//                            if ((m + subs.Length) >= a)
//                            {
//                                if (s3[c, m] == subs3)
//                                {
//                                    result[c] = 1;
//                                    break;
//                                }
//                            }
//                            else if ((m + subs.Length) < a)
//                            {
//                                if ((s3[c, m] == subs3) && ((s3[c, m + subs.Length] == " ") || s3[c, m + subs.Length] == null))
//                                {
//                                    result[c] = 1;
//                                    break;
//                                }
//                            }
//                        }
//                        else if (m != 0)
//                        {
//                            if ((s3[c, m] == subs3) && (s3[c, m - 1] == " ") && ((s3[c, m + subs.Length] == " ") || s3[c, m + subs.Length] == null))
//                            {
//                                result[c] = 1;
//                                break;
//                            }
//                        }
//                        else
//                            result[c] = 0;
//                    }
//                }
//                else
//                    result[c] = 0;
//            }
//            return result;
//        }
//        static void Main()
//        {
//            //string s = "123 456 7899 99";
//            //string subs = "99";
//            //int len = 2;
//            string s = "1) строкsdfgsdfgа разбивается на набор строsdfgsdfgdsк через выравнивание по заданной ширине.";
//            string subs = "строк";
//            int len = 12;
//            int[] findword;
//            findword = WordSearch(len, s, subs);
//            for (int i = 0; i < findword.Length; i++)
//            {
//                Console.Write(findword[i] + " ");
//            }
//            Console.ReadKey();
//        }
//    }
//}
#endregion
#region Попытка №5 без вывода 4-я отправка, 5-я отправка - успешно.
//namespace Level1Space
//{
//    public class Level1
//    {
//        public static int[] WordSearch(int len, string s, string subs)
//        {
//            char[] s1 = s.ToCharArray();
//            string[,] s3 = new string[s.Length, s.Length];
//            int k = 0;
//            int i, j;
//            int vertical = 0;
//            int horizontal = 0;
//            for (i = 0; i < s.Length; i++)
//            {
//                bool twelve = false;
//                for (j = 0; j < len; j++)
//                {
//                    if (k < s.Length)
//                    {
//                        if (s1[k].ToString() == " ")
//                            twelve = true;
//                        if (((j == 0) && (s1[k].ToString() == " ")) || ((s1[k].ToString() == " ") && (s1[k + 1].ToString() == " ")))
//                        {
//                            if (k == s.Length - 1)
//                            {
//                                k++;
//                                if (horizontal < j)
//                                    horizontal = j;
//                                break;
//                            }
//                            else
//                            {
//                                k++;
//                                s3[i, j] = s1[k].ToString();
//                                k++;
//                            }
//                        }
//                        else
//                        {
//                            s3[i, j] = s1[k].ToString();
//                            if (k < s.Length)
//                                k++;
//                        }
//                        if ((k == s.Length) || (s.Length <= 1))
//                        {
//                            if (horizontal < j)
//                                horizontal = j;
//                            break;
//                        }
//                    }
//                }
//                if ((k == s.Length) || (s.Length <= 1))
//                {
//                    if (vertical < i)
//                        vertical = i;
//                    break;
//                }
//                else
//                    if ((s[k].ToString() != " ") && (s[k - 1].ToString() != " "))
//                {
//                    int z = k;
//                    for (int d = j - 1; d >= 0; d--)
//                    {
//                        if (s3[i, d].ToString() == " ")
//                        {
//                            break;
//                        }
//                        else if ((d == 0) && (s3[i, d].ToString() != " "))
//                            k = z;
//                        else
//                        {
//                            if (twelve == true)
//                                s3[i, d] = "";
//                            k--;
//                        }
//                    }
//                }
//            }
//            //for (int d = 0; d < s.Length; d++)
//            //{
//            //    for (int b = 0; b < horizontal+1; b++)
//            //    {
//            //         Console.Write(s3[d, b] + " ");
//            //    }
//            //    Console.WriteLine();
//            //}
//            //Console.WriteLine();
//            string[] s4 = new string[s.Length];
//            bool w = false;
//            int a, g;
//            for (a = 0; a < s.Length; a++)
//            {
//                if (len >= s.Length)
//                    len = horizontal + 1;
//                for (g = 0; g < len; g++)
//                {
//                    if (s3[a, g] != null)
//                    {
//                        s4[a] += s3[a, g];
//                    }
//                    else
//                    {
//                        if (g != 0)
//                            a++;
//                        w = true;
//                        Array.Resize(ref s4, a);
//                        break;
//                    }
//                }
//                if (w == true)
//                {
//                    break;
//                }
//            }
//            //for (int d = 0; d < a; d++)
//            //{
//            //    Console.Write(s4[d] + " ");
//            //}
//            //Console.WriteLine();
//            int[] result = new int[a];
//            for (int c = 0; c < a; c++)
//            {
//                string values = s4[c].ToString();
//                string subs3 = subs.Substring(0, 1);
//                if (values.Contains(subs))
//                {
//                    for (int m = 0; m < a; m++)
//                    {
//                        if (m == 0)
//                        {
//                            if ((m + subs.Length) >= a)
//                            {
//                                if (s3[c, m] == subs3)
//                                {
//                                    result[c] = 1;
//                                    break;
//                                }
//                            }
//                            else if ((m + subs.Length) < a)
//                            {
//                                if ((s3[c, m] == subs3) && ((s3[c, m + subs.Length] == " ") || s3[c, m + subs.Length] == null))
//                                {
//                                    result[c] = 1;
//                                    break;
//                                }
//                            }
//                        }
//                        else if (m != 0)
//                        {
//                            if ((s3[c, m] == subs3) && (s3[c, m - 1] == " ") && ((s3[c, m + subs.Length] == " ") || s3[c, m + subs.Length] == null))
//                            {
//                                result[c] = 1;
//                                break;
//                            }
//                        }
//                        else
//                            result[c] = 0;
//                    }
//                }
//                else
//                    result[c] = 0;
//            }
//            return result;
//        }

//        /// <summary> Test2 - нулевая ширина </summary>

//        public static void Main()
//        {
//            //string s = "12345";
//            //string subs = "99";
//            //int len = 3;
//            string s = "12345";
//            string subs = "123";
//            int len = 3;
//            int[] findword;
//            findword = Level1.WordSearch(len, s, subs);

//            for (int i = 0; i < findword.Length; i++)
//            {
//                Console.Write(findword[i] + " ");
//            }
//            Console.ReadKey();
//        }
//    }
//}
#endregion
#region Попытка №5 без вывода 4-я отправка, 5-я отправка - успешно.
//namespace Level1Space
//{
//    public class Level1
//    {
//        public static int[] WordSearch(int len, string s, string subs)
//        {
//            char[] s1 = s.ToCharArray();
//            string[,] s3 = new string[s.Length, s.Length];
//            int k = 0;
//            int i, j;
//            int vertical = 0;
//            int horizontal = 0;
//            for (i = 0; i < s.Length; i++)
//            {
//                bool twelve = false;
//                for (j = 0; j < len; j++)
//                {
//                    if (k < s.Length)
//                    {
//                        if (s1[k].ToString() == " ")
//                            twelve = true;
//                        if (((j == 0) && (s1[k].ToString() == " ")) || ((s1[k].ToString() == " ") && (s1[k + 1].ToString() == " ")))
//                        {
//                            if (k == s.Length - 1)
//                            {
//                                k++;
//                                if (horizontal < j)
//                                    horizontal = j;
//                                break;
//                            }
//                            else
//                            {
//                                k++;
//                                s3[i, j] = s1[k].ToString();
//                                k++;
//                            }
//                        }
//                        else
//                        {
//                            s3[i, j] = s1[k].ToString();
//                            if (k < s.Length)
//                                k++;
//                        }
//                        if ((k == s.Length) || (s.Length <= 1))
//                        {
//                            if (horizontal < j)
//                                horizontal = j;
//                            break;
//                        }
//                    }
//                }
//                if ((k == s.Length) || (s.Length <= 1))
//                {
//                    if (vertical < i)
//                        vertical = i;
//                    break;
//                }
//                else
//                    if ((s[k].ToString() != " ") && (s[k - 1].ToString() != " "))
//                {
//                    int z = k;
//                    for (int d = j - 1; d >= 0; d--)
//                    {
//                        if (s3[i, d].ToString() == " ")
//                        {
//                            break;
//                        }
//                        else if ((d == 0) && (s3[i, d].ToString() != " "))
//                            k = z;
//                        else
//                        {
//                            if (twelve == true)
//                                s3[i, d] = "";
//                            k--;
//                        }
//                    }
//                }
//            }
//            //for (int d = 0; d < s.Length; d++)
//            //{
//            //    for (int b = 0; b < horizontal+1; b++)
//            //    {
//            //         Console.Write(s3[d, b] + " ");
//            //    }
//            //    Console.WriteLine();
//            //}
//            //Console.WriteLine();
//            string[] s4 = new string[s.Length];
//            bool w = false;
//            int a, g;
//            for (a = 0; a < s.Length; a++)
//            {
//                if (len >= s.Length)
//                    len = horizontal + 1;
//                for (g = 0; g < len; g++)
//                {
//                    if (s3[a, g] != null)
//                    {
//                        s4[a] += s3[a, g];
//                    }
//                    else
//                    {
//                        if (g != 0)
//                            a++;
//                        w = true;
//                        Array.Resize(ref s4, a);
//                        break;
//                    }
//                }
//                if (w == true)
//                {
//                    break;
//                }
//            }
//            //for (int d = 0; d < a; d++)
//            //{
//            //    Console.Write(s4[d] + " ");
//            //}
//            //Console.WriteLine();
//            int[] result = new int[a];
//            for (int c = 0; c < a; c++)
//            {
//                string values = s4[c].ToString();
//                string subs3 = subs.Substring(0, 1);
//                if (values.Contains(subs))
//                {
//                    for (int m = 0; m < a; m++)
//                    {
//                        if (m == 0)
//                        {
//                            if ((m + subs.Length) >= a)
//                            {
//                                if (s3[c, m] == subs3)
//                                {
//                                    result[c] = 1;
//                                    break;
//                                }
//                            }
//                            else if ((m + subs.Length) < a)
//                            {
//                                if ((s3[c, m] == subs3) && ((s3[c, m + subs.Length] == " ") || s3[c, m + subs.Length] == null))
//                                {
//                                    result[c] = 1;
//                                    break;
//                                }
//                            }
//                        }
//                        else if (m != 0)
//                        {
//                            if ((s3[c, m] == subs3) && (s3[c, m - 1] == " ") && ((s3[c, m + subs.Length] == " ") || s3[c, m + subs.Length] == null))
//                            {
//                                result[c] = 1;
//                                break;
//                            }
//                        }
//                        else
//                            result[c] = 0;
//                    }
//                }
//                else
//                    result[c] = 0;
//            }
//            return result;
//        }

//        /// <summary> Test2 - нулевая ширина </summary>

//        public static void Main()
//        {
//            //string s = "12345";
//            //string subs = "99";
//            //int len = 3;
//            string s = "12345";
//            string subs = "123";
//            int len = 3;
//            int[] findword;
//            findword = Level1.WordSearch(len, s, subs);

//            for (int i = 0; i < findword.Length; i++)
//            {
//                Console.Write(findword[i] + " ");
//            }
//            Console.ReadKey();
//        }
//    }
//}
#endregion

/*-------------------------------------------------------------------------------------------------------------------------------------------------*/
//Задача №8 "Искусственный интеллект для Оксаны" начало 09.03.2021. 7 дней - хотя бы одно решение - 14 дней последнее.
/* Условие задачи
  Оксана работает бухгалтером и каждый день выгружает из компьютера сводку за прошедшие сутки, которая содержит все приходы и расходы организации и итог. В сводке записаны только целые числа, и точно известно, что самое последнее число есть сумма всех предыдущих чисел.

Например, варианты сводок:
100 -50 10 -25 90 -35 90
5 -25 10 -35 -45

Эти сводки Оксана красиво оформляет в отчёте так:
+100 - 50 + 10 - 25 + 90 - 35 = +90

или так:
+5 - 25 + 10 - 35 = -45

Но однажды, придя на работу, Оксана обнаружила, что компьютер заразился вирусом и принялся из вредности путать числа в сводке. Например, вместо
5 -25 10 -35 -45 

он выдаёт явно ошибочное
10 -25 -45 -35 5

!
Оксана попросила программиста Олега, специализирующегося на искусственном интеллекте, помочь ей срочно подготовить правильные отчёты. Помогите Оксане -- напишите алгоритм, который будет находить в сводке число, равное сумме всех остальных чисел.

Функция
int SumOfThe(int N, int [] data)

получает параметром N длину всей сводки (N >= 2), и далее в массиве длиной N хранится сама сводка (целые числа).
Возвращает функция целое число из сводки, которое равно сумме всех остальных чисел. 
 */
#region 
/* Алгоритм
 * тест должен генерировать последовательность целых чисел где всегда будет число равное сумме всех остальных чисел: генерировать числа равные сумме преддыдущей, потом перемешивать и передавать в функцию
 * найти число равное сумме всех остальныхъ
 * 1. сформировать двумерный массив N,0
 * 2. поиск подстроки subs в строке s
 * 3. заполнить двумерный массив N,0
 * 4. сформировать одномерный массив целых чисел 1 0
 * 5. учесть ситуацию когда N=1 или полученная сумма равна 1 или целому числу
 * 6 return 
 */
#endregion
#region
//namespace Level1Space
//{
//    public static class Level1
//    {
//        public static int SumOfThe(int N, int[] data)
//        {
//            int result = 0;
//            int sum = 0;
//            //char[] s1 = s.ToCharArray();
//            //string[,] s3 = new string[s.Length, s.Length];
//            for (int i = 0; i < data.Length; i++)
//            {
//                sum = 0;
//                for (int j = 0; j < data.Length; j++)
//                {
//                    if (i == j)
//                        continue;
//                    else
//                        sum += data[j];
//                }
//                if (data[i] == sum)
//                {
//                    result = sum;
//                    break;
//                }
//            }
//            return result;
//        }

//        /// <summary> Test2 - нулевая ширина </summary>

//        public static void Main()
//        {
//            //string s = "123 456 7899 99";
//            //string subs = "99";
//            //int len = 2;
//            string s = "1) строк разбивается на набор строк через выравнивание по заданной ширине.";
//            string subs = "строк";
//            int len = 12;
//            int[] findword;
//            findword = Level1.WordSearch(len, s, subs);
//            for (int i = 0; i < findword.Length; i++)
//            {
//                Console.Write(findword[i] + " ");
//            }
//            Console.ReadKey();
//        }
//    }
//}
#endregion

/*-------------------------------------------------------------------------------------------------------------------------------------------------*/
//Задача №9 "Миссия невыполнима: Красный портфель"
/*Условие задачи
 * 
Итан Хант с невероятным трудом пробирается в секретное хранилище данных Синдиката, в подводный бункер под электростанцией. На добытой им флешке хранятся детали банковских счетов верхушки Синдиката на сумму несколько миллиардов долларов, однако она закрыта "красным портфелем" -- очень сложной технологией шифрования.
Ваша миссия: реализовать алгоритм шифрования "Красного портфеля", который не под силу даже специалистам MI-6.
На вход программы подаётся строка текста, состоящая из строчных букв и пробелов. Из строки удаляются все пробелы и определяется её длина N.
На основании N вычисляется размер матрицы, в которую будет упакован исходный текст: из N извлекается квадратный корень, и его нижняя граница берётся как число строк матрицы, а верхняя граница -- как число столбцов. Если их произведение меньше N, увеличивайте количество строк.

Например, есть строка текста

отдай мою кроличью лапку

Она преобразуется в

отдаймоюкроличьюлапку

Длина этой строки -- 21, квадратный корень -- 4.58.
21 элемент в матрицу размером 4x5 элементов не упаковывается, значит, берём матрицу 5x5:

отдай
моюкр
оличь
юлапк
у

И наконец выдаём зашифрованный результат, выдавая символы по столбцам сверху вниз и слева направо, и разделяя столбцы пробелами:

омоюу толл дюиа акчп йрьк

Напишите код, зашифровывающий текстовое сообщение, и декодировщик, расшифровывающий его.

Функция

string TheRabbitsFoot(string s, bool encode)

получает исходную строку s и либо зашифровывает её (encode = true), либо расшифровывает (encode = false), только конечно без исходных пробелов. 
*/
#region Попытка №2 с выводом
//namespace Level1Space 
//{
//    public static class Level1
//    {
//        public static string TheRabbitsFoot(string s, bool encode)
//        {
//            if (encode == true)
//            {
//                //убираем пробелы
//                s = s.Replace(" ", string.Empty);
//                Console.Write(s);
//                Console.WriteLine();
//                //вычислить длину строки
//                double root = Math.Sqrt(s.Length);
//                int down = (int)Math.Floor(root);
//                int up = (int)Math.Ceiling(root);
//                if (down * up < s.Length)
//                    down++;
//                //char[] s1 = s.ToCharArray();
//                string[,] matrix = new string[up, down];
//                //упаковывваем в матрицу
//                int k = 0;
//                for (int i = 0; i < up; i++)
//                {
//                    for (int j = 0; j < down; j++)
//                    {
//                        if (k < s.Length)
//                        {
//                            matrix[i, j] = s[k].ToString();
//                            k++;
//                            Console.Write(matrix[i, j]);
//                        }
//                        else
//                            break;
//                    }
//                    Console.WriteLine();
//                }
//                //преобразуем матрицу в одномерный массив
//                //объявить одномерный массив
//                int p = down * up;
//                string[] massiv = new string[p];
//                k = 0;
//                string result="";
//                for (int i = 0; i < up; i++)
//                {
//                    for (int j = 0; j < down; j++)
//                    {
//                        if (k < p)
//                        {
//                            //massiv[k] = matrix[j, i];
//                            result += matrix[j, i];
//                            Console.Write(massiv[k]);
//                            k++;
//                        }
//                        else
//                            break;
//                    }
//                    result += " ";
//                    Console.Write("  ");
//                }
//                Console.WriteLine();
//                //string result = massiv.ToString();
//                //string str = string.Join(" ", massiv);
//                //for (int i = 0; i < p; i++)
//                //{
//                //    massiv[i] = massiv[i].ToString();
//                //}
//                //Console.Write("  ");
//                return result;
//            }
//            else
//            {
//                //6. убрать пробелы
//                //5. вычислить длину строки
//                //4. вычислдить квадратный корень от длины строки
//                //3. вычислить нижнюю границу и верхнюю границу округлив 
//                //2. упаковать в матрицу N*M
//                //1. одномерный массив по столбцам сверху вниз
//                string s1 = s.Replace(" ", string.Empty);

//                //вычислить длину строки
//                double root = Math.Sqrt(s1.Length);
//                int down = (int)Math.Floor(root);
//                int up = (int)Math.Ceiling(root);
//                if (down * up < s1.Length)
//                    down++;
//                //string[] massiv;
//               // massiv = s.Split(" ");

//                string[,] matrix = new string[up, down];
//                int k = 0;
//                char[] array = s.ToCharArray();
//                for (int i = 0; i < s.Length; i++)
//                {
//                    Console.Write(array[i]);
//                }
//                Console.WriteLine();
//                //string[] array1 = massiv[k].ToCharArray();

//                //преобразуем в двумерный массив
//                for (int i = 0; i < up; i++)
//                {
//                    for (int j = 0; j < down; j++)
//                    {
//                        if (k < down * up) //&& (massiv[k] != " "))
//                        {
//                            //char[] array = massiv[k].ToCharArray();
//                            matrix[i,j] = array[k].ToString();
//                            if (matrix[i, j] != " ") 
//                                Console.Write(matrix[i, j]);
//                            if ((array[k].ToString() == " ") && (j == down-1))
//                                break;
//                            else if (array[k].ToString() == " ")
//                            {
//                                k++;
//                                matrix[i, j] = array[k].ToString();
//                                Console.Write(matrix[i, j]);
//                            }
//                            k++;

//                        }
//                        else
//                            break;
//                    }
//                    Console.WriteLine();
//                }

//                k = 0;
//                //string[] s2 = new string[down*up];
//                //переводим в одномерный массив
//                string result = "";
//                for (int i = 0; i < up; i++)
//                {
//                    for (int j = 0; j < down; j++)
//                    {
//                        if (k < s.Length)
//                        {
//                            result += matrix[j, i];
//                            k++;
//                            //Console.Write(result);
//                        }
//                        else
//                            break;
//                    }
//                }
//                Console.WriteLine(result);
//                return result;

//            }
//        }

//        /// <summary> Test2 - нулевая ширина </summary>

//        public static void Main()
//        {
//            //string s = "отдай мою кроличью лапку";
//            //bool encode = true;

//            string s = "омоюу толл дюиа акчп йрьк";
//            bool encode = false;
//            string result = TheRabbitsFoot (s,encode);
//            Console.WriteLine(result);
//            Console.ReadKey();
//        }
//    }
//}
#endregion
#region Попытка №2 без вывода
//namespace Level1Space
//{
//    public static class Level1
//    {
//        public static string TheRabbitsFoot(string s, bool encode)
//        {
//            if (encode == true)
//            {
//                s = s.Replace(" ", string.Empty);
//                double root = Math.Sqrt(s.Length);
//                int down = (int)Math.Floor(root);
//                int up = (int)Math.Ceiling(root);
//                if (down * up < s.Length)
//                    down++;
//                string[,] matrix = new string[up, down];
//                int k = 0;
//                for (int i = 0; i < up; i++)
//                {
//                    for (int j = 0; j < down; j++)
//                    {
//                        if (k < s.Length)
//                        {
//                            matrix[i, j] = s[k].ToString();
//                            k++;
//                            Console.Write(matrix[i, j]);
//                        }
//                        else
//                            break;
//                    }
//                    Console.WriteLine();
//                }
//                int p = down * up;
//                k = 0;
//                string result = "";
//                for (int i = 0; i < down; i++)
//                {
//                    for (int j = 0; j < up; j++)
//                    {
//                        if (k < p)
//                        {
//                            result += matrix[j, i];
//                            k++;
//                        }
//                        else
//                            break;
//                    }
//                    result += " ";
//                }
//                result = result.Trim();
//                return result;
//            }
//            else
//            {
//                string s1 = s.Replace(" ", string.Empty);
//                double root = Math.Sqrt(s1.Length);
//                int down = (int)Math.Floor(root);
//                int up = (int)Math.Ceiling(root);
//                if (down * up < s1.Length)
//                    down++;
//                string[,] matrix = new string[up, down];
//                int k = 0;
//                s = s.Trim();
//                char[] array = s.ToCharArray();
//                for (int i = 0; i < up; i++)
//                {
//                    for (int j = 0; j < down; j++)
//                    {
//                        if (k < down * up) 
//                        {
//                            matrix[i, j] = array[k].ToString();
//                            if ((array[k].ToString() == " ") && (j == down - 1))
//                                break;
//                            else if (array[k].ToString() == " ")
//                            {
//                                k++;
//                                matrix[i, j] = array[k].ToString();
//                            }
//                            k++;
//                        }
//                        else
//                            break;
//                    }
//                }
//                k = 0;
//                string result = "";
//                for (int i = 0; i < down; i++)
//                {
//                    for (int j = 0; j < up; j++)
//                    {
//                        if (k < s.Length)
//                        {
//                            result += matrix[j, i];
//                            k++;
//                        }
//                        else
//                            break;
//                    }
//                }
//                result = result.Trim();
//                return result;
//            }
//        }
//        public static void Main()
//        {
//            //string s = "отдай мою кроличью лапку";
//            //bool encode = true;

//            string s = " омоюу толл дюиа акчп йрьк ";
//            bool encode = false;
//            string result = TheRabbitsFoot(s, encode);
//            Console.WriteLine(result);
//            Console.ReadKey();
//        }
//    }
//}
#endregion

/*-------------------------------------------------------------------------------------------------------------------------------------------------*/
//Задача №10 "Экономим тонер"
/*Условие задачи
 * 
 Ваш босс очень экономный человек. Он намерен ввести в организации очень строгие требования по расходованию тонера в принтерах. Для этого он хочет выявить сотрудников, которые пишут тексты, требующие повышенного расхода тонера.
Ваша задача -- написать драйвер, который перехватывает текст, отсылаемый на принтер, и скрытно записывает в базу количество тонера, требуемого для его печати.
Каждый символ требует свой объём тонера. Пробел, очевидно, вообще не расходует ресурсы, а вот например амперсанд @ подразумевает расход аж 32 условных единиц тонера. В документации к принтеру имеется таблица раскладки символов ASCII и соответствующего им объёма тонера. Используйте её, чтобы оценить расход тонера на печатаемый текст. . 

пробел) 0   !   9        "   6        #  24        $  29        %  22
&  24        '   3        (  12        )  12        *  17        +  13
,   7        -   7        .   4        /  10        0  22        1  19
2  22        3  23        4  21        5  27        6  26        7  16
8  23        9  26        :   8        ;  11        <  10        =  14
>  10        ?  15        @  32        A  24        B  29        C  20
D  26        E  26        F  20        G  25        H  25        I  18
J  18        K  21        L  16        M  28        N  25        O  26
P  23        Q  31        R  28        S  25        T  16        U  23
V  19        W  26        X  18        Y  14        Z  22        [  18
\  10        ]  18        ^   7        _   8        `   3        a  23
b  25        c  17        d  25        e  23        f  18        g  30
h  21        i  15        j  20        k  21        l  16        m  22
n  18        o  20        p  25        q  25        r  13        s  21
t  17        u  17        v  13        w  19        x  13        y  24
z  19        {  18        |  12        }  18        ~   9    

--------------------
 Функция

int PrintingCosts(string Line)

получает на вход строку Line. На выходе формируется расход тонера по этой строке, который получается как сумма расходов тонера по всем символам строки. Если встречается символ, не учитываемый таблицей из документации, используйте значение 23. 
*/
#region Попытка №1 с выводом
//namespace Level1Space
//{
//    public static class Level1
//    {
//        public static int PrintingCosts(string Line)
//        {
//            Dictionary<char, int> symbol = new Dictionary<char, int>(95);

//            symbol.Add(' ', 0);
//            symbol.Add('!', 9);
//            symbol.Add('"', 6);
//            symbol.Add('#', 24);
//            symbol.Add('$', 29);
//            symbol.Add('%', 22);
//            symbol.Add('&', 24);
//            symbol.Add('\'', 3);
//            symbol.Add('(', 12);
//            symbol.Add(')', 12);
//            symbol.Add('*', 17);
//            symbol.Add('+', 13);
//            symbol.Add(',', 7);
//            symbol.Add('-', 7);
//            symbol.Add('.', 4);
//            symbol.Add('/', 10);
//            symbol.Add('0', 22);
//            symbol.Add('1', 19);
//            symbol.Add('2', 22);
//            symbol.Add('3', 23);
//            symbol.Add('4', 21);
//            symbol.Add('5', 27);
//            symbol.Add('6', 26);
//            symbol.Add('7', 16);
//            symbol.Add('8', 23);
//            symbol.Add('9', 26);
//            symbol.Add(':', 8);
//            symbol.Add(';', 11);
//            symbol.Add('<', 10);
//            symbol.Add('=', 24);
//            symbol.Add('>', 10);
//            symbol.Add('?', 15);
//            symbol.Add('@', 32);
//            symbol.Add('A', 24);
//            symbol.Add('B', 29);
//            symbol.Add('C', 20);
//            symbol.Add('D', 26);
//            symbol.Add('E', 26);
//            symbol.Add('F', 20);
//            symbol.Add('G', 25);
//            symbol.Add('H', 25);
//            symbol.Add('I', 18);
//            symbol.Add('J', 18);
//            symbol.Add('K', 21);
//            symbol.Add('L', 16);
//            symbol.Add('M', 28);
//            symbol.Add('N', 25);
//            symbol.Add('O', 26);
//            symbol.Add('P', 23);
//            symbol.Add('Q', 31);
//            symbol.Add('R', 28);
//            symbol.Add('S', 25);
//            symbol.Add('T', 16);
//            symbol.Add('U', 23);
//            symbol.Add('V', 19);
//            symbol.Add('W', 26);
//            symbol.Add('X', 18);
//            symbol.Add('Y', 14);
//            symbol.Add('Z', 22);
//            symbol.Add('[', 18);
//            symbol.Add('\\', 10);
//            symbol.Add(']', 18);
//            symbol.Add('^', 7);
//            symbol.Add('_', 8);
//            symbol.Add('`', 3);
//            symbol.Add('a', 23);
//            symbol.Add('b', 25);
//            symbol.Add('c', 17);
//            symbol.Add('d', 25);
//            symbol.Add('e', 23);
//            symbol.Add('f', 18);
//            symbol.Add('g', 30);
//            symbol.Add('h', 21);
//            symbol.Add('i', 15);
//            symbol.Add('j', 20);
//            symbol.Add('k', 21);
//            symbol.Add('l', 16);
//            symbol.Add('m', 22);
//            symbol.Add('n', 18);
//            symbol.Add('o', 20);
//            symbol.Add('p', 25);
//            symbol.Add('q', 25);
//            symbol.Add('r', 13);
//            symbol.Add('s', 21);
//            symbol.Add('t', 17);
//            symbol.Add('u', 17);
//            symbol.Add('v', 13);
//            symbol.Add('w', 19);
//            symbol.Add('x', 13);
//            symbol.Add('y', 24);
//            symbol.Add('z', 19);
//            symbol.Add('{', 18);
//            symbol.Add('|', 12);
//            symbol.Add('}', 18);
//            symbol.Add('~', 9);

//            /*
//             * 1. создать коллекцию V
//             * 2. перевести строку в одномерный массив символов
//             * 3. перебрать циклом for по порядку по индексам с проверкой содержания и подсчета
//             */

//            char[] massiv = Line.ToCharArray();
//            int summ = 0;

//            for (int i = 0; i < massiv.Length; i++)
//            {
//                if (symbol.ContainsKey(massiv[i]))
//                    summ += symbol[massiv[i]];
//                else
//                    summ += 23;
//            }
//            //foreach (var c in symbol.Keys)
//            //{
//            //    if (!symbol.ContainsKey(c))
//            //    {
//            //        symbol.Add(c, 0);
//            //    }
//            //    symbol[c]++;
//            //}

//            //Dictionary<char, int> countDictionary = new Dictionary<char, int>();

//            //foreach (var c in input.ToLower())
//            //{
//            //    if (!symbol.ContainsKey(c))
//            //    {
//            //        symbol.Add(c, 0);
//            //    }

//            //    symbol[c]++;
//            //}

//            //Dictionary<TKey, TValue> лучше всего подходит здесь, вы можете сделать это в нескольких строках следующим образом:

//            //Dictionary<Char, int> alphabets = new Dictionary<Char, int>();

//            //for (int i = 0; i < input.Length; i++)
//            //{
//            //    char character = input[i];
//            //    if (Char.IsLetter(character)) // this is important user can enter numbers as well
//            //    {
//            //        if (alphabets.ContainsKey(character)) // if letter already in increment count
//            //            alphabets[character] = alphabets[character] + 1;
//            //        else
//            //            alphabets.Add(character, 1); // else add in dictionary 
//            //    }
//            //}


//            //if (Line.Length == 0)
//            //    return 0;
//            //else
//            //{
//            //    string[] count = text.Split(new char[] { ' ', '\n', '\r', ',' }, StringSplitOptions.RemoveEmptyEntries);
//            //    int a = count.Count(); // либо count.Length
//            //}
//            return summ;
//        }

//        public static void Main()
//        {

//            string Line = " )*^#@EBQM";
//            int result = PrintingCosts(Line);
//            Console.WriteLine(result);
//            Console.ReadKey();
//        }
//    }
//}
#endregion
#region Попытка №1 без вывода - успешно 04.04.2021
//namespace Level1Space
//{
//    public static class Level1
//    {
//        public static int PrintingCosts(string Line)
//        {
//            Dictionary<char, int> symbol = new Dictionary<char, int>(95)
//            {
//                { ' ', 0 },
//                { '!', 9 },
//                { '"', 6 },
//                { '#', 24 },
//                { '$', 29 },
//                { '%', 22 },
//                { '&', 24 },
//                { '\'', 3 },
//                { '(', 12 },
//                { ')', 12 },
//                { '*', 17 },
//                { '+', 13 },
//                { ',', 7 },
//                { '-', 7 },
//                { '.', 4 },
//                { '/', 10 },
//                { '0', 22 },
//                { '1', 19 },
//                { '2', 22 },
//                { '3', 23 },
//                { '4', 21 },
//                { '5', 27 },
//                { '6', 26 },
//                { '7', 16 },
//                { '8', 23 },
//                { '9', 26 },
//                { ':', 8 },
//                { ';', 11 },
//                { '<', 10 },
//                { '=', 24 },
//                { '>', 10 },
//                { '?', 15 },
//                { '@', 32 },
//                { 'A', 24 },
//                { 'B', 29 },
//                { 'C', 20 },
//                { 'D', 26 },
//                { 'E', 26 },
//                { 'F', 20 },
//                { 'G', 25 },
//                { 'H', 25 },
//                { 'I', 18 },
//                { 'J', 18 },
//                { 'K', 21 },
//                { 'L', 16 },
//                { 'M', 28 },
//                { 'N', 25 },
//                { 'O', 26 },
//                { 'P', 23 },
//                { 'Q', 31 },
//                { 'R', 28 },
//                { 'S', 25 },
//                { 'T', 16 },
//                { 'U', 23 },
//                { 'V', 19 },
//                { 'W', 26 },
//                { 'X', 18 },
//                { 'Y', 14 },
//                { 'Z', 22 },
//                { '[', 18 },
//                { '\\', 10 },
//                { ']', 18 },
//                { '^', 7 },
//                { '_', 8 },
//                { '`', 3 },
//                { 'a', 23 },
//                { 'b', 25 },
//                { 'c', 17 },
//                { 'd', 25 },
//                { 'e', 23 },
//                { 'f', 18 },
//                { 'g', 30 },
//                { 'h', 21 },
//                { 'i', 15 },
//                { 'j', 20 },
//                { 'k', 21 },
//                { 'l', 16 },
//                { 'm', 22 },
//                { 'n', 18 },
//                { 'o', 20 },
//                { 'p', 25 },
//                { 'q', 25 },
//                { 'r', 13 },
//                { 's', 21 },
//                { 't', 17 },
//                { 'u', 17 },
//                { 'v', 13 },
//                { 'w', 19 },
//                { 'x', 13 },
//                { 'y', 24 },
//                { 'z', 19 },
//                { '{', 18 },
//                { '|', 12 },
//                { '}', 18 },
//                { '~', 9 }
//            };

//            char[] massiv = Line.ToCharArray();
//            int summ = 0;

//            for (int i = 0; i < massiv.Length; i++)
//            {
//                if (symbol.ContainsKey(massiv[i]))
//                    summ += symbol[massiv[i]];
//                else
//                    summ += 23;
//            }
//            return summ;
//        }

//        public static void Main()
//        {

//            string Line = " )*^\\ \\\\ \"\"' ' \" ";
//            Console.WriteLine("исходная строка: "+Line);
//            int result = PrintingCosts(Line);
//            Console.WriteLine(result);
//            Console.ReadKey();
//        }
//    }
//}
#endregion

/*-------------------------------------------------------------------------------------------------------------------------------------------------*/
//Задача №11 "Райнехарт и мистер Андерсон"
/*Условие задачи
 * 
  РАЙНЕХАРТ
Наша компания - ведущая компания по разработке программного обеспечения в мире. И это все благодаря тому, что каждый отдельный служащий понимает, что он - часть целого. Таким образом, если служащий имеет проблему, это означает, что вся компания имеет проблему.
Пока ваша самая большая проблема, мистер Андерсон, что вы не выполнили в срок рабочее задание.
Пришло время делать выбор, мистер Андерсон. Либо вы сейчас же реализуете вычисление разностей BigInteger, либо вы будете вынуждены искать другую работу. Я ясно выражаюсь? 
--
 Требуется вычислить разницу между двумя целыми неотрицательными числами, заданными своим строковым представлением (например, "1234567890" и "321").
Числа задаются в диапазоне от 0 до 10^16 (включительно).
В некоторых языках есть поддержка так называемых BigInteger, которые потенциально не ограничены диапазонами, однако арифметические операции над ними выполняются не процессором, а эмуляционным кодом. По сути, для этих операций просто вызываются функции стандартных библиотек.
Возможно, в выбранном вами языке имеется поддержка BigInteger, однако в данной миссии надо обойтись без них.
Придумайте, как вычислять разность для любых заданных значений.

--------------------
Функция
string BigMinus(string s1, string s2)

получает на вход два числа в формате строки (числа всегда корректные -- набор цифр), и возвращает абсолютное значение (модуль) разности -- первое число s1 минус второе число s2, также в формате строки.

Например,
BigMinus("1234567891", "1") = "1234567890"
BigMinus("1", "321") = "320" 
*/
#region Попытка №1 с выводом
//namespace Level1Space
//{
//    public static class Level1
//    {
//        public static string BigMinus(string s1, string s2)
//        {
//            char[] s11 = s1.ToCharArray();
//            char[] s22 = s2.ToCharArray();
//            int equal = 0; //1- первое число больше, 2- равны, 3 - второе число больше
//            bool minusedinica = false;
//            if (s11.Length == s22.Length)
//            {
//                for (int k = 0; k < s11.Length; k++)
//                {
//                    for (int i = 0; i < s22.Length; i++)
//                    {
//                        if (Convert.ToInt32(s11[k]) > Convert.ToInt32(s22[i]))
//                        {
//                            equal = 1;
//                            break;
//                        }
//                        else if (Convert.ToInt32(s11[k]) < Convert.ToInt32(s22[i]))
//                        {
//                            equal = 3;
//                            break;
//                        }
//                        else if (Convert.ToInt32(s11[k]) == Convert.ToInt32(s22[i]))
//                        {
//                            if (k == s11.Length - 1)
//                                equal = 2;
//                            else
//                                k++;
//                        }
//                    }
//                    if (equal != 0)
//                        break;
//                }
//            }
//            else if (s11.Length > s22.Length)
//                equal = 1;
//            else if (s11.Length < s22.Length)
//                equal = 3;
//            if (equal == 2)
//                return "0";
//            else if (equal == 1)
//            {
//                int[] minus = new int[s11.Length];
//                int i = 0;
//                for (int k = s11.Length - 1; k >= 0; k--)
//                {
//                    if (i != -1)
//                    {
//                        for (i = s22.Length - 1; i >= 0; i--)
//                        {
//                            if (Convert.ToInt32(s11[k].ToString()) >= Convert.ToInt32(s22[i].ToString()))
//                            {
//                                if (minusedinica == true) 
//                                {
//                                    if (Convert.ToInt32(s11[k - 1].ToString()) > 0)
//                                    {
//                                        s11[k - 1] = Convert.ToChar(s11[k - 1] - 1);
//                                        minusedinica = false;
//                                    }
//                                    else
//                                    {
//                                        s11[k - 1] = Convert.ToChar("9");
//                                        minusedinica = true;
//                                    }
//                                }
//                                minus[k] = Math.Abs(Convert.ToInt32(s11[k]) - Convert.ToInt32(s22[i]));
//                                if (k > 0)
//                                    k--;
//                                else
//                                    break;
//                            }
//                            else
//                            {
//                                if (Convert.ToInt32(s11[k - 1].ToString()) > 0)
//                                {
//                                    s11[k - 1] = Convert.ToChar(s11[k - 1] - 1);
//                                    if (Convert.ToInt32(s11[k - 1].ToString()) == 0)
//                                        minusedinica = true;
//                                    else
//                                        minusedinica = false;
//                                }
//                                else
//                                {
//                                    s11[k - 1] = Convert.ToChar("9");
//                                    minusedinica = true;
//                                }
//                                s11[k] = Convert.ToChar(s11[k] + 10);
//                                minus[k] = Math.Abs(Convert.ToInt32(s11[k]) - Convert.ToInt32(s22[i]));
//                                k--;
//                            }
//                        }
//                    }
//                    if (i == -1 && k >= 0)
//                    {
//                        if (minusedinica == true && k > 0)
//                        {
//                            if (Convert.ToInt32(s11[k - 1].ToString()) > 0)
//                            {
//                                s11[k - 1] = Convert.ToChar(s11[k - 1] - 1);
//                                minusedinica = false;
//                            }
//                        }
//                        minus[k] = Convert.ToInt32(s11[k].ToString());
//                    }
//                }
//                string result = string.Join("", minus);
//                result = result.TrimStart('0');
//                return result;
//            }
//            else if (equal == 3)
//            {
//                int[] minus = new int[s22.Length];
//                int i = 0;
//                for (int k = s22.Length - 1; k >= 0; k--)
//                {
//                    if (i >= 0)
//                    {
//                        for (i = s11.Length - 1; i >= 0; i--)
//                        {
//                            if (Convert.ToInt32(s22[k].ToString()) >= Convert.ToInt32(s11[i].ToString()))
//                            {
//                                if (minusedinica == true)
//                                {
//                                    if (Convert.ToInt32(s22[k - 1].ToString()) > 0)
//                                    {
//                                        s22[k - 1] = Convert.ToChar(s22[k - 1] - 1);
//                                        minusedinica = false;
//                                    }
//                                    else
//                                    {
//                                        s22[k - 1] = Convert.ToChar("9");
//                                        minusedinica = true;
//                                    }
//                                }
//                                minus[k] = Math.Abs(Convert.ToInt32(s22[k]) - Convert.ToInt32(s11[i]));
//                                if (k > 0)
//                                    k--;
//                                else
//                                    break;
//                            }
//                            else
//                            {
//                                if (Convert.ToInt32(s22[k-1].ToString()) > 0)
//                                {
//                                    s22[k - 1] = Convert.ToChar(s22[k - 1] - 1);
//                                    if (Convert.ToInt32(s22[k - 1].ToString()) == 0)
//                                        minusedinica = true;
//                                    else
//                                        minusedinica = false;
//                                }
//                                else
//                                {
//                                    s22[k - 1] = Convert.ToChar("9");
//                                    minusedinica = true;
//                                }
//                                s22[k] = Convert.ToChar(s22[k] + 10);
//                                minus[k] = Math.Abs(Convert.ToInt32(s22[k]) - Convert.ToInt32(s11[i]));
//                                k--;
//                            }
//                        }
//                    }
//                    if (i == -1 && k >= 0)
//                    {
//                        if (minusedinica == true && k > 0)
//                        {
//                            if (Convert.ToInt32(s22[k - 1].ToString()) > 0)
//                            {
//                                s22[k - 1] = Convert.ToChar(s22[k - 1] - 1);
//                                minusedinica = false;
//                            }
//                        }
//                        minus[k] = Convert.ToInt32(s22[k].ToString());
//                    }
//                }
//                string result = string.Join("", minus);
//                result = result.TrimStart('0');
//                return result;
//            }
//            else
//                return "0";
//        }

//        public static void Main()
//        {
//            string s1 = "10000000001";
//            string s2 = "101011001";
//            Console.WriteLine("Исходная строка s1 " + s1);
//            Console.WriteLine("Исходная строка s2 " + s2);
//            string result = BigMinus(s1,s2);
//            Console.WriteLine(result);
//            Console.ReadKey();
//        }
//    }
//}
#endregion

/*-------------------------------------------------------------------------------------------------------------------------------------------------*/
//Задача №12 "146%"
/*Условие задачи
 * 
  Поступил крупный заказ на автоматизацию процесса подсчёта результатов выборов.

В систему поступает количество голосов, отданных за каждого из кандидатов. Она должна обработать их и определить один из трёх вариантов результата:
- победитель, набравший больше всех голосов и при этом более 50% голосов;
- победитель, набравший больше всех голосов и при этом менее или ровно 50% голосов;
- перевыборы (выявлено несколько победителей с одинаковым количеством голосов).
Например, список голосов, отданных за пятерых кандидатов, первый случай:
60, 10, 10, 15, 5. Победил первый кандидат с результатом 60%.
Cписок голосов, отданных за трёх кандидатов, второй случай:
10, 15, 10. Победил второй кандидат с результатом 42.85%.
Перевыборы, четыре кандидата: 111, 111, 110, 110
Точность результата округляется до трёх знаков после запятой.

Функция
string MassVote(int N, int [] Votes)
получает на вход количество кандидатов N >= 1 и массив, содержащий N голосов, отданных за соответствующих кандидатов.
На выходе формируется строка в одном из трёх форматов:
1) "majority winner K" если имеется победитель с номером K (начиная с 1), набравший более 50% голосов. Для случая 60, 10, 10, 15, 5 строка примет вид
majority winner 1
2) "minority winner K" если имеется победитель с номером K (начиная с 1), набравший менее 50% голосов. Для случая 10, 15, 10 строка примет вид
minority winner 2
3) "no winner" если победителя не выявлено. 
*/
/*Алгоритм
 * 1. Ищем максимальное значение
 * 2. Посчитать кол-во элементов равных максимальному, если более 1 то "no winner"
 * 2. Ищем одинаковые значения, если они есть приостаналиваем цикл и возвращаем "no winner"
 * 2. Если нет одинаковых значений, то находим максимальный по значению элемент и рассчитываем его процент от общего кол-ва полученных голосов
 * если процент более 50% выводим "majority winner k" где к - номер элемента в массиве, иначе "majority winner k"
 * процент округляем до трех знаков после запятой
 */
//#region Попытка №1 с выводом
//namespace Level1Space
//{
//    public static class Level1
//    {
//        public static string MassVote(int N, int[] Votes)
//        {
//            int max = Votes[0];
//            int x=0;
//            for (int i = 0; i < Votes.Length; i++)
//            {
//                if (Votes[i] > max)
//                {
//                    max = Votes[i];
//                    x = i;
//                }
//            }
//            x++;
//            int k = 0;
//            for (int i = 0; i < Votes.Length; i++)
//            {
//                if (Votes[i] == max)
//                    k++;  
//            }
//            if (k > 1)
//                return "no winner";
//            else
//            {
//                int summ = 0;
//                for (int i=0; i < Votes.Length; i++)
//                {
//                    summ += Votes[i];
//                }
//                double summ3 = Convert.ToDouble(summ);
//                double max2 = Convert.ToDouble(max);
//                double summ2;
//                summ2 = (double)(100 * max2 / summ3);
//                summ2 = Math.Round(summ2, 3);
//                if (summ2 > 50)
//                    return $"majority winner {x}";
//                else
//                    return $"minority winner {x}";
//            }
//        }

//        public static void Main()
//        {
//            int N = 2;
//            int[] Votes = { 100,99 };
//            Console.WriteLine("Кол-во кандидатов " + N);
//            Console.WriteLine("Исходный массив ");
//            for (int i=0; i < Votes.Length; i++)
//            {
//                Console.Write(" " + Votes[i]);
//            }
//            Console.WriteLine();
//            Console.WriteLine("Результат- "+MassVote(N,Votes));
//            Console.ReadKey();
//        }
//    }
//}
//#endregion

/*-------------------------------------------------------------------------------------------------------------------------------------------------*/
//Задача №13 "Сигналы НЛО"
/*Условие задачи
 * 
Британские учёные перехватили трафик переговоров двух НЛО, шпионящих за Землёй. Как выяснилось, сигналы первой НЛО передаются в восьмеричной системе счисления, а сигналы второй НЛО передаются в шестнадцатеричной системе счисления.
Для быстрой расшифровки их переговоры надо представить в более привычной землянам десятичной системе счисления. Срочно требуется конвертор для разных систем счисления.

Функция

int [] UFO(int N, int [] data, bool octal)

получает на вход длину N цифровой записи трафика, сам трафик (последовательность положительных чисел) в массиве data, и флажок octal, который задаёт систему счисления входных данных: восьмеричная если octal = true, и шестнадцатеричная в противном случае.
Если числа подаются в восьмеричной системе счисления, гарантируется, что в них не будет цифр 8 и 9.

Функция возвращает массив длины N, содержащий исходные числа, преобразованные в десятичную систему счисления.

Например, если на вход подаётся массив из двух чисел 1234,1777 с флажком octal = false, то результат будет 4660,6007.
А если флажок для данного массива будет true, то результат будет 668,1023. 
 */

/* АЛгоритм
Научиться переводить число из одной системы счисления в другую очень просто.
Любое число может быть легко переведено в десятичную систему по следующему алгоритму:
Каждая цифра числа должна быть умножена на основание системы счисления этого 
числа возведенное в степень равное позиции текущей цифры в числе справа налево, причём счёт начинается с 0.
----
1. создаем  dictionary для шестнадцатеричной системы A,B,C,D,E,F
2. перевернем число чтобы не мудрить и не делать в цикле отдельный счетчик
3. вычисляем результат
 */
#region Попытка №1 с выводом
//namespace Level1Space
//{
//    public static class Level1
//    {
//        public static int[] UFO(int N, int[] data, bool octal)
//        {
//            #region //для шестнадцатеричной системы если будут символы
//            //Dictionary<char, int> symbol = new Dictionary<char, int>(95) //для шестнадцатеричной системы
//            //{
//            //    { 'A', 11 },
//            //    { 'B', 12 },
//            //    { 'C', 13 },
//            //    { 'D', 14 },
//            //    { 'E', 15 },
//            //    { 'F', 16 },
//            //    { 'a', 11 },
//            //    { 'b', 12 },
//            //    { 'c', 13 },
//            //    { 'd', 14 },
//            //    { 'e', 15 },
//            //    { 'f', 16 },
//            //};
//            #endregion
//            int notation;
//            if (octal == true) //восьмеричная
//                notation = 8;
//            else
//                notation = 16;

//            string[] stringData = new string[N];
//            int counter = 0;
//            int[] result = new int[N];

//            for (int i = 0; i < N; i++)
//            {
//                stringData[counter] = data[i].ToString();
//                char[] charArray = stringData[counter].ToCharArray(); // 1-е число перевели в символьный одномерный массив
//                int k = 0;

//                //for (int x = 0; x < charArray.Length; x++)
//                //{
//                //    Console.Write(charArray[x]+" ");
//                //}
//                //Console.WriteLine();

//                for (int j = charArray.Length-1; j > -1; j--)
//                {
//                    int numeral = int.Parse(charArray[j].ToString());
//                    result[i] += (int)(numeral* Math.Pow(notation, k));
//                    k++;
//                }
//            }
//            return result;
//        }

//        public static void Main()
//        {
//            int N = 2;
//            int[] data = { 1234, 1777 };
//            bool octal = true; //8
//            Console.WriteLine("Длина траффика " + N);
//            Console.WriteLine("Исходный массив ");
//            for (int i = 0; i < data.Length; i++)
//            {
//                Console.Write(" " + data[i]);
//            }
//            Console.WriteLine();
//            for (int i = 0; i < N; i++)
//            {
//                Console.WriteLine("Результат{0}- " + UFO(N, data, octal)[i]+" ",i+1);
//            }
//            Console.ReadKey();
//        }
//    }
//}
#endregion
#region Попытка №2 без вывода успешно 25.04.2021
//namespace Level1Space
//{
//    public static class Level1
//    {
//        public static int[] UFO(int N, int[] data, bool octal)
//        {
//            int notation;
//            if (octal == true)
//                notation = 8;
//            else
//                notation = 16;
//            string[] stringData = new string[N];
//            int counter = 0;
//            int[] result = new int[N];

//            for (int i = 0; i < N; i++)
//            {
//                stringData[counter] = data[i].ToString();
//                char[] charArray = stringData[counter].ToCharArray();
//                int k = 0;

//                for (int j = charArray.Length - 1; j > -1; j--)
//                {
//                    int numeral = int.Parse(charArray[j].ToString());
//                    result[i] += (int)(numeral * Math.Pow(notation, k));
//                    k++;
//                }
//            }
//            return result;
//        }

//        public static void Main()
//        {
//            int N = 1;
//            int[] data = { 214747 };
//            bool octal = false; //16
//            Console.WriteLine("Длина траффика " + N);
//            Console.WriteLine("Исходный массив ");
//            for (int i = 0; i < data.Length; i++)
//            {
//                Console.Write(" " + data[i]);
//            }
//            Console.WriteLine();
//            for (int i = 0; i < N; i++)
//            {
//                Console.WriteLine("Результат{0}- " + UFO(N, data, octal)[i] + " ", i + 1);
//            }
//            Console.ReadKey();
//        }
//    }
//}
#endregion

/*-------------------------------------------------------------------------------------------------------------------------------------------------*/
//Задача №14 "Оптимизация беспилотного трафика"
/*Условие задачи
 * 
 Яндекс выпускает на улицы тысячи беспилотных автомобилей, и теперь появляется отличная возможность оптимизации трафика на дорогах. Прежде всего требуется точно оценить время прибытия машины в место назначения.
На дороге автомобиль постоянно встречает светофоры, которые горят либо зелёным, либо красным. Время горения зелёного и красного света задаётся в секундах. Цикл переключения цветов повторяется бесконечно и начинается с красного цвета.
Так как скорость автомобиля известна, положения светофоров на дороге определяются временем, которое требуется, чтобы доехать до этого светофора из начала дороги при условии, что все предыдущие светофоры горят зелёным.
Каждый светофор также характеризуется временем горения красного и зелёного цвета.
Задача -- определить, за какое время автомобиль доберётся до конца дороги.
Например, имеется дорога длиной 10 единиц времени. Первый светофор расположен на отметке 3 единицы времени и характеризуется циклом 5 красный 5 зелёный. Второй светофор расположен на отметке 5, и время показа красного и зелёного для него 2 и 2.
Автомобиль стартует, через 3 единицы добирается до первого светофора, на котором горит красный. Он горит 5 единиц, то есть движение начинается с 5-го момента.
Через две единицы автомобиль добирается до второго светофора -- это абсолютный момент 7. В этот момент на светофоре горит зелёный, и автомобиль проезжает его без остановки. От второго светофора до конца дороги остаётся ещё 5 моментов, таким образом суммарное время автомобиля в пути равно 12 (7 + 5).

Функция

int Unmanned(int L, int N, int [][3] track)

получает на вход длину L дороги, количество светофоров на ней N, и описание самой дороги, где каждый элемент состоит из трёх значений: момент времени относительно начала дороги (когда в него прибудет автомобиль по свободной дороге), время показа красного света и время показа зелёного цвета.
Для примера выше параметры функции Unmanned() будут такими: 10, 2, [ [3,5,5], [5,2,2] ]
Функция возвращает реальное время, требуемое для преодоления дороги. 
 */
/* АЛгоритм
1. Сортируем массивы внутри большого массива, т.к. в задаче не сказано про порядок перечисления массивов внутри большого массива. При этом нам надо расположить светофоры в правильном порядке
2. 
 */
#region Попытка №1 с выводом
//namespace Level1Space
//{
//    public static class Level1
//    {
//        public static int Unmanned(int L, int N, int [][] track)
//        {
//            //int tp = 0;
//            int tabs = 0;
//            int ts = 0;
//            bool trafficLight = false; //false - красный (был зеленый) светофор, true -зеленый (был красный) светофор

//            ///< summary > сортировка массива массивов < /summary >
//            int[] temp = new int[3];
//            for (int m = 0; m < track.Length-1; m++)
//            {
//                if (track[m][0] > track[m + 1][0])
//                {
//                    Array.Copy(track[m],temp,3);
//                    //temp[m] = track[m][3];
//                    Array.Copy(track[m + 1], track[m], 3);
//                    Array.Copy(temp, track[m + 1], 3);
//                }
//            }

//            ///< summary > печатаем для проверки < /summary >
//            for (int m = 0; m < track.Length; m++)
//            {
//                Console.WriteLine("Массив №{0} ", m + 1);

//                for (int i = 0; i < track[m].Length; i++)
//                    Console.Write("\t\t " + track[m][i]);
//                Console.WriteLine();
//            }
//            Console.WriteLine();

//            ///< summary > идем по массивам внутри большого массива < /summary >
//            for (int m = 0; m < track.Length; m++)
//            {
//                //tp += track[m][0] - tabs;
//                tabs = tabs + (track[m][0] - tabs) + ts;
//                ts = 0;
//                int summa = 0; 

//                ///<summary> вычисляем красный или зеленый </summary>
//                while (summa < tabs) 
//                {
//                    summa += track[m][1];
//                    trafficLight = true;
//                    if (summa >= tabs)
//                        break;
//                    else
//                    {
//                        summa += track[m][2];
//                        trafficLight = false;
//                    }
//                    if (summa >= tabs)
//                        break;
//                }

//                if (trafficLight == true)//светофор был красный считаем время остановки
//                {
//                    ts += summa - tabs; //считаем время остановки
//                    if (m + 1 == track.Length) //если светофор последний
//                    {
//                        tabs += (L - tabs) + ts; //считаем время с остановкой
//                    }
//                }
//                else if (trafficLight == false) //светофор был зеленый переходим к следующему
//                {
//                    //tp += summa - tabs;
//                    if (m + 1 == track.Length) //если светофор последний
//                    {
//                        tabs += L - track[m][0]; //прибавляем разницу между длиной дороги и последним светофором
//                    }
//                }
//                //else if (trafficLight == false) //светофор был зеленый переходим к следующему
//            }
//            if (tabs < L)
//                tabs += L - tabs;
//            //tabs += ts;
//            //result = tp + ts;
//            return tabs;
//        }

//        public static void Main()
//        {
//            int L = 10;
//            int N = 1;
//            int[][] track = new int[1][];
//            //track[0] = new[] {3,5,5};
//            track[0] = new[] {5,2,2};
//            Console.WriteLine("О "+track[0]);
//            Console.WriteLine("Длина дороги {0}; Кол-во светофоров {1} ",L,N);
//            Console.WriteLine("ОПисание дороги ");
//            for (int m = 0; m < track.Length; m++)
//            {
//                Console.WriteLine("Массив №{0} ",m+1);

//                for (int i = 0; i < track[m].Length; i++)
//                    Console.Write("\t\t " + track[m][i]);
//                Console.WriteLine();
//            }
//            Console.WriteLine();
//            Console.WriteLine("Результат- " + Unmanned(L,N,track));
//            Console.ReadKey();
//        }
//    }
//}
#endregion
#region Попытка №2 без вывода - ошибка Тест закончился ошибкой:
//Unmanned(10, 2, [[11, 5, 5],[15, 2, 2]]) = 10, попытка №3 26.04.2021
//namespace Level1Space
//{
//    public static class Level1
//    {
//        public static int Unmanned(int L, int N, int[][] track)
//        {
//            int tabs = 0; //абсолютное время 
//            int ts = 0; //время стоянки
//            bool trafficLight = false; //- красный/зеленый светофор на пути
//            bool trafficLightOutside = true; //дорога без светофоров

//            int[] temp = new int[3];

//            if (track[0][0] <= L)
//                trafficLightOutside = false;

//            for (int m = 0; m < track.Length - 1; m++)
//            {
//                if (track[m][0] > track[m + 1][0])
//                {
//                    Array.Copy(track[m], temp, 3);
//                    Array.Copy(track[m + 1], track[m], 3);
//                    Array.Copy(temp, track[m + 1], 3);
//                }
//                if (track[m][0] <= L)
//                    trafficLightOutside = false;
//            }

//            if (trafficLightOutside == false)
//            {
//                for (int m = 0; m < track.Length; m++)
//                {
//                    tabs = tabs + (track[m][0] - tabs) + ts;
//                    ts = 0;
//                    int summa = 0;

//                    while (summa < tabs)
//                    {
//                        summa += track[m][1];
//                        trafficLight = true;
//                        if (summa >= tabs)
//                            break;
//                        else
//                        {
//                            summa += track[m][2];
//                            trafficLight = false;
//                        }
//                        if (summa >= tabs)
//                            break;
//                    }

//                    if (trafficLight == true)
//                    {
//                        ts += summa - tabs;
//                        if (m + 1 == track.Length)
//                        {
//                            tabs += (L - tabs) + ts;
//                        }
//                    }
//                    else if (trafficLight == false)
//                    {
//                        if (m + 1 == track.Length)
//                        {
//                            tabs += L - track[m][0];
//                        }
//                    }
//                }
//                if (tabs < L)
//                    tabs += L - tabs;
//                return tabs;
//            }
//            else
//                return L;
//        }

//        public static void Main()
//        {
//            int L = 10;
//            int N = 1;
//            int[][] track = new int[1][];
//            track[0] = new[] {3,5,5};
//            //track[0] = new[] { 5, 2, 2 };
//            Console.WriteLine("О " + track[0]);
//            Console.WriteLine("Длина дороги {0}; Кол-во светофоров {1} ", L, N);
//            Console.WriteLine("ОПисание дороги ");
//            for (int m = 0; m < track.Length; m++)
//            {
//                Console.WriteLine("Массив №{0} ", m + 1);

//                for (int i = 0; i < track[m].Length; i++)
//                    Console.Write("\t\t " + track[m][i]);
//                Console.WriteLine();
//            }
//            Console.WriteLine();
//            Console.WriteLine("Результат- " + Unmanned(L, N, track));
//            Console.ReadKey();
//        }
//    }
//}
#endregion


/*-------------------------------------------------------------------------------------------------------------------------------------------------*/
//Задача №14 "Оптимизация беспилотного трафика"
/*Условие задачи
 * 
 Яндекс выпускает на улицы тысячи беспилотных автомобилей, и теперь появляется отличная возможность оптимизации трафика на дорогах. Прежде всего требуется точно оценить время прибытия машины в место назначения.
На дороге автомобиль постоянно встречает светофоры, которые горят либо зелёным, либо красным. Время горения зелёного и красного света задаётся в секундах. Цикл переключения цветов повторяется бесконечно и начинается с красного цвета.
Так как скорость автомобиля известна, положения светофоров на дороге определяются временем, которое требуется, чтобы доехать до этого светофора из начала дороги при условии, что все предыдущие светофоры горят зелёным.
Каждый светофор также характеризуется временем горения красного и зелёного цвета.
Задача -- определить, за какое время автомобиль доберётся до конца дороги.
Например, имеется дорога длиной 10 единиц времени. Первый светофор расположен на отметке 3 единицы времени и характеризуется циклом 5 красный 5 зелёный. Второй светофор расположен на отметке 5, и время показа красного и зелёного для него 2 и 2.
Автомобиль стартует, через 3 единицы добирается до первого светофора, на котором горит красный. Он горит 5 единиц, то есть движение начинается с 5-го момента.
Через две единицы автомобиль добирается до второго светофора -- это абсолютный момент 7. В этот момент на светофоре горит зелёный, и автомобиль проезжает его без остановки. От второго светофора до конца дороги остаётся ещё 5 моментов, таким образом суммарное время автомобиля в пути равно 12 (7 + 5).

Функция

int Unmanned(int L, int N, int [][3] track)

получает на вход длину L дороги, количество светофоров на ней N, и описание самой дороги, где каждый элемент состоит из трёх значений: момент времени относительно начала дороги (когда в него прибудет автомобиль по свободной дороге), время показа красного света и время показа зелёного цвета.
Для примера выше параметры функции Unmanned() будут такими: 10, 2, [ [3,5,5], [5,2,2] ]
Функция возвращает реальное время, требуемое для преодоления дороги. 
 */
/* АЛгоритм
1. Сортируем массивы внутри большого массива, т.к. в задаче не сказано про порядок перечисления массивов внутри большого массива. При этом нам надо расположить светофоры в правильном порядке
2. 
 */
#region Попытка №3 без вывода - ошибка 1471$ - пройдено успешно Золота: 1721$
//Тест закончился ошибкой:
//Unmanned(10, 2, [[3, 6, 2],[6, 2, 2]]) = 14 26.04.2021
//namespace Level1Space
//{
//    public static class Level1
//    {
//        public static int Unmanned(int L, int N, int[][] track)
//        {
//            int ts = 0; //время остановки
//            int tp = 0; //время поездки
//            bool trafficLight = false; //- красный/зеленый светофор на пути
//            bool trafficLightOutside = true; //дорога без светофоров

//            int[] temp = new int[3];

//            if (track[0][0] <= L)
//                trafficLightOutside = false;

//            for (int m = 0; m < track.Length - 1; m++)
//            {
//                if (track[m][0] > track[m + 1][0])
//                {
//                    Array.Copy(track[m], temp, 3);
//                    Array.Copy(track[m + 1], track[m], 3);
//                    Array.Copy(temp, track[m + 1], 3);
//                }
//                if (track[m][0] <= L)
//                    trafficLightOutside = false;
//            }

//            if (trafficLightOutside == false)
//            {
//                for (int m = 0; m < track.Length; m++)
//                {
//                    if (track[m][0] > L) //дорога кончилась а светофоры есть
//                        break;
//                    int differenceLight = 0; //расстояние между текущим светофором и предыдущим
//                    if (m > 0) //если это не первый светофор считаем расстояние между текущим светофором и предыдущим
//                        differenceLight = track[m][0] - track[m - 1][0];
//                    tp +=track[m][0] - tp + differenceLight; //едем до светофора
//                    int summa = 0;

//                    while (summa < tp) //красный или зеленый светофор на пути и где он  (summa)
//                    {
//                        summa += track[m][1];
//                        trafficLight = true;
//                        if (summa >= tp)
//                            break;
//                        else
//                        {
//                            summa += track[m][2];
//                            trafficLight = false;
//                        }
//                        if (summa >= tp)
//                            break;
//                    }

//                    if (trafficLight == true) //если светофор красный считаем время остановки
//                    {
//                        ts += summa - tp;
//                        tp += summa - tp;
//                        //tp += differenceLight;
//                        if (m + 1 == track.Length) //если это последний светофор
//                        {
//                            tp += (L - tp); //считаем абсолютное время
//                        }
//                    }
//                    else if (trafficLight == false) //если светофор зеленый 
//                    {
//                        if (m + 1 == track.Length)
//                        {
//                            tp += L - tp;
//                        }
//                    }
//                }
//                if (tp < L)
//                    tp += L - tp;
//                tp += ts;
//                return tp;
//            }
//            else
//                return L;
//        }

//        public static void Main()
//        {
//            int L = 10;
//            int N = 2;
//            int[][] track = new int[2][];
//            track[0] = new[] { 9, 4, 3 };
//            track[1] = new[] { 14, 2, 2 };
//            Console.WriteLine("О " + track[0]);
//            Console.WriteLine("Длина дороги {0}; Кол-во светофоров {1} ", L, N);
//            Console.WriteLine("ОПисание дороги ");
//            for (int m = 0; m < track.Length; m++)
//            {
//                Console.WriteLine("Массив №{0} ", m + 1);

//                for (int i = 0; i < track[m].Length; i++)
//                    Console.Write("\t\t " + track[m][i]);
//                Console.WriteLine();
//            }
//            Console.WriteLine();
//            Console.WriteLine("Результат- " + Unmanned(L, N, track));
//            Console.ReadKey();
//        }
//    }
//}
#endregion

/*-------------------------------------------------------------------------------------------------------------------------------------------------*/
//Задача №15 "Танковый раш"
/*Условие задачи
 * 
Разведчики выяснили, что неведомый клан готовит внезапный массивный прорыв премиум-танков. У нашей арты будет возможность произвести только один залп. Ваша задача: выявить местонахождение группировки танков на карте.
На входе два массива (карта и группировка танков), каждый описывается одинаково: количество строк, количество столбцов и набор строк, разделённых пробелом. Каждый символ строки описывает один элемент карты.
Например, дана карта:

1234
2345
0987
Этот массив размером 3*4 будет представлен на вводе так:
3 4 1234 2345 0987
Второй массив представляется аналогично первому.

Задача: проверить, входит ли второй массив в первый (в двумерном виде).
Например, второй массив может быть таким:
34
98
или
2 2 34 98
Он входит в состав первого массива.

Функция
bool TankRush(int H1, int W1, string S1, int H2, intW2, string S2) 

первыми тремя параметрами получает исходную карту, а следующими тремя -- карту, которая ищется в исходной.
TankRush возвращает true, если вторая карта содержится в первой.  
 */
/* АЛгоритм
1. разобрать строки и создать массивы
2. определить наличие второго массива в первом
 */
#region Попытка №1 без вывода Золота: 1721$
//namespace Level1Space
//{
//    public static class Level1
//    {
//        public static bool TankRush(int H1, int W1, string S1, int H2, int W2, string S2)
//        {
//            //определяем размерность массива
//            int[,] Array1 = new int [H1, W1];
//            int[,] Array2 = new int[H2, W2];
//            char[] text1 = S1.ToCharArray();
//            char[] text2 = S2.ToCharArray();
//            int k = 0;
//            int result = 0;

//            //#region переводим в массив
//            //for (int i = 0; i < H1; i++) 
//            //{
//            //    for (int j = 0; j < W1; j++) 
//            //    {
//            //        if (j == 0 && i != 0)
//            //            k++;
//            //        if (S1[k].ToString() != " ") 
//            //        {
//            //            Array1[i, j] = Convert.ToInt32(S1[k].ToString());
//            //            if (k < S1.Length)
//            //                k++;
//            //        }
//            //        else
//            //        {
//            //            k++;
//            //            break;
//            //        }
//            //    }
//            //}

//            //k = 0;
//            //for (int i = 0; i < H2; i++)
//            //{
//            //    for (int j = 0; j < W2; j++)
//            //    {
//            //        if (j == 0 && i != 0)
//            //            k++;
//            //        if (S2[k].ToString() != " ")
//            //        {
//            //            Array2[i, j] = Convert.ToInt32(S2[k].ToString());
//            //            if (k < S2.Length)
//            //                k++;
//            //        }
//            //        else
//            //        {
//            //            k++;
//            //            break;
//            //        }
//            //    }
//            //}
//            //#endregion

//            //#region печатаем
//            //Console.WriteLine("Массив 1:");
//            //for (int i = 0; i < H1; i++)
//            //{
//            //    for (int j = 0; j < W1; j++)
//            //    {
//            //        Console.Write(Array1[i, j]);
//            //    }
//            //    Console.WriteLine();
//            //}
//            //Console.WriteLine("Массив 2:");
//            //for (int i = 0; i < H2; i++)
//            //{
//            //    for (int j = 0; j < W2; j++)
//            //    {
//            //        Console.Write(Array2[i, j]);
//            //    }
//            //    Console.WriteLine();
//            //}
//            //#endregion

//            #region ищем

//            int x = 0;
//            int y = 0;
//            k = 0;
//            int a = 0;
//            int b = 0;

//            while (result < H2*W2)
//             {
//                if (text2[b] == text1[a] && text2[b].ToString() != " ")
//                {
//                    result++;
//                    if (y == 0)
//                        k = a; //если первый символ в строке то запоминаем позицию первого символа
//                    if (y < W2)
//                        y++;
//                    if (y == W2)
//                    {
//                        a = k + W1 + 1;//
//                        b++;
//                        y = 0;
//                    }
//                    else
//                    {
//                        a++;
//                        b++;
//                    }
//                }
//                else 
//                {
//                    if ((text1[a].ToString() != " ") && (text2[b].ToString() != " "))
//                    {
//                        if (y == W2)// && text1[a+1].ToString() == " ")
//                        {
//                            result = 0;
//                            y = 0;
//                            for (int n = a; n > 0; n--) 
//                            {
//                                if (text1[n].ToString() == " ") 
//                                {
//                                    a = n + 1;
//                                    break;
//                                }
//                            }
//                            b = 0;
//                        }
//                        else
//                        {
//                            a++;
//                        }
//                    }
//                    if (text1[a].ToString() == " ")
//                        a++;
//                    if (text2[b].ToString() == " ")
//                        b++;
//                }
//                if (a > H1 * W1 + (H1 - 1))
//                    break;
//            }
//            #endregion
//            if (result == H2 * W2)
//                return true;
//            else
//                return false;
//        }

//        public static void Main()
//        {
//            int H1 = 3;
//            int W1 = 4;
//            string S1 = "1234 2345 0987";
//            int H2 = 2;
//            int W2 = 2;
//            string S2 = "34 98";
//            Console.WriteLine("Карта1 " + S1);
//            Console.WriteLine("Карта2 " + S2);
//            Console.WriteLine("Результат- " + TankRush(H1,W1,S1,H2,W2,S2));
//            Console.ReadKey();
//        }
//    }
//}
#endregion

#region
namespace Level1Space
{
    public static class Level1
    {
        public static bool TankRush(int H1, int W1, string S1, int H2, int W2, string S2)
        {
            char[] text1 = S1.ToCharArray();
            char[] text2 = S2.ToCharArray();
            int result = 0;

            int y = 0;
            int k = 0;
            int a = 0;
            int b = 0;

            while (result < H2 * W2)
            {
                if (text2[b] == text1[a] && text2[b].ToString() != " ")
                {
                    result++;
                    if (y == 0)
                        k = a; 
                    if (y < W2)
                        y++;
                    if (y == W2)
                    {
                        a = k + W1 + 1;
                        b++;
                        y = 0;
                    }
                    else
                    {
                        a++;
                        b++;
                    }
                }
                else
                {
                    if ((text1[a].ToString() != " ") && (text2[b].ToString() != " "))
                    {
                        if (y == W2)
                        {
                            result = 0;
                            y = 0;
                            for (int n = a; n > 0; n--)
                            {
                                if (text1[n].ToString() == " ")
                                {
                                    a = n + 1;
                                    break;
                                }
                            }
                            b = 0;
                        }
                        else
                        {
                            a++;
                        }
                    }
                    if (text1[a].ToString() == " ")
                        a++;
                    if (text2[b].ToString() == " ")
                        b++;
                }
                if (a > H1 * W1 + (H1 - 1))
                    break;
            }

            if (result == H2 * W2)
                return true;
            else
                return false;
        }

        public static void Main()
        {
            int H1 = 3;
            int W1 = 4;
            string S1 = "3 4 1234 2345 0987";
            int H2 = 2;
            int W2 = 2;
            string S2 = "2 2 34 98";
            Console.WriteLine("Карта1 " + S1);
            Console.WriteLine("Карта2 " + S2);
            Console.WriteLine("Результат- " + TankRush(H1, W1, S1, H2, W2, S2));
            Console.ReadKey();
        }
    }
}
#endregion