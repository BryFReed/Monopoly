using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public GameObject Player;
    List<GameObject> tiles = new List<GameObject>();
    public GameObject tile;
    // Start is called before the first frame update
    void Start()
    {

        make_board();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void make_board()
    {
        for (int i = 0; i < 10; i++)
        {
            tiles.Add(GameObject.Instantiate(tile, new Vector3(i * 5, -.25f, 0), Quaternion.identity));
        }
        for (int i = 0; i < 8; i++)
        {
            tiles.Add(GameObject.Instantiate(tile, new Vector3(45, -.25f, 5 + i * 5), Quaternion.identity));
        }
        for (int i = 0; i < 10; i++)
        {
            tiles.Add(GameObject.Instantiate(tile, new Vector3(45 - 5 * i, -.25f, 40), Quaternion.identity));
        }
        for (int i = 0; i < 8; i++)
        {
            tiles.Add(GameObject.Instantiate(tile, new Vector3(0, -.25f, 35 - i * 5), Quaternion.identity));
        }
    }
    
}

