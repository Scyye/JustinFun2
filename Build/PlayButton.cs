using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public GameObject playButton;

    // Start is called before the first frame update
    void Start()
    {
    }

    public void OnClick() 
    {
        SceneManager.LoadScene("level 1");
    }
}
