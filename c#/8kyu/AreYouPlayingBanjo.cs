using System;

public class Kata
{
  public static string AreYouPlayingBanjo(string name)
  {
    
    return (name[0] == 'r'||name[0] =='R') ? name + " plays banjo" : name + " does not play banjo";
  }
}