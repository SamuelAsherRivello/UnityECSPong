﻿using Entitas;

namespace RMC.EntitasPong.Entitas.Components
{
	/// <summary>
	/// Stores how the computer Paddle responds to the ball
	/// </summary>
	public class AIComponent : IComponent
	{
		// ------------------ Serialized fields and properties
		public Entity targetEntity;
		public float deadZoneY = 1;
		public float velocityY = 0.5f;

	}
}