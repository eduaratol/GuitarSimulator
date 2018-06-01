using UnityEngine;

public class RGB : MonoBehaviour
{
	private void Update ()
    {
        ChangeColor(Random.Range(1, 4));
	}

    private void ChangeColor(int random)
	{
		switch(random)
		{
		    case 1:
			    gameObject.GetComponent<Renderer>().material.color = Color.red;
			    break;
		    case 2:
			    gameObject.GetComponent<Renderer>().material.color = Color.green;
			    break;
		    case 3:
			    gameObject.GetComponent<Renderer>().material.color = Color.blue;
			    break;
		}
	}
}