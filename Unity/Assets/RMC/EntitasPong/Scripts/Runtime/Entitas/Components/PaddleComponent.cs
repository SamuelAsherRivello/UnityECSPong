﻿using Entitas;

namespace RMC.EntitasPong.Entitas.Components
{
	/// <summary>
	/// Flags Entity as a Paddle. 
	/// </summary>
	public class PaddleComponent : IComponent
	{
        public enum PaddleType
        {
            White,
            Black
        }
		// ------------------ Serialized fields and properties
		public PaddleType paddleType;

	}
}