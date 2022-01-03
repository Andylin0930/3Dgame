using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float HInput;
    public float speed = 10;

    public float xRange = 15;

    public GameObject foodLunch;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * HInput * speed);
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(foodLunch, transform.position, Quaternion.identity);
        }
    }
}
