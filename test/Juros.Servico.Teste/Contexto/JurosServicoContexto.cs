using Juros.Servico.Interface;

namespace Juros.Servico.Teste.Contexto
{
    public class JurosServicoContexto
    {
        public JurosServicoContexto() { }

        public IJurosServico Create() => new JurosServico();
    }
}
