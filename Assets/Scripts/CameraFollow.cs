using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Camera controls with the mouse
public class CameraFollow : MonoBehaviour
{
	public float mouseSensitivity = 100f;
	private float initialX;
	private float initialY;
	private float initialZ;
	public Transform target;
	float mouseX;
	float mouseY;
    // Start is called before the first frame update
    void Start()
    {
		//maintains the same distance from the target
        initialX = transform.position.x - target.position.x;
		initialY = transform.position.y - target.position.y;
		initialZ = transform.position.z - target.position.z;

		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;

	}

    // Update is called once per frame
    void LateUpdate()
    {
		mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
		mouseY -= Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

		//mouseX = Mathf.Clamp(mouseX, -160, 160);
		mouseY = Mathf.Clamp(mouseY, -60, 60);

		transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, transform.eulerAngles.z);
		transform.Rotate(Vector3.up, mouseX);
		transform.eulerAngles = new Vector3(mouseY, transform.eulerAngles.y, transform.eulerAngles.z);
		//transform.position = Vector3.Lerp(transform.position, new Vector3(initialX + target.position.x, initialY + target.position.y, initialZ + target.position.z), 0.8f);
		transform.position = new Vector3(initialX + target.position.x, initialY + target.position.y, initialZ + target.position.z);

	}
}
