namespace MauiAppCurso
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Registra as rotas para navegação
            Routing.RegisterRoute(nameof(MauiAppCurso.Views.DisciplinaWebPage), typeof(MauiAppCurso.Views.DisciplinaWebPage));
            Routing.RegisterRoute(nameof(MauiAppCurso.Views.DisciplinaAnalisePage), typeof(MauiAppCurso.Views.DisciplinaAnalisePage));
            // Registre as outras rotas aqui
        }
    }
}
