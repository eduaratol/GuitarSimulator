using UnityEngine;

public class ErrorContactor : MonoBehaviour
{
	private void OnTriggerStay(Collider other)
	{	
		if (other.GetComponent<Spheres>() != null) 
		{
			Controller.ErroCount++;
            Destroy(other.gameObject);
		}
	}
}
