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
        MakeBoard();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    /// <summary>
    /// Makes the game board.
    /// </summary>
    void MakeBoard()
    {
        for (int i = 0; i < 10; i++)
            AddTile(new Vector3(i * 5, -.25f, 0));
        for (int i = 0; i < 8; i++)
            AddTile(new Vector3(45, -.25f, 5 + i * 5));
        for (int i = 0; i < 10; i++)
            AddTile(new Vector3(45 - 5 * i, -.25f, 40));
        for (int i = 0; i < 8; i++)
            AddTile(new Vector3(0, -.25f, 35 - i * 5));
    }
    /// <summary>
    /// Adds a tile at the specified world position.
    /// </summary>
    /// <param name="tilePos">World position of the Tile to add</param>
    void AddTile(Vector3 tilePos)
    {
        tiles.Add(GameObject.Instantiate(tile, tilePos, Quaternion.identity));
    }
}

