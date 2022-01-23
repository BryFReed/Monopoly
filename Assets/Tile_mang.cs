using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tile_mang : MonoBehaviour
{
    public Button yes;
    public Button no;
    public Text msg;
    public GameObject panel;
    public static Tile_mang singlton;
    public Property curr;
    public Player playa;
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
        Debug.Log(panel.active);
        singlton = this;
        yes.onClick.AddListener(click_yes);
        no.onClick.AddListener(click_no);
    }
    public void click_yes()
    {
        curr.owned = true;
        curr.owner = playa;
        playa.money -= curr.cost;
        playa.wallet.Add(curr.id);
        panel.SetActive(false);
    }
    public void click_no()
    {
        panel.SetActive(false);
    }
 


    }


    public abstract class Tile 
    {
        public Tile_in_eng eng;
        public string name;
        public Tile(string nam)
        {
            name = nam;
        }
    public abstract void interact(Player playa);


    }
    public class Property : Tile
    {

        public int id;
        public int cost;
        int house_price;
        int rent_0;
        int rent_1;
        int rent_2;
        int rent_3;
        int rent_4;
        int rent_5;
        int mortgage;
        public bool owned = false;
        public Player owner;

    public Property(string nam, int id, int cost, int house_price, int rent_0, int rent_1, int rent_2, int rent_3, int rent_4, int rent_5, int mortgage) : base(nam)
        {
            this.id = id;
            this.cost = cost;
            this.house_price = house_price;
            this.rent_0 = rent_0;
            this.rent_1 = rent_1;
            this.rent_2 = rent_2;
            this.rent_3 = rent_3;
            this.rent_4 = rent_4;
            this.rent_5 = rent_5;
            this.mortgage = mortgage;
        }

        public override void interact(Player palya)
        {
            //if(owned == false && palya.money >= cost)
            //{
                Tile_mang.singlton.curr = this;
                Tile_mang.singlton.playa = palya;
                Tile_mang.singlton.msg.text = this.name + " " + "$" + this.cost;
                Tile_mang.singlton.panel.SetActive(true);
            //}
        }
    }






