using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public GameObject board;
    int[] xpos = new int[]  {0,1,2,3,3,3,3,2,1,0,0,0};
    int[] ypos = new int[]  {0,0,0,0,1,2,3,3,3,3,2,1};
    int tile = 0;
    //public GameObject joe = board.GameObject.transform.GetChild(1);
    //Vector3[] positions;
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] tiles;
        for(int i = 0; i < 36; i++){
            //tiles[i] = (board.transform.GetChild(i).gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Space)){ 
            int roll = 5;
            tile += roll;
            if (tile > 36){
                tile -= 36;
            }
            transform.position = new Vector3(xpos[tile],ypos[tile],1);

        }
        


    }

}
