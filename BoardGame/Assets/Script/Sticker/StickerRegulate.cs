using UnityEngine;

using HD;

public class StickerRegulate : MonoBehaviour
{
    [SerializeField]
    private Sticker sticker;

    [SerializeField]
    private Transform stickerImage;

    private Vector3 criteriaVector;

    private void Awake()
    {
        criteriaVector = (transform.position - transform.parent.position).normalized;
    }

    private void OnMouseDown()
    {
        sticker.IsActiveTools = true;
    }

    private void OnMouseDrag()
    {
        // Rotation
        Vector3 mouseDirection = (GetMouseWorldPosition() - transform.parent.position).normalized;

        float eulerZ = SignedAngleBetween(criteriaVector, mouseDirection, Vector3.forward) + 180;

        transform.parent.rotation = transform.parent.rotation.ChangeZ(eulerZ);

        // Scale
        float distance = Vector2.Distance(transform.parent.position, GetMouseWorldPosition());
        
        transform.parent.localScale = new Vector2(distance, distance);

        distance = Vector2.Distance(stickerImage.position, transform.position);

        transform.parent.localScale = new Vector2(distance, distance);
    }

    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);

        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        return mousePosition;
    }

    float SignedAngleBetween(Vector3 a, Vector3 b, Vector3 n)
    {
        float angle = Vector3.Angle(a, b);
        float sign = Mathf.Sign(Vector3.Dot(n, Vector3.Cross(a, b)));

        float signed_angle = angle * sign;

        float angle360 = (signed_angle + 180) % 360;

        return angle360;
    }
}
