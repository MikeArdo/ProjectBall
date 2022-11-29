#pragma strict
var myPos : Vector3;
var myPlay : Transform;
function Start () {

}

function Update()
{
//inseguimento GameObject
   transform.position = myPlay.position + myPos;
   //posizione fissa della camera sull'asse z
   transform.position.z = 5.0;
}