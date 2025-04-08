using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class EnemyTraceController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float raycastDistance = .2f;
    public float traceDistance = 2f;

    private Transform player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        Vector2 disrction = player.position - transform.position;

        if (disrction.magnitude > traceDistance)
            return;
        Vector2 directionNormalized = disrction.normalized;

        RaycastHit2D[] hits = Physics2D.RaycastAll(transform.position, directionNormalized, raycastDistance);

    }
}
    // Start is called before the first frame update
    