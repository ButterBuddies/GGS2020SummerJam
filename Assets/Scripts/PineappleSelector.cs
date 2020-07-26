using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class PineappleSelector : MonoBehaviour
{
    public int totalPineapples;
    public int gottenPineapples = 0;

   public Text scoretext;

    private void Awake()
    {
        totalPineapples = GameObject.FindGameObjectsWithTag("Pineapple").Length;
    }
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
                    gottenPineapples++;
                }
            }
        }
    }

    public void TallyScore()
    {
        scoretext.text = ("You Found " + gottenPineapples.ToString() + "/"+ totalPineapples.ToString() + " Pinapples");
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
