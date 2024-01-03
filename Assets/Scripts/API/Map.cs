using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
public class Map 
{
    public int map_id { get; set; }
    public string map_name { get; set; }
}

[SerializeField]
public class MapList
{
    public List<Map> map;
}