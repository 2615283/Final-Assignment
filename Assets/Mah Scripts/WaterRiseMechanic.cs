using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterRiseMechanic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    public List<GameObject> TreasureCards = new List<GameObject>();

    public void AddTreasureCardstoList()
    {
        TreasureCards.Add(GameObject.Find("floodcard"));
        TreasureCards.Add(GameObject.Find("floodcard"));
        TreasureCards.Add(GameObject.Find("floodcard"));
    }
}

    // Update is called once per frame
    void Update()
    {
public class Location
{
    public long ID {get;set;}
    public long ParentID {get;set;}
    public List<Location> Children {get;set;}
}
    }
}
