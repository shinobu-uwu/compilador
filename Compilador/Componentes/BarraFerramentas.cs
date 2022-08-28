using Compilador.Componentes.Botoes;

namespace Compilador.Componentes;

public sealed class BarraFerramentas : MenuStrip
{
    public BarraFerramentas()
    {
        Dock = DockStyle.Top;
        Size = new Size(900, 70);
        AddBotoes();
    }

    private void AddBotoes()
    {
        ToolStripItem[] botoes =
        {
            new BotaoNovo(),
            new BotaoAbrir(),
            new BotaoSalvar(),
            new BotaoCopiar(),
            new BotaoColar(),
            new BotaoRecortar(),
            new BotaoCompilar(),
            new BotaoEquipe(),
        };
        
        Items.AddRange(botoes);
    }
}