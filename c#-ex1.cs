/*
Shaheen Ghazazani // 2016 // C# Code Wars Rank up 
Problem:
Given a string, swap the case for each of the letters.

e.g. CodEwArs --> cODeWaRS

Examples

Kata.Swap("") == ""
Kata.Swap("CodeWars") == "cODEwARS"
Kata.Swap("abc") == "ABC"
Kata.Swap("ABC") == "abc"
Kata.Swap("123235") == "123235"
*/

//Solution:
using System;

public static class Kata {
  public static string Swap(string str) {
    char[] strArr = str.ToCharArray();
    for (var i = 0; i < str.Length; i++){
      if (char.IsUpper(str[i])){
        strArr[i] = char.ToLower(str[i]);
      }else if (char.IsLower(str[i])){
        strArr[i] = char.ToUpper(str[i]);
      }
    }
    return new string(strArr); 
  }
}