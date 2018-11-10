using UnityEngine;

public class CloseButton : MonoBehaviour
{
    [SerializeField]
    private Sticker sticker;

    private void OnMouseDown()
    {
        sticker.IsActiveTools = true;
    }

    private void OnMouseUp()
    {
        Destroy(this.transform.parent.gameObject);
    }
}
