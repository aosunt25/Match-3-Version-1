using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePiece : MonoBehaviour
{
    private GamePiece piece;
    private IEnumerator moveCouroutine;

    void Awake()
    {
        piece = GetComponent<GamePiece> ();

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
    }

   

    public void Move(int newX, int newY, float time)
    {
        if (moveCouroutine != null)
        {
            StopCoroutine(moveCouroutine);
        }

        moveCouroutine = MoveCoroutine(newX, newY, time);
        StartCoroutine(moveCouroutine);
        
        //piece.X = newX;
       // piece.Y = newY;
        //piece.transform.localPosition = piece.GridRef.GetPositionGird(newX, newY);

    }

    private IEnumerator MoveCoroutine(int newX, int newY, float time)
    {
        Vector3 startPos = transform.position;
        Vector3 endPos = piece.GridRef.GetPositionGird(newX, newY);

        piece.X = newX;
        piece.Y = newY;

        for ( float t=0; t <= 1 * time; t += Time.deltaTime)
        {
            piece.transform.position = Vector3.Lerp(startPos, endPos, t / time);
            yield return 0;

        }
        piece.transform.position = endPos;
    }
}
