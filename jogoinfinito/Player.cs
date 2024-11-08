
public delegate void Callback();
{
    public class Player : Animacao
    {
public Player (Image a) : base (a)
{
    for (int i = 1; i <= 05; ++i)
    Animacao1.Add ($ "andar {i.ToString ("D2")}.png");
    for (int i = 1; i <= 2; ++i)
    Animacao1.Add ($ " {i.ToString ("D2")}.png");
}
SetAnimacaoAtiva(1);
}
public void Die()
{
    Lookup=false;
    SetAnimacaoAtiva(2);
}

public void Run()
{
  Lookup=true;
  SetAnimacaoAtiva(1);
  Player();

} 
}