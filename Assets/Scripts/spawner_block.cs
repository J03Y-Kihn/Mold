using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner_block : MonoBehaviour
{

    [SerializeField]
    GameObject objectToSpawn;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnObject(){
        Instantiate(objectToSpawn, transform.position, transform.rotation);
    }
}
