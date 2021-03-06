﻿using UnityEngine;

[RequireComponent( typeof( EgoComponent ) )]
public class OnCollisionExitComponent : MonoBehaviour
{
    void OnCollisionExit( Collision collision )
    {
        var thisEgoComponent = GetComponent<EgoComponent>();
        var otherEgoComponent =  collision.gameObject.GetComponent<EgoComponent>();
        var e = new CollisionExitEvent( thisEgoComponent, otherEgoComponent, collision );
        EgoEvents<CollisionExitEvent>.AddEvent( e );
    }
}
