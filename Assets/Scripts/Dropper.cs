using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 3f;

    MeshRenderer myMeshRenderer;
    Rigidbody rigidBody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        myMeshRenderer = GetComponent<MeshRenderer>();
        myMeshRenderer.enabled = false;
        rigidBody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        {
            myMeshRenderer.enabled = true;
            rigidBody.useGravity = true;
        }
    }
}
