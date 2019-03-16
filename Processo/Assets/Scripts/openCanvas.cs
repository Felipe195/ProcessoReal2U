using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openCanvas : MonoBehaviour
{
    public GameObject canvasON;
    public GameObject canvasOFF;
    public void open()
    {
        canvasON.SetActive(true);
        canvasOFF.SetActive(false);
    }
}
