namespace MauiAppCurso.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Exemplo de navegação para cada página de disciplina

        private async void GoToDisciplinaWeb(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(DisciplinaWebPage));
        }

        private async void GoToDisciplinaAnalise(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(DisciplinaAnalisePage));
        }

        private async void GoToDisciplinaDesignDigital(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(DisciplinaDesignDigitalPage));
        }

        private async void GoToDisciplinaFundamentosInformatica(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(DisciplinaFundamentosInformaticaPage));
        }

        private async void GoToDisciplinaTecnicasProgramacao(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(DisciplinaTecnicasProgramacaoPage));
        }

        private async void GoToDisciplinaBancoDados(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(DisciplinaBancoDadosPage));
        }

        private async void GoToDisciplinaDesenvolvimentoSistemas(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(DisciplinaDesenvolvimentoSistemasPage));
        }

        private async void GoToDisciplinaEticaCidadania(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(DisciplinaEticaCidadaniaPage));
        }

        private async void GoToDisciplinaProgramacaoMobile(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(DisciplinaProgramacaoMobilePage));
        }

        private async void GoToDisciplinaInternetSeguranca(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(DisciplinaInternetSegurancaPage));
        }

        private async void GoToDisciplinaTCC(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(DisciplinaTCCPage));
        }

        private async void GoToDisciplinaQualidadeTeste(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(DisciplinaQualidadeTestePage));
        }

        private async void GoToDisciplinaSistemasEmbarcados(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(DisciplinaSistemasEmbarcadosPage));
        }

    }
}
