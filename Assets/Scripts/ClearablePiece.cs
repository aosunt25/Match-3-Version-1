using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ClearablePiece : MonoBehaviour
{


    private bool isBeingCleared = false;

    public bool IsBeingCleared
    {
        get { return isBeingCleared; }
    }

    protected GamePiece piece;

    void Awake()
    {
        piece = GetComponent<GamePiece>();
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Clear()
    {
        isBeingCleared = true;
        Destroy(gameObject);

    }

}
