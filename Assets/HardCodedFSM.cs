using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardCodedFSM : ScriptableObject
{
    enum State {PATROL, CHASE, ATTACK};
    State myState;
    State PATROL, CHASE, ATTACK;

    void Update()
    {
        if (myState == PATROL)
        {
            if (canSeePlayer())
            {
                myState = CHASE;
            }
        }

        if (myState == CHASE)
        {
            if (canSeePlayer() == false)
            {
                myState = PATROL;
            }
            else if (playerInAttackRange())
            {
                myState = ATTACK;
            }
        }

        if (myState == ATTACK)
        {
            if (playerInAttackRange() == false)
            {
                myState = CHASE;
            }
        }
    }

    public bool canSeePlayer()
    {
        return true;
    }

    public bool playerInAttackRange()
    {
        return true;
    }
}