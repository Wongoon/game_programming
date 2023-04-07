using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour
{
    public GameObject pipePrefab;
    float span = 1.5f;
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
            GameObject p = Instantiate(pipePrefab);
            float y = Random.Range(-1.0f, 2.0f);
            p.transform.position = new Vector3(3.0f, y, 0);
        }
    }
}
