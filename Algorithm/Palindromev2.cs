bool solution(string inputString) {
        Regex regex = new Regex("[^a-zA-Z0-9]");
        string onlyAlphabet = regex.Replace(inputString, String.Empty).ToLower();
        
        char [] charArray = onlyAlphabet.ToCharArray();
        Array.Reverse(charArray);
        
        string newString = new String(charArray);

        return onlyAlphabet.Equals(newString);
}
