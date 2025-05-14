class Solution {
private:
    queue<int> qR;
    queue<int> qD;
public:
    string predictPartyVictory(string senate) {
        for(int i = 0;i<senate.size();i++){
            if(senate[i]=='R'){
                qR.push(i);
            }else{
                qD.push(i);  
            }        
        }
        while(true){
            if (qR.empty()) return \Dire\;
            if (qD.empty()) return \Radiant\;
            if(qR.front()<qD.front()){
                qD.pop();
                qR.push(qR.front()+senate.size());
                qR.pop();
            }else{
                qR.pop();
                qD.push(qD.front()+senate.size());
                qD.pop();
            }
        }
       
    }
};