namespace MauiAppCurso.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Exemplo de navegação para página de uma disciplina
        private async void GoToDisciplinaWeb(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(DisciplinaWebPage));
        }

        private async void GoToDisciplinaAnalise(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(DisciplinaAnalisePage));
        }
    }
}
