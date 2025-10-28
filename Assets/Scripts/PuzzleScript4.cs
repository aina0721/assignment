using UnityEngine;

public class PuzzleScript4 : MonoBehaviour
{
    public GameObject obj4;

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
        float objx = obj4.transform.localPosition.x;
        float objy = obj4.transform.localPosition.y;

        if (-60 <= objx && objx <= 60)
        {
            if (60 >= objy && objy >= -60)
            {
                obj4.transform.localPosition = new Vector3(-1, -13, 0);
                game_manager.GetComponent<GameManager>().count++;
                PuzzleScript4 script = GetComponent<PuzzleScript4>();
                Destroy(script);
            }
        }
    }
}
