using UnityEngine;

public class PuzzleScript3 : MonoBehaviour
{
    public GameObject obj3;

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
        float objx = obj3.transform.localPosition.x;
        float objy = obj3.transform.localPosition.y;

        if (-360 <= objx && objx <= -240)
        {
            if (60 >= objy && objy >= -60)
            {
                obj3.transform.localPosition = new Vector3(-301, -13, 0);
                game_manager.GetComponent<GameManager>().count++;
                PuzzleScript3 script = GetComponent<PuzzleScript3>();
                Destroy(script);
            }
        }
    }
}
