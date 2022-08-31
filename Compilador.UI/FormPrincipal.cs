using Compilador.UI.Componentes;

namespace Compilador.UI;

public sealed class FormPrincipal : Form
{
    private const int LarguraJanela = 910;
    private const int AlturaJanela = 600;

    private static FormPrincipal? _instancia;

    public readonly BarraFerramentas BarraFerramentas = new();
    public readonly TextoEditor TextoEditor = new();
    public readonly BarraStatus BarraStatus = new();
    public readonly AreaMensagens AreaMensagens = new();
    public string? CaminhoArquivoAberto;

    public static FormPrincipal GetInstancia()
    {
        if (_instancia is null)
        {
            _instancia = new FormPrincipal();
        }

        return _instancia;
    }

    private FormPrincipal()
    {
        Size = new Size(LarguraJanela, AlturaJanela);
        KeyPreview = true;
        Controls.Add(BarraFerramentas);
        Controls.Add(TextoEditor);
        Controls.Add(BarraStatus);
        Controls.Add(AreaMensagens);
    }

    protected override void OnKeyDown(KeyEventArgs e)
    {
        // Para os atalhos apenas simulamos os cliques dos botões
        switch (e.KeyCode)
        {
            case Keys.F7:
                BarraFerramentas.BotaoCompilar.PerformClick();
                break;
            case Keys.F1:
                BarraFerramentas.BotaoEquipe.PerformClick();
                break;
            case Keys.Control:
            case Keys.N:
                BarraFerramentas.BotaoNovo.PerformClick();
                break;
            case Keys.O:
                BarraFerramentas.BotaoAbrir.PerformClick();
                break;
            case Keys.S:
                BarraFerramentas.BotaoSalvar.PerformClick();
                break;
        }

        base.OnKeyDown(e);
    }
}