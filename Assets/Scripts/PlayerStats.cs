using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour {

    public static int Money;
    public int startMoney = 400;

    public static int Hp;
    public int startHp = 100;

    public static int Rounds;

    void Start()
    {
        Money = startMoney;
        Hp = startHp;

        Rounds = 0;
    }


   
}
