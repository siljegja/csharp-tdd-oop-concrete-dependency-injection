﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_concrete_dependency_injection.CSharp.Main
{
    public class Computer
    {
        // fields
        public List<Game> installedGames = new List<Game>();
        public PowerSupply powerSupply;
        public Game game;

        // constructor
        public Computer(PowerSupply powerSupply)
        {
            this.powerSupply = powerSupply;
        } 
        public Computer(PowerSupply powerSupply, List<Game> preInstalledGames)
        {
            this.powerSupply = powerSupply;
            this.installedGames = preInstalledGames;
        }

        public Computer(PowerSupply powerSupply, List<Game> preInstalledGames, Game game)
        {
            this.powerSupply = powerSupply;
            this.installedGames = preInstalledGames;
            this.game = game;
        }

        // methods
        public void turnOn() {
            this.powerSupply.turnOn();
        }

        public void installGame(Game game) {
            this.installedGames.Add(game);
        }

        public String playGame(string name) {
            foreach (Game g in this.installedGames) {
                if (g.name.Equals(name)) {
                    return g.start();
                }
            }

            return "Game not installed";
        }
    }
}
