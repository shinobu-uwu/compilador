using Compilador.Componentes.Botoes;

namespace Compilador.Componentes;

public sealed class BarraFerramentas : MenuStrip
{
    private const int Altura = 70;

    public BarraFerramentas()
    {
        BackColor = Color.White;
        Anchor = AnchorStyles.Top | AnchorStyles.Left;
        Location = new Point(0, 0);
        Size = new Size(ClientSize.Width, Altura);
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