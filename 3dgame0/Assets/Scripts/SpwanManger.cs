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
        animalIndex = Random.Range(0, animalPerfabs.Length);
        if (Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(animalPerfabs[animalIndex], new Vector3(Random.Range(-17, 17), 0, 20), animalPerfabs[animalIndex].transform.rotation);
        }
    }
}
