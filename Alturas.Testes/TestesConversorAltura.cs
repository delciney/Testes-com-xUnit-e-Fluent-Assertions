using System;
using Xunit;
using FluentAssertions;

namespace Alturas.Testes
{
    public class TestesConversorAltura
    {
        [Theory]
        [InlineData(1, 0.3048)]
        [InlineData(10, 3.048)]
        [InlineData(55.555, 16.9332)]
        [InlineData(100, 30.48)]
        public void TesteConversorAltura(double pes, double metros)
        {
            double resultado = ConversorAltura.PesParaMetros(pes);
            resultado.Should().Be(metros,
                $"Altura em metros não corresponde ao valor esperado ({metros})");
        }

        [Fact]
        public void TesteConversorAltura1()
        {
            double resultado = ConversorAltura.PesParaMetros(1);
            Assert.Equal(0.3048, resultado);
        }
    }
}
