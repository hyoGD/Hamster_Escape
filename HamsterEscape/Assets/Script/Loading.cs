using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Loading : MonoBehaviour
{
    public Text load;
    private int num;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        num++;
        load.text = "Loading: " + num + "%";
        if(num>= 100)
        {
            SceneManager.LoadScene(1);
        }
    }
}
