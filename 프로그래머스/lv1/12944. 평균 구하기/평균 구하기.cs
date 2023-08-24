public class Solution {
    public double solution(int[] arr) { 
        double answer = 0;
        double sum = 0;
        int count = 0;
        for (int i=0; i<arr.Length; i++){
            sum += arr[i];
            count += 1;               
        }
        answer = sum / count;
        return answer;
    }
}