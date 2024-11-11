public delegate void Callback();
public class Player: jogoinfinito.Animacao
{
    public Player(Image a) : base(a)
    {
        for (int i = 1; i <= 5; ++i)
            Animacao01.Add($"player { i.ToString("D2")}.png");
        for (int i = 1; i <= 2; ++i)
            Animacao01.Add($"playerdead { i.ToString("D2")}.png");
    }
    public void Run()
{
  loop=true;
  SetAnimacaoAtiva(1);
  Play();

} 
}