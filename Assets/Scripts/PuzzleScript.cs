using UnityEngine;

public class PuzzleScript : MonoBehaviour
{
    public GameObject obj;

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
        float objx = obj.transform.localPosition.x;
        float objy = obj.transform.localPosition.y;

        if (-360 <= objx && objx <= -240)
        {
            if (330 >= objy && objy >= 230)
            {
                obj.transform.localPosition = new Vector3(-301, 282, 0);
                game_manager.GetComponent<GameManager>().count++;
                PuzzleScript script = GetComponent<PuzzleScript>();
                Destroy(script);
            }
        }
    }
}
