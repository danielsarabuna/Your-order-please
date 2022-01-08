using System;
using System.Text;

public class Program
{  
  public static string Order(string Text)
  {
    if(Text == string.Empty) return Text;
    StringBuilder builder = new StringBuilder(string.Empty);
    string[] Words = Text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    for(int i = 1; i < 10; i++)
      foreach(string word in Words)
        if(word.Contains(i.ToString()))
          builder.Append(i == 1 ? word : " " + word);
    return builder.ToString();
  }
}