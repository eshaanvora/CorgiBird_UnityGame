using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalSpawner : MonoBehaviour
{

    public GameObject ScoreCounter;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(ScoreCounter);
    }

    
}
