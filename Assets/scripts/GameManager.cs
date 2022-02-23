using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class GameManager : MonoBehaviour
{
    public GameObject enemy;
    private Vector2 pos1, pos2;
    public Tilemap[] tiles;
    public GameObject buttons;
    public Text welcomText;
    public GameObject player;
    public TextMeshProUGUI lives;
    public TextMeshProUGUI timer;
    public TextMeshProUGUI gameover;
    private float count = 60f;
    private int life;
    private bool startGame=true;
    // Start is called before the first frame update
    void Start()
    {
        life = GameObject.Find("Player").GetComponent<PlayerMovement>().lives;
        pos1= new Vector2(13,-9);
        pos2= new Vector2(11, 2);           
        buttons.gameObject.SetActive(true);
        welcomText.gameObject.SetActive(true);
        player.gameObject.SetActive(false);
        enemy.gameObject.SetActive(false);
        lives.gameObject.SetActive(false);
        timer.gameObject.SetActive(false);
        gameover.gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        SetTimer();
    }
    public void StartGame(int levelNumer)
    {
        if (startGame)
        {
            player.gameObject.SetActive(true);
            enemy.gameObject.SetActive(true);
            Instantiate(enemy, pos1, transform.rotation);
            Instantiate(enemy, pos2, transform.rotation);
            buttons.gameObject.SetActive(false);
            welcomText.gameObject.SetActive(false);
            tiles[levelNumer].gameObject.SetActive(true);
            lives.gameObject.SetActive(true);
            timer.gameObject.SetActive(true);
            lives.SetText("Lives" + life);
        }
    }
    void SetTimer()
    {
        count -= Time.deltaTime;
        timer.SetText("" + count);
        if (count< 1)
        {

            timer.SetText("TimeUP!");
            gameover.gameObject.SetActive(true);
            startGame = false;
        }
    }
}
