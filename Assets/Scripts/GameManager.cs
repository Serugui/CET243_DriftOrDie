using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform player;
    public Transform cameraTransform;

    public float deathZone = -5f;
    public float cameraSpeed = 5f;

    void Update()
    {
        float yDifference = player.position.y - cameraTransform.position.y;

        if (yDifference < deathZone)
        {
            RestartGame();
        }

        MoveCameraUp();
    }

    void MoveCameraUp()
    {
        float cameraSpeed = 1f;

        cameraTransform.Translate(Vector3.up * cameraSpeed * Time.deltaTime);
    }

    void RestartGame()
    {
        player.position = new Vector3(0.6f, -2.5f, 0f);
        player.rotation = Quaternion.identity;
        cameraTransform.position = new Vector3(0f, 0f, -1f);
    }
    }
