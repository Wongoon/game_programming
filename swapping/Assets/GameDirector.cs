using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject dinoskate;
    GameObject finish;
    GameObject distance;
    // Start is called before the first frame update
    void Start()
    {
        dinoskate = GameObject.Find("dinoskate");
        finish = GameObject.Find("finish");
        distance = GameObject.Find("distance");
    }

    // Update is called once per frame
    void Update()
    {
        float length = finish.transform.position.x - dinoskate.transform.position.x;
        distance.GetComponent<Text>().text = "남은 거리 : " + length.ToString("F2") + "m";

        if(dinoskate.transform.position.y < -2.24f){
            distance.GetComponent<Text>().text = "Game Over";
        }
    }
}
