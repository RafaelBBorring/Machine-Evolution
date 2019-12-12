using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engrenagem_Rotation : MonoBehaviour
{
    public int speed;
    void Update()
    {
        this.transform.rotation *= Quaternion.Euler(0, 0, speed * Time.deltaTime);
    }
}
