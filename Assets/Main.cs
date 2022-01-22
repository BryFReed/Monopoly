using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public Button roll;
    public Player player;
    List<GameObject> tiles = new List<GameObject>();
    public GameObject tile;

    // Start is called before the first frame update
    void Start()
    {
        MakeBoard();
        roll.onClick.AddListener(take_turn);
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
            AddTile(new Vector3(45 - 5 * i, -.25f, 45));
        for (int i = 0; i < 8; i++)
            AddTile(new Vector3(0, -.25f, 40 - i * 5));
        tiles.Reverse(1, 35);
    }
    /// <summary>
    /// Adds a tile at the specified world position.
    /// </summary>
    /// <param name="tilePos">World position of the Tile to add</param>
    void AddTile(Vector3 tilePos)
    {
        tiles.Add(GameObject.Instantiate(tile, tilePos, Quaternion.identity));
    }
    int roll_dice()
    {
        return (Random.Range(1, 7) + Random.Range(1, 7));
    }

    public void take_turn()
    {
        int roll = roll_dice();
        int new_pos = roll + player.pos;
        if(new_pos > 36)
        {
            new_pos -= 36;
        }
        player.transform.position = tiles[new_pos].transform.position;
        player.pos = new_pos;
    }
    
}

