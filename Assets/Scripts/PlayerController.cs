using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float speed = 5.0f;
    public float turnSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // We'll move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Translate(Vector3. right * Time.deltaTime * turnSpeed);
    }
}
