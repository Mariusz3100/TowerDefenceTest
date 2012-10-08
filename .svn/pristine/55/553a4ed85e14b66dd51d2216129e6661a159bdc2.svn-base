#pragma strict

function Start () {

}
var speed:int;
function Update () {

if(this.transform.position.z>-28&&this.transform.position.z<61){
var vert=Input.GetAxisRaw("Vertical")*Time.deltaTime;
this.transform.position.z+=vert*speed;

}else{
this.transform.position.z-=Mathf.Sign(this.transform.position.z)/10; //so mage won't get blocked on the edges
}


if(this.transform.position.x>-38&&this.transform.position.x<53){
	var hor=Input.GetAxisRaw("Horizontal")*Time.deltaTime;
	this.transform.position.x+=hor*speed;
}else{
	this.transform.position.x-=Mathf.Sign(this.transform.position.x)/10; //so mage won't get blocked on the edges
}

}