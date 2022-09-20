using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeerTowerPlacer : MonoBehaviour
{
    private int secondsUntilNextCreation = 3;

    protected bool isWaitingToCreate = false;

    public List<GameObject> BeerTowerTop;
    public List<GameObject> BeerTowerBottom;


    //Switch based on randon number, use cases to determine which pair of pipes to spawn
  
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(CountDownUntilCreation());
    }

    //Code to spawn Beertower after a certain time

    private void FixedUpdate()
    {
        if (!isWaitingToCreate)
        {
            isWaitingToCreate = true;
            StartCoroutine(CountDownUntilCreation());
        }
    }

    IEnumerator CountDownUntilCreation()
    {
        SpawnRandomTower();

        yield return new WaitForSeconds(secondsUntilNextCreation);

        Create();
    }

    protected virtual void Create()
    {
        isWaitingToCreate = false;

    }

    private void SpawnRandomTower()
    {
        int randomTowerPicker = BeerTowerPicker.generateRandomNumber();

        switch(randomTowerPicker)
        {
            case 1:
                Instantiate(BeerTowerTop[0]);
                Instantiate(BeerTowerBottom[0]);
                break;
            case 2:
                Instantiate(BeerTowerTop[1]);
                Instantiate(BeerTowerBottom[1]);
                break;
            case 3:
                Instantiate(BeerTowerTop[2]);
                Instantiate(BeerTowerBottom[2]);
                break;
            case 4:
                Instantiate(BeerTowerTop[3]);
                break;
            case 5:
                Instantiate(BeerTowerBottom[3]);
                break;
        }


    }



}
