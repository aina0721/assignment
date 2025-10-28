using UnityEngine;

public class PuzzleScript7 : MonoBehaviour
{
    public GameObject obj7;

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
        float objx = obj7.transform.localPosition.x;
        float objy = obj7.transform.localPosition.y;

        if (-60 <= objx && objx <= 60)
        {
            if (-260 >= objy && objy >= -360)
            {
                obj7.transform.localPosition = new Vector3(-1, -313, 0);
                game_manager.GetComponent<GameManager>().count++;
                PuzzleScript7 script = GetComponent<PuzzleScript7>();
                Destroy(script);
            }
        }
    }
}
