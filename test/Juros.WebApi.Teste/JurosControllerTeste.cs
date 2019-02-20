using Juros.WebApi.Teste.Contexto;
using Moq;
using Shouldly;
using Xunit;

namespace Juros.WebApi.Teste
{
    public class JurosControllerTeste
    {
        private readonly JurosControllerContexto contexto;

        public JurosControllerTeste() =>
            contexto = new JurosControllerContexto();

        [Fact]
        public void DeveChamarServicoParaCalcularJurosCompostos()
        {
            contexto.JurosServico
                .Setup(x => x.CalculaJurosCompostos(It.IsAny<decimal>(), It.IsAny<int>()))
                .Returns(105.10m);

            var controller = contexto.Create();

            controller.Get(100, 5);

            contexto.JurosServico.Verify(x => x.CalculaJurosCompostos(100, 5), Times.Once);
        }

        [Fact]
        public void DeveRetornarOValorObtidoPeloCalculoNoServico()
        {
            contexto.JurosServico
                .Setup(x => x.CalculaJurosCompostos(It.IsAny<decimal>(), It.IsAny<int>()))
                .Returns(105.10m);

            var controller = contexto.Create();

            var resultado = controller.Get(100, 5);

            resultado.Value.ShouldBe("105.10");
        }
        [Fact]
        public void DeveRetornarOValorComDuasCasasDecimais()
        {
            contexto.JurosServico
                .Setup(x => x.CalculaJurosCompostos(It.IsAny<decimal>(), It.IsAny<int>()))
                .Returns(105.1m);

            var controller = contexto.Create();

            var resultado = controller.Get(100, 5);

            resultado.Value.ShouldBe("105.10");
        }

    }
}
