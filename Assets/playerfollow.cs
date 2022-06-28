
using UnityEngine;
using System.Collections;

class playerfollow : MonoBehaviour
{

    [SerializeField] Transform player;
    public float xOffset = 0;
    public float yOffset = 0;
    public float zOffset = 0;
    Vector3 playerPosition;

    void Start()
    {
        player = GameObject.Find("Player").transform;
    }

    void Update()
    {
        playerPosition.x = player.position.x + xOffset;
        playerPosition.y = player.position.y + yOffset;
        playerPosition.z = player.position.y + zOffset;
        transform.position = playerPosition;
    }

}
