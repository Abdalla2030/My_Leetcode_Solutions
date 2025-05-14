using System;
using System.Collections.Generic;

public class Solution {
    public string PredictPartyVictory(string senate) {
        Queue<int> qR = new Queue<int>();
        Queue<int> qD = new Queue<int>();
        
        for (int i = 0; i < senate.Length; i++) {
            if (senate[i] == 'R') {
                qR.Enqueue(i);
            } else {
                qD.Enqueue(i);
            }
        }
        
        int n = senate.Length;
        while (true) {
            if (qR.Count == 0) return \Dire\;
            if (qD.Count == 0) return \Radiant\;
            
            int rIndex = qR.Dequeue();
            int dIndex = qD.Dequeue();
            
            if (rIndex < dIndex) {
                qR.Enqueue(rIndex + n);  // R wins, adds it to the end
            } else {
                qD.Enqueue(dIndex + n);  // D wins, adds it to the end
            }
        }
    }
}
