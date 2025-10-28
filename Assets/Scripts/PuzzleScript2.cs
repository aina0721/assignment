using UnityEngine;

public class PuzzleScript2 : MonoBehaviour
{
    public GameObject obj2;

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
        float objx = obj2.transform.localPosition.x;
        float objy = obj2.transform.localPosition.y;

        if (240 <= objx && objx <= 360)
        {
            if (330 >= objy && objy >= 230)
            {
                obj2.transform.localPosition = new Vector3(299, 282, 0);
                game_manager.GetComponent<GameManager>().count++;
                PuzzleScript2 script = GetComponent<PuzzleScript2>();
                Destroy(script);
            }
        }
    }
}
