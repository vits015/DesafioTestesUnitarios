using System;
using System.Collections.Generic;
using System.Text;

namespace NewTalents
{
    public class Calculadora
    {
        private List<string> _listaHistorico;

        public Calculadora()
        {
            _listaHistorico = new List<string>();
        }

        public int Somar(int a, int b)
        {
            int res = a + b;

            _listaHistorico.Insert(0, $"Resultado: {res}");
            return res;
        }
        public int Subtrair(int a, int b)
        {
            int res = a - b;

            _listaHistorico.Insert(0, $"Resultado: {res}");
            return res;
        }
        public int Multiplicar(int a, int b)
        {
            int res = a * b;

            _listaHistorico.Insert(0, $"Resultado: {res}");
            return res;
        }
        public int Dividir(int a, int b)
        {
            int res = a / b;

            _listaHistorico.Insert(0, $"Resultado: {res}");
            return res;
        }
        public List<string> Historico()
        {
            _listaHistorico.RemoveRange(3,_listaHistorico.Count - 3);

            return _listaHistorico;
        }
    }
}
