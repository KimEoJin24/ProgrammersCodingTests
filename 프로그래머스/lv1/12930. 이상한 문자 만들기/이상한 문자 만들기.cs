public class Solution {
    public string solution(string s) {
        string answer = "";
        bool evenOdd = true;
        for(int i=0; i<s.Length; i++){
            char c = s[i];
            if(c != ' '){
                if(evenOdd){
                    evenOdd = false;
                    answer += c.ToString().ToUpper();
                }
                else{
                    evenOdd = true;
                    answer += c.ToString().ToLower();
                }
            }
            else{
                evenOdd = true;
                answer += " ";
            }
            
        }
        
        return answer;
    }
}