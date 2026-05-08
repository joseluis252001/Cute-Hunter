using UnityEngine;

public class MoveBaseGameplayOne : MonoBehaviour
{
    void Update()
    {
        transform.position += new Vector3(0,0,-1) * Time.deltaTime;
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Destroy"))
        {
            Destroy(gameObject);
        }
    }
}
