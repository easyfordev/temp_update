using UnityEngine;

public class DrawLine : MonoBehaviour
{
    [SerializeField]
    private Material lineMaterial;

    [SerializeField]
    private DrawingBoard drawingBoard;

    private int pointCount;

    private int lineCount;

    private Vector3 prevMousePosition;

    private LineRenderer lineRenderer;

    public float Thickness { get; set; }

    public Material LineMaterial { get { return lineMaterial; } }

    private void Awake()
    {
        prevMousePosition = Vector3.zero;

        Thickness = 1f;

        lineCount = 0;

        drawingBoard.AddBeginDragEvent(new DrawingBoard.BeginDragDelegate(GetNewLine));

        drawingBoard.AddDragEvent(new DrawingBoard.DragDelegate(Draw));
    }

    public void Draw()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 85);

        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        lineRenderer.positionCount = pointCount + 1;

        lineRenderer.SetPosition(pointCount, mousePosition);

        prevMousePosition = mousePosition;

        pointCount++;
    }

    public void GetNewLine()
    {
        LineRenderer newLine = new GameObject("Line").gameObject.AddComponent<LineRenderer>();

        newLine.transform.parent = this.transform;

        newLine.transform.localPosition = Vector3.zero;
        newLine.transform.localRotation = Quaternion.identity;
        newLine.transform.localScale = Vector3.zero;

        newLine.material = new Material(lineMaterial);

        //newLine.startWidth = Thickness;
        //newLine.endWidth = Thickness;

        newLine.sortingOrder = lineCount++;

        newLine.positionCount = 0;

        pointCount = 0;

        lineRenderer = newLine;
    }
}
