namespace Compilador.Componentes;

public sealed class AreaMensagens : RichTextBox
{
    public AreaMensagens()
    {
        Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
        BackColor = Color.White;
        ReadOnly = true;
        Location = new Point(13, 440);
        Size = new Size(870, 100);
        ScrollBars = RichTextBoxScrollBars.ForcedBoth;
        WordWrap = false;
        AcceptsTab = true;
        Multiline = true;
    }
}