using UnityEngine;
using UnityEngine.UI;

using HD;

public enum PenType
{
    Brush,
    Highlight,
    Spray
}

public class LineTool : MonoBehaviour
{
    [SerializeField]
    private DrawLine lineGroup;

    [SerializeField]
    private Transform stickerGroup;

    [SerializeField]
    private Texture noiseTexture;

    [SerializeField]
    private Transform[] pensTransform;

    private const float moveDistance = 2.5f;

    private PenType prevPenType;

    private void Start()
    {
        prevPenType = PenType.Brush;

        PenMove(PenType.Brush, true);

        lineGroup.LineMaterial.color = lineGroup.LineMaterial.color.ChangeAlpha(1f);

        lineGroup.LineMaterial.SetTexture("_NoiseTex", null);
    }

    public void SelectBrush()
    {
        if (prevPenType == PenType.Brush)
            return;

        PenInit();

        PenMove(PenType.Brush, true);

        prevPenType = PenType.Brush;
    }

    public void SelectHighLight()
    {
        if (prevPenType == PenType.Highlight)
            return;

        PenInit();

        lineGroup.LineMaterial.color = lineGroup.LineMaterial.color.ChangeAlpha(0.5f);

        PenMove(PenType.Highlight, true);

        prevPenType = PenType.Highlight;
    }

    public void SelectSpray()
    {
        if (prevPenType == PenType.Spray)
            return;

        PenInit();

        lineGroup.LineMaterial.SetTexture("_NoiseTex", noiseTexture);

        PenMove(PenType.Spray, true);

        prevPenType = PenType.Spray;
    }

    private void PenInit()
    {
        PenMove(prevPenType, false);

        lineGroup.LineMaterial.color = lineGroup.LineMaterial.color.ChangeAlpha(1f);

        lineGroup.LineMaterial.SetTexture("_NoiseTex", null);
    }

    private void PenMove(PenType penType, bool isOpen)
    {
        float moveValue = moveDistance;

        if (!isOpen)
            moveValue = -moveValue;

        StartCoroutine(Tween.TweenTransform.Position(pensTransform[(int)penType],
                                                     pensTransform[(int)penType].position.SumY(moveValue),
                                                     0.5f));
    }

    public void SelectColor(Image colorImage)
    {
        lineGroup.LineMaterial.color = new Color(colorImage.color.r,
                                            colorImage.color.g,
                                            colorImage.color.b,
                                            lineGroup.LineMaterial.color.a);
    }

    public void SelectClear()
    {
        int childCount = lineGroup.transform.childCount;

        for (int i = 0; i < childCount; ++i)
             Destroy(lineGroup.transform.GetChild(i).gameObject);

        childCount = stickerGroup.transform.childCount;

        for (int i = 0; i < childCount; ++i)
            Destroy(stickerGroup.transform.GetChild(i).gameObject);
    }
}
