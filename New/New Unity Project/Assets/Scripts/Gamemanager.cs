using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Gamemanager : MonoBehaviour
{
    public GameObject startButton;
    public void OnMouseUpAsButton()
    {
        SceneManager.LoadScene(1);
    }
    // Start is called before the first frame update
    void Start()
    {
        


            }
    


    // Update is called once per frame
    void Update()
    {

    }
}
