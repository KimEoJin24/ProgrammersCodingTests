using System;
public class Solution {
    public string solution(string s, int n) {
        string answer = "";
        int ascii = 0;
        foreach(char c in s){
            if(c != ' '){
                if((int)c > 64 && (int)c < 91){
                    ascii = (int)c + n;
                    if(ascii > 90){
                        ascii -= 26;
                    }
                }
                else if((int)c > 96 && (int)c < 123){
                    ascii = (int)c + n;
                    if(ascii > 122){
                        ascii -= 26;
                    }
                }
                answer += Convert.ToChar(ascii);
            }
            else{
                answer += ' ';
            }
        }
        return answer;
    }
}