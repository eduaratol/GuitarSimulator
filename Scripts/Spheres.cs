using UnityEngine;

public class Spheres : MonoBehaviour
{
	private void OnTriggerStay(Collider other)
	{	
		if (other.tag == "Player")
        {
            Controller.Score++;
            Destroy(this.gameObject);
        }	
	}
}