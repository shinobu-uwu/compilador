namespace Compilador.Componentes.Botoes;

public sealed class BotaoAbrir : BotaoBarraFerramentas
{
    public BotaoAbrir()
    {
        Text = "Abrir";
        ToolTipText = "Abrir arquivo (ctrl + o)";
        Click += (sender, args) =>
        {
            var dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var form = FormPrincipal.GetInstancia();
                form.BarraStatus.Text = dialog.FileName;
                form.TextoEditor.LoadFile(dialog.FileName);
            }
        };
    }
}