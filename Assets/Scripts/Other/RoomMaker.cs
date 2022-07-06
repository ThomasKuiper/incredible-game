using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomMaker : MonoBehaviour
{
    public GameObject wall;
    public int width;
    public int length;
    private float wallWidth;
    private float wallLength;
    void Start()
    {
        Vector2 wallSize = wall.GetComponent<BoxCollider2D>().size;
        float scaleX = wall.transform.localScale.x;
        float scaleY = wall.transform.localScale.y;
        wallWidth = wallSize.x * scaleX;
        wallLength = wallSize.y * scaleY;
        MakeSquareRoom(width, length);
    }

    void MakeSquareRoom(int width, int height)
    {
        //make top and bottom walls
        if (width % 2 == 0)//walls are at x = wallHeight/2 + wallHeight * (i = -width/2....width/2), y = constant (so no middle wall at x =0)
        {
            float topY = height / 2f * wallLength + wallWidth/2;
            float bottomY = topY * -1;
            for (float i = width / 2f * wallLength * -1 + wallLength / 2; i < width / 2 * wallLength; i += wallLength)
            {
                Vector3 topLocation = new Vector3(i, topY);
                Vector3 bottomLocation = new Vector3(i, bottomY);
                Vector3 topRotation = new Vector3(0, 0, -90);
                Vector3 bottomRotation = new Vector3(0, 0, 90);
                Instantiate(wall, topLocation, Quaternion.Euler(topRotation));
                Instantiate(wall, bottomLocation, Quaternion.Euler(bottomRotation));
            }
        }
        else//walls are at x = wallHeight * (i = -(width -1)/2....width/2), y = constant
        {
            float topY = height / 2f * wallLength;
            float bottomY = topY * -1;
            for (float i = (width -1)/ 2f * wallLength * -1; i < width/2f * wallLength; i += wallLength)
            {
                Vector3 topLocation = new Vector3(i, topY);
                Vector3 bottomLocation = new Vector3(i, bottomY);
                Vector3 topRotation = new Vector3(0, 0, -90);
                Vector3 bottomRotation = new Vector3(0, 0, 90);
                Instantiate(wall, topLocation, Quaternion.Euler(topRotation));
                Instantiate(wall, bottomLocation, Quaternion.Euler(bottomRotation));
            }
        }

        //make left and right walls
        if (height % 2 == 0)//walls are at y = wallHeight/2 + wallHeight * (i = -width/2....width/2), x = constant
        {
            float rightX = width / 2f * wallLength - wallWidth/2f;
            float leftX = rightX * -1;
            for (float i = height / 2f * wallLength * -1 + wallLength / 2; i < height / 2 * wallLength; i += wallLength)
            {
                Vector3 rightLocation = new Vector3(rightX, i);
                Vector3 leftLocation = new Vector3(leftX, i);
                Vector3 leftRotation = new Vector3(0, 0, 0);
                Vector3 rightRotation = new Vector3(0, 0, 180);
                Instantiate(wall, rightLocation, Quaternion.Euler(leftRotation));
                Instantiate(wall, leftLocation, Quaternion.Euler(rightRotation));
            }
        }
        else//walls are at y = wallHeight * (i = -(width -1)/2....width/2), x = constant
        {
            float rightX = width / 2f * wallLength - wallWidth / 2f;
            float leftX = rightX * -1;
            for (float i = (height -1)/ 2f * wallLength * -1; i < height /2f * wallLength; i += wallLength)
            {
                Vector3 rightLocation = new Vector3(rightX, i);
                Vector3 leftLocation = new Vector3(leftX, i);
                Vector3 leftRotation = new Vector3(0, 0, 0);
                Vector3 rightRotation = new Vector3(0, 0, 180);
                Instantiate(wall, rightLocation, Quaternion.Euler(leftRotation));
                Instantiate(wall, leftLocation, Quaternion.Euler(rightRotation));
            }
        }
    }
}
