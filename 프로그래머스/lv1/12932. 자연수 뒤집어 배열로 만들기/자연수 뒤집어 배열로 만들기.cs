public class Solution {
    public int[] solution(long n) {
        string m = n.ToString();
        int[] answer = new int[m.Length];
        for (int i=0; i<m.Length; i++){
            answer[i] = (int)(n % 10);
            n = n/10;
        }
        return answer;
    }
}