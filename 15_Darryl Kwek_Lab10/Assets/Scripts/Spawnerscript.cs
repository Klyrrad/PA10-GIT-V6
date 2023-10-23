using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawnerscript : MonoBehaviour
{
    //public GameObject SpawnObject;
    float PositionY;

    public GameObject[] myObjects;

    public Text ScoreText;
    public static float Score;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Score: " + Score;


    }

    void SpawnObjects()
    {
        PositionY = Random.Range(4, -4f);
        int randomIndex = Random.Range(0, myObjects.Length);
        this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
        Instantiate(myObjects[randomIndex], transform.position, transform.rotation);
    }
}
