namespace Compilador.Componentes.Botoes;

public sealed class BotaoSalvar : BotaoBarraFerramentas
{
    public BotaoSalvar()
    {
        Text = "Salvar";
        ToolTipText = "Salvar (ctrl + s)";
    }
}