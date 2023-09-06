using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(int[] arr) {
        int[] answer = new int[] {};
        List<int> arr_list = new List<int>(arr);
        int arrMin = arr.Min();
        arr_list.RemoveAll (num => num == arrMin);
        if(arr_list.Count == 0){
            arr_list.Add(-1);
        }
        answer = arr_list.ToArray();
        return answer;
    }
}