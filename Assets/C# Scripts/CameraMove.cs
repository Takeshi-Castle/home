using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform Player;

    public Transform orientation;

    public float sensx;

    public float sensy;

    public Vector3 offset;

    float xrotation;
    float yrotation;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    void Update()
    {
        transform.position = Player.transform.position;
        float mousex = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensx;
        float mousey = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensy;


        xrotation -= mousey;
        yrotation += mousex;

        transform.rotation = Quaternion.Euler(xrotation, yrotation,0);
        orientation.rotation = Quaternion.Euler(0, yrotation, 0);

        Vector3 euler = new Vector3(Player.transform.rotation.x, transform.rotation.y, Player.transform.rotation.z);

        Player.transform.rotation = Quaternion.Euler(euler);
    }
    
}
