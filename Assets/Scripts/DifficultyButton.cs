using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour
{
    private Button button;


    private GameManeger gameManeger;

    public int difficulty;
    
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        gameManeger = GameObject.Find("Game Maneger").GetComponent<GameManeger>();
        button.onClick.AddListener(SetDifficulty);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SetDifficulty()
    {
        Debug.Log(button.gameObject.name + "was clicked");
        gameManeger.StartGame(difficulty);
    }
}