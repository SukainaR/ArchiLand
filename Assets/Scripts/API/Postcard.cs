using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
public class Postcard
{
    public int post_id { get; set; }
    public string post_name { get; set; }
    public string post_img { get; set; }
    public string post_text { get; set; }
}
[SerializeField]
public class PostcardList
{
    public List<Postcard> postcard;
}