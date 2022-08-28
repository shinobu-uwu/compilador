namespace Compilador.Componentes.Botoes;

public sealed class BotaoRecortar : BotaoBarraFerramentas
{
    public BotaoRecortar()
    {
        Text = "Recortar";
        ToolTipText = "Recortar (ctrl + x)";
    }
}