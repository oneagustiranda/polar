﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoogleApi : MonoBehaviour
{
    public RawImage img;

    string url;

    public float lat;
    public float lon;

    LocationInfo li;

    public int zoom = 18;
    public int mapWidth = 800;
    public int mapHeight = 600;

    public enum mapType { roadmap, satellite, hybrid, terrain}
    public mapType mapSelected;
    public int scale;

    IEnumerator Map()
    {
        //url = "https://maps.googleapis.com/maps/staticmap?center=" + lat + "," + lon +
        //    "&zoom=" + zoom + "&size=" + mapWidth + "x" + mapHeight + "&scale=" + scale
        //    +"&maptype=" + mapSelected +
        //    "&markers=color:blue%7Clabel:S%7C40.702147,-74.015794&markers=color:green%7Clabel:G%7C40.711614,-74.012318&markers=color:red%7Clabel:C%7C40.718217,-73.998284&key=AIzaSyC7cx2sfblEiaHo1aqZO_evbK5lPBZHCDg";
       
        url = "https://www.openstreetmap.org/?mlat=" + lat + "&mlon=" + lon + "#map=" + zoom + "/" + lat + "/" + lon;
        WWW www = new WWW(url);
        yield return www;
        img.texture = www.texture;
        img.SetNativeSize();
    }

    // Start is called before the first frame update
    void Start()
    {
        img = gameObject.GetComponent<RawImage>();
        StartCoroutine(Map());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
