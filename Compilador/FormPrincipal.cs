using Compilador.Componentes;

namespace Compilador;

public sealed class FormPrincipal : Form
{
    private const int LarguraJanela = 910;
    private const int AlturaJanela = 600;

    private static FormPrincipal? _instancia;

    public readonly BarraFerramentas BarraFerramentas = new();
    public readonly TextoEditor TextoEditor = new();
    public readonly BarraStatus BarraStatus = new();
    public readonly AreaMensagens AreaMensagens = new();

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
        Controls.Add(BarraFerramentas);
        Controls.Add(TextoEditor);
        Controls.Add(BarraStatus);
        Controls.Add(AreaMensagens);
    }
}