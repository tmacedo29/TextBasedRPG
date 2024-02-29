
// Essa é uma classe que servirá para definir cada uma das partes da história
public class HistoryStep
{
  public int Id; // Esse é o código da parte da história, que deve ser único para cada HistoryStep
  public string? Texto; // Atributo para guardar o Texto que vai aparecer para o usuario
  public bool TemImagem = false; // Atributo para dizer se tem ou não uma imagem para mostrar
  public string? UrlDaImagem; // Em caso de ter imagem, esse atributo vai guardar OU o endereço da Imagem, ou o nome da Imagem (se ela estiver em resources/images)
  public bool TemResposta = false; // Atributo para dizer se é um texto para contar a história ou se é preciso responder algo para continuar
  public string? TextoDaResposta01; // Texto do primeiro botão de resposta
  public string? TextoDaResposta02; // Texto do segundo botão de resposta
  public string? TextoDaResposta03; // Texto do terceiro botão de resposta
  public int IdLevelResposta01; // Para qual Código do HistoryStep que o primeiro botão de respostas deve levar 
  public int IdLevelResposta02; // Para qual Código do HistoryStep que o segundo botão de respostas deve levar 
  public int IdLevelResposta03; // Para qual Código do HistoryStep que o terceiro botão de respostas deve levar 
  public bool HeroIsDead = false; // Atributo para dizer se nesse passo o Herói morreu
}