using UnityEngine;

public class PuzzleScript5 : MonoBehaviour
{
    public GameObject obj5;

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
        float objx = obj5.transform.localPosition.x;
        float objy = obj5.transform.localPosition.y;

        if (240 <= objx && objx <= 360)
        {
            if (60 >= objy && objy >= -60)
            {
                obj5.transform.localPosition = new Vector3(299, -13, 0);
                game_manager.GetComponent<GameManager>().count++;
                PuzzleScript5 script = GetComponent<PuzzleScript5>();
                Destroy(script);
            }
        }
    }
}
