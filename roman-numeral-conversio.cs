// Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.
// Roman numerals are usually written largest to smallest from left to right. 
// Given a roman numeral, convert it to an integer.
// [Problem from leetcode.com]

public class Solution {
    public int RomanToInt(string s) {
        int arabicNumeral = 0;
        
        for (int i = 0; i < s.Length; i++) {
            // I
            if (s[i].Equals('I')) {
                if (i < (s.Length-1)) {
                    if (s[i+1].Equals('V')) {
                        arabicNumeral += 4;
                        i++;
                        continue;
                    }
                    if (s[i+1].Equals('X')) {
                        arabicNumeral += 9;
                        i++;
                        continue;
                    }
                }
                arabicNumeral++;    
            }
                    
            // V
            else if (s[i].Equals('V')) {
                arabicNumeral += 5;   
            }
                    
            // X
            else if (s[i].Equals('X')) {
                if (i < (s.Length-1)) {
                    if (s[i+1].Equals('L')) {
                        arabicNumeral += 40;
                        i++;
                        continue;
                    }
                    if (s[i+1].Equals('C')) {
                        arabicNumeral += 90;
                        i++;
                        continue;
                    }
                } 
                arabicNumeral += 10; 
            }
            
            // L
            else if (s[i].Equals('L')) {
                arabicNumeral += 50;   
            }
                    
            // C
            else if (s[i].Equals('C')) {
                if (i < (s.Length-1)) {
                    if (s[i+1].Equals('D')) {
                        arabicNumeral += 400;
                        i++;
                        continue;
                    }
                    if (s[i+1].Equals('M')) {
                        arabicNumeral += 900;
                        i++;
                        continue;
                    }
                }
                arabicNumeral += 100; 
            }        
                    
            // D
            else if (s[i].Equals('D')) {
                arabicNumeral += 500;   
            }
                    
            // M
            else if (s[i].Equals('M')) {
                arabicNumeral += 1000;   
            }
        }
        return arabicNumeral;
    }
}
