using UnityEngine;
using System.Collections;

public class MouseLook : MonoBehaviour
{
    Vector3 hit_position = Vector3.zero;
    Vector3 current_position = Vector3.zero;
    Vector3 camera_position = Vector3.zero;

    public float speed;
    public Transform target;
    void Start()
    {

    }

    void Update()
    {
        Move();
        if (Input.GetMouseButtonDown(0))
        {
            hit_position = Input.mousePosition;

            camera_position = transform.position;

        }
        if (Input.GetMouseButton(0))
        {
            current_position = Input.mousePosition;
            LeftMouseDrag();
        }
    }
    private void Move()
    {
        Vector3 a = transform.position;
        Vector3 b = target.position;
        transform.position = Vector3.MoveTowards(a, b, speed / 200f);
    }
    void LeftMouseDrag()
    {
        current_position.z = hit_position.z = camera_position.y;

        Vector3 direction = Camera.main.ScreenToWorldPoint(current_position) - Camera.main.ScreenToWorldPoint(hit_position);

        direction = direction * -1;

        Vector3 position = camera_position + direction;

        transform.position = new Vector3(position.x, transform.position.y, transform.position.z);
    }
}