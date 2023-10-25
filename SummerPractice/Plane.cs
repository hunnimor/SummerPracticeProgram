using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerPractice
{
    class Plane
    {
        int a;
        int b;
        int c;
        int d;

        // конструктор
        public Plane(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
       
        // угол пересечения произвольной прямой и плоскости
        public double angle(double l, double m, double n)
        {
            double sinF = Math.Abs(a*l+b*m+c*n)/(Math.Sqrt(a*a+b*b+c*c)*Math.Sqrt(l*l+m*m+n*n));
            return sinF;
        }

        // cоотношение между плоскостями
        public string relationships(Plane other)
        {
            string result;
            double lamda = this.a / other.a;
            if (((this.b / other.b) == lamda) && ((this.c / other.c) == lamda) && ((this.d / other.d) == lamda))
            {
                result = "Совподающие плоскости";
            }
            else if (((this.b / other.b) == lamda) && ((this.c / other.c) == lamda) && ((this.d / other.d) != lamda))
            {
                result = "Параллельные плоскости";
            }
            else
            {
                result = "Пересекающиеся плоскости";
            }
            return result;
        }
    }
}
