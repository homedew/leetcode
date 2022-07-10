// https://leetcode.com/problems/valid-palindrome/
// 125. Valid Palindrome
// A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.

// Given a string s, return true if it is a palindrome, or false otherwise.

 

// Example 1:

// Input: s = "A man, a plan, a canal: Panama"
// Output: true
// Explanation: "amanaplanacanalpanama" is a palindrome.
// Example 2:

// Input: s = "race a car"
// Output: false
// Explanation: "raceacar" is not a palindrome.
// Example 3:

// Input: s = " "
// Output: true
// Explanation: s is an empty string "" after removing non-alphanumeric characters.
// Since an empty string reads the same forward and backward, it is a palindrome.
// ------------------------------------------------------------------------------------------------------

// This solution still not good
using System.Text.RegularExpressions;
public class Solution {
    public bool IsPalindrome(string s) {
        Regex regex = new Regex("[^a-zA-Z0-9]");
        string onlyAlphabet = regex.Replace(s, String.Empty).ToLower();
        
        char [] charArray = onlyAlphabet.ToCharArray();
        string reverseString = string.Empty;

        for(int i = charArray.Length - 1; i > -1; i--) {
            reverseString+= charArray[i];
        }

        if(onlyAlphabet == reverseString) {
            return true;
        }
        return false;
    }
}