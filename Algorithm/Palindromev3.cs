//two pointers
using System.Text.RegularExpressions;
public class Solution {
    public bool IsPalindrome(string s) {
        if(s.Length < 2) return true;
        Regex regex = new Regex("[^a-zA-Z0-9]");
        string onlyAlphabet = regex.Replace(s, String.Empty).ToLower();
        
        char [] charArray = onlyAlphabet.ToCharArray();
        
        int i = 0, j = charArray.Length - 1;
        
        while(i < j) {
            if(charArray[i] != charArray[j]) {
                return false;
            }
            
            i++;
            j--;
        }
      
        return true;
    }
}