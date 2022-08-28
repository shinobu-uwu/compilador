namespace Compilador.Componentes.Botoes;

public sealed class BotaoCopiar : BotaoBarraFerramentas
{
    public BotaoCopiar()
    {
        Text = "Copiar";
        ToolTipText = "Copiar (ctrl + c)";
    }
}