using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float speed = 0.8f;

    Vector3 playerPos;


    void Awake()
    {
        gameObject.SetActive(false);
    }


    void Start()
    {
        playerPos = player.transform.position;
    }


    void Update()
    {
        flyAtPlayer();
        DestroyWhenReached();
    }

    void flyAtPlayer()
    {
        float flySpeed = Time.deltaTime * speed;
        transform.position = Vector3.MoveTowards(transform.position, playerPos, flySpeed);
        
    }

    void DestroyWhenReached()
    {
        if (transform.position == playerPos)
        {
            Destroy(gameObject);
        }
        
    }
}
