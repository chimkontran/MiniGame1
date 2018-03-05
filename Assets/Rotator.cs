using UnityEngine;

/// <summary>
/// Assign an Index for each trap for different rotations
/// </summary>
public class Rotator : MonoBehaviour {

    // Assign an Index for the trap rotation
    public int RotationIndex;

    private float rotateSpeed;
    private float hardSpeed;

    void Start()
    {
        rotateSpeed = 100f;
        hardSpeed = 1.5f;
    }

    void Update()
    {
        if (!Player.instance.gameOver)
        {
            switch (RotationIndex)
            {
                // 0. side rotation
                case 0:
                    transform.Rotate(0f, rotateSpeed * Time.deltaTime, transform.position.z);
                    break;
                // 1. left rotation
                case 1:
                    transform.Rotate(0f, 0f, rotateSpeed * Time.deltaTime);
                    break;
                // 2. right rotation
                case 2:
                    transform.Rotate(0f, 0f, -rotateSpeed * Time.deltaTime);
                    break;
                // 3. fast side rotation
                case 3:
                    transform.Rotate(0f, hardSpeed * rotateSpeed * Time.deltaTime, transform.position.z);
                    break;
                // 4.fast left rotation
                case 4:
                    transform.Rotate(0f, 0f, hardSpeed * rotateSpeed * Time.deltaTime);
                    break;
                // 5. fast right rotation
                case 5:
                    transform.Rotate(0f, 0f, -hardSpeed * rotateSpeed * Time.deltaTime);
                    break;
                default:
                    Debug.Log(RotationIndex);
                    break;
            }
        }

        // GAME OVER
        /*
        if (!Player.instance.gameOver)
        {
            transform.Rotate(0f, 0f, rotateSpeed * Time.deltaTime);
        }
        */
    }
}
