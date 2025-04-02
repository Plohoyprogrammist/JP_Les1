using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20f;
    public float turnSpeed;

    public float horInput;
    public float vertInput;

    private void Update()
    {
        horInput = Input.GetAxis("Horizontal");
        vertInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * vertInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horInput);
    }
}
