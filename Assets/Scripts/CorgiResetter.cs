using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorgiResetter : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        Game.Instance.LoseCorgi();
    }

}
