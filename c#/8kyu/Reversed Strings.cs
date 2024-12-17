using System;

public static class Kata
{
  public static string Solution(string str) 
  {
    char[] strArray = str.ToCharArray();
    Array.Reverse(strArray);
    return new string(strArray);
  }
}