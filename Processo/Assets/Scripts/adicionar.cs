using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class adicionar : MonoBehaviour
{
    public GameObject model_cam;
    public GameObject model_vuf;
    private float x, y, z, angle_x, angle_y, angle_z;
    public InputField getX, getY, getZ, getAngle_X, getAngle_Y, getAngle_Z;
    public Toggle Vuforia;
    private Vector3 newPosition;
    private Quaternion newRotation;

    public void clickAdicionar()
    {
        newPosition = new Vector3(float.Parse(getX.text),float.Parse(getY.text),float.Parse(getZ.text));
        newRotation = Quaternion.Euler(float.Parse(getAngle_X.text), float.Parse(getAngle_Y.text), float.Parse(getAngle_Z.text));

        if(Vuforia.isOn)
        {
            model_cam.SetActive(false);
            model_vuf.SetActive(true);

            model_vuf.transform.localPosition = newPosition;
            model_vuf.transform.localRotation = newRotation;
            
            //model_vuf.transform.SetPositionAndRotation(newPosition, newRotation);
        }
        else
        {
            model_cam.SetActive(true);
            model_vuf.SetActive(false);

            model_cam.transform.SetPositionAndRotation(newPosition, newRotation);
        }
    }
}
