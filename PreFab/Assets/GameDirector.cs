using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject hp;
    // Start is called before the first frame update
    void Start()
    {
        hp = GameObject.Find("HP");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Decrease(){
        hp.GetComponent<Image>().fillAmount -= 0.333f;
    }

    public void Increase(){
        hp.GetComponent<Image>().fillAmount += (0.333f / 5);
    }
}
