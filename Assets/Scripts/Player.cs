using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        float y = Input.GetAxis("Jump");

        Vector3 movement = new Vector3(x,y,z);

        if(rb.position.y < 0){
            SceneManager.LoadScene("SampleScene",LoadSceneMode.Single);
        }
        rb.AddForce(Vector3.Normalize(movement) * speed);


    }
}
