﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_concrete_dependency_injection.CSharp.Main
{
    public class Computer 
    {
        public List<Game> installedGames = new List<Game>();
        
        public PowerSupply powerSupply;

        public Computer(PowerSupply powerSupply) {
            this.powerSupply = powerSupply;
        }

        public void turnOn() {
            powerSupply.turnOn();
        }

        public void installGame(Game game) {
            //Game game = new Game(name);
            this.installedGames.Add(game);
        }

        public String playGame(Game game) {
            foreach (Game g in this.installedGames) {
                if (g.Equals(game)) {
                    return g.start();
                }
            }

            return "Game not installed";
        }
    }
}
