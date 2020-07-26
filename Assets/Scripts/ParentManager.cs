using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentManager : MonoBehaviour
{
    public GameObject car;
    public GameObject dolly;
    public GameObject cam;


    public Vector3 carPos, dollyPos, cameraPos; //-1.8f, 1.75f, -1.25f   0,0,5f


    public void SwapParent(int par)
    {
        switch (par)
        {
            case 0: gameObject.transform.parent = car.transform;
                gameObject.transform.localPosition = carPos;
                break;
            case 1: gameObject.transform.parent = dolly.transform;
                gameObject.transform.localPosition = dollyPos;
                break;
            case 2: gameObject.transform.parent = cam.transform;
                gameObject.transform.localPosition = cameraPos;
                break;
        }
    }
}
