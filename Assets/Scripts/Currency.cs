using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Currency : MonoBehaviour
{
    public Text hajsiwo;
    public int money;

    public int katana = 10;
    public int gun = 30;


    // Start is called before the first frame update
    void Start()
    {
        money = 0;
    }

    // Update is called once per frame
    void Update()
    {
        hajsiwo.text = "Money: " + (int)money + "$";
    }
}
