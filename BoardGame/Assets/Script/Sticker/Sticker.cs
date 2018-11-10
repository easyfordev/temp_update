using UnityEngine;

public class Sticker : MonoBehaviour
{
    [SerializeField]
    private GameObject[] tools;

    [SerializeField]
    private SpriteRenderer spriteRenderer;

    private Vector3 distance;

    public bool IsActiveTools { get; set; }

    public void SetSprite(Sprite sprite)
    {
        spriteRenderer.sprite = sprite;
    }

    private void OnMouseDown()
    {
        Vector3 mousePosition = GetMouseWorldPosition();

        distance = transform.position - mousePosition;

        IsActiveTools = true;
    }

    private void OnMouseDrag()
    {
        IsActiveTools = false;

        Vector3 mousePosition = GetMouseWorldPosition();

        transform.position = mousePosition + distance;
    }

    private void Update()
    {
        if (IsActiveTools)
        {
            ActiveTools(true);

            return;
        }

        if (Input.GetMouseButtonDown(0))
            ActiveTools(false);
    }

    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);

        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        return mousePosition;
    }

    private void ActiveTools(bool isActive)
    {
        for (int i = 0; i < tools.Length; ++i)
            tools[i].SetActive(isActive);
    }
}
