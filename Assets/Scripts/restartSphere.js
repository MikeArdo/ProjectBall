#pragma strict
var sphereObject:Transform;
var volume;
function Start () {

}

function Update () {
}
//riavvio alla collisione
function OnTriggerEnter (collision : Collider)
{
if(collision.gameObject.tag == "cube")
    {
    Application.LoadLevel("menù");
    }
  }