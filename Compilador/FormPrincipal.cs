using Compilador.Componentes;

namespace Compilador;

public class FormPrincipal : Form
{
    private const int LarguraJanela = 910;
    private const int AlturaJanela = 600;

    private static FormPrincipal? _instancia;
    
    public BarraFerramentas BarraFerramentas { get; } = new();
    public TextoEditor TextoEditor { get; } = new();
    public BarraStatus BarraStatus { get; } = new();


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
        var layout = new FlowLayoutPanel();
        layout.Dock = DockStyle.Fill;
        layout.FlowDirection = FlowDirection.TopDown;
        layout.WrapContents = false;
        layout.Controls.Add(BarraFerramentas);
        layout.Controls.Add(TextoEditor);
        layout.Controls.Add(BarraStatus);
        Controls.Add(layout);
        ResizeRedraw = true;
    }
}