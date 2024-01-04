using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetMoney : MonoBehaviour
{
    public int money = 150;
    public Text moneyText;

    // Start is called before the first frame update
    void Start()
    {
        moneyText.text = money.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
