﻿using System;
using System.Collections.Generic;

namespace DrawlandiaApp.Models
{
    public class Room
    {
        public Room()
        {
        }

        public Room(string name, string password)
        {
            this.Name = name;
            this.Password = password;
            this.State = RoomState.NotStarted;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public ICollection<Player> Players { get; set; }

        public RoomState State { get; set; }
    }
}
