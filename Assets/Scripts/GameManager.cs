using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Vector3 _previousPos = Vector3.zero;
    private Vector3 _currentPos = Vector3.zero;
    private bool _isDrog = false; // �u�h���b�O����Ă��邩�v�̐^�U�l

    public int count = 0;

    public GameObject title_image;
    public GameObject clear_image;

    private void Start()
    {
        title_image.SetActive(true);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _previousPos = Input.mousePosition;
        }

        if (_isDrog == true)
        {
            if (Input.GetMouseButton(0))
            {
                GetComponent<RectTransform>().SetAsLastSibling();
                _currentPos = Input.mousePosition;
                Vector3 _diffDistance = _currentPos - _previousPos;
                _diffDistance *= 1.0f;

                this.transform.GetComponent<RectTransform>().position -= new Vector3(-_diffDistance.x, -_diffDistance.y);
                _previousPos = Input.mousePosition;
            }
        }

        if (count == 9)
        {
            Invoke("Clear", 0.5f);
        }
    }

    void Clear()
    {
        clear_image.GetComponent<RectTransform>().SetAsLastSibling();
        clear_image.SetActive(true);  
    }

    public void OnClick()
    {
        title_image.SetActive(false);
    }

    // �h���b�O���ɌĂяo����鏈��
    public void OnDrog()
    {
        _isDrog = true;
    }

    // �h���b�O�I�����ɌĂяo����鏈��
    public void OffDrog()
    {
        _isDrog = false;
    }
}
