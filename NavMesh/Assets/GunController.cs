using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public Transform weaponHold;
    public Gun startingGun;
    Gun equippedGun;
    // Start is called before the first frame update
    void Start()
    {
        equippedGun = Instantiate(startingGun, weaponHold.position, weaponHold.rotation) as Gun;
        equippedGun.transform.parent = weaponHold;
    }
    public void Shoot(){
        equippedGun.Shoot();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
