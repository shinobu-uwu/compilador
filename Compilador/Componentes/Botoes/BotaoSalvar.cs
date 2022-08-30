using System.Windows.Forms.VisualStyles;

namespace Compilador.Componentes.Botoes;

public sealed class BotaoSalvar : BotaoBarraFerramentas
{
    public BotaoSalvar()
    {
        Text = "Salvar";
        ToolTipText = "Salvar (ctrl + s)";
    }

    protected override void OnClick(EventArgs e)
    {
        var form = FormPrincipal.GetInstancia();

        if (form.CaminhoArquivoAberto is null)
        {
            var dialog = new SaveFileDialog();

            if (dialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            form.CaminhoArquivoAberto = dialog.FileName;
        }

        File.WriteAllText(form.CaminhoArquivoAberto, form.TextoEditor.Text);

        base.OnClick(e);
    }
}