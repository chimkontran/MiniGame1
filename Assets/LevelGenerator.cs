using UnityEngine;

public class LevelGenerator : MonoBehaviour {
    // Variables
    public GameObject RandomTraps;
    //public GameObject plusTrapPrefab, crossTrapPrefab, circleTrapPrefab;
    private GameObject[] traps;

    //private int randomTrap;
    private int trapPoolSize = 14;

    private Vector2 trapPoolPosition = new Vector2(0f, 0f);
    private Vector2 trapSpawnOffset = new Vector2(0f, 6f);

    // Use this for initialization
    void Start()
    {
        // Spawn Traps
        traps = new GameObject[trapPoolSize];
        for (int i = 0; i < trapPoolSize; i++)
        {
            trapPoolPosition += trapSpawnOffset;
            //SpawnRandomTrap(j);
            SpawnTrap(i);
        }
    }
    /*
    // Spawn random traps
    private void SpawnRandomTrap(int index)
    {
        randomTrap = Random.Range(1, 4);
        switch (randomTrap)
        {
            case 1: // +
                traps[index] = Instantiate(plusTrapPrefab, trapPoolPosition, Quaternion.identity);
                break;
            case 2: // x
                traps[index] = Instantiate(crossTrapPrefab, trapPoolPosition, Quaternion.identity);
                break;
            case 3: // o
                traps[index] = Instantiate(circleTrapPrefab, trapPoolPosition, Quaternion.identity);
                break;
        }
    }
    */

    // Spawn trap
    private void SpawnTrap(int index)
    {
        traps[index] = Instantiate(RandomTraps, trapPoolPosition, Quaternion.identity);
    }
}
