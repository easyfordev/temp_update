using UnityEngine;
using UnityEngine.UI;

public class ObjectActive : MonoBehaviour
{
    [SerializeField]
    private GameObject[] targetList;

    [SerializeField]
    private Image drawingBoard;

    [SerializeField]
    private Text drawingText;

    [SerializeField]
    private bool isActive;

    private void Awake()
    {
        for(int i = 0; i < targetList.Length; ++i)
            targetList[i].SetActive(isActive);
    }

    public void Active()
    {
        isActive = !isActive;

        for (int i = 0; i < targetList.Length; ++i)
            targetList[i].SetActive(isActive);

        drawingBoard.raycastTarget = isActive;

        if (isActive)
            drawingText.text = "End Drawing";

        else
            drawingText.text = "Start Drawing";
    }
}