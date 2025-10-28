using UnityEngine;

public class PuzzleScript6 : MonoBehaviour
{
    public GameObject obj6;

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
        float objx = obj6.transform.localPosition.x;
        float objy = obj6.transform.localPosition.y;

        if (-360 <= objx && objx <= -240)
        {
            if (-260 >= objy && objy >= -360)
            {
                obj6.transform.localPosition = new Vector3(-301, -313, 0);
                game_manager.GetComponent<GameManager>().count++;
                PuzzleScript6 script = GetComponent<PuzzleScript6>();
                Destroy(script);
            }
        }
    }
}
