using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.WSA.Input;
using UnityEngine.UI;

public class GestureCapture : MonoBehaviour
{
    GestureRecognizer gestureRecognizer;
    Text text ;

    void Start()
    {
        text =FindObjectOfType <Text >();

        gestureRecognizer = new GestureRecognizer();
        gestureRecognizer.Tapped += RecognizerTapped;
        gestureRecognizer.SetRecognizableGestures(GestureSettings.Tap);
        gestureRecognizer.StartCapturingGestures();
        InteractionManager.InteractionSourcePressed += InteractionSourcePressed;
    }

    void OnDestroy()
    {
        gestureRecognizer.Tapped -= RecognizerTapped;
        InteractionManager.InteractionSourcePressed += InteractionSourcePressed;
    }

    void RecognizerTapped(TappedEventArgs args)
    {
        text .text +="\ntap";
    }

    void InteractionSourcePressed(InteractionSourcePressedEventArgs args)
    {
        text .text +="\npressed";
    }
}
