
using UnityEngine;

public class Node : MonoBehaviour
{
    public Transform nodePosition;

    void Update()
    {
        transform.position = new Vector3(
            Mathf.Lerp(transform.position.x, nodePosition.position.x, Time.deltaTime * 15),
            nodePosition.position.y,nodePosition.position.z+1);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "RedColor")
        {
            this.gameObject.transform.GetChild(0).GetComponent<MeshRenderer>().material.color=Finish._instance.redCaseColor;
        }if (collision.gameObject.tag == "GreenColor")
        {
            this.gameObject.transform.GetChild(0).GetComponent<MeshRenderer>().material.color=Finish._instance.greenCaseColor;
        }if (collision.gameObject.tag == "PurpleColor")
        {
            this.gameObject.transform.GetChild(0).GetComponent<MeshRenderer>().material.color=Finish._instance.purpleCaseColor;
        }if (collision.gameObject.tag == "BlueColor")
        {
            this.gameObject.transform.GetChild(0).GetComponent<MeshRenderer>().material.color=Finish._instance.blueCaseColor;
        }
    }
}
