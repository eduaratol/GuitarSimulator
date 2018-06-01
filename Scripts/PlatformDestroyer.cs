using UnityEngine;

public class PlatformDestroyer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Finish")
		{
			Destroy (this.transform.parent.gameObject);
		}
	}
}