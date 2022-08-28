namespace Compilador.Componentes.Botoes;

public sealed class BotaoCompilar : BotaoBarraFerramentas
{
    public BotaoCompilar()
    {
        Text = "Compilar";
        ToolTipText = "Compilar arquivo (F7)";
    }
}