using System;
using System.Collections.Generic;

namespace FriendLetter.Models
{
  public class MadLib
  {
    private string Exclamation = "";
    private string Adverb = "";
    private string Noun = "";
    private string Adjective = "";

    public MadLib(string exclamation, string adverb, string noun, string adjective)
    {
      Exclamation = exclamation;
      Adverb = adverb;
      Noun = noun;
      Adjective = adjective;
    }
    public string GetExclamation()
    {
      return Exclamation;
    }
    public string GetAdverb()
    {
      return Adverb;
    }
    public string GetNoun()
    {
      return Noun;
    }
    public string GetAdjective()
    {
      return Adjective;
    }
  }
}
