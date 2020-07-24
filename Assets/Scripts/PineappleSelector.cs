using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PineappleSelector : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.gameObject.CompareTag("Pineapple"))
                {
                    Debug.Log("That's a Pineapple");
                    hit.transform.gameObject.SetActive(false);
                }
            }
        }
    }
}
