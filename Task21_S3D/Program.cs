int x1 = Coordinate("x", "A");
 int y1 = Coordinate("y", "A");
 int z1 = Coordinate("z", "A");
 int x2 = Coordinate("x", "B");
 int y2 = Coordinate("x", "B");
 int z2 = Coordinate("x", "B");

 (int, int, int ) a = (1, 2, 3);

 double rast = Math.Round((Rasstoyanie(x1, y1, z1, x2, y2, z2)), 2);
 Console.WriteLine($"Длина отрезка {rast}");

 int Coordinate(string coor, string tochka)
 {
    Console.Write($"Введите координату {coor} точки {tochka}: ");
    int vvod = Convert.ToInt32(Console.ReadLine());
    return vvod;
 }

double Rasstoyanie (double arg1, double arg2, double arg3, double arg4, double arg5, double arg6)
 {
    double answer = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
    return answer;
 }