using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InGameCard : MonoBehaviour, ICardViewer , IDragHandler, IEndDragHandler , IPointerDownHandler
{
    [SerializeField] Image _cardImage;
    [SerializeField] Text  _cardName;
    [SerializeField] Text  _cost;
    [SerializeField] int   _cardCd;
    int                    _cardID;
    Vector3                _originalPosition;
    RectTransform          rectTransform;

    void Start() { rectTransform     = GetComponent<RectTransform>(); }

    public void ShowCard(int cardID) { _cardID = cardID; }


    public void OnDrag(PointerEventData    eventData) { rectTransform.position = Input.mousePosition; }
    public void OnEndDrag(PointerEventData eventData) { rectTransform.position = _originalPosition; }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (_originalPosition == Vector3.zero) { _originalPosition = rectTransform.position; }
    }
}