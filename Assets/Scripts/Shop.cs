using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public Currency curr;
    public GameObject player;

    public void Awake()
    {
        curr = player.GetComponent<Currency>();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void shop1Katana()
    {
        if(curr.money>= curr.katana)
        {
            curr.money -= curr.katana;
            //katana unlock
        }
    }

    public void shop2Gun()
    {
        if (curr.money >= curr.gun)
        {
            curr.money -= curr.gun;
            //katana unlock
        }
    }
}
