namespace Compilador.Componentes;

public sealed class TextoEditor : RichTextBox
{
    public int AlturaLinha
    {
        get
        {
            using var graphics = CreateGraphics();
            return (int)graphics.MeasureString("A", Font).Height;
        }
    }

    public TextoEditor()
    {
        Size = new Size(870, 400);
        Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
        Location = new Point(13, 30);
        BackColor = Color.White;
        ScrollBars = RichTextBoxScrollBars.ForcedBoth;
        WordWrap = false;
        AcceptsTab = true;
        Multiline = true;
    }
}