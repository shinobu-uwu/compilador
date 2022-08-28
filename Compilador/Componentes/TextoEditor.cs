namespace Compilador.Componentes;

public sealed class TextoEditor : RichTextBox
{
    public TextoEditor()
    {
        BackColor = Color.White;
        Anchor = AnchorStyles.Top;
        Dock = DockStyle.Fill;
        ScrollBars = RichTextBoxScrollBars.ForcedBoth;
        WordWrap = false;
        AcceptsTab = true;
    }
}