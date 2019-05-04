using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.X)) {
            SceneManager.LoadScene("SampleScene" ,LoadSceneMode.Single);
        }
        if(Input.GetKeyDown(KeyCode.Z)) {
            Instantiate(player);
        }
    }
}
