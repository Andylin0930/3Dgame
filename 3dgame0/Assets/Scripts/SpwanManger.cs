using UnityEngine;

public class SpwanManger : MonoBehaviour
{
    public GameObject[] animalPerfabs;
    public int animalIndex;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(animalPerfabs[animalIndex], new Vector3(0, 0, 20), animalPerfabs[animalIndex].transform.rotation);
        }
    }
}
