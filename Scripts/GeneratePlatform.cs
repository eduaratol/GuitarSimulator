using UnityEngine;

public class GeneratePlatform : MonoBehaviour
{
	private GameObject Platform;
	private Vector3 NewPlatformPosition;

	private void Update () 
	{
        Platform = this.transform.parent.gameObject;
        NewPlatformPosition = new Vector3 (Platform.transform.position.x, Platform.transform.position.y, Platform.transform.position.z + 100);
	}

    private void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Finish")
		{
			Instantiate(Platform, NewPlatformPosition, Quaternion.identity);
		}
	}
}