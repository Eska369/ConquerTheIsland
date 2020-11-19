using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public Currency curr;

    public void Awake()
    {
        curr = GetComponent<Currency>();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void katana()
    {
        if(curr.money>= curr.katana)
        {
            curr.money -= curr.katana;
            //katana unlock
        }
    }
}
