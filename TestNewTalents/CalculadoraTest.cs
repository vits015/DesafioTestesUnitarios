using System;
using Xunit;
using NewTalents;
using System.Collections.Generic;

namespace TestNewTalents
{
    public class CalculadoraTest
    {
        private Calculadora _calc = new Calculadora();   
        

        [Theory]
        [InlineData (1, 2, 3)]
        [InlineData(4, 5, 9)]
        [InlineData(6, 3, 9)]
        public void TesteSomar(int val1, int val2, int resultado)
        {
            int retultadoCalculadora = _calc.Somar(val1,val2);

            Assert.Equal(resultado, retultadoCalculadora);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        [InlineData(6, 3, 18)]
        public void TesteMultiplicar(int val1, int val2, int resultado)
        {
            int retultadoCalculadora = _calc.Multiplicar(val1, val2);

            Assert.Equal(resultado, retultadoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        [InlineData(8, 2, 4)]
        public void TesteDividir(int val1, int val2, int resultado)
        {
            int retultadoCalculadora = _calc.Dividir(val1, val2);

            Assert.Equal(resultado, retultadoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 4)]
        [InlineData(5, 5, 0)]
        [InlineData(8, 2, 6)]
        public void TesteSubtrair(int val1, int val2, int resultado)
        {
            int retultadoCalculadora = _calc.Subtrair(val1, val2);

            Assert.Equal(resultado, retultadoCalculadora);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Assert.Throws<DivideByZeroException>(
                 () => _calc.Dividir(3, 0)
            );
        }

        [Fact]
        public void TestarHistorico()
        {
            _calc.Somar(1, 2);
            _calc.Somar(2, 8);
            _calc.Somar(3, 7);

            var lista = _calc.Historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);

        }
    }
}
