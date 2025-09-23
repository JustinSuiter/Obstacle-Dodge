using UnityEngine;

public class Scorer : MonoBehaviour
{

    int hits = 0;
    void OnCollisionEnter(Collision collision)
    {
        hits++;
        Debug.Log("You have hit something " + hits + " times");
    }
}
