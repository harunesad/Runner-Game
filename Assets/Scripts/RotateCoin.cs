using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCoin : MonoBehaviour
{
    public int rotateSpeed = 1;
    void Update()
    {
          this.transform.Rotate(0, rotateSpeed, 0, Space.World);
    }
}
