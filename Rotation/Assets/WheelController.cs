using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float rotSpeed = 0;
    bool isRoll = false;
    int idx = 0;
    float min = 360.0f;
    int shift_idx = 0;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0)){
            this.rotSpeed = 10;
            isRoll = true;
        }
        transform.Rotate(0, 0, this.rotSpeed);

        this.rotSpeed *= 0.99f;
        if(isRoll == true && rotSpeed < 0.01f){
            for(int i = 0; i < 7; i++){
                if(transform.GetChild(i).eulerAngles.z < min){
                    min = transform.GetChild(i).eulerAngles.z;
                    idx = i;
                }
            }
            shift_idx = idx - 1 < 0 ? 6 : idx - 1;
            Debug.Log(min);
            if(transform.GetChild(idx).eulerAngles.z > 360.0f - transform.GetChild(shift_idx).eulerAngles.z){
                Debug.Log(transform.GetChild(shift_idx).name);
            }
            else{
                Debug.Log(transform.GetChild(idx).name);
            }
            isRoll = false;
            min = 360.0f;
        }
    }
}
