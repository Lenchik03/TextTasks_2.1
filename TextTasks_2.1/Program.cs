//задание 1
//int. TryParse(Console.ReadLine(), out int a);
//int.TryParse(Console.ReadLine(), out int b);
//int.TryParse(Console.ReadLine(), out int c);

//if (a > 0)
//a = Math.Pow(a, 2);
//    Console.WriteLine(Math.Pow(a, 2));
//else
//    Console.WriteLine(Math.Pow(a, 4));
//Console.WriteLine(a);

//if (b > 0)
//    Console.WriteLine(Math.Pow(b, 2));
//else
//    Console.WriteLine(Math.Pow(b, 4));


//if (c > 0)
//    Console.WriteLine(Math.Pow(c, 2));

//else
//    Console.WriteLine(Math.Pow(c, 4));

//задание 2
//int.TryParse(Console.ReadLine(), out int x1);
//int.TryParse(Console.ReadLine(), out int y1);
//int.TryParse(Console.ReadLine(), out int x2);
//int.TryParse(Console.ReadLine(), out int y2);

//double z1 = Math.Pow(x1, 2) + Math.Pow(y1, 2);
//double z2 = Math.Pow(x2, 2) + Math.Pow(y2, 2);

//if (z1 < z2)
//    Console.WriteLine("Точка А ближе");
//else 
//    Console.WriteLine("Точка Б ближе");

//задание 3
//int.TryParse(Console.ReadLine(), out int a);
//int.TryParse(Console.ReadLine(), out int b);

//double c = 180 - (a + b);
//if (a + b + c == 180 && c>0)
//    Console.WriteLine("ТАКОЙ ТРЕУГОЛЬНИК ВОЗМОЖЕН");
//else
//{
//    Console.WriteLine("НЕВОЗМОЖЕН");
//    return;
//}
//if (a == 90 || b == 90 || c == 90)
//    Console.WriteLine("Прямоугольный");
//else
//    Console.WriteLine("НЕ прямоугольный");

//задание 4
//int.TryParse(Console.ReadLine(), out int x);
//int.TryParse(Console.ReadLine(), out int y);
//int x1 = x, y1 = y;
//if (x < y)
//{
//    x = (x1 + y1) / 2;
//    y = x1 * y1 * 2;
//}
//else if (x > y)
//{
//    y = (x1 + y1) / 2;
//    x = x1 * y1 * 2;
//}
//else
//    Console.WriteLine("Числа не должны равняться!");

//Console.WriteLine(x);
//Console.WriteLine(y);

//задание 5
//int.TryParse(Console.ReadLine(), out int x);
//int.TryParse(Console.ReadLine(), out int y);

//if (x == 0 && y == 0)
//    Console.WriteLine("точка в начале координат");

//else if(x == 0 && (y>0 || y<0))
//    Console.WriteLine("На оси У");
//else if((y>0 || y<0) && y == 0)
//    Console.WriteLine("точка на оси Х");
//else if(x>0 && y>0)
//    Console.WriteLine("точка в 1 четверти");
//else if(x<0 && y>0)
//    Console.WriteLine("точка во 2 четверти");
//else if (x<0 && y<0)
//    Console.WriteLine("точка в 3 четверти");
//else
//    Console.WriteLine("точка в 4 четверти");

//задание 6
//int.TryParse(Console.ReadLine(), out int m);
//int.TryParse(Console.ReadLine(), out int n);
//int m1 = m, n1 = n;

//if (m != n && m < n)
//{
//    m = n1;
//Console.WriteLine(m);
//}

//else if(m != n && m > n)
//{
//    n = m1;
//    Console.WriteLine(n);
//}

//else
//{
//    m = 0;
//    n = 0;
//    Console.WriteLine(m);
//    Console.WriteLine(n);
//}

//задание 7
//int.TryParse(Console.ReadLine(), out int a);
//int.TryParse(Console.ReadLine(), out int b);
//int.TryParse(Console.ReadLine(), out int c);
//int k = 0;

//if (a < 0)
//    k += 1; // k = k+1;
//if (b < 0)
//    k += 1;
//if (c < 0)
//    k += 1;

//Console.WriteLine(k);

//задание 8
//int.TryParse(Console.ReadLine(), out int a);
//int.TryParse(Console.ReadLine(), out int b);
//int.TryParse(Console.ReadLine(), out int c);
//int k = 0;

//if (a > 0)
//    k += 1; // k = k+1;
//if (b > 0)
//    k += 1;
//if (c > 0)
//    k += 1;

//Console.WriteLine(k);

//задание 9
//?
//double.TryParse(Console.ReadLine(), out double x);
//int y = (int)x;
//if (x == y)
//{
//    Console.WriteLine("ЦЕЛОЕ");
//}
//else
//{ Console.WriteLine("NO"); }
//задание 10
//int.TryParse(Console.ReadLine(), out int a);
//int.TryParse(Console.ReadLine(), out int b);
//int.TryParse(Console.ReadLine(), out int c);
//int.TryParse(Console.ReadLine(), out int k);
//int yes = 0;

//if (a % k == 0)
//    yes += 1;
//if (b % k == 0)
//    yes += 1;
//if (c % k == 0)
//    yes += 1;

//Console.WriteLine(yes);

//задание 11
//int.TryParse(Console.ReadLine(), out int a);
//int.TryParse(Console.ReadLine(), out int b);
//int.TryParse(Console.ReadLine(), out int c);
//int.TryParse(Console.ReadLine(), out int m);

//if(m < a)
//{
//    Console.WriteLine("Заплатите: " + b + "r");
//}
//else if(m > a)
//{
//    double s = (m -a) * c + b;
//    Console.WriteLine("s");
//}

//задание 12
//string P = Console.ReadLine();
//if (P == "M")
//    Console.WriteLine("Мне нравятся девочки!");
//else if (P == "D")
//    Console.WriteLine("Мне нравятся мальчики!");

//else
//    Console.WriteLine("Ошибка!");

//задание 13
//int.TryParse(Console.ReadLine(), out int Vg);
//int.TryParse(Console.ReadLine(), out int t);
//int.TryParse(Console.ReadLine(), out int Va);
//int.TryParse(Console.ReadLine(), out int t1);

//double x = Va - Vg;
//double s = t * Vg - x * t1;

//if (s > 0)
//    Console.WriteLine("Грузовой впереди на " + s + " км");
//else
//    Console.WriteLine("Грузовой впереди на " + -s + " км");

//Никитина Алёна и Залевская Полина 



