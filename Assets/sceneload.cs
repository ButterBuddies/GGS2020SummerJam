using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneload : MonoBehaviour
{
    // Start is called before the first frame update
    public void loadLevel(string level)
    {
        SceneManager.LoadScene(level);
    }
}
