using Juros.Servico.Teste.Contexto;
using Shouldly;
using Xunit;

namespace Juros.Servico.Teste
{
    public class JurosServicoTeste
    {
        private readonly JurosServicoContexto contexto;

        public JurosServicoTeste() =>
            contexto = new JurosServicoContexto();

        [Fact]
        public void RetornaValorCorrigidoPorJurosCompostos()
        {
            var servico = contexto.Create();

            var resultado = servico.CalculaJurosCompostos(100, 5);

            resultado.ShouldBe(105.10m);
        }

        [Fact]
        public void RetornaOutroValorCorrigidoPorJurosCompostos()
        {
            var servico = contexto.Create();

            var resultado = servico.CalculaJurosCompostos(102.75m, 3);

            resultado.ShouldBe(105.86m);
        }

        [Fact]
        public void RetornaZeroSeValorInicialForZero()
        {
            var servico = contexto.Create();

            var resultado = servico.CalculaJurosCompostos(0, 5);

            var valor = new decimal(0);
            resultado.ShouldBe(valor);
        }

        [Fact]
        public void RetornaIgualValorInicialSeMesesForZero()
        {
            var servico = contexto.Create();

            var resultado = servico.CalculaJurosCompostos(100, 0);

            var valor = new decimal(100);
            resultado.ShouldBe(valor);
        }

        [Fact]
        public void RetornaIgualValorInicialSeMesesForNegativo()
        {
            var servico = contexto.Create();

            var resultado = servico.CalculaJurosCompostos(100, -1);

            var valor = new decimal(100);
            resultado.ShouldBe(valor);
        }
    }
}
