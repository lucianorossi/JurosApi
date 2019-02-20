using Juros.Servico.Interface;
using Juros.WebApi.Controllers;
using Moq;

namespace Juros.WebApi.Teste.Contexto
{
    public class JurosControllerContexto
    {
        public Mock<IJurosServico> JurosServico { get; set; }

        public JurosControllerContexto() =>
            JurosServico = new Mock<IJurosServico>();

        public JurosController Create()
        {
            var controller = new JurosController(JurosServico.Object);

            return controller;
        }
    }
}
