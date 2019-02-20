namespace Juros.Servico.Interface
{
    public interface IJurosServico
    {
        /// <summary>
        /// Aplica juros compostos sobre o valor inicial conforme a quantidade de meses
        /// </summary>
        /// <param name="valorInicial">Valor a ser corrigido</param>
        /// <param name="meses">Meses para aplicar a correção</param>
        /// <returns></returns>
        decimal CalculaJurosCompostos(decimal valorInicial, int meses);
    }
}
