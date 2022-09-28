using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ChangeSpeechBubbleSize : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _Text;
    [SerializeField] GameObject _TopLeftCorner;
    [SerializeField] GameObject _TopRightCorner;
    [SerializeField] GameObject _BottomLeftCorner;
    [SerializeField] GameObject _BottomRightCorner;
    [SerializeField] GameObject _Height;
    [SerializeField] GameObject _Width;

    // get current size and location
    ArrayList GetBounds(GameObject image)
    {
        var rectTransform = image.GetComponent<RectTransform>();
        var sizeDelta = rectTransform.sizeDelta;
        var position = image.transform.position;

        Vector3 bottomLeft = position - new Vector3(sizeDelta.x / 2, sizeDelta.y / 2);
        Vector3 bottomRight = bottomLeft + new Vector3(rectTransform.rect.width,0);
        Vector3 topRight = position + new Vector3(sizeDelta.x / 2, sizeDelta.y / 2);
        Vector3 topLeft = topRight - new Vector3(rectTransform.rect.width,0);
        
        ArrayList bounds = new ArrayList();

        bounds.Add(topLeft);
        bounds.Add(topRight);
        bounds.Add(bottomLeft);
        bounds.Add(bottomRight);
        
        return bounds;
    }
    void Start()
    {

    }
    void Update()
    {
        Debug.Log(_Text.textInfo.lineCount);
        if(_Text.textInfo.lineCount > 3)
        {
            _Width.transform.localScale = new Vector3(1,_Text.textInfo.lineCount - 1,1);
            Vector3 _tp = (Vector3) GetBounds(_Height)[0];
            _TopLeftCorner.transform.position = _tp;
            
        }
        else
        {
            _Width.transform.localScale = new Vector3(1,1,1);
        }
    }
    
}
