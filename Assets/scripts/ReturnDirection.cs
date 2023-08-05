using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ReturnDirection
{
    private enum HitDirection { None, Top, Bottom, Forward, Back, Left, Right };
    public static string direction( GameObject Object, GameObject ObjectHit ){
		HitDirection hitDirection = HitDirection.None;
		RaycastHit MyRayHit;
		Vector3 direction = ( Object.transform.position - ObjectHit.transform.position ).normalized;
		Ray MyRay = new Ray( ObjectHit.transform.position, direction );
		
		if ( Physics.Raycast( MyRay, out MyRayHit ) ){
				
			if ( MyRayHit.collider != null ){
				
				Vector3 MyNormal = MyRayHit.normal;
				MyNormal = MyRayHit.transform.TransformDirection( MyNormal );
				
				if( MyNormal == MyRayHit.transform.up ){ 
                    return "top";
                } else if( MyNormal == -MyRayHit.transform.up ){ 
                    return "bottom";
                } else if( MyNormal == MyRayHit.transform.forward ){ 
                    return "forward";
                }else if( MyNormal == -MyRayHit.transform.forward ){ 
                    return "back";
                } else if( MyNormal == MyRayHit.transform.right ){ 
                    return "right";
                }
				return "left";
			}	
		}
        return "something wrong, i can feel it";
	}
}
