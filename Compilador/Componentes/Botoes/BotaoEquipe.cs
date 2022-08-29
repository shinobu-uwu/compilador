namespace Compilador.Componentes.Botoes;

public sealed class BotaoEquipe : BotaoBarraFerramentas
{
    public BotaoEquipe()
    {
        Text = "Equipe";
        ToolTipText = "Equipe (F1)";

        Click += (sender, args) =>
        {
            FormPrincipal.GetInstancia().AreaMensagens.Text += @"Integrantes da equipe:
Matheus Filipe dos Santos Reinert
Leonardo Linhares Silva";
        };
    }
}