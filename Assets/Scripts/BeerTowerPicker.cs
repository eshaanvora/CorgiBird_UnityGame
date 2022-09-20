using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class BeerTowerPicker
{
    public static int generateRandomNumber()
    {
        int randomCase = Random.Range(1, 5);
        return randomCase;
    }
}
