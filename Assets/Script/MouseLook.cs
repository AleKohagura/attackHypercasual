using UnityEngine;
using System.Collections;

public class MouseLook : MonoBehaviour
{
    public float speed;
    public Transform target;

    void Update()
    {
        Move();
        if (Input.touchCount > 0)
        {
            Touch t = Input.GetTouch(0);
            if (t.phase== TouchPhase.Moved)
            {
                Vector3 touchedPos = Camera.main.ScreenToWorldPoint(new Vector3(t.position.x, t.position.y, 10));
                Vector3 newpos = new Vector3(touchedPos.x, transform.position.y, transform.position.z);
                transform.position = Vector3.Lerp(transform.position, newpos, Time.deltaTime);
            }
        }
       
    }
    private void Move()
    {
        Vector3 a = transform.position;
        Vector3 b = target.position;
        transform.position = Vector3.MoveTowards(a, b, speed*Time.deltaTime);
    }
  
}