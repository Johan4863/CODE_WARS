public class Kata
{
  public string Rps(string p1, string p2)
  {
    if(p1==p2){
      return "Draw!";
    }else{
      return (p1=="paper"&&p2!="scissors"||p1=="rock"&&p2!="paper"||p1=="scissors"&&p2!="rock")
    ? "Player 1 won!" : "Player 2 won!"; 
    }
  }
}