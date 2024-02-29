namespace TextBasedRPG;

public partial class GamePage : ContentPage
{
  //------------------------------------------------------------------------------------------------

  List<HistoryStep> historia = new List<HistoryStep>();
  HistoryStep HistoryStepAtual;

  //------------------------------------------------------------------------------------------------

	public GamePage()
	{
		InitializeComponent();

    historia.Add(new HistoryStep()
    {
      Id = 0,
      Texto = "Olá Forasteiro, parece que você não come nem bebe nada há muito tempo! Para que essa espada? E por quê esse sangue em sua roupa?",
      TemResposta=false
    });
    historia.Add(new HistoryStep()
    {
      Id = 1,
      Texto = "Desculpe tantas perguntas! Não vemos muitas pessoas diferentes por aqui! Você aceita água?",
      TemResposta=true,
      TextoDaResposta01="Sim, por favor",
      TextoDaResposta02="Não, estou bem",
      TextoDaResposta03="Para de me encher",
      IdLevelResposta01=2,
      IdLevelResposta02=4998,
      IdLevelResposta03=5000
    });
    historia.Add(new HistoryStep()
    {
      Id = 2,
      Texto = "Siga-me! Vou te levar até o poço",
      TemResposta=false,
    });
    historia.Add(new HistoryStep()
    {
      Id = 3,
      Texto = "Esse é o nosso poço! Já tivemos mais água aqui, assim como tinhámos crianças brincando por toda parte sobre a grama verde. Mas aquele monstro maldito... aquele monstro... queimou tudo!!",
      TemResposta=false,
    });
    historia.Add(new HistoryStep()
    {
      Id = 4,
      Texto = "Essa sua espada... consegue cortar pele de dragão?",
      TemResposta=false,
    });
    historia.Add(new HistoryStep()
    {
      Id = 5,
      Texto = "(continua)",
      HeroIsDead=true
    });
    historia.Add(new HistoryStep()
    {
      Id = 4998,
      Texto = "Ok...",
      TemResposta=false,
    });
    historia.Add(new HistoryStep()
    {
      Id = 4999,
      Texto = "(morreu de sede)",
      TemResposta=false,
      HeroIsDead=true
    });
    historia.Add(new HistoryStep()
    {
      Id = 5000,
      Texto = "(Golpe de Faca) Não seja mal-educado!",
      TemResposta=false,
      HeroIsDead=true
    });

    Iniciar();
	}

  //------------------------------------------------------------------------------------------------

  void Iniciar()
  {
    TrocaHistoryStepAtual(0);
  }

  //------------------------------------------------------------------------------------------------

  void PreencherPagina()
  {
    labelTexto.Text = HistoryStepAtual.Texto;

    if (HistoryStepAtual.HeroIsDead)
      frameGameOver.IsVisible = true;
    else
      frameGameOver.IsVisible = false;

    if (HistoryStepAtual.TemResposta)
    {
      buttonVerMais.IsVisible = false;
      buttonResposta01.IsVisible = true;
      buttonResposta02.IsVisible = true;
      buttonResposta03.IsVisible = true;
      buttonResposta01.Text = HistoryStepAtual.TextoDaResposta01;
      buttonResposta02.Text = HistoryStepAtual.TextoDaResposta02;
      buttonResposta03.Text = HistoryStepAtual.TextoDaResposta03;
    }
    else
    {
      buttonVerMais.IsVisible = true;
      buttonResposta01.IsVisible = false;
      buttonResposta02.IsVisible = false;
      buttonResposta03.IsVisible = false;
    }
  }

  //------------------------------------------------------------------------------------------------

  void TrocaHistoryStepAtual(int id)
  {
    HistoryStepAtual = historia.Where(d => d.Id == id).First();
    PreencherPagina();
  }

  //------------------------------------------------------------------------------------------------

  void OnButtonVerMaisClicked(object sender, EventArgs args)
  {
    var proximoId = HistoryStepAtual.Id + 1;
    TrocaHistoryStepAtual(proximoId);
  }

  //------------------------------------------------------------------------------------------------

  void OnButton01Clicked(object sender, EventArgs args)
  {
    TrocaHistoryStepAtual(HistoryStepAtual.IdLevelResposta01);
  }

  //------------------------------------------------------------------------------------------------

  void OnButton02Clicked(object sender, EventArgs args)
  {
    TrocaHistoryStepAtual(HistoryStepAtual.IdLevelResposta02);
  }

  //------------------------------------------------------------------------------------------------

  void OnButton03Clicked(object sender, EventArgs args)
  {
    TrocaHistoryStepAtual(HistoryStepAtual.IdLevelResposta03);
  }

  //------------------------------------------------------------------------------------------------

  void OnGameOverButtonClicked(object sender, EventArgs args)
  {
    Iniciar();
  }

  //------------------------------------------------------------------------------------------------

}