using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodsFactoryScript : MonoBehaviour
{
    public GameObject Goods;
    private int numGoods;

    // Start is called before the first frame update
    void Start()
    {
        numGoods = 10;
        float y = 15f;

        for (int x=-1; x<6; x+=4)
        {
            for(int z=-7; z<10; z+=4)
            {
                Instantiate(Goods, new Vector3(x, y, z), Quaternion.identity);
            }         
        }

    }
   
    // Update is called once per frame
    void Update()
    {
        
    }
}
