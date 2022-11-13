using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanSpin : MonoBehaviour
{
    public int Speed;
    public GameObject fan;
    void FixedUpdate()
    {
        fan.transform.Rotate(0, Speed, 0 * Time.deltaTime);
    }
}
