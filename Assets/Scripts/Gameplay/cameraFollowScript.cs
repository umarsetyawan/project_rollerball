using UnityEngine;

public class cameraFollowScript : MonoBehaviour
{

    [SerializeField]private Transform target;
    [SerializeField]private Transform camPosition;
    [SerializeField]private Vector3 offset;
    [SerializeField]private float smoothTime;

    private Vector3 velocity = Vector3.zero;

    // Start is called before the first frame update
    void Awake()
    {
        offset = camPosition.position - target.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 targetPosition = target.position + offset;
        camPosition.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
