
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using UnityEngine.AI;

public class seguiPlayer1 : UdonSharpBehaviour
{
    public Transform playerObj;
    public Animator anim;
    private float minV = 0.05f;
    
    protected NavMeshAgent enemyMesh;
    void Start()
    {
        enemyMesh = GetComponent<NavMeshAgent>();
        
    }

    private void Update()
    {
        enemyMesh.SetDestination(playerObj.position);

        
    }
}
