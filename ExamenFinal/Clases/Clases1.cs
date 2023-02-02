using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal.Clases
{
    public class Clases1
    {
        public int a { get; set; }
        public int m { get; set; }
        public int x0 { get; set; }
        public int numeroDatos { get; set; }

        public Clases1() 
        { 
        }
        public Clases1(Clases1 demanda1) 
        {
            a = demanda1.a;
            m = demanda1.m;
            x0 = demanda1.x0;
            numeroDatos= demanda1.numeroDatos;      
        }
    }
}
