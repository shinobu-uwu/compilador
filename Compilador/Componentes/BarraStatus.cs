namespace Compilador.Componentes;

public sealed class BarraStatus : Label
{
    private const int Altura = 25;
    
    public BarraStatus()
    {
        Size = new Size(ClientSize.Width, Altura);
        Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        Text = "Editor iniciado!";
        Location = new Point(0, 540);
    }
}