using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InGameCard : MonoBehaviour, ICardViewer , IPointerDownHandler
{
    [SerializeField] Image _cardImage;
    [SerializeField] Text  _cardName;
    [SerializeField] Text  _cost;
    [SerializeField] int   _cardCd;
    int                    _cardID;
    Vector3                _originalPosition;
    public void ShowCard(int cardID) { _cardID = cardID; }



    public void OnPointerDown(PointerEventData eventData)
    {
        
    }
}