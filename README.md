# Explain

This project is the smallest case prepared for this question. https://stackoverflow.com/questions/62056166/holographic-remoting-can-not-capture-gestures-at-unity

## BuiltinConnector

Open Scenes/BuiltinConnector, open unity built-in holographic remoting at window/xr/holographic emulation, connect to hololens device, and run. And try use tap, you will see log at world space ui, like "tap"\"pressed".

## CustomConnector

Open Scenes/CustomConnector, make sure you are not using the built-in connector. The only difference with the BuiltinConnector scenes is the use custom connector at Prefabes/Connector .
Ready hololens device, click run button. If you press the Q key, will start connection. when you see graphic at hololens, try use tap. you will see only "pressed" at log, but not "tap".

## More

I had imported MRTKv2 to test gesture, no tap gestures too.  
I am not use unity new XR Plugin Management, because this newer feature is not available in the older unity version. And my problem appears in almost all unity versions.