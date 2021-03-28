using System;
//using Test_Level1;


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
u#region 
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
namespace Level1Space
{
    public static class Level1
    {
        public static int SumOfThe(int N, int[] data)
        {
            char[] s1 = s.ToCharArray();
            string[,] s3 = new string[s.Length, s.Length];
            int k = 0;
            int i;
            int j;
            for (i = 0; i < s.Length; i++)
            {
                bool twelve = false;
                for (j = 0; j < len; j++)
                {
                    if (k < s.Length)
                    {
                        if (s1[k].ToString() == " ")
                            twelve = true;
                        if (((j == 0) && (s1[k].ToString() == " ")) || ((s1[k].ToString() == " ") && (s1[k + 1].ToString() == " ")))
                        {
                            if (k == s.Length - 1)
                            {
                                k++;
                                break;
                            }
                            else
                            {
                                k++;
                                s3[i, j] = s1[k].ToString();
                                k++;
                            }
                        }
                        else
                        {
                            s3[i, j] = s1[k].ToString();
                            if (k < s.Length)
                                k++;
                        }
                        if ((k == s.Length) || (s.Length <= 1))
                            break;
                    }
                }
                if ((k == s.Length) || (s.Length <= 1))
                    break;
                else
                    if ((s[k].ToString() != " ") && (s[k - 1].ToString() != " "))
                {
                    int z = k;
                    for (int d = j - 1; d >= 0; d--)
                    {
                        if (s3[i, d].ToString() == " ")
                        {
                            break;
                        }
                        else if ((d == 0) && (s3[i, d].ToString() != " "))
                            k = z;
                        else
                        {
                            if (twelve == true)
                                s3[i, d] = "";
                            k--;
                        }
                        // Console.Write(s3[i, d] + " ");
                    }
                }
            }
            for (int d = 0; d < s.Length; d++)
            {
                for (int b = 0; b < len; b++)
                {
                    Console.Write(s3[d, b] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            string[] s4 = new string[s.Length];
            bool w = false;
            int a, g;
            for (a = 0; a < s.Length; a++)
            {
                for (g = 0; g < len; g++)
                {
                    if (s3[a, g] != null)
                    {
                        s4[a] += s3[a, g];
                    }
                    else
                    {
                        if (g != 0)
                            a++;
                        w = true;
                        Array.Resize(ref s4, a); //для массива 12345678 со словом 1234 ----   a+1 -> a
                        break;
                    }
                }
                if (w == true)
                {
                    //a++; //для массива 12345678 со словом 1234 ----   a+1 -> a
                    break;
                }
            }
            for (int d = 0; d < a; d++)
            {
                Console.Write(s4[d] + " ");
            }
            Console.WriteLine();
            int[] result = new int[a];
            for (int c = 0; c < a; c++)
            {
                string values = s4[c].ToString();
                string subs3 = subs.Substring(0, 1);
                if (values.Contains(subs))
                {
                    for (int m = 0; m < a; m++)
                    {
                        if (m == 0)
                        {
                            if ((m + subs.Length) >= a)
                            {
                                if (s3[c, m] == subs3)
                                {
                                    result[c] = 1;
                                    break;
                                }
                            }
                            else if ((m + subs.Length) < a)
                            {
                                if ((s3[c, m] == subs3) && ((s3[c, m + subs.Length] == " ") || s3[c, m + subs.Length] == null))
                                {
                                    result[c] = 1;
                                    break;
                                }
                            }
                        }
                        else if (m != 0)
                        {
                            if ((s3[c, m] == subs3) && (s3[c, m - 1] == " ") && ((s3[c, m + subs.Length] == " ") || s3[c, m + subs.Length] == null))
                            {
                                result[c] = 1;
                                break;
                            }
                        }
                        else
                            result[c] = 0;
                    }
                }
                else
                    result[c] = 0;
            }
            return result;
        }
        static void Main()
        {
            //string s = "123 456 7899 99";
            //string subs = "99";
            //int len = 2;
            string s = "1) строкsdfgsdfgа разбивается на набор строsdfgsdfgdsк через выравнивание по заданной ширине.";
            string subs = "строк";
            int len = 12;
            int[] findword;
            findword = WordSearch(len, s, subs);
            for (int i = 0; i < findword.Length; i++)
            {
                Console.Write(findword[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
#endregion