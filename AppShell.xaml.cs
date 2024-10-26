using MauiAppCurso.Views;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(DisciplinaWebPage), typeof(DisciplinaWebPage));
        Routing.RegisterRoute(nameof(DisciplinaAnalisePage), typeof(DisciplinaAnalisePage));
        //Routing.RegisterRoute(nameof(DisciplinaDesignDigitalPage), typeof(DisciplinaDesignDigitalPage));
        //Routing.RegisterRoute(nameof(DisciplinaFundamentosInformaticaPage), typeof(DisciplinaFundamentosInformaticaPage));
        //Routing.RegisterRoute(nameof(DisciplinaTecnicasProgramacaoPage), typeof(DisciplinaTecnicasProgramacaoPage));
        //Routing.RegisterRoute(nameof(DisciplinaBancoDadosPage), typeof(DisciplinaBancoDadosPage));
        //Routing.RegisterRoute(nameof(DisciplinaDesenvolvimentoSistemasPage), typeof(DisciplinaDesenvolvimentoSistemasPage));
        //Routing.RegisterRoute(nameof(DisciplinaEticaCidadaniaPage), typeof(DisciplinaEticaCidadaniaPage));
        //Routing.RegisterRoute(nameof(DisciplinaProgramacaoMobilePage), typeof(DisciplinaProgramacaoMobilePage));
        //Routing.RegisterRoute(nameof(DisciplinaInternetSegurancaPage), typeof(DisciplinaInternetSegurancaPage));
        //Routing.RegisterRoute(nameof(DisciplinaTCCPage), typeof(DisciplinaTCCPage));
        //Routing.RegisterRoute(nameof(DisciplinaQualidadeTestePage), typeof(DisciplinaQualidadeTestePage));
        //Routing.RegisterRoute(nameof(DisciplinaSistemasEmbarcadosPage), typeof(DisciplinaSistemasEmbarcadosPage));
    }
}
