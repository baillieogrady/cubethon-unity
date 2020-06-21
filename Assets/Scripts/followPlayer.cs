using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform player;
    // store three numbers (floats)
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        // when lowercase 't' it refers to the transform of our current object
        // the object that this script it sitting on
        transform.position = player.position + offset;
    }
}
