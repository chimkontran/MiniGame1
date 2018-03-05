using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTraps : MonoBehaviour {

    private int randomIndex;

    // Use this for initialization
    void Start()
    {
        randomIndex = Random.Range(0, 3);
        transform.GetChild(randomIndex).gameObject.SetActive(true);
    }
}
