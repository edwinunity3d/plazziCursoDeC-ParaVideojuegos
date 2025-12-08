using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;

    public Vector3 offset =  new Vector3(0.2f, 0, -10f)    ;
    public float dampingTIme =0.3f ;

    public Vector3 velocity = Vector3.zero;


    void Awake()
    {
        Application.targetFrameRate = 60;

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveCamera(true);
    }

    public void ResetCamearaPostion()
    {
        MoveCamera(false);
    }


    void MoveCamera(bool smoot)
    {
        Vector3 destination = new Vector3 (target.position.x  - offset.x , offset.y, offset.z);

        if (smoot)
        {this.transform.position = Vector3.SmoothDamp(this.transform.position,
            destination, ref velocity, dampingTIme);

        }
        else
        {
            this.transform.position = destination;
        }

    }
}
