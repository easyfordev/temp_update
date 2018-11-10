using UnityEngine;
using UnityEngine.EventSystems;

public class DrawingBoard : MonoBehaviour
{
    public delegate void BeginDragDelegate();
    public delegate void DragDelegate();

    private BeginDragDelegate beginDragDelegate;

    private DragDelegate dragDelegate;

    public void AddBeginDragEvent(BeginDragDelegate beginDragEvent)
    {
        beginDragDelegate += beginDragEvent;
    }

    public void AddDragEvent(DragDelegate dragEvent)
    {
        dragDelegate += dragEvent;
    }

    private void OnMouseDown()
    {
        beginDragDelegate();
    }

    private void OnMouseDrag()
    {
        dragDelegate();
    }
}