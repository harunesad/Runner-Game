using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        this.gameObject.SetActive(false);
    }
}
