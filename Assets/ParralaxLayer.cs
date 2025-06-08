using UnityEngine;

public class ParralaxLayer : MonoBehaviour
{
    [Range(0,1)]
    public float parralaxMultiplier = 0.5f;
    private Transform cam;
    private Vector3 previousCameraPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cam = Camera.main.transform;
        previousCameraPos = cam.position;
    }

void LateUpdate()
{
    Vector3 delta = cam.position - previousCameraPos;
    float moveX = delta.x * (1 - parralaxMultiplier);
    float moveY = delta.y * (1 - parralaxMultiplier);

    transform.position += new Vector3(moveX, moveY, 0);
    previousCameraPos = cam.position;
}

}
