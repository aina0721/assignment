using UnityEngine;

public class PuzzleScript8 : MonoBehaviour
{
    public GameObject obj8;

    private GameObject game_manager;

    private void Start()
    {
        game_manager = GameObject.Find("GameObject");
    }

    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Puzzle();
            Debug.Log("ç∂ÉNÉäÉbÉNÇó£ÇµÇ‹ÇµÇΩ");
        }
    }

    void Puzzle()
    {
        float objx = obj8.transform.localPosition.x;
        float objy = obj8.transform.localPosition.y;

        if (240 <= objx && objx <= 360)
        {
            if (-260 >= objy && objy >= -360)
            {
                obj8.transform.localPosition = new Vector3(299, -313, 0);
                game_manager.GetComponent<GameManager>().count++;
                PuzzleScript8 script = GetComponent<PuzzleScript8>();
                Destroy(script);
            }
        }
    }
}
