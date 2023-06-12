using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasController : MonoBehaviour
{
    public GameObject canvasStartPoint;
    public GameObject Tutorial;
    public GameObject Camera;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TutorialEnd(){
        Camera.transform.position = new Vector3(10, 3, -2);
        Tutorial.SetActive(false);
        canvasStartPoint.SetActive(true);
    }

    public void StartPointEnd(){
        SceneManager.LoadScene("FlappyBirdType");
    }

    public void MainMenu(){
        SceneManager.LoadScene("MainMenu");
    }
}
