using UnityEngine;

public class ToolActive : MonoBehaviour
{
    [SerializeField]
    private float moveTime;

    [SerializeField]
    private Transform target;

    [SerializeField]
    private Transform openTransform;

    [SerializeField]
    private Transform closeTransform;

    private bool isActive;

    private void Awake()
    {
        isActive = false;
    }

    public void ClickActiveButton()
    {
        isActive = !isActive;

        StopAllCoroutines();

        if (isActive)
            Open();

        else
            Close();
    }

    private void Open()
    {
        StartCoroutine(Tween.TweenTransform.Position(target.transform, openTransform.position, moveTime));
    }

    private void Close()
    {
        StartCoroutine(Tween.TweenTransform.Position(target.transform, closeTransform.position, moveTime));
    }
}
