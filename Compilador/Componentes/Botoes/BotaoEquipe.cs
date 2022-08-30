namespace Compilador.Componentes.Botoes;

public sealed class BotaoEquipe : BotaoBarraFerramentas
{
    public BotaoEquipe()
    {
        Text = "Equipe";
        ToolTipText = "Equipe (F1)";
    }

    protected override void OnClick(EventArgs e)
    {
        FormPrincipal.GetInstancia().AreaMensagens.EscreverMensagem(@"Integrantes da equipe:
Matheus Filipe dos Santos Reinert
Leonardo Linhares Silva");
        base.OnClick(e);
    }
}