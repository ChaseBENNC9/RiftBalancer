using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject playerObj;
    private float leftEdge,rightEdge, viewportWidth;
    [SerializeField] private float EDGE_BUFFER = 2f;
    [SerializeField] private float PLAYER_BUFFER = 0.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.transform.position = new Vector3(playerObj.transform.position.x,gameObject.transform.position.y,-10);
       leftEdge =  Camera.main.ViewportToWorldPoint(Vector3.zero).x;
       rightEdge = Camera.main.ViewportToWorldPoint(new Vector3(1,0,0)).x;
       viewportWidth = rightEdge - leftEdge;
    }

    // Update is called once per frame
    void Update()
    {
        leftEdge = gameObject.transform.position.x - (viewportWidth/2.0f) + EDGE_BUFFER;
        rightEdge = gameObject.transform.position.x + (viewportWidth/2.0f) - EDGE_BUFFER;

       if ((playerObj.transform.position.x -PLAYER_BUFFER) < leftEdge)
       {
            gameObject.transform.position = new Vector3(playerObj.transform.position.x + (viewportWidth/2.0f)- EDGE_BUFFER - PLAYER_BUFFER,gameObject.transform.position.y,gameObject.transform.position.z);
       }
       else if ((playerObj.transform.position.x +PLAYER_BUFFER) > rightEdge)
       {
            gameObject.transform.position = new Vector3(playerObj.transform.position.x - (viewportWidth/2.0f) + EDGE_BUFFER + PLAYER_BUFFER,gameObject.transform.position.y,gameObject.transform.position.z);

       }
    }
}
