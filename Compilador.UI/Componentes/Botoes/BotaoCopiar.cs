namespace Compilador.UI.Componentes.Botoes;

public sealed class BotaoCopiar : BotaoBarraFerramentas
{
    public BotaoCopiar()
    {
        Text = "Copiar";
        ToolTipText = "Copiar (ctrl + c)";
    }

    protected override void OnClick(EventArgs e)
    {
        Clipboard.SetText(FormPrincipal.GetInstancia().TextoEditor.SelectedText);
        base.OnClick(e);
    }
}