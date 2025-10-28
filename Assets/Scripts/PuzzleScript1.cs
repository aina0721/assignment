using UnityEngine;

public class PuzzleScript1 : MonoBehaviour
{
    public GameObject obj1;

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
        float objx = obj1.transform.localPosition.x;
        float objy = obj1.transform.localPosition.y;

        if (-60 <= objx && objx <= 60)
        {
            if (330 >= objy && objy >= 230)
            {
                obj1.transform.localPosition = new Vector3(-1, 282, 0);
                game_manager.GetComponent<GameManager>().count++;
                PuzzleScript1 script = GetComponent<PuzzleScript1>();
                Destroy(script);
            }
        }
    }
}
