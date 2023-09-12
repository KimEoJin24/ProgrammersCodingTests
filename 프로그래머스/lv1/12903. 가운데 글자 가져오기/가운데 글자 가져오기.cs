public class Solution {
    public string solution(string s) {
        string answer = "";
        int sNum = ((s.Length + 1) % 2) + 1;
        int sStart = (s.Length - 1) / 2;
        answer = s.Substring(sStart, sNum);
        return answer;
    }
}