using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    public class Tren
    {
        public List<int> Vagones { get; set; }

        public Tren(List<int> vagones)
        {
            Vagones = vagones;
        }

        public void MostrarTren()
        {
            Console.WriteLine("Tren:\n");
            if (Vagones.Count > 0)
                Console.Write($"[{Vagones[0]}]");

            for (var i = 1; i < Vagones.Count; i++)
            {
                Console.Write($" - [{Vagones[i]}]");
            }
        }

        public void EngancharIzquierda(int num)
        {
            Vagones.Insert(0, num);
        }

        public void EngancharDerecha(int num)
        {
            Vagones.Add(num);
        }

        public void DesengancharIzquierda()
        {
            Vagones.RemoveAt(0);
        }

        public void DesengancharDerecha()
        {
            Vagones.RemoveAt(Vagones.Count - 1);
        }
    }
}
