using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
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
