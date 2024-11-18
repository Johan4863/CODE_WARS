using System;

public static class Kata
{
  public static int CountSheeps(bool[] sheeps){
    int sheepCounter = 0;
    foreach(bool sheep in sheeps){
      if(sheep){
      sheepCounter++;
      }
    }
    return sheepCounter;
  }
}