using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GameInstanceBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    private int height;
    private int width;
    private GameObject[,] field;
    private GameObject player;
    private int playerX, playerY;

    [SerializeField] GameObject empty;
    [SerializeField] GameObject wall;
    [SerializeField] GameObject box;
    [SerializeField] GameObject goal;
    [SerializeField] GameObject mover;

    void Start()
    {
        parseLevel("level1.lvl");
    }

    private void parseLevel(string file)
    {
        //width height
        //in matrix 0 is empty space, 1 is wall, 2 is box, 3 is goal, 4 is mover
        string[] lines = File.ReadAllLines(file);
        string[] s = lines[0].Split(' ');
        height = int.Parse(s[0]);
        width = int.Parse(s[1]);
        field = new GameObject[height, width];
        for (int i = 0; i < height; i++)
        {
            s = lines[i + 1].Split();
            for (int j = 0; j < width; j++)
            {
                if (s[0] == "0")
                {
                    field[i, j] = Instantiate(empty);
                }
                else if (s[0] == "1")
                {
                    field[i, j] = Instantiate(wall);
                }
                else if (s[0] == "2")
                {
                    field[i, j] = Instantiate(box);
                }
                else if (s[0] == "3")
                {
                    field[i, j] = Instantiate(goal);
                }
                else if (s[0] == "4")
                {
                    field[i, j] = Instantiate(mover);
                    player = mover;
                    playerX = j;
                    playerY = i;
                }
            }
        }
    }

    //0 is for left, 1 is for up, 2 is for right, 3 is for down
    private void move(int dir)
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a"))
            move(0);
        else if (Input.GetKeyDown("w"))
            move(1);
        else if (Input.GetKeyDown("d"))
            move(2);
        else if (Input.GetKeyDown("s"))
            move(3);
    }
}
