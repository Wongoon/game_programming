using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector : MonoBehaviour
{
    private Detector detector;
    // Start is called before the first frame update
    void Start()
    {
        detector = GetComponent<Detector>();
        detector.raycastEvent.AddListener(SelectCube);
    }
    public void SelectCube(Transform hit) {
        hit.GetComponent<Controller>().ChangeColor();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
