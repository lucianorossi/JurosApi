using Juros.Servico.Interface;
using System;

namespace Juros.Servico
{
    public class JurosServico : IJurosServico
    {
        private const double juros = 0.01;

        decimal IJurosServico.CalculaJurosCompostos(decimal valorInicial, int meses) =>
            Arredondar(valorInicial * (decimal)Math.Pow((1 + juros), meses < 0 ? 0 : meses));

        private decimal Arredondar(decimal valor) => (decimal)(long)(valor * 100) / 100;
    }
}
