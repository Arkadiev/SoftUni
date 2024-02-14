using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.PokemonTrainer
{
    public class Trainer
    {
        public Trainer(string name) => Name = name;

        public string Name { get; set; }
        public ushort BadgesCount { get; set; }
        public List<Pokemon> PokemonCollection { get; set; } = new();
    }
}