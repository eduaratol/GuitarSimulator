using UnityEngine;

public class TouchButton : MonoBehaviour
{
    public int ButtonNumber;

	private void OnMouseDrag()
	{
        Controller.Mobile = true;
        GetComponentInParent<Controller>().SelectedKey(ButtonNumber);
	}

    private void OnMouseUpAsButton()
	{
        Controller.Mobile = false;
        GetComponentInParent<Controller>().SelectedKey(-1);
    }
}