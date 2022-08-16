// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int x1 = 7; int y1 = -5; int z1 = 0;
int x2 = 1; int y2 = -1; int z2 = 9;

List<int> a = new List<int>()
    {
        x1, y1, z1
    };
string res1 = string.Join(";", a.ToArray());

List<int> b = new List<int>()
    {
        x2, y2, z2
    };

string res2 = string.Join(";", b.ToArray());

double x = (b[0] - a[0])*(b[0] - a[0]);
double y = (b[1] - a[1])*(b[1] - a[1]);
double z = (b[2] - a[2])*(b[2] - a[2]);

double S = Math. Sqrt(x+y+z);
Console.WriteLine(S);