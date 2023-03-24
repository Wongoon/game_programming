using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heartGenerator : MonoBehaviour
{
    public GameObject heartPreFab;
    float span = 0.2f;
    float delta = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if(delta > span){
            delta = 0;
            GameObject m = Instantiate(heartPreFab);
            float x = Random.Range(-8.0f, 9.0f);
            m.transform.position = new Vector3(x, 7, 0);
        }
    }
}
