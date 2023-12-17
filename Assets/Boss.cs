using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Boss
{
    private int hp = 100; //体力
    private int mp=53;  //魔法力
    private int power = 23; //攻撃力

    public void Attack(){
        Debug.Log(this.power + "のダメージを与えた");
    }

    public void Magic(){
        if(mp>=5){
            mp-=5;
            Debug.Log("魔法攻撃をした。残りMPは "+this.mp);
        }else{
            Debug.Log("MPが足りないため、魔法が使えない。");
        }
    }

    public void Defence(int damage){
        Debug.Log(damage+"のダメージを受けた");
        this.hp -= damage;
    }
    
}
