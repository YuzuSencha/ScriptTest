using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] arr = {2,3,5,7,11};

        for (int i=0; i<arr.Length; i++){
            Debug.Log(arr[i]);
        }
        for(int j=arr.Length-1; j>=0; j--){
            Debug.Log(arr[j]);
        }

        Boss lastBoss = new Boss();   

        lastBoss.Attack();
        lastBoss.Defence(3);

        lastBoss.Magic(); //一回目の攻撃
        for(int i=0; i<10; i++){ //魔法攻撃を十回して、最後の十回目は魔法力が足りないはずです。
            lastBoss.Magic();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
