﻿using Newtonsoft.Json;

namespace CSGO_Demos_Manager.Models.Events
{
	public class BombDefusedEvent : BaseEvent
	{
		[JsonProperty("defuser_steamid")]
		public long DefuserSteamId { get; set; }

		[JsonProperty("defuser_name")]
		public string DefuserName { get; set; }

		[JsonProperty("site")]
		public string Site { get; set; }

		[JsonIgnore]
		public override string Message => "Bomb defused on BP " + Site + " by " + DefuserName;

		public BombDefusedEvent(int tick, float seconds)
			: base(tick, seconds)
		{
		}
	}
}
