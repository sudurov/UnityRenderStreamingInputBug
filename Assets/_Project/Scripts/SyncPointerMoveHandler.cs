using UnityEngine;
using UnityEngine.EventSystems;

public class SyncPointerMoveHandler : MonoBehaviour, IPointerMoveHandler
{
    [SerializeField] private Transform _target;

    public void OnPointerMove(PointerEventData eventData)
    {
        _target.position = eventData.position;
    }
}