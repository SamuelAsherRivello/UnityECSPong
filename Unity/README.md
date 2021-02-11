<p align="center">
    <img src="https://raw.githubusercontent.com/sschmid/Entitas-CSharp/develop/Readme/Images/Entitas-Header.png" alt="Entitas">
</p>
--------------

What is Entitas?
=============
* <a href="http://www.rivellomultimediaconsulting.com/unity3d_architectures_entitas/">Unity3D Architectures: Entitas</a> - Read my latest article for the full introduction

This Github Project
=============
* <a href="http://www.RivelloMultimediaConsulting.com/unity/">Rivello Multimedia Consulting</a> (RMC) created this simple 'Pong' clone using Entitas
* Entitas is an ECS (Entity Component System) which presents a new way to think about architecting your Unity projects. Thanks to the amazing work of <a href="http://github.com/sschmid/Entitas-CSharp/">https://github.com/sschmid/Entitas-CSharp/</a>

Screenshot
=============

![Alt text](/entitas_pong_screenshot.png?raw=true "Screenshot")

Instructions
=============
* Replace the /unity/Assets/3rdParty/Entitas folder contents with the latest download from <a href="http://github.com/sschmid/Entitas-CSharp/">github.com</a></BR>
* Open the /unity/ folder in Unity3D. </BR>
* Open the EntitasPong.unity file. Play.
* Use the up and down arrows to move your paddle. Prevent the ball from passing your paddle. Bounce the ball to pass behind the opponents paddle to score. There is no end to the game :)

Structure Overview
=============
* **/Assets/RMC/Common/Scripts/Runtime/** contains code that could be reused across various Entitas games<BR>
* **/Assets/RMC/EntitasPong/Scripts/Runtime/** contains game-specific code

Code Overview
=============
* **GameController.cs** is the main entry point
* **GameConstants.cs** has some easy to edit values
* **StartNextRoundSystem.cs** is called before every round.

Open Questions
=============
* I added `ENTITAS_HELP_REQUEST` comments in the code where I have questions about best practices. I created a new <a href= "https://github.com/sschmid/Entitas-CSharp/issues/137">GitHub issue which includes all related code snippets</a>. Please help! :)

TODO
=============
* Done


Created By
=============

- Samuel Asher Rivello <a href="https://twitter.com/srivello/">@srivello</a>, <a href="http://www.github.com/RivelloMultimediaConsulting/">Github</a>, <a href="http://www.rivellomultimediaconsulting.com/unity/">Rivellomultimediaconsulting.com</a>

