using UnityEngine;

public class camera_following : MonoBehaviour
{
    public Transform T;
    public Vector3 pos;

    void FixedUpdate()
    {
        transform.position = T.position + pos;
        
    }
}
